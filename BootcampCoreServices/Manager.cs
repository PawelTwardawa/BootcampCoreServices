using BootcampCoreServices.Database;
using BootcampCoreServices.Model;
using BootcampCoreServices.Utils;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampCoreServices
{
    public class Manager
    {
        public DataContext DataContext { get; set; }
        public event Action<Exception> Error;

        public Manager()
        {}

        public Data LoadFile(string fileName)
        {
            Data data = null;
            try
            {
                switch (Path.GetExtension(fileName))
                {
                    case ".json":
                        {
                            return JsonConvert.DeserializeObject<Data>(File.ReadAllText(fileName));
                        }
                    case ".xml":
                        {
                            return XmlParser.Deserialize<Data>(fileName);
                        }
                    case ".csv":
                        {
                            return CsvParser.Deserialize(fileName);
                        }
                    default:
                        {
                            Error?.Invoke(new Exception("Invalid file extension"));
                            Environment.Exit(0);
                            return null;
                        }
                }
            }
            catch (Exception ex)
            {
                Error?.Invoke(ex);
            }

            return null;
        }

        public void ConnectToDatabase()
        {
            var option = new DbContextOptionsBuilder<DataContext>().UseInMemoryDatabase(databaseName: "TestDB").Options;

            DataContext = new DataContext(option);
        }

        private bool ValidateRequest(Request request)
        {
            if (request.ClientId == null)
                return false;
            if (request.Name == null)
                return false;
            if (request.Price == null)
                return false;
            if (request.Quantity == null)
                return false;
            if (request.RequestId == null)
                return false;
            return true;
        }

        public void AddDataToDatabase(List<Request> list)
        {
            if (list == null)
                return;
            foreach (var r in list)
            {
                try
                {
                    if (!ValidateRequest(r))
                        continue;

                    DataContext.Add(r);
                    DataContext.SaveChanges();
                }
                catch(ArgumentException ex)
                {
                    continue;
                }
                catch(InvalidOperationException ex) when (ex.Source.Contains("Microsoft.EntityFrameworkCore"))
                {
                    continue;
                }
            }
        }
    }
}

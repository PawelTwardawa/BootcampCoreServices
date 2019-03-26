using BootcampCoreServices.Model;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampCoreServices.Utils
{
    public class CsvParser
    {
        public static Data Deserialize(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader))
            {
                Data data = new Data();
                data.Requests = new List<Request>();
                csv.Configuration.HeaderValidated = null;
                csv.Configuration.MissingFieldFound = null;
                var records = csv.GetRecords<Request>().ToList();

                foreach(var r in records)
                {
                    data.Requests.Add(r);
                }

                return data;
                
            }
        }

        public static void Serialize(string filePath, Data data)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer))
            {
                 csv.WriteRecords(data.Requests);   
            }
        }
    }
}

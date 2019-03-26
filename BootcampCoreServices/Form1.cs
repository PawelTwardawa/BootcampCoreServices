using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using BootcampCoreServices.Database;
using BootcampCoreServices.Model;
using BootcampCoreServices.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using Newtonsoft.Json;

namespace BootcampCoreServices
{
    public partial class Form1 : Form
    {
        Manager _manager;

        public Form1()
        {
            InitializeComponent();
            _manager = new Manager();

            _manager.Error += (ex) => MessageBox.Show(ex.Message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxRaports.SelectedIndex = 0;
            comboBoxSortType.SelectedIndex = 0;
            _manager.ConnectToDatabase();

            LoadFile();
        }

        private void LoadFile()
        {
            List<string> files = new List<string>();
            if (Environment.GetCommandLineArgs().Length == 1)
            {
                openFileDialog1.Filter = "(*.json)|*.json|(*.xml)|*.xml|(*.csv)|*.csv";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    files[0] = openFileDialog1.FileName;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                var args = Environment.GetCommandLineArgs();

                for (int i = 1; i < args.Length; i++)
                    files.Add(args[i]);
            }

            for (int i = 0; i < files.Count; i++)
                _manager.AddDataToDatabase(_manager.LoadFile(files[i])?.Requests);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            switch (comboBoxRaports.SelectedIndex)
            {
                case 0: //a. Ilość zamówień
                    {
                        labelClientId.Visible = false;
                        textBoxClientId.Visible = false;
                        labelRange.Visible = false;
                        textBoxRangeMin.Visible = false;
                        labelRangeSplit.Visible = false;
                        textBoxRangeMax.Visible = false;
                        labelSort.Visible = false;
                        comboBoxSort.Visible = false;
                        comboBoxSortType.Visible = false;

                        break;
                    }
                case 1: //b. Ilość zamówień dla klienta o wskazanym identyfikatorze
                    {
                        labelClientId.Visible = true;
                        textBoxClientId.Visible = true;
                        labelRange.Visible = false;
                        textBoxRangeMin.Visible = false;
                        labelRangeSplit.Visible = false;
                        textBoxRangeMax.Visible = false;
                        labelSort.Visible = false;
                        comboBoxSort.Visible = false;
                        comboBoxSortType.Visible = false;
                        break;
                    }
                case 2: //c. Łączna kwota zamówień
                    {
                        labelClientId.Visible = false;
                        textBoxClientId.Visible = false;
                        labelRange.Visible = false;
                        textBoxRangeMin.Visible = false;
                        labelRangeSplit.Visible = false;
                        textBoxRangeMax.Visible = false;
                        labelSort.Visible = false;
                        comboBoxSort.Visible = false;
                        comboBoxSortType.Visible = false;
                        break;
                    }
                case 3: //d. Łączna kwota zamówień dla klienta o wskazanym identyfikatorze
                    {
                        labelClientId.Visible = true;
                        textBoxClientId.Visible = true;
                        labelRange.Visible = false;
                        textBoxRangeMin.Visible = false;
                        labelRangeSplit.Visible = false;
                        textBoxRangeMax.Visible = false;
                        labelSort.Visible = false;
                        comboBoxSort.Visible = false;
                        comboBoxSortType.Visible = false;
                        break;
                    }
                case 4: //e. Lista wszystkich zamówień
                    {
                        labelClientId.Visible = false;
                        textBoxClientId.Visible = false;
                        labelRange.Visible = false;
                        textBoxRangeMin.Visible = false;
                        labelRangeSplit.Visible = false;
                        textBoxRangeMax.Visible = false;
                        labelSort.Visible = true;
                        comboBoxSort.Visible = true;
                        comboBoxSortType.Visible = true;
                        break;
                    }

                case 5: //f. Lista zamówień dla klienta o wskazanym identyfikatorze
                    {
                        labelClientId.Visible = true;
                        textBoxClientId.Visible = true;
                        labelRange.Visible = false;
                        textBoxRangeMin.Visible = false;
                        labelRangeSplit.Visible = false;
                        textBoxRangeMax.Visible = false;
                        labelSort.Visible = true;
                        comboBoxSort.Visible = true;
                        comboBoxSortType.Visible = true;
                        break;
                    }
                case 6: //g. Średnia wartość zamówienia
                    {
                        labelClientId.Visible = false;
                        textBoxClientId.Visible = false;
                        labelRange.Visible = false;
                        textBoxRangeMin.Visible = false;
                        labelRangeSplit.Visible = false;
                        textBoxRangeMax.Visible = false;
                        labelSort.Visible = false;
                        comboBoxSort.Visible = false;
                        comboBoxSortType.Visible = false;
                        break;
                    }
                case 7: //h. Średnia wartość zamówienia dla klienta o wskazanym identyfikatorze
                    {
                        labelClientId.Visible = true;
                        textBoxClientId.Visible = true;
                        labelRange.Visible = false;
                        textBoxRangeMin.Visible = false;
                        labelRangeSplit.Visible = false;
                        textBoxRangeMax.Visible = false;
                        labelSort.Visible = false;
                        comboBoxSort.Visible = false;
                        comboBoxSortType.Visible = false;
                        break;
                    }
                case 8: //i. Ilość zamówień pogrupowanych po nazwie
                    {
                        labelClientId.Visible = false;
                        textBoxClientId.Visible = false;
                        labelRange.Visible = false;
                        textBoxRangeMin.Visible = false;
                        labelRangeSplit.Visible = false;
                        textBoxRangeMax.Visible = false;
                        labelSort.Visible = true;
                        comboBoxSort.Visible = true;
                        comboBoxSortType.Visible = true;
                        break;
                    }
                case 9: //j. Ilość zamówień pogrupowanych po nazwie dla klienta o wskazanym identyfikatorze
                    {
                        labelClientId.Visible = true;
                        textBoxClientId.Visible = true;
                        labelRange.Visible = false;
                        textBoxRangeMin.Visible = false;
                        labelRangeSplit.Visible = false;
                        textBoxRangeMax.Visible = false;
                        labelSort.Visible = true;
                        comboBoxSort.Visible = true;
                        comboBoxSortType.Visible = true;
                        break;
                    }
                case 10: //k. Zamówienia w podanym przedziale cenowym
                    {
                        labelClientId.Visible = false;
                        textBoxClientId.Visible = false;
                        labelRange.Visible = true;
                        textBoxRangeMin.Visible = true;
                        labelRangeSplit.Visible = true;
                        textBoxRangeMax.Visible = true;
                        labelSort.Visible = true;
                        comboBoxSort.Visible = true;
                        comboBoxSortType.Visible = true;
                        break;
                    }
            }
        }

        private void buttonGenerateRaport_Click(object sender, EventArgs e)
        {
            //comboBoxSort.Items.Clear();
            var AllColumnsOrderByDelegate = new Func<Request, dynamic>((o) =>
            {
                if (comboBoxSort.SelectedItem.Equals(typeof(Request).GetProperties()[0].Name))
                {
                    return o.ClientId;
                }
                else if (comboBoxSort.SelectedItem.Equals(typeof(Request).GetProperties()[1].Name))
                {
                    return o.RequestId;
                }
                else if (comboBoxSort.SelectedItem.Equals(typeof(Request).GetProperties()[2].Name))
                {
                    return o.Name;
                }
                else if (comboBoxSort.SelectedItem.Equals(typeof(Request).GetProperties()[3].Name))
                {
                    return o.Quantity;
                }
                else if (comboBoxSort.SelectedItem.Equals(typeof(Request).GetProperties()[4].Name))
                {
                    return o.Price;
                }

                return null;
            });

            var RequestCountOrderByDelegate = new Func<dynamic, dynamic>((o) =>
            {
                if (comboBoxSort.SelectedItem.Equals("Name"))
                {
                    return o.Name;
                }
                else if (comboBoxSort.SelectedItem.Equals("Count"))
                {
                    return o.Count;
                }

                return null;
            });

            switch (comboBoxRaports.SelectedIndex)
            {
                case 0: //a. Ilość zamówień
                    {
                        var v = _manager.DataContext.Requests.Count().ToString();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Ilosc zamowien");
                        dt.Rows.Add(v);

                        dataGridView.DataSource = dt;
                        break;
                    }
                case 1: //b. Ilość zamówień dla klienta o wskazanym identyfikatorze
                    {
                        var v = _manager.DataContext.Requests.Where(w => w.ClientId == textBoxClientId.Text).Count().ToString();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Ilosc zamowien");
                        dt.Rows.Add(v);

                        dataGridView.DataSource = dt;
                        break;
                    }
                case 2: //c. Łączna kwota zamówień
                    {
                        var v = _manager.DataContext.Requests.Sum(s => s.Price).ToString();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Suma");
                        dt.Rows.Add(v);

                        dataGridView.DataSource = dt;
                        break;
                    }
                case 3: //d. Łączna kwota zamówień dla klienta o wskazanym identyfikatorze
                    {
                        var v = _manager.DataContext.Requests.Where(w => w.ClientId == textBoxClientId.Text).Sum(s => s.Price).ToString();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Suma");
                        dt.Rows.Add(v);

                        dataGridView.DataSource = dt;
                        break;
                    }
                case 4: //e. Lista wszystkich zamówień
                    {
                        if (comboBoxSort.SelectedIndex == -1)
                        {
                            dataGridView.DataSource = _manager.DataContext.Requests.ToList();
                        }
                        else
                        {
                            if (comboBoxSortType.SelectedIndex == 1)
                                dataGridView.DataSource = _manager.DataContext.Requests.OrderBy(AllColumnsOrderByDelegate).ToList();
                            else
                                dataGridView.DataSource = _manager.DataContext.Requests.OrderByDescending(AllColumnsOrderByDelegate).ToList();
                        }


                        int selectedIndex = comboBoxSort.SelectedIndex;
                        comboBoxSort.Items.Clear();

                        foreach (DataGridViewColumn col in dataGridView.Columns)
                            comboBoxSort.Items.Add(col.Name);

                        try
                        {
                            comboBoxSort.SelectedIndex = selectedIndex;
                        }
                        catch (ArgumentException ex)
                        {
                            comboBoxSort.SelectedIndex = 0;
                        }
                        break;
                    }

                case 5: //f. Lista zamówień dla klienta o wskazanym identyfikatorze
                    {
                        if (comboBoxSort.SelectedIndex == -1)
                        {
                            dataGridView.DataSource = _manager.DataContext.Requests.Where(w => w.ClientId == textBoxClientId.Text).ToList();
                        }
                        else
                        {
                            if (comboBoxSortType.SelectedIndex == 1)
                                dataGridView.DataSource = _manager.DataContext.Requests.Where(w => w.ClientId == textBoxClientId.Text).OrderBy(AllColumnsOrderByDelegate).ToList();
                            else
                                dataGridView.DataSource = _manager.DataContext.Requests.Where(w => w.ClientId == textBoxClientId.Text).OrderByDescending(AllColumnsOrderByDelegate).ToList();
                        }


                        int selectedIndex = comboBoxSort.SelectedIndex;
                        comboBoxSort.Items.Clear();

                        foreach (DataGridViewColumn col in dataGridView.Columns)
                            comboBoxSort.Items.Add(col.Name);

                        try
                        {
                            comboBoxSort.SelectedIndex = selectedIndex;
                        }
                        catch (ArgumentException ex)
                        {
                            comboBoxSort.SelectedIndex = 0;
                        }
                        break;
                    }
                case 6: //g. Średnia wartość zamówienia
                    {
                        var v = _manager.DataContext.Requests.Average(a => a.Price).ToString();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Srednia");
                        dt.Rows.Add(v);

                        dataGridView.DataSource = dt;
                        break;
                    }
                case 7: //h. Średnia wartość zamówienia dla klienta o wskazanym identyfikatorze
                    {
                        var v = _manager.DataContext.Requests.Where(w => w.ClientId == textBoxClientId.Text).Average(a => a.Price).ToString();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Srednia");
                        dt.Rows.Add(v);

                        dataGridView.DataSource = dt;
                        break;
                    }
                case 8: //i. Ilość zamówień pogrupowanych po nazwie
                    {
                        if (comboBoxSort.SelectedIndex == -1)
                        {
                            dataGridView.DataSource = _manager.DataContext.Requests.GroupBy(b => new { b.Name }).Select(s => new { Name = s.Key.Name, Count = s.Count() }).ToList();
                        }
                        else
                        {
                            if (comboBoxSortType.SelectedIndex == 1)
                                dataGridView.DataSource = _manager.DataContext.Requests.GroupBy(b => new { b.Name }).Select(s => new { Name = s.Key.Name, Count = s.Count() }).OrderBy(RequestCountOrderByDelegate).ToList();
                            else
                                dataGridView.DataSource = _manager.DataContext.Requests.GroupBy(b => new { b.Name }).Select(s => new { Name = s.Key.Name, Count = s.Count() }).OrderByDescending(RequestCountOrderByDelegate).ToList();
                        }

                        int selectedIndex = comboBoxSort.SelectedIndex;
                        comboBoxSort.Items.Clear();

                        foreach (DataGridViewColumn col in dataGridView.Columns)
                            comboBoxSort.Items.Add(col.Name);

                        try
                        {
                            comboBoxSort.SelectedIndex = selectedIndex;
                        }
                        catch (ArgumentException ex)
                        {
                            comboBoxSort.SelectedIndex = 0;
                        }
                        break;
                    }
                case 9: //j. Ilość zamówień pogrupowanych po nazwie dla klienta o wskazanym identyfikatorze
                    {
                        if (comboBoxSort.SelectedIndex == -1)
                        {
                            dataGridView.DataSource = _manager.DataContext.Requests.Where(w => w.ClientId == textBoxClientId.Text).GroupBy(b => new { b.Name }).Select(s => new { Name = s.Key.Name, Count = s.Count() }).ToList();
                        }
                        else
                        {
                            if (comboBoxSortType.SelectedIndex == 1)
                                dataGridView.DataSource = _manager.DataContext.Requests.Where(w => w.ClientId == textBoxClientId.Text).GroupBy(b => new { b.Name }).Select(s => new { Name = s.Key.Name, Count = s.Count() }).OrderBy(RequestCountOrderByDelegate).ToList();
                            else
                                dataGridView.DataSource = _manager.DataContext.Requests.Where(w => w.ClientId == textBoxClientId.Text).GroupBy(b => new { b.Name }).Select(s => new { Name = s.Key.Name, Count = s.Count() }).OrderByDescending(RequestCountOrderByDelegate).ToList();
                        }

                        int selectedIndex = comboBoxSort.SelectedIndex;
                        comboBoxSort.Items.Clear();

                        foreach (DataGridViewColumn col in dataGridView.Columns)
                            comboBoxSort.Items.Add(col.Name);

                        try
                        {
                            comboBoxSort.SelectedIndex = selectedIndex;
                        }
                        catch (ArgumentException ex)
                        {
                            comboBoxSort.SelectedIndex = 0;
                        }
                        break;
                    }
                case 10: //k. Zamówienia w podanym przedziale cenowym
                    {
                        try
                        {
                            if (int.Parse(textBoxRangeMin.Text) > int.Parse(textBoxRangeMax.Text))
                                throw new InvalidOperationException("Invalid data order", new FormatException());

                            if (comboBoxSort.SelectedIndex == -1)
                            {
                                dataGridView.DataSource = _manager.DataContext.Requests.Where(w => w.Price >= int.Parse(textBoxRangeMin.Text) && w.Price <= int.Parse(textBoxRangeMax.Text)).ToList();
                            }
                            else
                            {
                                if (comboBoxSortType.SelectedIndex == 1)
                                    dataGridView.DataSource = _manager.DataContext.Requests.Where(w => w.Price >= int.Parse(textBoxRangeMin.Text) && w.Price <= int.Parse(textBoxRangeMax.Text)).OrderBy(AllColumnsOrderByDelegate).ToList();
                                else
                                    dataGridView.DataSource = _manager.DataContext.Requests.Where(w => w.Price >= int.Parse(textBoxRangeMin.Text) && w.Price <= int.Parse(textBoxRangeMax.Text)).OrderByDescending(AllColumnsOrderByDelegate).ToList();
                            }


                            int selectedIndex = comboBoxSort.SelectedIndex;
                            comboBoxSort.Items.Clear();

                            foreach (DataGridViewColumn col in dataGridView.Columns)
                                comboBoxSort.Items.Add(col.Name);

                            try
                            {
                                comboBoxSort.SelectedIndex = selectedIndex;
                            }catch(ArgumentException ex)
                            {
                                comboBoxSort.SelectedIndex = 0;
                            }
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show("Niepoprawny przedział");
                        }
                        catch(InvalidOperationException ex) when (ex.InnerException is FormatException)
                        {
                            MessageBox.Show("Niepoprawny przedział");
                        }
                        break;
                    }
            }
        }
    }
}

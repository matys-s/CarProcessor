using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CarProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        static void ReadMyFiles(string path)
        {
            List<string> carList = new List<string>();

            var fileContent = File
                .ReadAllLines(path)
                .Skip(1)
                .Select(l => (l))
                .ToList();

            // var showContent = string.Join(Environment.NewLine, fileContent);

            Console.WriteLine("Result");
            //fileContent.ForEach(e => Console.WriteLine(e));
            foreach (var item in fileContent)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                var defaultPath = GetDefaultFileFolder();
                openFileDialog.InitialDirectory = defaultPath;

                var dialogResult = openFileDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    var readAllText = File.ReadAllText(openFileDialog.FileName);
                    myTextArea.Text = readAllText;


                    //Preparation for further implementation works
                    //var path = openFileDialog.FileName;
                    //CreateCarsData(path);
                }
            }
        }

        private static string GetDefaultFileFolder()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            string projectDirectory = Directory.GetParent(currentDirectory).Parent.FullName;
            string sourceFolder = Path.Combine(projectDirectory, @"src\");

            return sourceFolder;
        }

        public static void CreateCarsData(string path)
        {
            List<LightCar> lightCars = new List<LightCar>();
            List<TruckCar> truckCars = new List<TruckCar>();

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                IgnoreBlankLines = false,
                Delimiter = ";",
            };
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, config))
            {
                csv.Context.RegisterClassMap<LightCarMap>();
                csv.Context.RegisterClassMap<TruckCarMap>();


                var isHeader = true;
                while (csv.Read())
                {
                    if (isHeader)
                    {
                        var readHeader = csv.ReadHeader();
                        var csvHeaderRecord = csv.HeaderRecord;
                        isHeader = false;
                        continue;
                    }

                    if (string.IsNullOrEmpty(csv.GetField(0)))
                    {
                        isHeader = true;
                        continue;
                    }

                    switch (csv.GetField(0))
                    {
                        case "Truck":
                            truckCars.Add(csv.GetRecord<TruckCar>());
                            break;
                        case "LightCar":
                            lightCars.Add(csv.GetRecord<LightCar>());
                            break;
                        default:
                            throw new InvalidOperationException("Unknown record type.");
                    }
                }
            }
        }
    }
}

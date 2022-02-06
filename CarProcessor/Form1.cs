using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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


    }
}

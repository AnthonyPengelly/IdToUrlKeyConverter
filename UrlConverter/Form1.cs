using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace UrlConverter
{
    public partial class Form1 : Form
    {
        private const int UrlKeyLength = 5;
        private static readonly char[] Digits =
        {'q', 'g', '4', '2', '9', 'w', 'f', 'm', 'r', 'h', 'x', 'b',
            'z', 'n', 'j', 'p', 'c', '3', '5', '6', '8', 'd', 'v'};
        private static readonly int Base = Digits.Length;
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                var ids = LoadFile();
                var urlKeys = ConvertIdsToUrlKeys(ids);
                SaveFile(urlKeys);
                MessageBox.Show("File Converted successfully");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private IEnumerable<long> LoadFile()
        {
            var reader = new StreamReader(File.OpenRead(inputFileTextBox.Text));
            var ids = new List<long>();
            while (!reader.EndOfStream)
            {
                ids.Add(Convert.ToInt64(reader.ReadLine()));
            }
            return ids;
        }

        private void SaveFile(IEnumerable<string> urlKeys)
        {
            var outputPath = folderBrowserDialog.SelectedPath + "\\" + fileNameTextBox.Text + ".csv";
            if (!File.Exists(outputPath))
            {
                using (File.Create(outputPath)) { }
            }
            using (var file = new StreamWriter(outputPath))
            {
                foreach (var urlKey in urlKeys)
                {
                    file.WriteLine(urlKey);
                }
            }
        }

        private IEnumerable<string> ConvertIdsToUrlKeys(IEnumerable<long> ids)
        {
            return ids.Select(ConvertIdToUrlKey).ToList();
        } 


        private string ConvertIdToUrlKey(long id)
        {
            var quotient = id;
            var url = GetPrefix();
            var previousDigit = 0;
            for (var i = 0; i < UrlKeyLength; i++)
            {
                var remainder = quotient % Base;
                quotient = quotient / Base;
                var digit = (int)(previousDigit + i + remainder) % Base;
                url += Digits[digit];
                previousDigit = digit;
            }
            return url;
        }

        private string GetPrefix()
        {
            if (eventRadioButton.Checked) return "e";
            if (actRadioButton.Checked) return "a";
            if (seriesRadioButton.Checked) return "r";
            if (coverageRadioButton.Checked) return "c";
            return "";
        }

        private void EnableButtonIfTextFilled()
        {
            if (inputFileTextBox.Text != "" && outputDirectoryTextBox.Text != "" && fileNameTextBox.Text != "")
            {
                convertButton.Enabled = true;
            }
            else
            {
                convertButton.Enabled = false;
            }
        }

        private void inputFileTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableButtonIfTextFilled();
        }

        private void outputDirectoryTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableButtonIfTextFilled();
        }

        private void fileNameTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableButtonIfTextFilled();
        }

        private void inputBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFileTextBox.Text = openFileDialog.FileName;
            }
        }

        private void outputBrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                outputDirectoryTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}

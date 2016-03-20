using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merge
{
    public partial class Merge : Form
    {
        #region Variables

        Dictionary<int, string> firstFile = new Dictionary<int, string>();
        Dictionary<int, string> secondFile = new Dictionary<int, string>();
        List<string> splitLineFirstFile = new List<string>();
        List<string> splitLineSecondFile = new List<string>();
        int index = 0;

        #endregion
        public Merge()
        {
            InitializeComponent();
        }

        private void btnFirstFile_Click(object sender, EventArgs e)
        {
            OpenFileDialogChoiceFile((sender as Button).Text);
        }

        private void btnSecondFile_Click(object sender, EventArgs e)
        {
            OpenFileDialogChoiceFile((sender as Button).Text);
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBoxMerge.Text)) richTextBoxMerge.Clear();
            if (!String.IsNullOrEmpty(textBoxFirstFullPath.Text) && !String.IsNullOrEmpty(textBoxSecondFullPath.Text))
            {
                string[] filePaths = { textBoxFirstFullPath.Text, textBoxSecondFullPath.Text };
                ReadFileAndAddToDictionary(filePaths);
                MergeBothFiles();
                firstFile.Clear();
                secondFile.Clear();
            }
        }

        #region Methods

        private void MergeBothFiles()
        {
            int indexMaxCount = firstFile.Count > secondFile.Count ? firstFile.Count : secondFile.Count;
            int indexMinCount = firstFile.Count < secondFile.Count ? firstFile.Count : secondFile.Count;
            for (int ii = 0; ii < indexMaxCount - 1; ii++)
            {
                string lineFromFirstFile = firstFile[ii];
                if (ii > indexMinCount) return;
                string lineFromSecondFile = secondFile[ii];
                if (lineFromFirstFile.Equals(lineFromSecondFile))
                {
                    richTextBoxMerge.Text += lineFromFirstFile + "\n";
                }
                else
                {
                    MergeHelper(lineFromFirstFile, lineFromSecondFile);
                }
            }
        }

        private void MergeHelper(string lineFromFirstFile, string lineFromSecondFile)
        {
            string pattern = @"\w(?<!\d)[\w'-]*";            
            int indexWord = 0;
            foreach (Match m in Regex.Matches(lineFromFirstFile, pattern))
            {
                if(!String.IsNullOrEmpty(m.Value))
                {
                    splitLineFirstFile.Add(m.Value);
                    indexWord++;
                }
            }
            indexWord = 0;
            foreach (Match m in Regex.Matches(lineFromFirstFile, pattern))
            {
                if (!String.IsNullOrEmpty(m.Value))
                {
                    splitLineSecondFile.Add(m.Value);
                    indexWord++;
                }
            }
        }

        private void CheckAnyChangesInBothLine()
        {

        }

        private void ReadFileAndAddToDictionary(string[] filePaths)
        {
            string readLine = String.Empty;
            try
            {
                for (int ii = 0; ii < filePaths.Length; ii++)
                {
                    using (StreamReader sr = new StreamReader(filePaths[ii]))
                    {
                        while ((readLine = sr.ReadLine()) != null)
                        {
                            if (String.IsNullOrEmpty(readLine)) continue;
                            if (ii == 0)
                            {
                                firstFile.Add(index, readLine.Trim());
                            }
                            else
                            {
                                secondFile.Add(index, readLine.Trim());
                            }
                            index++;
                        }
                        index = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Файл не может быть прочитан: {0}", ex.Message), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenFileDialogChoiceFile(string btnText)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите файл.";
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt файл (*.txt)|*.txt";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (btnText == "Первый файл")
                    {
                        textBoxFirstFullPath.Text = openFileDialog.FileName;
                    }
                    if (btnText == "Второй файл")
                    {
                        textBoxSecondFullPath.Text = openFileDialog.FileName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: Не могу прочитать файл с диска. Подробно: " + ex.Message);
                }
            }
        }

        #endregion
    }
}

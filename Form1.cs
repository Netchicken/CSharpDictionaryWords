using System;
using System.IO;
using System.Windows.Forms;

namespace CSharpDictionaryWords
{
    public partial class Form1 : Form
    {
        Operations operations = new Operations();

        public Form1()
        {
            InitializeComponent();
            operations.LoadDictionaryFile();
        }

        private void BtnLoadWords_Click(object sender, EventArgs e)
        {

            operations.LoadDictionary();

            this.Text = operations.DictionaryWords.Count.ToString();

            btnSearch.Enabled = true;

            pbxDict.Image = Resource1.randomDudeOnZoom;


        }

        #region Old Load words code OK to delete
        private void LoadDictionary()
        {
            //make a counter to show how many words we have
            int count = 0;

            //'C:\Dropbox\C# Lessons 2020\CSharpDictionaryWords\Resource1\dict1.txt'.'
            //C:\Dropbox\C# Lessons 2020\CSharpDictionaryWords\Resources
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\dict1.txt", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            foreach (var word in File.ReadLines(FileName))
            {
                count++;
                this.Text = count.ToString();

                //if the word is not in the dictionary then add it
                if (operations.DictionaryWords.ContainsKey(word) == false)
                {
                    operations.DictionaryWords.Add(word, word);
                }
            }
        }

        private string RunSearch()
        {
            if (operations.DictionaryWords.ContainsKey(operations.SearchWord))
            {
                return " is found";
            }
            else
            {
                return " is not found";

            }
        }


        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            operations.SearchWord = txtEnterWord.Text;
            string answer = operations.RunSearch(operations.DictionaryWords, operations.SearchWord);

            lbxAnswer.Items.Add(operations.SearchWord + answer);
        }


    }
}

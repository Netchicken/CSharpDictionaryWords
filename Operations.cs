using System;
using System.Collections.Generic;
using System.IO;

namespace CSharpDictionaryWords
{
    public class Operations
    {
        //fields


        public Dictionary<string, string> DictionaryWords = new Dictionary<string, string>();

        //properties
        // public Dictionary<string, string> DictionaryWords { get; set; }
        public string SearchWord { get; set; }
        // public string DictionaryName { get; set; } = "dict1.txt";

        public string LoadDictionaryFile()
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\dict1.txt", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));


            if (File.Exists(FileName))
            {
                return FileName;
            }
            else
            {
                return null;
            }
        }

        //methods
        public void LoadDictionary()
        {
            //make a counter to show how many words we have

            //'C:\Dropbox\C# Lessons 2020\CSharpDictionaryWords\Resource1\dict1.txt'.'
            //C:\Dropbox\C# Lessons 2020\CSharpDictionaryWords\Resources
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\dict1.txt", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));



            foreach (var word in File.ReadLines(LoadDictionaryFile()))
            {
                //if the word is not in the dictionary then add it
                if (DictionaryWords.ContainsKey(word) == false)
                {
                    DictionaryWords.Add(word, word);
                }
            }
        }


        //pure method for UNit Test
        public string RunSearch(Dictionary<string, string> Dict, string Search)
        {
            if (Dict.ContainsKey(Search.ToLower()))
            {
                return " is found";
            }
            else
            {
                return " is not found";

            }
        }


    }
}

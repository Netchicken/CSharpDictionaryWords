using CSharpDictionaryWords;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CSharpDictionaryWordUnitTest
{


    [TestClass]
    public class OperationsTest
    {
        Operations operations = new Operations();


        [TestMethod]
        public void RunSearchRunningTest()
        {
            Dictionary<string, string> MockData = new Dictionary<string, string>();

            MockData.Add("cat", "cat");
            MockData.Add("dog", "dog");
            MockData.Add("fish", "fish");
            MockData.Add("kiwi", "kiwi");

            string SearchTerm = "cat";

            string result = " is found";
            //  MockData.ContainsKey(SearchTerm);

            Assert.AreEqual(operations.RunSearch(MockData, SearchTerm), result);

        }

        [TestMethod]
        public void RunSearchCaseSensitivityTest()
        {
            Dictionary<string, string> MockData = new Dictionary<string, string>();

            MockData.Add("cat", "cat");
            MockData.Add("dog", "dog");
            MockData.Add("fish", "fish");
            MockData.Add("kiwi", "kiwi");

            string SearchTerm = "Cat";

            string result = " is found";

            Assert.AreEqual(operations.RunSearch(MockData, SearchTerm), result);

        }

        [TestMethod]
        public void LoadDictionaryFileTest()
        {
            //C:\\Dropbox\\C# Lessons 2020\\CSharpDictionaryWords\\CSharpDictionaryWordUnitTest\\Resources\\dict1.txt
            string expected = @"C:\\Dropbox\\C# Lessons 2020\\CSharpDictionaryWords\\CSharpDictionaryWordUnitTest\\Resources\\dict1.txt";

            string actual = operations.LoadDictionaryFile();

            string actual2 = actual.Replace("CSharpDictionaryWords", "CSharpDictionaryWords\\CSharpDictionaryWordUnitTest");

            Assert.IsNotNull(actual);

        }



    }
}

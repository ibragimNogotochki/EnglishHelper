namespace EnglishHelper
{
    public static class FileWork
    {
        public static Dictionary ReadDictionary(string filePath)
        {
            Dictionary dict = new Dictionary();
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (true)
                {
                    string currLine = sr.ReadLine();
                    if (currLine != null)
                    {
                        string[] wordsToWrtie = currLine.Trim().Split(' ');
                        dict.AddNode(wordsToWrtie[0], wordsToWrtie[^1]);
                    }
                    else
                        break;
                }

            }
            return dict;
        }

        public static void WriteDictionary(Dictionary dict, string filePath)
        {

        }
    }
}

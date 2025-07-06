namespace EnglishHelper
{
    public class Dictionary
    {
        private class DictionaryNode
        {
            private string? englishWord;
            private string? russianWord;

            public string? RussianWord { get => russianWord; set => russianWord = value; }
            public string? EnglishWord { get => englishWord; set => englishWord = value; }

            public DictionaryNode(string? englishWord, string? russianWord)
            {
                this.englishWord = englishWord;
                this.russianWord = russianWord;
            }
        }

        private List<DictionaryNode> values;
        public void AddNode(string? ruWord, string? engWord)
        {
            values.Add(new DictionaryNode(engWord, ruWord));
        }
        public void DelNode(int index)
        {
            values.RemoveAt(index);
        }
        public int GetSize()
        {
            return this.values.Count;
        }
        public string? GetRuAt(int index)
        {
            if (index >= 0 && index < this.values.Count())
                return this.values[index].RussianWord;
            else return null;
        }
        public string? GetEngAt(int index)
        {
            if (index >= 0 && index < this.values.Count())
                return this.values[index].EnglishWord;
            else return null;
        }
        public void ChangeNode(int index, string? newEng, string? newRu)
        {
            values[index].RussianWord = newRu;
            values[index].EnglishWord = newEng;
        }
        public Dictionary()
        {
            values = [];
        }
    }
}

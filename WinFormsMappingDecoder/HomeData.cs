using System.Linq;
using System.Collections.Generic;

namespace WinFormsMappingDecoder
{
    internal class HomeData
    {
        private const string Rus = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        private Dictionary<char, int> Alphabet { set; get; }
        private Dictionary<char, int> AnalyzedText { set; get; }
        private List<string> BufferList { set; get; }
        private int _indexList;

        public HomeData()
        {
            Alphabet = new Dictionary<char, int>();
            AnalyzedText = new Dictionary<char, int>();
            BufferList = new List<string>();
            _indexList = -1;

            foreach (var letter in Rus)
            {
                Alphabet.Add(letter, 0);
                AnalyzedText.Add(letter, 0);
            }
        }

        internal string SetAlphabet(string text)
        {
            AnalyzedText = Analysis(text, AnalyzedText);
            return GetAnalysis(AnalyzedText, "------\n");
        }

        internal string SetAnalyzedText(string text)
        {
            Alphabet = Analysis(text, Alphabet);
            return GetAnalysis(Alphabet);
        }

        private static Dictionary<char, int> Analysis(string text, Dictionary<char, int> dictionary)
        {
            foreach (var symbol in text.ToLower())
            {
                if (dictionary.ContainsKey(symbol))
                    dictionary[symbol] = dictionary[symbol] + 1;
            }

            var sum = dictionary.Values.Sum();
            for (var i = 0; i < dictionary.Count; i++)
            {
                dictionary[dictionary.Keys.ToArray()[i]] =
                    dictionary[dictionary.Keys.ToArray()[i]] * 100000 / sum;
            }

            return dictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        internal void SetBufferList(string text)
        {
            BufferList.Add(text);
            _indexList = BufferList.Count - 1;
        }

        internal string Сancel_CtrlZ()
        {
            if (_indexList <= 0) return null;

            _indexList--;
            return BufferList[_indexList];
            //textBox.Text
        }

        internal string Return_CtrlY()
        {
            if (_indexList >= BufferList.Count) return null;

            _indexList++;
            return BufferList[_indexList];
        }

        private static string GetAnalysis(Dictionary<char, int> data, string text = "")
        {
            return data.Aggregate(text, (current, d) => current + $"key: {d.Key}\t - value: {d.Value}\n");
        }
    }
}
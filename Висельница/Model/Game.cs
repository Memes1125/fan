using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Висельница.Model
{
    public class Game
    {
        public event EventHandler<int> ImageChanged;
        public event EventHandler<Char[]> WordStatusChanged;

        string word;
        int errorCount = 0;
        Char[] chars;
        public Game()
        {
            string path = "word_rus.txt";
            var words = File.ReadAllLines(path).Where(s => s.Length >= 5 && s.Length <= 7);
            word = words.Skip(new Random().Next(0, words.Count() - 1)).First();
            chars = word.Select(s => new Char()).ToArray();
            chars[0].Charector = word[0];
            chars[0].Unknown = false;
            chars[word.Length - 1].Charector = word[word.Length - 1];
            chars[word.Length - 1].Unknown = false;
        }

        internal Char[] GetStartWord()
        {
            return chars;
        }

        internal void TryWord(Char[] tryWord)
        {

        }
    }
}

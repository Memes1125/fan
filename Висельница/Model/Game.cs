using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace Висельница.Model
{
    public class Game 
    {
        public event EventHandler<int> ImageChanged;
        public event EventHandler<Char[]> WordStatusChanged;
        public event EventHandler CurrentMessageChanged;

        string word;
        int errorCount = 0;
        Char[] chars;
        private string currentMessage;

        public string CurrentMessage
        {
            get => currentMessage;
            internal set
            {
                currentMessage = value;
                CurrentMessageChanged?.Invoke(this, null);
            }
        }

        public Game()
        {
            chars = new Char[5];
            for (int i = 0; i < 5; i++)
                chars[i] = new Char();
        }

        public bool Status { get; private set; } 
        public int CountLetter { get; set; }




        public void StartGame()
        {
            CurrentMessage = "Привет";
            Status = true;
            string path = "word_rus.txt";
            var words = File.ReadAllLines(path).Where(s => s.Length == CountLetter);
            word = words.Skip(new Random().Next(0, words.Count() - 1)).First();
            chars = word.Select(s => new Char()).ToArray();
            chars[0].Charector = word[0];
            chars[0].Unknown = false;
            chars[word.Length - 1].Charector = word[word.Length - 1];
            chars[word.Length - 1].Unknown = false;
            WordStatusChanged?.Invoke(this, chars);
            ImageChanged?.Invoke(this, 0);
            
        }

        internal Char[] GetStartWord()
        {
            return chars;
        }

        internal void TryWord()
        {

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i].Unknown &&
                    char.IsLetter(chars[i].Charector))
                {
                    if (word[i] == chars[i].Charector)
                    {
                        chars[i].Unknown = false;
                        WordStatusChanged?.Invoke(this, chars);
                        if (chars.FirstOrDefault(s => s.Unknown) == null)
                        {
                            Status = false;
                            CurrentMessage = "Ты лох";
                        }
                    }
                    else
                    {
                        errorCount++;
                        ImageChanged?.Invoke(this, errorCount);
                        if (errorCount == 6)
                        {
                            WordStatusChanged?.Invoke(this,
                                word.Select(c => new Char
                                {
                                    Charector = c,
                                    Unknown = false
                                }).ToArray());
                            CurrentMessage = "Вы проиграли";
                            Status = false;
                        }
                    }
                    return;
                }
            }
        }
    }
}

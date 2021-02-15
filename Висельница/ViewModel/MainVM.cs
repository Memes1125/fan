using System;
using System.Collections.Generic;
using System.Text;
using Mvvm1125;
using Висельница.Model;

namespace Висельница.ViewModel
{
    public class MainVM : MvvmNotify
    {
        Game game;
        public string CurrentImage { get; set; }
        public Model.Char[] TryWord { get; set; }
        public MvvmCommand CommandTry { get; set; }
        public MvvmCommand CommandStart { get; set; }

        public MainVM()
        {
            game = new Game();
            TryWord = game.GetStartWord();
            CommandTry = new MvvmCommand(() => game.TryWord(TryWord), () => game.Status);
            CommandStart = new MvvmCommand(() => game.StartGame(), () => !game.Status);
            game.ImageChanged += Game_ImageChanged;
            game.WordStatusChanged += Game_WordStatusChanged;
        }

        private void Game_WordStatusChanged(object sender, Model.Char[] e)
        {
            TryWord = e;
            NotifyPropertyChanged("TryWord");
        }

        private void Game_ImageChanged(object sender, int e)
        {
            CurrentImage = $"/Hangman/Hangman-{e}.png";
            NotifyPropertyChanged("CurrentImage");
        }
    }
}

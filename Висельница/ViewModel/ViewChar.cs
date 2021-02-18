using System;
using System.Collections.Generic;
using System.Text;

namespace Висельница.ViewModel
{
    public class ViewChar :Mvvm1125.MvvmNotify
    {
        Висельница.Model.Char @char;

        public ViewChar(Model.Char @char)
        {
            this.@char = @char;
        }

        public char Character
        {
            get => @char.Charector;
            set => @char.Charector = value;
        }

        public bool Unknown
        {
            get => @char.Unknown;
            set
            {
                @char.Unknown = value;
                NotifyPropertyChanged();
            }
        }

    }
}

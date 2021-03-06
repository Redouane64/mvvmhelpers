﻿using System.Collections.Generic;
using System.Linq;
using JulMar.Windows.Mvvm;

namespace TestMvvm.ViewModels
{
    public class ColorDialogViewModel : ViewModel
    {
        private readonly Element _element;

        private IList<string> _colorList;
        public IList<string> Colors
        {
            get { return _colorList; }
            private set 
            { 
                _colorList = value;
                RaisePropertyChanged("Colors"); 
            }
        }

        public string Title { get { return "Shape Properties Dialog";  } }

        public string SelectedColor
        {
            get { return _element.Color; }
            set { _element.Color = value; RaisePropertyChanged("SelectedColor");}
        }

        public double Width
        {
            get { return _element.Width; }   
            set { _element.Width = value; RaisePropertyChanged("Width");}
        }

        public double Height
        {
            get { return _element.Height; }
            set { _element.Height = value; RaisePropertyChanged("Height"); }
        }

        public ColorDialogViewModel(Element element)
        {
            _element = element;

            Colors = (from color in typeof(System.Windows.Media.Colors).GetProperties()
                      select color.Name).ToList();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace simplepa2
{


    public class Data1List : INotifyPropertyChanged
    {
        public List<data1> child { get; set; } = new List<data1>();

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class data1
    {
        public int index { get; set; }
        public bool Chk { get; internal set; }
        public string Title { get; internal set; }

    }


}
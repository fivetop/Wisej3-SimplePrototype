using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using static simplepa2.DataSet1;

namespace simplepa2
{
    public class DataListAssetGroup : INotifyPropertyChanged
    {
        public List<AssetGroupsRow> lstAssetGroups { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }

    public class DataListAssetPresetGroup : INotifyPropertyChanged
    {
        public List<AssetPresetGroupsRow> lstAssetPresetGroups { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}
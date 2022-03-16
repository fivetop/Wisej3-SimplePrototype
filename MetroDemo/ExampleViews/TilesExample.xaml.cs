using System;
using System.Windows.Controls;

namespace MetroDemo.ExampleViews
{
    /// <summary>
    /// Interaction logic for TilesExample.xaml
    /// </summary>
    public partial class TilesExample : UserControl
    {
        public TilesExample()
        {
            InitializeComponent();
        }

        private void Tile_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            TileControl t2 = new TileControl();
            _t1.Children.Add(t2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        List<string> rgblist = new List<string>();

        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            byte r = (byte)(int)rSlider.Value;
            byte g = (byte)(int)gSlider.Value;
            byte b = (byte)(int)bSlider.Value;
            colorArea.Background = new SolidColorBrush(Color.FromRgb(r, g, b));

        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }
        }

        private void colorConboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            ColorRGB savergb = new ColorRGB();
            savergb.Red = (byte)(int)rSlider.Value;
            savergb.Green = (byte)(int)gSlider.Value;
            savergb.Bule = (byte)(int)bSlider.Value;

            rgblist.Add(rValue.Text);    //0+2...
            rgblist.Add(gValue.Text);    //1+2...
            rgblist.Add(bValue.Text);    //2+2...

            stockList.Items.Add("Red:" + savergb.Red + "Green:" + savergb.Green + "Bule:" + savergb.Bule);
        }

        private void stockList_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            var number = stockList.SelectedIndex;
            var rnum = number * 3;
            var gnum = number * 3 + 1;
            var bnum = number * 3 + 2;

            rValue.Text = rgblist[rnum];
            gValue.Text = rgblist[gnum];
            bValue.Text = rgblist[bnum];

        }

    }
}

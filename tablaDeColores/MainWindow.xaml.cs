using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace tablaDeColores
{
    public partial class MainWindow : Window
    {
        public byte stringToByte(string s)
        {
            return (byte)int.Parse(s);
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        public string colorR, colorG, colorB;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            colorR = ColorRR.Text;
            colorG = ColorGG.Text;
            colorB = ColorBB.Text;
            this.Background = new SolidColorBrush(Color.FromRgb(stringToByte(colorR), stringToByte(colorG), stringToByte(colorB)));
        }
    }
}

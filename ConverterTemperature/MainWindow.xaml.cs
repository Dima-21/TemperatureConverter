using System;
using System.Collections.Generic;
using System.Linq;
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

namespace ConverterTemperature
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void cel_KeyUp(object sender, KeyEventArgs e)
        {
            if (cel.Text != "")
                far.Text = $"{(Double.Parse(cel.Text) * ((double)9 / 5) + 32)}";
            else
                far.Text = "";
        }

        private void far_KeyUp(object sender, KeyEventArgs e)
        {
            if (far.Text != "")
                cel.Text = $"{(Double.Parse(far.Text) - (double)32) / ((double)9 / 5)}";
            else
                cel.Text = "";
        }
}
}

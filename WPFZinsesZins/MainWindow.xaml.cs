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
using System.ComponentModel;

namespace WPFZinsesZins
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ZinsesZins z1;
        public MainWindow()
        {
            InitializeComponent();
            z1 = new ZinsesZins();
            z1.A_kapital = 1000;
            z1.Zins = 10;
            z1.Jahre = 5;
            this.DataContext = z1;

        }

        private void b_Berechnen_Click(object sender, RoutedEventArgs e)
        {
            //z1 = new ZinsesZins(Convert.ToDouble(t_Kapitalwert.Text),Convert.ToDouble(t_Zinsfusswert.Text),Convert.ToDouble(t_Laufzeitwert.Text));

            z1.BerechneKapital();


        }
    }
}

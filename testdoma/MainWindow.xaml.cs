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

namespace testdoma
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Kamion kamion1;
        public MainWindow()
        {
            InitializeComponent();
            kamion1 = new Kamion();
            Showkamion(kamion1, txtbox1);
        }
        public void Showkamion(Kamion vehicle,TextBox text)
        {
            text.Text = $"Maxcarry: {vehicle.maxcarry}\n";
            text.Text = $"Maxfuel: {vehicle.maxfuel}\n";
            text.Text = $"Curentcarry:{vehicle.curentcarry}\n";
            text.Text = $"Curentfuel:{vehicle.curentfuel}\n";
            text.Text = $"Consum:{vehicle.consum}\n";
            text.Text = $"Distance:{vehicle.distance}\n";


        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            kamion1.Go();
            kamion1.Consum();
            Showkamion(kamion1, txtbox1);
        }

        public void refuel_Click(object sender, RoutedEventArgs e)
        {
            kamion1.Refuel();
            Showkamion(kamion1, txtbox1);
        }

        public void load_Click(object sender, RoutedEventArgs e)
        {
            kamion1.Loadcargo();
            Showkamion(kamion1, txtbox1);
        }

        public void unload_Click(object sender, RoutedEventArgs e)
        {
            kamion1.Unloadcargo();
            Showkamion(kamion1, txtbox1);
        }
    }
}

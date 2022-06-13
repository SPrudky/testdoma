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
        kamion2 kamion;
        public MainWindow()
        {
            InitializeComponent();
            kamion1 = new Kamion();

           
            Showkamion(kamion1, txtbox1);
            kamion = new kamion2();
            Showkamion2(kamion, txtbox2);
            
            
        }
        public void Showkamion2(kamion2 vehicle, TextBox texbox)
        {
           texbox.Text = $"Kamion2:Maxcarry: {vehicle.maxcarry}\n";
            texbox.Text = $"Kamion2: Maxfuel: {vehicle.maxfuel}\n";
            texbox.Text += $"          Curentcarry:{vehicle.curentcarry}\n";
            texbox.Text += $"          Curentfuel:{vehicle.curentfuel}\n";
            texbox.Text += $"          Consum:{vehicle.consum}\n";
            texbox.Text += $"          Distance:{vehicle.distance}\n";
        }
        public void Showkamion(Kamion vehicle,TextBox textbox)
        {
            textbox.Text = $"Kamion1:Maxcarry: {vehicle.maxcarry}\n";
            textbox.Text = $"Kamion1: Maxfuel: {vehicle.maxfuel}\n";
            textbox.Text += $"          Curentcarry:{vehicle.curentcarry}\n";
            textbox.Text += $"          Curentfuel:{vehicle.curentfuel}\n";
            textbox.Text += $"          Consum:{vehicle.consum}\n";
            textbox.Text += $"          Distance:{vehicle.distance}\n";


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

        private void go2_Click(object sender, RoutedEventArgs e)
        {
            kamion.go();
            kamion.Consum();
            Showkamion2(kamion, txtbox2);
        }

        private void refuel2_Click(object sender, RoutedEventArgs e)
        {
            kamion.Refuel();
            Showkamion2(kamion, txtbox2);
        }

        private void Load2_Click(object sender, RoutedEventArgs e)
        {
            kamion.loadcargo();
            Showkamion2(kamion, txtbox2);
        }

        private void unload2_Click(object sender, RoutedEventArgs e)
        {
            kamion.unloadcargo();
            Showkamion2(kamion, txtbox2);
        }
    }
}

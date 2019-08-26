using questao1;
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

namespace questao1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Viagem c = new Viagem();
            c.SetD(int.Parse(txtd.Text));
            c.SetT(int.Parse(txth.Text));
            txtv.Text = c.CalqV().ToString();
        }
    }
    class Viagem
    {
        private double d, t, v;
        public void SetD(double a)
        {
            if (a > 0) d = a;
        }
        public void SetT(double a)
        {
            if (a > 0) t = a;
        }
        public double GetT()
        {
            return t;
        }
        public double GetD()
        {
            return d;
        }
        public double CalqV()
        {
            v = d / t;
            return v;
        }
    }
}
/// <summary>
/// Interação lógica para MainWindow.xam
/// </summary>


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

namespace q2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            esfera v = new esfera();
            v.Setraio(double.Parse(txtr.Text));
            txta.Text = v.CalqA().ToString();
            txtv.Text = v.CalqV().ToString();
        }
    }
    class esfera
    {
        private double raio;
        public void Setraio(double r)
        {
            if (r > 0) raio = r;
        }
        public void Getraio(double r)
        {
            if (r > 0) raio = r;
        }
        public double CalqA()
        {
            return (4 * 3.14 * Math.Pow (raio,2));
        }
        public double CalqV()
        {
            return (4 * 3.14 * Math.Pow(raio, 3)) / 3;
        }
    }
}

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

namespace Ex03
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Retangulo f = new Retangulo(double.Parse(txtb.Text), double.Parse(txth.Text));
            txta.Text = f.CalqA().ToString();
            txtd.Text = f.CalcD().ToString();
        }
        class Retangulo
        {
            private double b, h;
            private double v1;
            private double v2;

            public Retangulo(double v1, double v2)
            {
                this.v1 = v1;
                this.v2 = v2;
            }

            public void SetB (double bas)
            { if (b > 0) b = bas; }

            public void SetH (double alt)
            { if (h > 0) h = alt; }

            public double GetB() { return b; }

            public double GetH() { return h; }

            public double CalqA()
            { return h * b; }

            public double CalcD()
            { return Math.Sqrt(b * b + h * h); }
        }
    }
}


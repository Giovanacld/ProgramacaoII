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

namespace q3
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
            bool pa, im;
            if (cpar.IsChecked == true) pa = true;
            else pa = false;
            if (imp.IsChecked == true) im = true;
            else im = false;
            Par n = new Par();
            n.SetNumeros(int.Parse(txti.Text), int.Parse(txtf.Text));
            list.Items.Clear();
            foreach (int i in n.Calcular(im, pa)) list.Items.Add(i); 
        }
    }
    class Par
    {
        private int f, i;
        public void SetNumeros(int ini,int fim)
        {
            i = ini;
            f = fim;
        }
        public int[] Calcular(bool i,bool p)
        {
            int[] carai = new int[f-this.i+1];
            int s = 0;
            for(int x = this.i; x <= f; x++)
            {
                if (x % 2 == 0 && p == true) carai[s++] = x;
                if (x % 2 != 0 && i == true) carai[s++] = x;

            }
            int[] l = new int[s];
            Array.Copy(carai, l, s);
            return l;

        }
    }
}

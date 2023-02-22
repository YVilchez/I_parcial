using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Ejempo_repo
{
    public partial class Ejercicio8 : Form
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recorrerUnoaUno(1, 100);
        }

        private void recorrerUnoaUno(int Valinicial, int Valfinal)
        {
            listBox1.Items.Add(Valinicial);

            if (Valinicial < Valfinal)
            {
                //RECURSIVA
                recorrerUnoaUno(Valinicial + 1, Valfinal);
            }
        }     
    }
}

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
    public partial class valo2 : Form
    {
        public valo2()
        {
            InitializeComponent();
        }

        private void rsuma_Click(object sender, EventArgs e)
        {
            //Variables
            decimal numero1 = Convert.ToDecimal(valor1.Text) ;
            decimal numero2 = Convert.ToDecimal(valor2.Text) ;

            decimal resultado = numero1 + numero2;

            MessageBox.Show("El resultado de la suma es: " + resultado);
        }
    }
}

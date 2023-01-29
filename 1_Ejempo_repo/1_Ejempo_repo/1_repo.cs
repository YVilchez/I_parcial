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

        decimal sumaTotal;

        private void rsuma_Click(object sender, EventArgs e)
        {
            //Variables
           decimal numero1 = Convert.ToDecimal(valor1.Text) ;
           decimal numero2 = Convert.ToDecimal(valor2.Text);

            //decimal resultado = numero1 + numero2;

            //MessageBox.Show("El resultado de la suma es: " + resultado);

            //LLAMAR PROCEDIMIENTO

            sumaTotal=Sumatoria(numero1, numero2);

            //LLAMAR FUNSION
            Sumatoria(numero1, numero2);
            //PARA mensajes se pueden usar botones 
            MessageBox.Show("La suma es: " + sumaTotal, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //PROCEDIMIENTOS
        private void Sumar(decimal N1, decimal N2)
        {
            //Se declaro como vriabke global
            sumaTotal = N1 + N2;

        }

        //FUNCION
        private decimal Sumatoria(decimal N1, decimal N2)
        {
            return N1 + N2;
        }
    }
}

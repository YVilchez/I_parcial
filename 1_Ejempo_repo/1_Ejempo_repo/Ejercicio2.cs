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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {

        }

        private void Ejecutar_B_Click(object sender, EventArgs e)
        {
            if (Operaciones_cb.Text == "")
            {

            }
            decimal resultado= Ejecutar(Convert.ToDecimal(N1_tb.Text), Convert.ToDecimal(N2_tb2.Text));

            Resultado_lb.Text = Convert.ToString(resultado);
        }

        //Funsion para boton ejecutar
        private decimal Ejecutar( decimal N1, decimal N2)

        {
            string operacion = Operaciones_cb.Text;
            decimal resultado = 0;
            if (operacion == "Suma")
            {
                resultado = N1 + N2;
            }
            else if (operacion == "Resta")
            {
                resultado = N1 - N2;
            }

            else if (operacion == "Multiplicacion")
            {
                resultado = N1 * N2;
            }

            else if (operacion == "Division")
            {
                resultado = N1 / N2;
            }

            return resultado;
        }

    }
}

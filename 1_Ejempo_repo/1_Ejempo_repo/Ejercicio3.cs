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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void Ejecutar_Click(object sender, EventArgs e)
        {
            //Al precionar ejecutar Texbox Mostrara el resutado de la cadena digitada 
            string cadena = CadenaTextBox.Text;

            //Length devuelve la cantidad de caracteres de la cadena 
            Longitud.Text = Convert.ToString(cadena.Length);


            //Primer Caracter mostrar LA PRIMERA POSICION ES 0
            PriCaracter.Text = cadena.Substring(0,1);
        }
    }
}

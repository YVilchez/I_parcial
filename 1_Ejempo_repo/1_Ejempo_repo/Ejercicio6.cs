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
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void bt_arreglo_Click(object sender, EventArgs e)
        {
            // Vector 
            //Tipo de dato [] nombre del vector = new int [TAMAÑO];
            int[] vector = new int[5];

            //LLENAR VECTOR
            //Indice por indice, vector empieza en 0
            vector[0] = 10;
            vector[1] = 20;
            vector[2] = 30;
            vector[3] = 40;
            vector[4] = 50;


            int[] vector2 = new int[5] {10, 20, 30, 40, 50 };


            int[] vector3 = new int[] { 10, 20, 30, 40, 50, 60 };


            int[] vector4 = { 10, 20, 30, 40, 50 };



            string[] vector5 = { "Maria", "Marta", "Juan","Luis", "Esteban" };


            //MOSTRAR VECTOR
            //Presionar 2 veces Tabulador
            for (int i = 0; i < vector5.Length; i++)
            {
    
                listBox1.Items.Add(vector5[i]);
                comboBox1.Items.Add(vector5[i]);


            }

            foreach(string item in vector5)
            {
                comboBox1.Items.Add(item);
            }



        }
    }
}

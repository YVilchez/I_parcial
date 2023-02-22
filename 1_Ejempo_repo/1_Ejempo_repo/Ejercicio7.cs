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
    public partial class Ejercicio7 : Form
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void bt_matriz_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //MATRIZ
            //La , representa que es de 2 dimenciones
            //Fila, Columna
            int[,] matriz1 = new int[3, 3] { { 3, 4, 3 }, 
                                             { 6, 9, 7 }, 
                                             { 8, 9, 4 } };

            //LLenar una matriz

            //int[,] matriz2 = new int[3, 4];
            //Genera numeros aleatorios

            Random random = new Random();



            //LLENAR ALEATORIAMENTE
           //Random rfila = new Random();
            //Random rcolumna = new Random();


            //int vfila = random.Next(1,10);
            int vfila = Convert.ToInt32(tb_fila.Text);

            //int vcolumna = random.Next(1, 10);
            int vcolumna = Convert.ToInt32(tb_columna.Text);

            int[,] matriz2 = new int[vfila, vcolumna];


            //HAY 2 DIMENCIONES AUERA=FILAS, ADENTRO=COLUMNAS
            //TAMAÑO DE FILA
            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {                                 //TAMAÑO DE columna
                //for (int columna = 0; columna < 4; columna++)
                for (int columna = 0; columna < matriz2.GetLength(1); columna++)
                {
                    matriz2[fila, columna] = random.Next(1, 100);
                }

            }
            //SINO SE CONOCE EL TAMAÑO
            //for (int fila = 0; fila < matriz2.GetLength(0); fila++)





            //MOSTRAR MATRIZ
            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {                                           //(1) dimension
                for (int columna = 0; columna < matriz2.GetLength(1); columna++)
                {
                    listBox1.Items.Add("La posicion: [" + fila + ", " + columna + "] = " + matriz2[fila, columna]);
                }

            }

            textBox1.Text= matriz2.GetLength(0).ToString() + "x" + matriz2.GetLength(1).ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

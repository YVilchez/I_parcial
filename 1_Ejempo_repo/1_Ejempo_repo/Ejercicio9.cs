using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//USAR 
using POO;

namespace _1_Ejempo_repo
{
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }

        Coche miCoche = null;
        //UTILIZAR DATA
        List<Coche> listaCoches = new List<Coche>();

        private void button1_Click(object sender, EventArgs e)
        {
            //INSTANCIAR OBJETO  DE LA CLASE Coche
            //Proyecto principal agregar Referencia
            //Nombre de objeto siempre en minuscula

            //Coche miCoche = new Coche();
            //Coche miCoche2 = new Coche("Toyota", "22R");


            //Instanciar mi coche
            // solicitar al usuario que ingrese caracteristicas
            string marca = tbMarca.Text;
            string modelo = tbModelo.Text;
            //decimal precio = Convert.ToDecimal(tbPrecio.Text);
            decimal precio;
            

            if(tbPrecio.Text== string.Empty)
            {
                precio = 0;
            }
            else
            {
                precio = Convert.ToInt32(tbKilo.Text);
            }

            int km = Convert.ToInt32(tbKilo.Text);



            miCoche = new Coche();

            miCoche.Marca = marca;
            miCoche.Modelo = modelo;
            miCoche.Precio = precio;
            miCoche.Kilometros = km;

            //MessageBox.Show("Objeto coche --> Marca: " + miCoche.Marca + "Modelo: "+ miCoche.Modelo);

            // data
            listaCoches.Add(miCoche);
            dataCoches.DataSource = null;
            dataCoches.DataSource = listaCoches;

            Limpiar();
            //regresar cursor
            tbMarca.Focus();
            //
        }


        //limpiar
        private void Limpiar()
        {
            tbMarca.Clear();
            tbModelo.Clear();
            tbPrecio.Clear();
            tbKilo.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

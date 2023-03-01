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

        private void button1_Click(object sender, EventArgs e)
        {
            //INSTANCIAR OBJETO  DE LA CLASE Coche
            //Proyecto principal agregar Referencia
            //Nombre de objeto siempre en minuscula

            Coche miCoche = new Coche();
            Coche miCoche2 = new Coche("Toyota", "22R");

        }
    }
}

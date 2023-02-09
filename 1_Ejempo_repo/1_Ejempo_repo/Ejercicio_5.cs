using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Ejempo_repo
{
    public partial class Ejercicio_5 : Form
    {
        public Ejercicio_5()
        {
            InitializeComponent();
        }

        private void bt_HornearP_Click(object sender, EventArgs e)
        {
            //LLamar PROCEDIMIENTO HORNEAR 
            HornearPizza();

        }
        //ROCEDIMIENTO HORNEAR
        private void HornearPizza()

        {
            //Tiempo de ejecucion segundos en miles
            Thread.Sleep(10000);
        }

        //PROCEDIMIENTO ASINCROMATICO (Se generan Tareas)
        private Task HornearPizzaAsync()
        {
            return Task.Delay(10000);
        }



        private void bt_HornearPA_Click(object sender, EventArgs e)
        {
            //LLamar PROCEDIMIENTO HORNEAR ASINCROMATICO
           
            HornearPizzaAsync();
        }
    }
} 

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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ejercicio4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = Fechac.Value;

            dia.Text = fecha.Day.ToString();

            Semana.Text = fecha.DayOfWeek.ToString();

            mes.Text = fecha.Month.ToString();

            anio.Text = fecha.Year.ToString();

            //No puede modificar fecha cita
            int numerodias = Convert.ToInt32(dia.Text);
            DateTime Fecha = DateTime.Now;

            Cita2.Text = Fecha.AddDays(numerodias).ToString();

        }
    }
}

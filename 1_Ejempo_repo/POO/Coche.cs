using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
   public class Coche
    {
        //ATRIBUTOS CARACTERISTICAS DE LA CLASE
        //SIEMPRE PRIVADOS
        private string marca;
        private string modelo;
        private decimal precio;

        // PROPIEDADES (acceder a los atributos)
        //SIEMPRE PUBLICOS
        //SIEMPRE empieza en MAYUSCULA

   //==================================================================
        public string Marca
        {
            //Obtener
            get { return marca; }
            //mandar informacion al atributo
            set { marca = value; }
        }
    //OTRAS FORMAS
        public string Modelo { get => modelo; set => modelo = value; }
        //MAS FACIL=
        public decimal Precio { get; set; }
    // prop + 2 veces tabulador
        public int Kilometros { get; set; }


    //=================================================================
        //CONSTRUCTORES // Siempre publico y el mimo nombre de la clase
        public Coche() { }

        public Coche(string _marca, string _modelo) 
        {
            Marca = marca;
            Modelo = modelo;

        }

        //ACCIONES RAPIDAS selecionar desarmador de lado,GENERAR CONSTRUCTOR, Seleccionar solo s propiedades
        public Coche(string marca, string modelo, decimal precio, int kilometros) : this(marca, modelo)
        {
            Precio = precio;
            Kilometros = kilometros;
        }

//======================================================================
//METODOS, ACCIONES QUE VA HA REALIZAR, CALCULOS.

        public string Devolver_DatosBasicos()
        {
            return "Marca " + Marca + "Modelo:" + Modelo + "Precio:" + Precio;

                
        }
    }
}
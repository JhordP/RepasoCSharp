using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.Update_2023
{
    public class Clases
    {
        //DTO (Data Access Objects)
        public class Bebida
        {
            //Atributos
            public string NombreBebida { get; set; }
            public int Cantidadml { get; set; }

            //Constructor
            public Bebida (string Nombre, int Cantidad) 
            {
                this.NombreBebida = Nombre;
                this.Cantidadml = Cantidad;
            }

            public void Beberse(int cantidadTomada)
            {
                this.Cantidadml -= cantidadTomada;
            }
        }
    }
}

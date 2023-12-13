using System;
using System.Collections.Generic;
using System.Text;
using static Practica.Update_2023.Clases;

namespace Practica.Update_2023
{
    public class Herencia
    {
        public class Cerveza : Bebida
        {
            string nombre = "Cerveza";
            int cant = 850;

            public Cerveza(string nombre, int cant) : base(nombre, cant) //Toma los parametros enviados por el hijo al ser instanciada
            {
            }

            public Cerveza(int cant, string nombre = "Corona") : base(nombre, cant) 
            {
                //Tambien se pueden colocar parametros por defectos, pero deben estar de ultimo
            }
        }
    }
}

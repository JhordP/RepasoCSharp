using System;
using System.Collections.Generic;
using System.Text;
using static Practica.Update_2023.Clases;
using static Practica.Update_2023.Interfaces;

namespace Practica.Update_2023
{
    public class Herencia
    {
        public class Cerveza : Bebida, IBebidaAlcoholica
        {
            //string nombre = "Cerveza";
            //int cant = 850;
            public int Alcohol {  get; set; }
            public string Marca { get; set; }

            public Cerveza(string nombre, int cant) : base(nombre, cant) //Toma los parametros enviados por el hijo al ser instanciada
            {
            }

            public Cerveza(int cant, string nombre = "Corona") : base(nombre, cant) 
            {
                //Tambien se pueden colocar parametros por defectos, pero deben estar de ultimo
            }

            // int Alcohol { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void MaxRecomendado()
            {
                Console.WriteLine("Máximo: 10%");
            }
        }

        public class Vino : Bebida, Interfaces.IBebidaAlcoholica
        {
            string nombre = "Vino";
            int cant = 850;

            public Vino(string nombre, int cant) : base(nombre, cant) //Toma los parametros enviados por el hijo al ser instanciada
            {
            }

            public Vino(int cant, string nombre = "La fuerza") : base(nombre, cant)
            {
                //Tambien se pueden colocar parametros por defectos, pero deben estar de ultimo
            }

            public int Alcohol { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void MaxRecomendado()
            {
                Console.WriteLine("Máximo: 10%");
            }
        }
    }
}

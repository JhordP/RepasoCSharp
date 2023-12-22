using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.Update_2023
{
    public class Listas
    {
        public Listas()
        {
            List<int> ints = new List<int>(); //Para crear una lista es como instanciar una clase, tambien se pueden hacer listas de clases

            //Metodos comunes
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Remove(1); //Elimina el 1
        }
    }
}

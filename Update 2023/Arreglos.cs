using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.Update_2023
{
    public class Arreglos
    {
        int[] ints;

        public Arreglos()
        {
            //Sintaxis de arreglos
            ints = new int[3] { 1, 2, 3}; //Tambien se le puede colocar valores por defecto entre llaves

            //Acceder a las variables
            int numero = ints[0]; //Primer elemento, desde cero en adelante
        }
    }
}

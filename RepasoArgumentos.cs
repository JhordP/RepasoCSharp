using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class RepasoArgumentos
    {
        //Parametros/Argumentos Opcionales
        public void metodo(string nombre, string curso = "Java", int? cantidad = 5)
            //Se deben colocar al final o de ultimo, y se crean colocandole un valor default dentro del parentesis.
        {
            Console.WriteLine(cantidad);
        }
    }
}

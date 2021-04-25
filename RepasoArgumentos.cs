using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class RepasoArgumentos
    {
        //Parametros/Argumentos Opcionales
        public void metodo(string nombre, string curso = "Java", int? cantidad = 5)
        //Se deben colocar al final o de ultimo, y se crean asignandole un valor dentro del parentesis.
        {
            Console.WriteLine(cantidad);
        }

        public void testArg(string name, int edad = 18, string ocup = "ing") //Probando que se utilizar los argumentos opcionales
        {
            Console.WriteLine($"{name}, {edad}, {ocup}.");
        }
    }
}

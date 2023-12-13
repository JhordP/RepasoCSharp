using Practica.Update_2023;
using System;
using static Practica.Update_2023.Clases;

namespace Practica
{
    class Program : RepasoPolimorfismo.Menu_PDHN
    {
        static void Main(string[] args)
        {
            //new Main(); //Instanciar y llamar to los disparates que estan en main
            //new RepasoPolimorfismo().Menu(); //Prácticas Poliformismo
            //new Program().golosinas(); //Programa terminado

            //Update 2023
            //Clases.Bebida bebida = new Clases.Bebida("Corona",750);
            //bebida.Beberse(125);
            //Console.WriteLine(bebida.Cantidadml);

            Herencia.Cerveza cerveza = new Herencia.Cerveza("Corona",750);
            cerveza.Beberse(150);
            Console.WriteLine(cerveza.Cantidadml);
        }


    }
}

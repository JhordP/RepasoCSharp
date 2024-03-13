using Practica.Update_2023;
using System;
using static Practica.RepasoPolimorfismo;
using static Practica.Update_2023.Clases;
using static Practica.Update_2023.Herencia;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Main(); //Instanciar y llamar to los disparates que estan en main
            //new RepasoPolimorfismo().Menu(); //Prácticas Poliformismo
            //new Main().tiendaGolosinas(); //Programa terminado

            //Update 2023

            //var cerv = new Cerveza("Brahma", 3);
            //cerv.Cantidadml = 100;
            //cerv.Marca = "CND";
            //new Main().editarCerveza(cerv);

            new Main().webservice_GET().Wait();

        }


    }
}

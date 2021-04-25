using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class RepasoStatic
    {
        public static class Conversor //Las clases estaticas son trujillo, o to lo que hay aqui es estatico o no sirve.
        {                             //Tampoco les gustan los metodos constructores porque hay que usar new para usarlos. Osea, hay que instanciarlos y no se puede.
                                      //**Correccion** Se puede poner un constructor si es estatico. Es trujillo.  
            
            public static double velocidad; //Variable estatica (solo existe 1 instancia fija)

            //Metodos estaticos
            public static void Metodo1 () //Al igual que las variables, los metodos static son fijos y no pueden ser invocados desde un objeto/instancia.
            {
                velocidad += 20;
            }
            public static void Metodo2 () //Dentro de un metodo estatico no se pueden llamar variables no-estaticas.
            {                                //Se pueden declarar variables locales no-estaticas.   
                velocidad += 78;
            }

            //Conversor de velocidades:

            public static void Opcion()
            {
                int opcion;
                string repetir;
                do
                {
                    Console.WriteLine("Escoja una de las opciones:\n" +
                                      "1 - Convertir de m/s a km/h\n" +
                                      "2 - Convertir de km/h a m/s\n");
                    opcion = int.Parse(Console.ReadLine());

                    
                    switch (opcion)
                    {
                        case 1: get_velocidad(); Conversor_ms_To_kmH(velocidad);
                            break;

                        case 2: get_velocidad(); Conversor_kmH_To_ms(velocidad);
                            break;

                        default: Console.WriteLine("Opcion incorrecta.");
                            break;
                    }
                    Console.WriteLine("Para repetir pulse 1. Para salir pulse cualquier tecla excepto 1.");
                    repetir = Console.ReadLine();
                } while (repetir=="1");

                void get_velocidad()
                {
                    Console.WriteLine("Escriba la velocidad a convertir.");
                    velocidad = 0;
                    velocidad = Double.Parse(Console.ReadLine());
                }
            }

            private static void Conversor_ms_To_kmH(double vel)
            {
                Console.WriteLine($"{vel} m/s = {(vel * 3600)/1000} km/h");
            }

            private static void Conversor_kmH_To_ms(double vel)
            {
                Console.WriteLine($"{vel} km/h = {(vel * 1000)/3600} m/s");
            }

            
        }
    }
}

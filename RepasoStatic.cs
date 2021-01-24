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
            public static void Conversor1 () //Al igual que las variables, los metodos static son fijos y no pueden ser invocados desde un objeto/instancia.
            {
                velocidad += 20;
            }
            public static void Conversor2 () //Dentro de un metodo estatico no se pueden llamar variables no-estaticas.
            {                                //Se pueden declarar variables locales no-estaticas.   
                velocidad += 78;
            }
        }
    }
}

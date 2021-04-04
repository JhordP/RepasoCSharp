using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class RepasoParametros
    {
        public void metodoObject(object[] collection) //Coleccion de objetos o vars como parametro
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            int uno = (int)collection[0]; //Convert int con parentesis y ya
            string dos = (string)collection[1]; //Convert string con parentesis y ya
            //Nota: Esta conversion entre parentesis como que no la entiendo no.

            Console.WriteLine($"\n{uno}\n{dos}");
        }

        public void metodoObjectParams(params object[] collection) //Permite enviar parametros en vez del tipo de datos especifico.
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        public void metodoIn (in int valor) //No permite que el parametro sea asignado desde dentro
        {                                   //(Lo convierte en solo lectura o readonly).
            //valor += 50; Este es un ejemplo de codigo que no funciona por la palabra in.
            Console.WriteLine(valor);
        }

        public void metodoRef (ref int valor) //Referencia la variable, la vuelve una sola fusionando su valor.
        {
            valor += (50 + 20); /*Al ser la misma variable, toma el valor que tiene en el main
                                  y se lo suma al 70 con el += gracias a ref.*/
        }

        public int metodoOut(out int valor) //Une ref/in permitiendo que la variable este sin inicializar
        {                                    //No es solo lectura y hace la referencia de fusion.
            valor = (50 + 20);
            return valor;
        }

    }
}

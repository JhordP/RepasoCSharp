using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class RepasoFunciones
    {
        private int metodo(int suma5) //Metodo de ejemplo
        {
            suma5 = 5;
            int valor10 = 10;
            suma5 += valor10; //Se vuelve 15.
            funcion();

            void funcion() //Las funciones son submetodos tipo void que estan dentro de un metodo.
            {                //Edit: Las funciones son la misma vaina que un metodo pero sin modif. de acceso. Pueden retornar. NO SON TIPO VOID SOLAMENTE.
                Console.WriteLine("Hola! Soy un metodo.");
                //Si se intenta acceder a la variable suma5 desde aqui si este tiene tipo "out", no lo reconocera porque esta fuera de su scope.
                Console.WriteLine(suma5);
            }
            funcion(); //Se ejecuta la funcion igual que un metodo.

            static int funcionStatic()
            {
                return 5 + 5;
            }

            static int arrowFunc() => 3 + 3; //Sintaxis Arrow Functions (expresion lambda) en C#. [tipoMetodo][nombreMetodo()][flecha return]
            arrowFunc();
            //
            return suma5 + 5;
        }

        //Aplicacion datos duplicados en un array

        int[] arreglo = { 1, 2, 2, 3, 6, 4, 4, 4, 9, 5, 6, 5, 9, 2 };
        int[] lista;
        public RepasoFunciones()
        {
            lista = new int[arreglo.Length];

        }

        public void getDuplicados()
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arreglo.Length; j++)
                {
                    if (arreglo[i] == arreglo[j])
                    {
                        count++;
                        if (numero(arreglo[i]))
                        {
                            lista[i] = arreglo[i];
                        }
                    }
                }

                if (lista[i] != 0)
                {
                    Console.WriteLine($"{lista[i]} se repite {count} veces.");
                }

            }

            bool numero(int num)
            {
                for (int i = 0; i < lista.Length; i++) if (lista[i] == num) return false;

                return true;
            }
        }





    }
}

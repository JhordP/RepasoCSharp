﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class RepasoSwitch
    {
        
        public RepasoSwitch ()
        {
            var name = new StringBuilder();
        }
        public void Menu()
        {
            Console.WriteLine("Utilizar aplicacion de switch: 1.\n" +
                              "Utilizar aplicacion arrow switch: 2.");
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1: Switch(); break;
                case 2: ArrowSwitch(); break;

                default: Console.WriteLine("Opcion no valida."); Menu();
                    break;
            }
        }

        private void Switch()
        {
            string[] arreglo = new string[5];

            /*int input = int.Parse(Console.ReadLine()); //Un intento de optimizacion fallido debido a que switch solo toma valores constantes. Se denota abajo.
            int[] arreglo = new int[input];
            */
            for (int i = 0; i < arreglo.Length; i++)
            {
                int num = i + 1;
            Console.WriteLine($"Escriba la opcion numero {num}.");
                arreglo[i] = Console.ReadLine();
            }

            char Y = 'Y', N = 'N';
            Console.WriteLine("Usar la estructura switch? Y/N");
            char swt = char.Parse(Console.ReadLine());

            if ((swt != Y) && (swt != N))
            {
                do
                {
                    Console.WriteLine("Opcion incorrecta. Intente de nuevo.");
                    swt = char.Parse(Console.ReadLine());

                } while ((swt != Y) && (swt != N));
            }
            if ((swt == Y) || (swt == N))
            {
                if (swt == Y)
                {
                    Console.WriteLine("Elija el num opción que quiere mostrar del 1 al 5.");
                    int opc = int.Parse(Console.ReadLine());

                        //Intenté hacer una optimizacion al codigo pero... Switch solo toma valores constantes, y ahi se cae.
                    switch (opc)
                    {
                        case 1:
                            Console.WriteLine($"La opcion {opc} es {arreglo[0]}");
                            break;
                        case 2:
                            Console.WriteLine($"La opcion {opc} es {arreglo[1]}");
                            break;
                        case 3:
                            Console.WriteLine($"La opcion {opc} es {arreglo[2]}");
                            break;
                        case 4:
                            Console.WriteLine($"La opcion {opc} es {arreglo[3]}");
                            break;
                        case 5:
                            Console.WriteLine($"La opcion {opc} es {arreglo[4]}");
                            break;

                        default:
                            Console.WriteLine("No es un num del 1 al 5");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Bye bye.");
                }
            }
        }


        private void ArrowSwitch()
        {
            Console.WriteLine("Escriba el signo de operacion:\n + para suma.\n - para resta.\n" +
                " * para multiplicacion.\n / para division");
            string signo = Console.ReadLine();

            if ((signo == "+") || (signo == "-") || (signo == "*") || (signo == "/"))
            {
                Console.WriteLine("Escriba los 2 valores y luego presione enter.");

                //Realizar varias asignaciones en una sola linea, con var.
                var (a, b, oper) = (double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), signo);

                /*Simplificacion de:
                 * switch(oper) {case"+": double result = a+b}; y demas operaciones.
                 * Donde result es una variable donde se asigna un valor dependiendo del valor o caso detras del arrow, que es el valor que trae oper. */
                Double result = oper switch
                {
                    "+" => Math.Round(a + b, 2),
                    "-" => Math.Round(a - b, 2),
                    "*" => Math.Round(a * b, 2),
                    "/" => Math.Round(a / b, 2)
                };

                Console.WriteLine($"\nEl resultado es {result}");

            }
            else { Console.WriteLine("Opcion no existe."); ArrowSwitch(); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class RepasoMetodos
    {
        //atributos
        private string cadena;
        private string verMayusculas = "";
        private string verMinusculas = "";
        private int n;
        private string[] Mayusculas;
        private string[] Minusculas;
        private string[] tempMayus;
        private string[] tempMinus;

        public RepasoMetodos (int met)
        {
            switch(met) //Requiere parametro met
            {
                case 1: getMetodo1();
                    break;
                case 2: Console.WriteLine(metodoString(5));
                    break;
            }
        }
        public RepasoMetodos (string cadena) //Sobrecarga de builders
        {
            this.cadena = cadena;
            n = cadena.Length;
            Mayusculas = new string[n];
            Minusculas = new string[n];
            tempMayus = new string[n];
            tempMinus = new string[n];
        }


        private void getMetodo1 () //Metodo basico void (vacio)
        {
            Console.WriteLine("Metodo 1: Void Basico");
        }

        private string metodoString(int num) //Metodo con parametros que retorna un tipo de dato
        {
            return "Metodo 2: Parametros y return " + num.ToString();
        }

        //Practica mayusculas y minusculas//

        public void get_MayusMinus ()
        {
            Console.WriteLine(Mayus());
            Console.WriteLine(Minus());
        }

        private string Mayus ()
        {
            for (int i = 0; i < n; i++)
            {
                if (Char.IsUpper(cadena[i]))
                {
                    tempMayus[i] = cadena[i].ToString();
                }
            }
            for (int i = 0; i < tempMayus.Length; i++)
            {
                if (tempMayus[i] != null)
                {
                    Mayusculas[i] = tempMayus[i];
                    verMayusculas += $"{Mayusculas[i]},";
                }
            }
            return $"\nMAYUSCULAS: \n{verMayusculas}";
        }

        private string Minus ()
        {
            for (int i = 0; i < n; i++)
            {
                if (Char.IsLower(cadena[i]))
                {
                    tempMinus[i] = cadena[i].ToString();
                }
            }
            for (int i = 0; i < tempMinus.Length; i++)
            {
                if (tempMinus[i] != null)
                {
                    Minusculas[i] = tempMinus[i];
                    verMinusculas += $"{Minusculas[i]},";
                }
            }
            return $"\nminusculas: \n{verMinusculas}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class RepasoAbstract
    {
        public abstract class Principal
        {
            protected string cadena;
            public Principal(string cadena) //Recibe la informacion de la clase hija que hace referencia a esta, e inicializa el valor ejecutando asi el constructor de esta clase padre, y luego volviendo al método hijo
            {                                                           //**NOTA: Se puede tener metodo constructor en la clase abstracta
                this.cadena = cadena;
            }
            public abstract void getProducto();
        }

        public class Menu : Principal
        {
            public Menu(string cadena) : base(cadena) //El constructor de Menu se ejecuta, aplicando el codigo dentro y enviando la informacion del parametro al constructor de la clase padre
            {
                Console.WriteLine("La empresa es:");
            }

            public override void getProducto()
            {
                Console.WriteLine(cadena);
            }
        }
    }
}

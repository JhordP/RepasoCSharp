using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class RepasoHerencia
    {
        public class MenuPadre
        {
            private string cadena;

            public MenuPadre()
            {

            }

            public MenuPadre(string cadena) //Sobrecarga de metodo constructor.
            {
                this.cadena = cadena;
            }

            public void getCadena()
            {
                Console.WriteLine(cadena);
            }

            public void getProducto()
            {
                Console.WriteLine("Curso de C# desde cero.");
            }

            private void metodoPrivado()
            {
                Console.WriteLine("Este método no se hereda por ser privado.");
            }

            protected void metodoProtegido() //Este metodo esta hecho para ser mostrado solo por la clase que lo crea, y sus hijos
            {
                Console.WriteLine("Este metodo si se hereda. Protected esta hecho para eso.");
            }

            public virtual void metodoVirtual()
            {//El metodo virtual permite que pueda ser sobreescrito mientras ya existe codigo dentro del original.
                Console.WriteLine("Este metodo es virtual.");
            }

            //protected abstract void metodoAbstracto();

        }

        public class MenuHijo : MenuPadre
        {
            /*public MenuHijo ()
            {

                getProducto(); //Hereda el metodo de la clase padre.
                               //NOTA** Obviamente se requiere llamar desde otro metodo, en este caso el constructor.

                //Otra manera de notarlo directamente como herencia:
                new MenuHijo().getProducto(); //Se elige el metodo del padre directamente desde la clase hija.

                //new MenuHijo().metodoPrivado(); //No compila, debido a que el modificador privado no lo permite.

                new MenuHijo().metodoProtegido(); //El modificador protected sirve especificamente para que solamente pueda llamarse
                                                  //desde la clase padre y clases hijas.

            }*/

            public MenuHijo(string cadena) : base(cadena) //Hace referencia al constructor de la clase padre, enviando el parametro a la misma.
            {
                
            }
            public MenuHijo()
            {

            }

            public override void metodoVirtual()
            {
                Console.WriteLine("He sobreescrito el metodo Virtual dentro de la clase hija!");
            }
        }
    }
}

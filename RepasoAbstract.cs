using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class RepasoAbstract
    {
        public abstract class Principal //No se puede crear una instancia en otra clase de una clase abstracta.
        {
            protected string cadena;
            public Principal(string cadena) //Recibe la informacion de la clase hija que hace referencia a esta, e inicializa el valor ejecutando asi el constructor de esta clase padre, y luego volviendo al método hijo
            {                                                           //**NOTA: Se puede tener metodo constructor en la clase abstracta
                this.cadena = cadena;
            }
            public abstract void getProducto();
        }

        public class Menu : Principal, IProductos //Al heredar de una clase abstracta, esta clase hija de implementar todos sus metodos abstractos.
        {
            public Menu(string cadena) : base(cadena) //El constructor de Menu se ejecuta, aplicando el codigo dentro y enviando la informacion del parametro al constructor de la clase padre
            {
                Console.WriteLine("La empresa es:");
                //getProducto(); Esto fue una simple prueba para utilizar este metodo de forma obligatoria luego del writeline de arriba
            }

            public override void getProducto()
            {
                Console.WriteLine(cadena);
            }

            public void addProductos()
            {
                Console.WriteLine("Interface");
                
            }

            public void metodoabsInterf()
            {
                
            }

            /*public void interf() //Este metodo sobreescribe el metodo con cuerpo o default de la interface, implementandolo.
            {
                Console.WriteLine("Sobreescrita la interf");
            }*/
           
        }

        public interface IProductos //Es una practica correcta colocarle "I" de prefijo a los nombres de las interfaces
        {
            void addProductos(); //Para declarar metodos abstractos en interfaces no es necesario colocarle la palabra reservada abstract
            
            public void interf() //Para poder utilizar este marditisimo metodo, que viene siendo un default para implementacion
            {             //Se debe llamar a la interface pero hacer la instancia en el metodo que la implementa (ver apartado de interfaces en clase Main.cs)
                Console.WriteLine("Metodo Interf");
            } //Ah, y debe ser publica para poder implementar por default. Sino, en la clase que lo implementa tambien te pedira que no tenga modificadores

            abstract void metodoabsInterf(); //Aqui al utilizar el abstract esta de mas. No causa ninguna diferencia de dejarlo sin el.

        }


    }
}

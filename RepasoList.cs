using System;
using System.Collections.Generic;

namespace Practica
{
    class RepasoList
    {
        List<int> listaEnteros; //Una lista de numeros enteros
        public List<Object> listaObject; //Lista de tipos Var (o de todos los elementos)

        List<dynamic> listaDynamic = new List<dynamic>(); //Se pueden crear tambien listas de tipo dinamico. En este caso
                                                          //el tipo de valor de la posicion en el index podra ser cambiado de tipo.
        public RepasoList()
        {
            listaEnteros = new List<int>();
            listaObject = new List<object>();
        }

        public void adicionarElem(object elem) //Nota: Los metodos tambien pueden retornar listas.
        {
            listaObject.Add(elem);
        }

        public void mostrarLista(List<object> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        public void list_forEach ()
        {
            listaObject.ForEach(item => Console.WriteLine(item)); //Se utiliza un arrow function para usar los foreach
            listaObject.ForEach(item => { //Forma larga
                Console.WriteLine(item);
            });

        }

        public void insertList ()
        {
            listaObject.Insert(2,"Juan"); //Agrega un elemento en el index 2. El elemento a insertar debe estar dentro de la propiedad Count de la lista.
                                          //De lo contrario, generará una excepción.
        }

        public void indexOf ()
        {
            listaEnteros.Add(56);
            listaEnteros.Add(15);
            listaEnteros.Add(32);
            listaEnteros.Add(94);
            listaEnteros.Add(78);
            listaEnteros.Add(16);
            listaEnteros.Add(18);
            listaEnteros.Add(34);
            listaEnteros.Add(54);


            listaEnteros.IndexOf(32); //Muestra el index donde esta el elemento colocado.

            listaEnteros.IndexOf(15, 0); //En esta sobrecarga, el segundo elemento es el index a partir del cual comienza a buscar. Devuelve -1 si no lo encuentra.

            Console.WriteLine(listaEnteros.IndexOf(18,2,5)); //El 3er elemento es Count: cuantas posiciones va a buscar a partir de ese numero (limite de busqueda).


        }

        public void listExists()
        {
            listaEnteros.Exists(dato => dato.Equals(5)); //parametro dato para usar lambda a traves del arrow
        }


        //**APLICACIONES DE LISTAS ENLAZADAS**//

        //public class RepasoLinkedList {

        //    public RepasoLinkedList ()
        //    {
        //        LinkedList<string> nodo = new LinkedList<string>();
        //    }
            
        //    public void Node ()
        //    {
                
        //    }

        //    public class Nodo
        //    {
        //        public int dato;
        //        public Nodo siguiente;

        //        public Nodo(int dato)
        //        {
        //            this.dato = dato;
        //            this.siguiente = null;
        //        }

        //    }

        //    public class ListaNodo
        //    {
        //        private Nodo primero;
        //        private int size;

        //        public ListaNodo()
        //        {
        //            primero = null;
        //            size = 0;
        //        }

        //        public void agregarNodo (int dato)
        //        {
        //            var nuevo = new Nodo(dato); //Agregar el nodo
        //            Nodo valor1, valor2;

        //            if (primero == null)
        //            {
        //                primero = nuevo;
        //                nuevo.siguiente = null;
        //            }
        //            else
        //            {
        //                valor1 = primero;
        //                while (valor1!=null)
        //                {
        //                    valor2 = valor1.siguiente;

        //                    //Condicion que verifica si el numero entrante debe ir de primero
        //                    if (nuevo.dato <= valor1.dato)
        //                    {
        //                        nuevo.siguiente = primero;
        //                        primero = nuevo;
        //                        break;
        //                    }
        //                    else
        //                    {
        //                        //Condicion que verifica si el numero entrante debe ir de ultimo
        //                        if ((nuevo.dato > valor1.dato) && valor2 == null)
        //                        {
        //                            valor1.siguiente = nuevo;
        //                            nuevo.siguiente = null;
        //                            break;
        //                        }
        //                        else
        //                        {
        //                            //Condicion que verifica si el numero entrante debe ir en el medio de otros nodos
        //                            if ((valor1.dato < nuevo.dato) &&(valor2.dato >= nuevo.dato))
        //                            {
        //                                valor1.siguiente = nuevo;
        //                                nuevo.siguiente = valor2;
        //                                break;
        //                            }
        //                            else
        //                            {
        //                                valor1 = valor1.siguiente;
        //                            }
        //                        }
        //                    }

        //                }
        //            }

        //        }
        //        public void ListaVacia()
        //        {
        //            if (primero == null)
        //            {
        //                Console.WriteLine("La lista está vacia.");
        //            }
        //            else
        //            {
        //                Console.WriteLine("La lista tiene datos.");
        //            }
        //        }

        //        public void Listar()
        //        {
        //            Nodo actual = primero;
        //            while (actual!=null)
        //            {
        //                Console.Write(""); //Me rendi aqui con este tema, no entiendo. Si decido retomarlo seria el video 60 donde me quede.
        //            }
        //        }

        //    }   
            
        //}

    }
}

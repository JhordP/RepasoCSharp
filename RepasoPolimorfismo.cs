using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    public class RepasoPolimorfismo  //El polimorfismo lo que hace es permitir tener varios objetos (clases) que heredan
    {                          //de una clase abstracta e implementen sus metodos a su manera
        //***CODIGO PROPIO DEL PROGRAMA

        //Se crean las instancias de las clases hijas como atributos
        private Golosinas golosina;
        private Frutas fruta;

        public RepasoPolimorfismo () //Builder Method
        {
            //Inicializo las instancias en el constructor.
            golosina = new Golosinas();
            fruta = new Frutas();
        }

        public void Menu ()
        {
            //Creo el menu
            Console.WriteLine("Elije la opcion deseada." +
                              "\n-Digita 0 para verificar los productos." +
                              "\n-Digita 1 para agregar un producto de Golosinas." +
                              "\n-Digita 2 para agregar un producto de Frutas.");
            int opcion = int.Parse(Console.ReadLine()); //Se captura la opcion deseada

            //Condiciones de la opcion deseada
            if (opcion == 1 || opcion == 2) SetProducto(opcion);
            else if (opcion == 0)
            {
                //Sub-menu de visualizacion de productos
                Console.WriteLine("Digite 1 para visualizar los productos de Golosinas.\n" +
                                  "Digite 2 para visualizar los productos de Frutas.\n");
                int opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                {
                    //Ciclo para recorrer los productos de la lista de golosinas
                    for (int i = 0; i < golosina.productos.Count; i++)
                    {
                        Console.WriteLine("=======================================");
                        Console.WriteLine($"\n ID:{golosina.productos[i].ID}" +
                                          $"\n Nombre:{golosina.productos[i].Nombre}" +
                                          $"\n Precio:{golosina.productos[i].Precio}");
                    }
                }
                else if (opc == 2) 
                {
                    //Ciclo para recorrer los productos de la lista de frutas
                    for (int i = 0; i < fruta.productos.Count; i++)
                    {
                        Console.WriteLine("=======================================");
                        Console.WriteLine($"\n ID:{fruta.productos[i].ID}" +
                                          $"\n Nombre:{fruta.productos[i].Nombre}" +
                                          $"\n Precio:{fruta.productos[i].Precio}");
                    }
                }

            }

            //Condicion para salir o volver al menu
            Console.WriteLine("Quieres realizar otra accion?" +
                              "\n0 para volver al menu, cualquier numero para salir.");
            int exit = int.Parse(Console.ReadLine());
            if (exit == 0) Menu();
        }

        //Metodo que coloca la informacion de los productos a agregar
        public void SetProducto (int opcion) 
        {
            //Variables a utilizar
            int idProd;
            string nombreProd;
            double precioProd;

            Console.WriteLine("Escriba el ID del producto");
            idProd = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el nombre del producto");
            nombreProd = Console.ReadLine();

            Console.WriteLine("Escriba el precio del producto");
            precioProd = double.Parse(Console.ReadLine());

            //Se crea la instancia de las propiedades del producto
            var producto = new Producto();
            producto.ID = idProd;
            producto.Nombre = nombreProd;
            producto.Precio = precioProd;
            
            //Se elige donde se agregara el producto
            if (opcion == 1) golosina.addProducto(producto);
            else if (opcion == 2) fruta.addProducto(producto);
        }

        //Clase Golosinas
        public class Golosinas : Almacen
        {
            public List<Producto> productos = new List<Producto>(); //Lista de productos de la clase golosinas.

            //Metodos poliformos implementados del padre.
            public override List<Producto> GetProductos()
            {
                return productos; //Retorna la lista de productos
            }

            public override void addProducto(Producto producto)
            {
                productos.Add(producto); //Agrega el producto a la lista
            }
        }

        //Clase Frutas
        public class Frutas : Almacen
        {
            public List<Producto> productos = new List<Producto>(); //Lista de productos de la clase frutas.

            //Metodos poliformos implementados del padre.
            public override List<Producto> GetProductos()
            {
                return productos; //Retorna la lista de productos
            }

            public override void addProducto(Producto producto)
            {
                productos.Add(producto); //Agrega el producto a la lista
            }
        }

        //Clase Producto
        public class Producto 
        {
            //Propiedades de la clase
            public int ID { get; set; }
            public string Nombre { get; set; }
            public double Precio { get; set; }

        }

        //Clase Almacen
        public abstract class Almacen //Copia de clase RepasoAbstract.Principal, aunque el codigo que esta ahi no se uso aqui HAHA.
        {
            public abstract List<Producto> GetProductos(); //Uy, que avanzadito. Es un metodo tipo lista (que retorna lista en ves de int o string)
                                                                       //y recibe por parametro un string. Retorna una lista de propiedades de la clase producto

            public abstract void addProducto(Producto producto); //Y esto es un 'simple' metodo que recibe por parametro una instancia de la clase producto con sus propiedades.
        }


        //***CODIGO DEL PROFESOR

        public abstract class Almacen_PDHN //Copia de clase RepasoAbstract.Principal, aunque el codigo que esta ahi no se uso aqui HAHA.
        {
            public abstract List<Producto_PDHN> GetProductos(string producto); //Uy, que avanzadito. Es un metodo tipo lista (que retorna lista en ves de int o string)
                                                           //y recibe por parametro un string. Retorna una lista de propiedades de la clase producto

            public abstract void addProducto(Producto_PDHN producto); //Y esto es un 'simple' metodo que recibe por parametro una instancia de la clase producto con sus propiedades.
        }

        public class Producto_PDHN
        {
            public string ID { get; set; }
            public string Nombre { get; set; }
            public double Precio { get; set; }
        }


        public class Menu_PDHN : IMenu_PDHN
        {
            Almacen_PDHN g = new Golosinas_PDHN();

            public void golosinas()
            {
                var des = "";
                var valor = false;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Venta de golosinas.");
                    if (g.GetProductos("").Count.Equals(0))
                    {
                        Console.WriteLine("No hay golosinas.");
                        Console.WriteLine("Desea agregar productos de golosinas? presione tecla s/n");
                        des = Console.ReadLine();

                        if (des.Equals("s"))
                        {
                            Console.WriteLine("Cuantas golosinas va a agregar?");
                            int cant = Int16.Parse(Console.ReadLine());

                            for (int i = 0; i < cant; i++)
                            {
                                Console.WriteLine("Nueva golosina.");
                                Console.WriteLine("Ingrese ID del producto.");
                                var id = Console.ReadLine();
                                Console.WriteLine("Ingrese el nombre del producto.");
                                var nombre = Console.ReadLine();
                                Console.WriteLine("Ingrese el precio del producto.");
                                var precio = double.Parse(Console.ReadLine());

                                g.addProducto(new Producto_PDHN 
                                { //Bueno no sabia que se podian inicializar las propiedades de una clase asi.
                                   ID = id,
                                   Nombre = nombre,
                                   Precio = precio
                                });
                            }

                            Console.WriteLine("Desa ir al inicio? s/n");
                            des = Console.ReadLine();

                            if (des.Equals("s")) valor = true;
                            else valor = false;
                        }
                        else
                        {
                            Console.WriteLine("Desa ir al inicio? s/n");
                            des = Console.ReadLine();
                            if (des.Equals("s"))
                            {
                                Console.Clear();
                                Console.WriteLine("Venta de golosinas y frutas.");
                            }
                            else
                            {
                                valor = false;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lista de golosinas");
                        foreach (var item in g.GetProductos(""))
                        {
                            Console.WriteLine($"====\nID: {item.ID}\nNombre: {item.Nombre}\nPrecio: {item.Precio}");
                        }
                        Console.WriteLine("Desea realizar ventas de golosinas? s/n");
                        des = Console.ReadLine();
                        if (des.Equals("s"))
                        {
                            ventas();
                        }
                        else
                        {
                            valor = false;
                        }
                    }

                } while (valor);
            }

            public double solicitarPago()
            {
                bool pagoCorrecto = false;
                double res = 0;

                while (!pagoCorrecto)
                {
                    Console.WriteLine("Pago con 10 o con 5.");
                    res = double.Parse(Console.ReadLine());
                    if (res != 5 && res != 10)
                    {
                        Console.WriteLine("Pago no valido.");
                    }
                    else
                    {
                        pagoCorrecto = true;
                    }
                }
                return res;
            }

            public void ventas()
            {
                double total = 0;
                string des = "";
                do
                {
                    Console.WriteLine("Ingrese el producto");
                    string producto = Console.ReadLine();
                    var productos = g.GetProductos(producto);
                    while (productos.Count.Equals(0))
                    {
                        Console.WriteLine("Producto no disponible, seleccione otro.");
                        producto = Console.ReadLine();
                        productos = g.GetProductos(producto);
                    }

                    Console.WriteLine($"Su monto a pagar es de: {productos[0].Precio} dolares.");
                    double pago = solicitarPago();
                    while (pago < productos[0].Precio)
                    {
                        Console.WriteLine($"El monto es menor. Faltan {productos[0].Precio-pago} dolares.");
                        pago += solicitarPago();
                    }
                    Console.WriteLine($"Cambio: {pago-productos[0].Precio}");
                    total += productos[0].Precio;
                    Console.WriteLine("Pago total: {0} dolares",total);
                    Console.WriteLine("Desea realizar otra compra? s/n");
                    des = Console.ReadLine();
            

                } while (des.Equals("s"));
            }
        }

        public class Golosinas_PDHN : Almacen_PDHN
        {
            private List<Producto_PDHN> productosGolosinas; 

            public Golosinas_PDHN ()
            {
                productosGolosinas = new List<Producto_PDHN>();
            }
            //Metodos poliformos implementados del padre.
            public override List<Producto_PDHN> GetProductos(string producto)
            {
                var golosinas = new List<Producto_PDHN>();
                if (producto.Equals("")) 
                {
                    golosinas = productosGolosinas;
                }
                else
                {
                    golosinas = productosGolosinas.FindAll(prod => prod.Nombre.Equals(producto));
                }

                return golosinas;
            }

            public override void addProducto(Producto_PDHN producto)
            {
                productosGolosinas.Add(producto); //Agrega el producto a la lista
            }
        }

        interface IMenu_PDHN
        {
            void golosinas();
            void ventas();
            double solicitarPago();
        }
    }
}

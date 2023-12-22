using Practica.Update_2023;
using System;
using System.Collections.Generic;
using System.Text;
using static Practica.Update_2023.Herencia;

namespace Practica
{
    class Main : Program //Herencia por si acaso no tiene todo lo de la clase principal
    {
        readonly int numeroReadonly; //Un valor solo lectura solo puede ser reasignado en el metodo constructor. Permite declarar sin valor
        const int NUMEROCONST = 0; //Si una constante se declara sin valor, lanza error. Lo correcto es usar Uppercase.
        public Main()
        {
            
        }

        //2021
        public Main(string data2021)
        {
            //--Multiple asignacion con VAR
            var (valor1, valor2, valor3) = (1, "2", "tres");

            //--Instancia clase RepasoSwitch.cs
            var run_switch = new RepasoSwitch();
            run_switch.Menu();

            //--Instancia clase RepasoMetodos.cs
            var met = new RepasoMetodos(1);
            new RepasoMetodos(2);

            //--Esto tiene una sobrecarga de metodo constructor por lo que 
            //--si el parametro es int lanza el codigo de arriba y si es string el de abajo.
            Console.WriteLine("Escriba la cadena.");
            string cadena = Console.ReadLine();
            var app = new RepasoMetodos(cadena);
            app.get_MayusMinus();

            //--Objeto creado para usar en la clase RepasoParametros.cs
            object[] coleccion = new object[5];
            coleccion[0] = 1;
            coleccion[1] = "2";
            coleccion[2] = "tres";
            coleccion[3] = true;
            coleccion[4] = 5.5;

            //--Instanciadores de la clase RepasoParametros.cs
            new RepasoParametros().metodoObject(coleccion); //Enviar por parametro la coleccion de objetos

            //--Uso de params.
            new RepasoParametros().metodoObjectParams("Jhor", 23, false); //Enviar parametros directos en vez de la coleccion como valor(arriba)
                                                                          //Esto solo mediante el uso de la palabra params en el metodo metodoObjectParams  
                                                                          //--Uso de in.
            int num = default; //Asigna el valor por defecto de la variable. En este caso 0.
            new RepasoParametros().metodoIn(in num); //Utilizando in para que solo pueda tomar este dato
                                                     //Y no pueda ser modificado desde el metodo.

            //--Uso de Readonly.
            numeroReadonly = 10;

            //--Uso de Const
            //NUMEROCONST = 3; //Las constantes no se pueden inicializar ni en los constructores.

            //Si se intenta modificar este valor en otro lugar que no sea el constructor, lanza error.

            //--Uso de ref.
            //int dataRef; Codigo no funciona porque para usar ref la variable debe ser inicializada
            int dataRef = 60;
            new RepasoParametros().metodoRef(ref dataRef);
            Console.WriteLine(dataRef);

            //--Uso de out.
            int dataOut; //A diferencia de ref, este permite que la variable no este inicializada
            new RepasoParametros().metodoOut(out dataOut);
            Console.WriteLine(dataOut);
            //Out se utiliza inicialmente para que el metodo pueda retornar una segunda salida. Es lo que es, una salida.
            //Asi, si el metodo ya retorna un valor, un valor out o de salida puede utilizarse para un segundo return.

            //--Repaso de funciones.
            new RepasoFunciones().getDuplicados();

            //--Repaso Static

            //Se utilizan sin crear una nueva instancia. Se accede directamente debido a que solo hay 1 existencia.
            RepasoStatic.Conversor.velocidad = 0;
            RepasoStatic.Conversor.Metodo1();
            RepasoStatic.Conversor.Metodo1();

            //--Argumentos opcionales y nombrados

            var arg = new RepasoArgumentos();
            //arg.metodo("Jhord","C#",1);
            //arg.metodo("Jhord"); //Al haber un argumento opcional, se puede quedar vacio el espacio del mismo.
            //                        //Esto, debido a que ya tiene un valor dentro del metodo.

            //arg.metodo(nombre:"Hector", cantidad: 2); //Parametros nombrados, permiten no obedecer el orden de los parametros en el metodo.

            arg.metodo("Juan", cantidad: null); //Para permitir que un valor Int tome un valor Null se le debe colocar "?" al lado del tipo de dato.

            var inst = new RepasoArgumentos();
            inst.testArg(edad: 20, name: "Juan"); //Probando que se utilizar los argumentos nombrados.

            //--Repaso propiedades
            var estudiante = new RepasoPropiedades.Estudiante();
            estudiante.Nombre = "Juan";
            var name = estudiante.Nombre;
            Console.WriteLine(name);

            //Aplicacion de agregar y buscar estudiantes en el repaso de propiedades***

            //Creo los estudiantes
            var estudiante1 = new RepasoPropiedades.Estudiante();
            estudiante1.Nombre = "Jhord";
            estudiante1.Edad = 23;
            estudiante1.Calificacion = 84.7;

            var estudiante2 = new RepasoPropiedades.Estudiante();
            estudiante2.Nombre = "Carla";
            estudiante2.Edad = 24;
            estudiante2.Calificacion = 93.6;

            var estudiante3 = new RepasoPropiedades.Estudiante();
            estudiante3.Nombre = "Jonathan";
            estudiante3.Edad = 31;
            estudiante3.Calificacion = 95.9;

            //Agrego los estudiantes a la escuela
            var C_E_Duarte = new RepasoPropiedades.Escuela();
            C_E_Duarte.agregarEstudiante(estudiante1);
            C_E_Duarte.agregarEstudiante(estudiante2);
            C_E_Duarte.agregarEstudiante(estudiante3);

            bool encontrado = true;
            do
            {
                Console.WriteLine("\nIngrese el nombre del estudiante a buscar.");
                string nombre = Console.ReadLine();

                encontrado = C_E_Duarte.buscarPorNombre(nombre); //No se por que pero esto asigna el return del bool a la variable y tambien ejecuta el metodo.

            } while (encontrado == false);


            //--Clase genérica List<>
            var listas = new RepasoList();

            Console.WriteLine("Escriba la cantidad de elementos a agregar a la lista.");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba los elementos.");
            for (int i = 0; i < cantidad; i++)
            {
                listas.adicionarElem(Console.ReadLine());
            }

            listas.mostrarLista(listas.listaObject); //Metodo 1, manual para foreach
            listas.list_forEach(); //Metodo 2, automatico foreach de la clase list

            listas.indexOf();

            //--Herencia de clases

            new RepasoHerencia.MenuHijo("Empresa").getCadena();//Invoca el metodo constructor de la clase hija pero esta hace referencia a la clase padre.

            new RepasoHerencia.MenuPadre().metodoVirtual(); //Esto selecciona el método de la clase padre.
            new RepasoHerencia.MenuHijo().metodoVirtual(); //Esto selecciona el método sobreescrito del override en la clase hija.

            //--Abstract
            new RepasoAbstract.Menu("PDHN").getProducto(); //Llama al constructor de Menu

            //--Interfaces
            RepasoAbstract.IProductos inter = new RepasoAbstract.Menu("Cadena"); //Se debe utilizar de manera explicita la interfaz y luego asignar la nueva instancia
            inter.interf();                                                      //al metodo que implementa la interface para poder invocar un metodo con cuerpo (default, publico) de la interface. 
                                                                                 //NOTA: var no funciona porque toma por defecto la instancia de la clase que implementa.

            //--Polimorfismo
            //El diablaso, lo logre solo... lo logre, logre de manera sencilla con valores fijos adaptar el codigo para que funcione
            //SIN ver si quiera la mitad del video del profesor. Ahora lo aplicare a lo real con valores variantes en la clase del repaso.

            //Se agregan los datos.
            int idProd = 0;
            string nombreProd = "Chocolate";
            double precioProd = 34.99;

            //Se crea la instancia del producto, asignandole los valores de las variables a las propiedades.
            var nom = new RepasoPolimorfismo.Producto();
            nom.ID = idProd;
            nom.Nombre = nombreProd;
            nom.Precio = precioProd;

            //Se crea la instancia del tipo de producto, en este caso Golosina, y se agrega el producto a la lista.
            RepasoPolimorfismo.Golosinas gol = new RepasoPolimorfismo.Golosinas();
            gol.addProducto(nom);

            //Se asigna a un var (que se convierte en una lista) la lista retornada del metodo GetProductos, colocandole que el ID a retornar es el 0.
            var listaProd = gol.GetProductos(); //Esto tenia un 0 cuando lo hice probando.

            //Se muestra cada una de las propiedades del index 0
            Console.WriteLine($"\n ID:{listaProd[0].ID}\n Nombre:{listaProd[0].Nombre}\n Precio:{listaProd[0].Precio}");
            
        }

        public void tiendaGolosinas()
        {
            //La aplicacion de verdad con mi codigo, instancia
            new RepasoPolimorfismo().Menu();

            //La aplicacion hecha por el profesor
            new RepasoPolimorfismo.Menu_PDHN().golosinas();
        }

        //---Update 2023
        //App con DB
        public void obtenerCerveza()
        {

            //Clases.Bebida bebida = new Clases.Bebida("Corona",750);
            //bebida.Beberse(125);
            //Console.WriteLine(bebida.Cantidadml);

            //Herencia.Cerveza cerveza = new Herencia.Cerveza("Corona",750);
            //cerveza.Beberse(150);
            //Console.WriteLine(cerveza.Cantidadml);
            foreach (Cerveza item in new CervezaDB().Obtener())
            {
                Console.WriteLine( "Marca >> " + item.Marca
                                 + "\nNombre >> " + item.NombreBebida
                                 + "\n===============");
            }
        }
    }
}

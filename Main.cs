using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class Main : Program //Herencia por si acaso no tiene todo lo de la clase principal
    {
        readonly int numeroReadonly; //Un valor solo lectura solo puede ser reasignado en el metodo constructor. Permite declarar sin valor
        const int NUMEROCONST = 0; //Si una constante se declara sin valor, lanza error. Lo correcto es usar Uppercase.
        public Main()
        {
            //--Multiple asignacion con VAR
            var (valor1, valor2, valor3) = (1, "2", "tres");

            //--Instancia clase RepasoSwitch.cs
            var @switch = new RepasoSwitch();
            @switch.Menu();

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
            int num = Convert.ToInt16(coleccion[0]);
            new RepasoParametros().metodoIn(num); //Utilizando in para que solo pueda tomar este dato
                                                  //Y no pueda ser modificado desde el metodo.

            //--Uso de Readonly.
            numeroReadonly = 10;

            //--Uso de Const
            //NUMEROCONST = 3; //Las constantes no se pueden inicializar ni en los constructores.

            //Si se intenta modificar este valor en otro lugar que no sea el constructor, lanza error.

            //--Uso de ref.

            //int data; Codigo no funciona porque para usar ref la variable debe ser inicializada
            int dataRef = 60;
            new RepasoParametros().metodoRef(ref dataRef);
            Console.WriteLine(dataRef);

            //--Uso de out.
            int dataOut; //A diferencia de ref, este permite que la variable no este inicializada
            new RepasoParametros().metodoOut(out dataOut);
            Console.WriteLine(dataOut);

            //--Repaso de funciones.
            new RepasoFunciones().getDuplicados();

            //--Repaso Static

            //Se utilizan sin crear una nueva instancia. Se accede directamente debido a que solo hay 1 existencia.
            RepasoStatic.Conversor.velocidad = 0;
            RepasoStatic.Conversor.Conversor1();
            RepasoStatic.Conversor.Conversor1();

            //--Argumentos opcionales y nombrados

            var arg = new RepasoArgumentos();
            //arg.metodo("Jhord","C#",1);
            //arg.metodo("Jhord"); //Al haber un argumento opcional, se puede quedar vacio el espacio del mismo.
            //                        //Esto, debido a que ya tiene un valor dentro del metodo.

            //arg.metodo(nombre:"Hector", cantidad: 2); //Parametros nombrados, permiten no obedecer el orden de los parametros en el metodo.

            arg.metodo("Juan", cantidad: null); //Para permitir que un valor Int tome un valor Null se le debe colocar "?" al lado del tipo de dato.

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
        }
    }
}

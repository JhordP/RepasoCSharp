﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class RepasoPropiedades
    {
        //--CLASE ESTUDIANTE
        public class Estudiante
        {
            //--Definiciones***
            public int edadPrueba { get; set; } = 10; //Acceso corto y directo. //Get para obtener data, set para colocar la data.
            
            public string NombrePrueba
            {
                get { return nombre; } //Si se le quita el set, la variable no puede ser reasignada.
                set { nombre = value; }  //Cuando otra clase invoca la propiedad asignandole un valor, el valor asignado a la propiedad reasigna tambien la variable usada dentro debido a que hace referencia a esta.   
            
            }//El get sirve para traer informacion de la propiedad, por ejemplo asignar el valor de la misma a una variable local.
             //El set sirve para poder inicializar o reasignar la propiedad, principalmente atraves de una instancia en otra clase.
            
            private string nombre; 
            private string nombre2 = "Oscar";
            private string apellido = "Polanco"; //Aunque segun lo que indica, este asigna el valor de "nombre", la variable leida es apellido.
            
            

            public string segundoNombre   //Con operador flecha
            {
                get => nombre2;
                set => nombre2 = value;
            }

            //--Inicio Aplicacion de Practica***
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public double Calificacion { get; set; }

        }

        //--CLASE ESCUELA
        public class Escuela
        {
            private List<Estudiante> estudiantes;
            public Escuela()
            {
                estudiantes = new List<Estudiante>();
            }

            public void agregarEstudiante(Estudiante nuevoEstudiante)
            {
                estudiantes.Add(nuevoEstudiante);
            }

            public bool buscarPorNombre(string nombre)
            {
                bool encontrado = false;
                int i = 0;
                while ((encontrado == false) && (i < estudiantes.Count))
                {
                    if (estudiantes[i].Nombre.Equals(nombre))
                    {
                        encontrado = true;
                    }
                    else
                    {
                        i++;
                    }
                }

                if (encontrado) //Los bool traen por defecto el valor true en las condiciones
                {
                    Console.WriteLine($"Nombre: {estudiantes[i].Nombre}\n" +
                                      $"Edad: {estudiantes[i].Edad}\n" +
                                      $"Calificacion: {estudiantes[i].Calificacion}");
                    return true;
                }

                else
                {
                    Console.WriteLine("No se encuentran datos que contengan el criterio.");
                    return false;
                }
            }
        }
    }
}

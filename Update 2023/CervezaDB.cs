using System;
using System.Collections.Generic;
using System.Text;
using static Practica.Update_2023.Herencia;
using Microsoft.Data.SqlClient;

namespace Practica.Update_2023
{
    public class CervezaDB
    {
        private string connString =
            "Data Source=JHORDPC\\SQLEXPRESS;Initial Catalog=Crud;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public List<Cerveza> Obtener()
        {
            List<Cerveza> cervezas = new List<Cerveza>();
            string query = "SELECT nombre, marca, alcohol, cantidad FROM Cerveza;";

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string nombre = reader.GetString(0);
                string marca =  reader.GetString(1);
                int alcoh = reader.GetInt32(2);
                int cant = reader.GetInt32(3);
                              
                Cerveza cerveza = new Cerveza(cant, nombre);
                cerveza.NombreBebida = nombre;
                cerveza.Marca = marca;
                cervezas.Add(cerveza);
            }
            reader.Close();
            conn.Close();

            return cervezas;
        }
    }
}

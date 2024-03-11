using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Practica.Update_2023
{
    public class Serializacion_y_Deserializacion
    {
        public Serializacion_y_Deserializacion() 
        {
            //Serializar Objeto a Json
            Herencia.Cerveza cerveza = new Herencia.Cerveza(10, "Cerveza x");
            string miJson = JsonSerializer.Serialize(cerveza);
            File.WriteAllText("objeto.txt", miJson);

            //Deserializar de Json a Objeto
            string json = File.ReadAllText("objeto.txt");
            var ceveza_json = JsonSerializer.Deserialize<Herencia.Cerveza>(json);

        }



    }
}

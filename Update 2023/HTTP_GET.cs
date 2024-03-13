using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Practica.Update_2023
{
    public class HTTP_GET
    {
        string url;
        public HTTP_GET() { this.url = "https://jsonplaceholder.typicode.com/posts"; }

        public async Task getFromWebService()
        {
            HttpClient client = new HttpClient();

            // Entre la declaracion de "response" y await hay un hilo. El nugget se muerde mientras se espera la cerveza.
            // Cuando finaliza, entonces el await permite que se ejecute el codigo siguiente.
            /*
            Console.WriteLine("Pedir cerveza");
            var response = client.GetAsync(url);
            Console.WriteLine("Nugget mordido");
            await response;

            Console.WriteLine("Tomar cerveza");
            */
            var response = await client.GetAsync(this.url);
            if (response.IsSuccessStatusCode) //Retorna codigo 200 (satisfactorio) si es exitoso,y le asigna valor true.
            {
                //Espera a que termine de traer toda la informacion(json) en un string
                var content = await response.Content.ReadAsStringAsync();

                //Deserializa en un listado de objetos desde la variable con el json, y se lo asigna a una lista de ese tipo de objetos.
                List<Atributos_JSON> atributos_JSONs = JsonSerializer.Deserialize<List<Atributos_JSON>>(content);

                foreach (var item in atributos_JSONs) //Mostrar cada uno de los atributos
                {
                    Console.WriteLine("ID: "+item.id+"\n"
                                     +"User ID: "+item.userId+"\n"
                                     +"Title: "+item.title+"\n"
                                     +"Body: "+item.body);
                    Console.WriteLine("-------------------------");
                }
            }
        }
    }
}

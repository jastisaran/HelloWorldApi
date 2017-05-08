using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WebApiConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:50875/");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("v1/Products/Product/Hello").Result;

            if (response.IsSuccessStatusCode)
            {
                var users = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(users);
                Console.ReadLine();
                // usergrid.ItemsSource = users;

            }
            else
            {
             //   MessageBox.Show("Error Code" +
              //  response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }
    }
}

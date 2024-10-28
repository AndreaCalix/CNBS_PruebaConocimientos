using System;
using System.Net.Http;
using System.Threading.Tasks;

public class ServicesApi
{
    private static readonly HttpClient cliente = new HttpClient();
    private const string apiUrl = "https://iis-des.cnbs.gob.hn/ws.TestData/api/data";
    private const string apiKey = "MEYwMEJGQ0E3QUNDN0MxNTg2M0UyOEE1QTU0MTcwM0FBQjUwNjE4MkFGNjQ0RjMyQUNCMDI1OTdDMjUwMDREOA=="; // Reemplaza con tu clave de API

    public async Task<string> ObtenerDatosAsync(string fecha = null)
    {
        try
        {

            cliente.DefaultRequestHeaders.Clear();  
            cliente.DefaultRequestHeaders.Add("ApiKey", apiKey);

           
            var urlConFecha = fecha != null ? $"{apiUrl}?Fecha={fecha}" : apiUrl;

            HttpResponseMessage respuesta = await cliente.GetAsync(urlConFecha);

            
            if (respuesta.IsSuccessStatusCode)
            {
                
                string contenido = await respuesta.Content.ReadAsStringAsync();
                Console.WriteLine("Solicitud exitosa. Datos obtenidos:");
                Console.WriteLine(contenido);
                return contenido;
            }
            else
            {
                Console.WriteLine($"Error: Código de estado {respuesta.StatusCode}");
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al intentar conectarse a la API: {ex.Message}");
            return null;
        }
    }
}

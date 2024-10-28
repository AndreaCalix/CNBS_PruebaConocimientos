using System.Text.Json;
using System.Xml.Linq;
using CNBS_PruebaConocimientos.Models;

namespace CNBS_PruebaConocimientos.DataAccess
{
    public class DataProcessor
    {
        public static List<Declaracion> DeserializarJson(string jsonDescomprimido)
        {
            var opciones = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<List<Declaracion>>(jsonDescomprimido, opciones);
        }
    }
}

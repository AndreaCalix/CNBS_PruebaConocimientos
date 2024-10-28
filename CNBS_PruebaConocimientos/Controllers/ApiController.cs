using CNBS_PruebaConocimientos.DataAccess;
using CNBS_PruebaConocimientos.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace CNBS_PruebaConocimientos.Controllers
{
    public class ApiController : Controller
    {
        private readonly ServicesApi _servicioAPI;
        //private readonly DatabaseService _databaseService;

        public ApiController(ServicesApi servicioAPI)
        {
            _servicioAPI = servicioAPI;
            //_databaseService = databaseService;
        }

        //   
        public async Task<IActionResult> ProbarConexion(String fecha)
        {
            string xmlRespuesta = await _servicioAPI.ObtenerDatosAsync(fecha);

            if (!string.IsNullOrEmpty(xmlRespuesta))
            {
                try
                {

                    var xmlDocument = XDocument.Parse(xmlRespuesta);
                    var datosComprimidos = xmlDocument.Root.Element("datosComprimidos")?.Value;


                    if (!string.IsNullOrEmpty(datosComprimidos))
                    {
                        // Descomprime el contenido Base64
                        string jsonDescomprimido = await CompressionHelper.DescomprimirDatosAsync(datosComprimidos);

                        if (!string.IsNullOrEmpty(jsonDescomprimido))
                        {
                            Console.WriteLine("Datos JSON descomprimidos:");
                            Console.WriteLine(jsonDescomprimido);

                            var datosDeserializados = JArray.Parse(jsonDescomprimido);

                           
                            foreach (var item in datosDeserializados)
                            {
                                
                                if (item is JObject objeto)
                                {
                                    // Acceder a ART
                                    var articulos = (JArray)objeto["ART"];
                                    foreach (var articulo in articulos)
                                    {
                                        Console.WriteLine($"ID: {articulo["Iddt"]}, Descripción: {articulo["Cartdesc"]}");
                                    }

                                    // Acceder a DDT
                                    var ddt = (JObject)objeto["DDT"];
                                   // Console.WriteLine($"ID de texto: {ddt["Iddtextr"]}");

                                    // Acceder a LIQ
                                    var liq = (JObject)objeto["LIQ"];
                                    //Console.WriteLine($"Liquidación: {liq["Iliq"]}");

                                    // Acceder a LQA
                                    var lqaArray = (JArray)objeto["LQA"];
                                    foreach (var lqa in lqaArray)
                                    {
                                        Console.WriteLine($"LQA: {lqa["Iliq"]}, Nart: {lqa["Nart"]}");
                                    }
                                }
                            }

                            return Content(jsonDescomprimido, "application/json");
                        }
                        else
                        {
                            return Content("Error al descomprimir los datos.");
                        }
                    }
                    else
                    {
                        return Content("No se encontraron datos comprimidos en la respuesta.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error procesando la respuesta: {ex.Message}");
                    return Content("Error inesperado al procesar la respuesta de la API.");
                }
            }
            else
            {
                return Content("No se recibieron datos o hubo un error en la conexión.");
            }


        }


        public ActionResult TuAccion(string jsonDescomprimido)
        {
            if (!string.IsNullOrEmpty(jsonDescomprimido))
            {
                // Devolver el JSON a la vista
                return Content(jsonDescomprimido, "application/json");
            }
            else
            {
                return Content("Error al descomprimir los datos.");
            }
        }


    }

}

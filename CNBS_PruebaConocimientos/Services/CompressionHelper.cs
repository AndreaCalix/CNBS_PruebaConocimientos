﻿using System.IO.Compression;
using System.Text;

namespace CNBS_PruebaConocimientos.Services
{
    public static class CompressionHelper
    {
        public static async Task<string> DescomprimirDatosAsync(string datosComprimidos)
        {
            try
            {
                
                byte[] datos = Convert.FromBase64String(datosComprimidos);

                
                using (MemoryStream ms = new MemoryStream(datos))
                using (GZipStream gzip = new GZipStream(ms, CompressionMode.Decompress))
                using (MemoryStream msDescomprimido = new MemoryStream())
                {
                    await gzip.CopyToAsync(msDescomprimido);
                    return Encoding.UTF8.GetString(msDescomprimido.ToArray());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al descomprimir los datos: {ex.Message}");
                return null;
            }
        }
    }
}

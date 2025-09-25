using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EstancieroDigitalData;

namespace EstancieroDigitalData
{
    public static class Archivo
    {
        public static async Task GuardarAsync<T>(string ruta, T datos)
        {
            var opciones = new JsonSerializerOptions { WriteIndented = true };
            using FileStream stream = new FileStream(ruta, FileMode.Create, FileAccess.Write, FileShare.None);
            await JsonSerializer.SerializeAsync(stream, datos, opciones);
        }

        public static async Task<T?> LeerAsync<T>(string ruta)
        {
            if (!File.Exists(ruta))
                return default;

            using FileStream stream = new FileStream(ruta, FileMode.Open, FileAccess.Read, FileShare.Read);
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }
    }
}

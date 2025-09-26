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
        private static readonly string DirectorioBase = "../EstancieroDigitalData/Archivosjson";
        private static readonly string ArchivoUsuarios = "usuarios.json";
        private static readonly string ArchivoPartidas = "partidas.json";
        private static readonly string ArchivoTablero = "Tablero.json";

        public static UsuarioEntities AgregarUsuario(UsuarioEntities usuario)
        {
            var lista = LeerUsuariosDesdeArchivoJson();

            var usuarioExistente = lista.FirstOrDefault(u => u.DNI == usuario.DNI);

            if (usuarioExistente != null)
            {
                usuarioExistente.EstadisticaJugador = usuario.EstadisticaJugador;
            }
            else
            {
                lista.Add(usuario);
            }

            GuardarUsuariosEnArchivoJson(lista);
            return usuario;
        }
        public static List<UsuarioEntities> LeerUsuariosDesdeArchivoJson()
        {
            string rutaCompleta = ObtenerRutaCompleta(ArchivoUsuarios);

            if (File.Exists(rutaCompleta))
            {
               string json = File.ReadAllText(rutaCompleta);
                if (!string.IsNullOrWhiteSpace(json))
                {
                    return JsonConvert.DeserializeObject<List<UsuarioEntities>>(json) ?? new List<UsuarioEntities>();
                } 
            }

            return new List<UsuarioEntities>();
        }
        private static void GuardarUsuariosEnArchivoJson(List<UsuarioEntities> usuarios)
        {
            GuardarEnArchivo(usuarios, ArchivoUsuarios);
        }
        public static PartidaEntities AgregarPartida(PartidaEntities partida)
        {
            var lista = LeerPartidasDesdeArchivoJson();

            var partidaExistente = lista.FirstOrDefault(p => p.NumeroPartida == partida.NumeroPartida);

            if (partidaExistente != null)
            {
                var index = lista.IndexOf(partidaExistente);
                lista[index] = partida;
            }
            else
            {
                if (partida.NumeroPartida == null)
                {
                    partida.NumeroPartida = lista.Any() ? lista.Max(p => p.NumeroPartida) + 1 : 1;
                    partida.FechaInicio = DateTime.Now;
                    partida.Estado = "En Juego";
                }

                lista.Add(partida);
            }

            GuardarPartidasEnArchivoJson(lista);
            return partida;
        }
        public static List<PartidaEntities> LeerPartidasDesdeArchivoJson()
        {
            string rutaCompleta = ObtenerRutaCompleta(ArchivoPartidas);

            if (File.Exists(rutaCompleta))
            {
                string json = File.ReadAllText(rutaCompleta);
                if (!string.IsNullOrWhiteSpace(json))
                {
                    return JsonConvert.DeserializeObject<List<PartidaEntities>>(json) ?? new List<PartidaEntities>();
                } 
            }

            return new List<PartidaEntities>();
        }
        private static void GuardarPartidasEnArchivoJson(List<PartidaEntities> partidas)
        {
            GuardarEnArchivo(partidas, ArchivoPartidas);
        }
        private static string ObtenerRutaCompleta(string nombreArchivo)
        {
            string rutaCompleta = Path.Combine(DirectorioBase, nombreArchivo);
            return Path.GetFullPath(rutaCompleta);
        }
        private static void GuardarEnArchivo<T>(T objeto, string nombreArchivo)
        {

            string rutaCompleta = ObtenerRutaCompleta(nombreArchivo);

            Directory.CreateDirectory(Path.GetDirectoryName(rutaCompleta) ?? DirectorioBase);

            string json = JsonConvert.SerializeObject(objeto, Formatting.Indented);
            File.WriteAllText(rutaCompleta, json);
        }
        public static List<TableroEntities> ObtenerTableroDesdeJson()
        {
            string rutaCompleta = ObtenerRutaCompleta(ArchivoTablero);
            if (File.Exists(rutaCompleta))
            {
                string json = File.ReadAllText(rutaCompleta);
                if (!string.IsNullOrWhiteSpace(json))
                {
                    return JsonConvert.DeserializeObject<List<TableroEntities>>(json) ?? new List<TableroEntities>();
                } 
            }
            return new List<TableroEntities>();
        }
    }
}
using System.Text.Json;
using System.Text.Json.Serialization;
namespace RPG
{
    public class PersonajesJson
    {
        public void GuardarPersonajes(List<Personaje> listaPersonajes, string nombreArchivo)
        {
            var json = JsonSerializer.Serialize(listaPersonajes);
            File.WriteAllText(nombreArchivo, json);
        }

        public List<Personaje>? LeerPersonajes(string nombreArchivo)
        {
            var data = File.ReadAllText(nombreArchivo);
            List<Personaje>? lista = JsonSerializer.Deserialize<List<Personaje>>(data);
            return lista;
        }

        public bool Existe(string nombreArchivo)
        {
            return File.Exists(nombreArchivo);
        }
    }
}
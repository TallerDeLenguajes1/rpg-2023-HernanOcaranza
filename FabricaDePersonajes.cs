using Helpers;

namespace RPG
{
    public class FabricaDePersonajes
    {                
        private string[] TiposDePersonajes;
        private string[] NombresDePersonajes;
        private string[] ApodosDePersonajes;

        public FabricaDePersonajes()
        {
            TiposDePersonajes = PersonajesApi.GetTiposPersonajes();
            NombresDePersonajes = PersonajesApi.GetNombresPersonajesAsync().Result;
            ApodosDePersonajes = PersonajesApi.GetApodosPersonajes();
        }
        public Personaje crearPersonajeAleatorio()
        {
            var r = new Random();
            var tipo = TiposDePersonajes[r.Next(TiposDePersonajes.Length)];
            var nombre = NombresDePersonajes[r.Next(NombresDePersonajes.Length)];
            var apodo = ApodosDePersonajes[r.Next(ApodosDePersonajes.Length)];
            var fechaNacimiento = new DateTime(1600, 1, 1).AddDays(r.Next(109500));
            var velocidad = r.Next(1, 10);
            var destreza = r.Next(1, 5);
            var fuerza = r.Next(1, 10);
            var nivel = r.Next(1, 10);
            var armadura = r.Next(1, 10);
            var salud = 100;
            return new Personaje(tipo, nombre, apodo, fechaNacimiento, velocidad, destreza, fuerza, nivel, armadura, salud);
        }
    }
}
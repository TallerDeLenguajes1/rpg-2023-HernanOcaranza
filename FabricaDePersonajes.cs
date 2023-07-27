namespace RPG
{
    public class FabricaDePersonajes
    {
        private string[] TiposDePersonajes = { "Orco", "Mago", "Elfo", "Cazador", "Druida" };
        private string[] NombresDePersonajes = { "Lifestealer", "Templar Assassin", "Bounty Hunter", "Drow Ranger" };
        private string[] ApodosDePersonajes = { "Naix", "Lanyana", "Gondar", "Drow" };
        public Personaje crearPersonajeAleatorio()
        {
            var r = new Random();
            var tipo = TiposDePersonajes[r.Next(TiposDePersonajes.Length)];
            var nombreId = r.Next(NombresDePersonajes.Length);
            var nombre = NombresDePersonajes[nombreId];
            var apodo = ApodosDePersonajes[nombreId];
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
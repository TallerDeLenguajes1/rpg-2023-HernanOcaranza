namespace RPG
{
    public static class Program
    {
        public static void Main()
        {
            //Creacion o recuperacion de personajes
            var listaPersonajes = new List<Personaje>();
            var archivoPersonajes = new PersonajesJson();
            var nombreArchivo = "./personajes.json";

            if (archivoPersonajes.Existe(nombreArchivo))
            {
                listaPersonajes = archivoPersonajes.LeerPersonajes(nombreArchivo);
            }
            else
            {
                var FabricaDePersonajes = new FabricaDePersonajes();
                for (int i = 0; i < 10; i++)
                {
                    listaPersonajes.Add(FabricaDePersonajes.crearPersonajeAleatorio());
                }
                archivoPersonajes.GuardarPersonajes(listaPersonajes, nombreArchivo);
            }

            //Listar Personajes

            // foreach (var miPersonaje in listaPersonajes)
            // {
            //     miPersonaje.MostrarDatos();
            //     miPersonaje.MostrarCaracteristicas();
            //     System.Console.WriteLine("");
            // }

            //Juego 
            var nuevaPartida = new Partida(listaPersonajes);
            var r = new Random();
            while (nuevaPartida.Competidores.Count > 1)
            {
                nuevaPartida.Competidores = nuevaPartida.Competidores.OrderBy(i => r.Next()).ToList(); // Desordena la lista
                var competidor1 = nuevaPartida.Competidores.First();
                nuevaPartida.Competidores.RemoveAt(0);
                var competidor2 = nuevaPartida.Competidores.First();
                nuevaPartida.Competidores.RemoveAt(0);
                var ganadorDelCombate = nuevaPartida.combate(competidor1, competidor2);
                nuevaPartida.Competidores.Add(ganadorDelCombate);
            }

            System.Console.WriteLine("");
            System.Console.WriteLine("************* GANADOR DEL TRONO DE HIERRO *************");
            var ganador = nuevaPartida.Competidores.First();
            ganador.MostrarDatos();
            ganador.MostrarCaracteristicas();
            System.Console.WriteLine($"El/La {ganador.Tipo} {ganador.Nombre} ({ganador.Apodo}) de {ganador.Edad} anios Fue el vencedor en esta competencia por el trono de hierro");
        }
    }
}
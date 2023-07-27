namespace RPG
{
    public static class Program
    {
        public static void Main()
        {
            var listaPersonajes = new List<Personaje>();
            var archivoPersonajes = new PersonajesJson();
            var nombreArchivo = "personajes.json";

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

            foreach (var miPersonaje in listaPersonajes)
            {
                miPersonaje.MostrarDatos();
                miPersonaje.MostrarCaracteristicas();
                System.Console.WriteLine("");
            }
        }
    }
}
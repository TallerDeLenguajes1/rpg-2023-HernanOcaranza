namespace RPG
{
    public static class Program
    {
        public static void Main()
        {
            var FabricaDePersonajes = new FabricaDePersonajes();
            var miPersonaje = FabricaDePersonajes.crearPersonajeAleatorio();
            miPersonaje.MostrarDatos();
            miPersonaje.MostrarCaracteristicas();
        }
    }
}
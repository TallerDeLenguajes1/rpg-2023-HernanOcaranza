using Helpers;
namespace RPG
{
    public class Personaje
    {
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Apodo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public int Velocidad { get; set; }
        public int Destreza { get; set; }
        public int Fuerza { get; set; }
        public int Nivel { get; set; }
        public int Armadura { get; set; }
        public int Salud { get; set; }

        public Personaje(string tipo, string nombre, string apodo, DateTime fechaNacimiento, int velocidad, int destreza, int fuerza, int nivel, int armadura, int salud)
        {
            Tipo = tipo;
            Nombre = nombre;
            Apodo = apodo;
            FechaNacimiento = fechaNacimiento;
            Edad = Helper.calcularAñosRestandoFechas(fechaNacimiento, new DateTime(1900, 7, 28));
            Velocidad = velocidad;
            Destreza = destreza;
            Fuerza = fuerza;
            Nivel = nivel;
            Armadura = armadura;
            Salud = salud;
        }

        public void MostrarDatos()
        {
            System.Console.WriteLine("------------------------ DATOS ------------------------");
            System.Console.WriteLine($"Tipo: {Tipo}");
            System.Console.WriteLine($"Nombre: {Nombre}");
            System.Console.WriteLine($"Apodo: {Apodo}");
            System.Console.WriteLine($"Fecha de Nacimiento: {FechaNacimiento.Day}/{FechaNacimiento.Month}/{FechaNacimiento.Year}");
            System.Console.WriteLine($"Edad: {Edad} años");
        }

        public void MostrarCaracteristicas()
        {
            System.Console.WriteLine("------------------- CARACTERISTICAS -------------------");
            System.Console.WriteLine($"Velocidad: {Velocidad}");
            System.Console.WriteLine($"Destreza: {Destreza}");
            System.Console.WriteLine($"Fuerza: {Fuerza}");
            System.Console.WriteLine($"Nivel: {Nivel}");
            System.Console.WriteLine($"Armadura: {Armadura}");
            System.Console.WriteLine($"Salud: {Salud}");
        }
    }
}
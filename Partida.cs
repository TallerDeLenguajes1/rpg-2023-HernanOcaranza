namespace RPG
{
    public class Partida
    {
        public List<Personaje> Competidores { get; set; }

        public Partida(List<Personaje> competidores)
        {
            Competidores = competidores;
        }

        public double atacar(Personaje atacante, Personaje defensor)
        {
            var r = new Random();
            const int constAjuste = 500;
            var ataque = atacante.Destreza * atacante.Fuerza * atacante.Nivel;
            var efectividad = r.Next(1, 100);
            var defensa = defensor.Armadura * defensor.Velocidad;
            return ((ataque * efectividad) - defensa) / constAjuste;
        }
        public Personaje combate(Personaje p1, Personaje p2)
        {
            bool banderaTurno = true;
            double danioProvocado;
            var saludInicialP1 = p1.Salud;
            var saludInicialP2 = p2.Salud;
            while (p1.Salud > 0 && p2.Salud > 0)
            {
                if (banderaTurno)
                {
                    danioProvocado = atacar(p1, p2);
                    p2.Salud -= danioProvocado;
                }
                else
                {
                    danioProvocado = atacar(p2, p1);
                    p1.Salud -= danioProvocado;
                }
                banderaTurno = !banderaTurno;
            }
            System.Console.WriteLine(" ");
            if (p1.Salud > 0)
            {
                p1.Salud = saludInicialP1 + 10;
                p1.Armadura += 5;
                System.Console.WriteLine("Jugador eliminado:");
                p2.MostrarDatos();
                return p1;
            }
            else
            {
                p2.Salud = saludInicialP2 + 10;
                p2.Armadura += 5;
                System.Console.WriteLine("Jugador eliminado:");
                p1.MostrarDatos();
                return p2;
            }
        }
    }
}
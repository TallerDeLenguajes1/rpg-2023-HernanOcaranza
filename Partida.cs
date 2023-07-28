namespace RPG
{
    public class Partida
    {
        public List<Personaje> Competidores {get; set;} 

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
            while (p1.estaVivo() && p2.estaVivo())
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
            if (p1.estaVivo())
            {
                BonificarPersonaje(p1);
                System.Console.WriteLine("Jugador eliminado:");
                p2.MostrarDatos();
                return p1;
            }
            else
            {
                BonificarPersonaje(p2);
                System.Console.WriteLine("Jugador eliminado:");
                p1.MostrarDatos();
                return p2;
            }
        }

        private void BonificarPersonaje(Personaje p)
        {
            p.Nivel += 1;
            p.Armadura += 5;
            p.Salud = 100;
        }
    }
}
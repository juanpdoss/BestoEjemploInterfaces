using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeEstrategy
{
    public class Druida : Unidad, IRanged, IMelee
    {
        public Druida(int puntosVida, int puntosDaño, string nombre, ERaza raza, int velocidadMovimiento) 
                    : base(puntosVida, puntosDaño, nombre, raza, velocidadMovimiento)
        {
        }

        protected override string Spawnear()
        {
            float tiempoSpawn = this.puntosDaño / 3;
            return tiempoSpawn.ToString();
        }

        #region implementacion interfaz IRanged
        public string AtacarDistanca()
        {
            return $"Soy {this.nombre} en forma humana, ataco con mi hechizo fuego lunar por {this.puntosDaño} puntos de daño";
        }

        public void BajarArmadura()
        {
            this.puntosVida -= 10;
        }

        public void SubirVelocidad()
        {
            this.velocidadMovimiento += 10; ;
        }

        void IRanged.Morir() //implementacion explicita
        {
            this.puntosVida = 0;
        }

        #endregion


        #region implementacion interfaz IMelee
        public string AtacarMelee()
        {
            return $"Soy {this.nombre} en mi forma de oso, ataco con las garras por {this.puntosDaño + 25} puntos de daño.";
        }

        public void ReducirVelocidad()
        {
            this.velocidadMovimiento -= 10;
        }

        public void SubirArmadura()
        {
            this.puntosVida += 10; ;
        }


        void IMelee.Morir() //implementacion explicita
        {
            this.puntosVida = 0;
        }



        #endregion
    }
}

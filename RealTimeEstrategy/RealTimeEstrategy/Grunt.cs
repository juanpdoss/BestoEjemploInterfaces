using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeEstrategy
{
    public class Grunt:Unidad,IMelee
    {
        EFaccion faccion;

        public Grunt(EFaccion faccion, int puntosVida, int puntosDaño, int velocidadMovimiento, string nombre, ERaza raza)
                    : base(puntosVida, puntosDaño, nombre, raza, velocidadMovimiento)
        {
            this.faccion = faccion;
        }

        protected override string Spawnear()
        {
            float tiempoSpawn = this.puntosDaño / 3;
            return tiempoSpawn.ToString(); 
        }

        #region implementacion interfaz
        public string AtacarMelee()
        {
           return $"{this.nombre} ataca con un hachazo por {this.puntosDaño} puntos de daño.";
        }

        public void ReducirVelocidad()
        {
            this.velocidadMovimiento -= 10; 
        }

        public void SubirArmadura()
        {
            this.puntosVida += 10; ;
        }

        public void Morir()
        {
            this.puntosVida = 0;
        }

        
        #endregion

    }
}

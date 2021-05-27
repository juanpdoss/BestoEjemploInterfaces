using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeEstrategy
{
    public class Nigromante : Unidad, IRanged
    {
        EFaccion faccion;

        public Nigromante(EFaccion faccion,int puntosVida, int puntosDaño, string nombre, ERaza raza, int velocidadMovimiento) 
                            : base(puntosVida, puntosDaño, nombre, raza, velocidadMovimiento)
        {
            this.faccion = faccion;
        }


        protected override string Spawnear()
        {
            float tiempoSpawn = this.puntosDaño / 2;
            return tiempoSpawn.ToString();
        }




        public string AtacarDistanca()
        {
            return $"{this.nombre} ataca con una maldicion por {this.puntosDaño} puntos de daño";
        }

        public void BajarArmadura()
        {
            this.puntosVida -= 15; 
        }

        public void SubirVelocidad()
        {
            this.velocidadMovimiento += 10; 
        }

        public void Morir()
        {
            this.puntosVida = 0;
        }
       
    }
}

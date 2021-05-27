using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeEstrategy
{
    public class Arquera<T> : Unidad, IRanged where T:new() //T tiene que tener si o si un constructor sin parametros
    {

        EFaccion faccion;
        public Arquera(EFaccion faccion,int puntosVida, int puntosDaño, string nombre, ERaza raza, int velocidadMovimiento) 
                        : base(puntosVida, puntosDaño, nombre, raza, velocidadMovimiento)
        {
            this.faccion = faccion;

        }


        protected override string Spawnear()
        {
            float tiempoSpawn = this.puntosDaño / 2;


            return tiempoSpawn.ToString();
        }



        #region Implementacion interfaz
        public string AtacarDistanca()
        {
            return $"{this.nombre} ataca con una flecha por {this.puntosDaño} puntos de daño";
        }

        public void BajarArmadura()
        {
            this.puntosVida -= 10; 
        }

        public void SubirVelocidad()
        {
            this.velocidadMovimiento += 10; ;
        }

        public void Morir()
        {
            this.puntosVida = 0;
        }

        public string MetodoGenerico2(T algo)
        {
            return "hola mundo";
        }

        public T metodoGenerico(string algoGenerico)
        {
            return new T();
        }


        #endregion
    }
}

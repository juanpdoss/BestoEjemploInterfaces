using System;
using System.Text;

namespace RealTimeEstrategy
{
    public abstract class Unidad
    {
        public int puntosVida;
        public int puntosDaño;
        public int velocidadMovimiento;
        public string nombre;
        public ERaza raza;

        protected Unidad(int puntosVida, int puntosDaño, string nombre,ERaza raza,int velocidadMovimiento)
        {
            this.puntosVida = puntosVida;
            this.puntosDaño = puntosDaño;
            this.nombre = nombre;
            this.raza = raza;
            this.velocidadMovimiento = velocidadMovimiento;
        }

        protected abstract string Spawnear();

        protected string Mostrar() //alfinal no lo use XD 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"soy un {this.raza.ToString()}");
            sb.AppendLine($"tengo {this.puntosVida} puntos de vida, y {this.puntosDaño} puntos de ataque.");

            return sb.ToString();
        }





    }
}

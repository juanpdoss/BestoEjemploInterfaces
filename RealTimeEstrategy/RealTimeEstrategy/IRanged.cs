using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeEstrategy
{
    public interface IRanged:IVelocidad
    {     
        string AtacarDistanca();//ups

        // T metodoGenerico(string algoGenerico);
        void BajarArmadura();
       // void SubirVelocidad(); firma que viene de IVelocidad 
        void Morir();
    }
}

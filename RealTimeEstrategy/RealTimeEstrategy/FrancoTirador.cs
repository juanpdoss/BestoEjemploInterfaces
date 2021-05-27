using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeEstrategy
{
    public class FrancoTirador : IRanged
    {
        public string AtacarDistanca()
        {
            return "dispara";
        }

        public void BajarArmadura()
        {
            throw new NotImplementedException();
        }

        public void Morir()
        {
            throw new NotImplementedException();
        }

        public void SubirVelocidad()
        {
            throw new NotImplementedException();
        }
    }
}

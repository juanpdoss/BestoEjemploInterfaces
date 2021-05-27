using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeEstrategy
{
    public abstract class Minion : IRanged
    {
        public abstract string AtacarDistanca();
        

        public virtual void BajarArmadura()
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

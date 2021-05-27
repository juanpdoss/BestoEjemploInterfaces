using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeEstrategy
{
    public class Minionsito : Minion
    {
        public override string AtacarDistanca()
        {
            return "pium pium";
        }

        public override void BajarArmadura()
        {
            base.BajarArmadura(); //puedo reutilizar el base
            //mas codigo 
        }
    }
}

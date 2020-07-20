using System;
using System.Collections.Generic;
using System.Text;

namespace Subsistema
{
    public class Fachada
    {
        private Subsistema1 objH1 = new Subsistema1();
        private Subsistemas2 objH2 = new Subsistemas2();

        public void Hacer()
        {
            this.objH1.Hacer1();
            this.objH2.Hacer2();
        }
    }
}

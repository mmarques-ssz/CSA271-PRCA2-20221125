using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLeds
{
    internal class Lampada
    {
        private bool estado;
        public Lampada()
        {
            this.estado = false;
        }
        public Lampada(bool estado)
        {
            this.estado = estado;
        }
        public void acender()
        {
            this.estado = true;
        }
        public void apagar()
        {
            this.estado = false;
        }
        public bool getEstado()
        {
            return this.estado;
        }
    }
}

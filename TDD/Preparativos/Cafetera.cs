using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Preparativos
{
    public class Cafetera
    {
        private int cantidadCafe;

        public Cafetera(int cantidadCafe) => this.cantidadCafe = cantidadCafe;

        public void setCantidadDeCafe(int param1)
        {
            this.cantidadCafe = param1;
        }
        public int getCantidadDeCafe()
        {
            return this.cantidadCafe;
        }
        public Boolean hasCafe(int cantidadCafe)
        {
            if(getCantidadDeCafe() >= cantidadCafe)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void giveCafe(int cantidadCafe)
        {
            setCantidadDeCafe(getCantidadDeCafe() - cantidadCafe);
        }
    }
}

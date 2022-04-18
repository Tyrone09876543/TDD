using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Preparativos
{
    public class Azuquero
    {
        private int cantidadDeAzucar;

        public Azuquero(int cantidadDeAzucar) => this.cantidadDeAzucar = cantidadDeAzucar;

        public void setCantidadAzucar(int param1)
        {
            this.cantidadDeAzucar = param1;
        }
        public int getCantidadAzucar()
        {
            return this.cantidadDeAzucar;
        }
        public Boolean hasAzucar(int cantidadDeAzucar)
        {
            if(getCantidadAzucar() >= cantidadDeAzucar)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void giveAzucar(int cantidadDeAzucar)
        {
            setCantidadAzucar(getCantidadAzucar() - cantidadDeAzucar);
        }
    }
}

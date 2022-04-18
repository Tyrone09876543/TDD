using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Preparativos
{
    public class Vaso
    {
        private int cantidadVasos;
        private int contenido;

        public Vaso(int cantidadVasos, int contenido)
        {
            this.cantidadVasos = cantidadVasos;
            this.contenido = contenido;
        }

        public void setCantidadVasos(int param1)
        {
            this.cantidadVasos = param1;
        }
        public void setContenido(int param1)
        {
            this.cantidadVasos = param1;
        }
        public int getCantidadVasos()
        {
            return this.cantidadVasos;
        }
        public int getContenido()
        {
            return this.contenido;
        }
        public Boolean hasVasos(int cantidadVasos)
        {
            if (getCantidadVasos() < cantidadVasos)
            {
                return false;
            }
 
            return true;
        }
        public void giveVasos(int cantidadVasos)
        {
            setCantidadVasos(getCantidadVasos() - cantidadVasos);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Preparativos;

namespace TDD
{
    public class MaquinaCafe
    {
        
        private Cafetera cafetera = new Cafetera(50);
        private Azuquero azuquero = new Azuquero(20);
        private Vaso vasosPequenos = new Vaso(5, 10);
        private Vaso vasosMedianos = new Vaso(5, 20);
        private Vaso vasosGrandes = new Vaso(5, 30);

        public Vaso getTipoVaso(string tipoDeVaso)
        {
            switch (tipoDeVaso)
            {
                case "pequeno":
                    return getVasosPequenos();
                    break;
                case "mediano":
                    return getVasosMediano();
                    break;
                case "grande":
                    return getVasosGrande();
                    break;
                default :
                    return null;
                    break;
            }
        }

        public string getVasoDeCafe(Vaso tipoDeVaso, int cantidadDeVasos, int cantidadDeAzucar)
        {
            if (tipoDeVaso.getCantidadVasos() < cantidadDeVasos)
            {
                return "No hay vasos";
            }
            else if (azuquero.getCantidadAzucar() < cantidadDeAzucar)
            {
                return "No hay Azucar";
            }
            else if(cafetera.getCantidadDeCafe() < tipoDeVaso.getContenido())
            {
                return "No hay cafe";
            }
            
            tipoDeVaso.setCantidadVasos(tipoDeVaso.getCantidadVasos() - cantidadDeVasos);
            azuquero.setCantidadAzucar(azuquero.getCantidadAzucar() - cantidadDeAzucar);
            cafetera.setCantidadDeCafe(cafetera.getCantidadDeCafe() - tipoDeVaso.getContenido());

            return "Felicitaciones";
        }

        public void setCafetera(Cafetera cafetera) => this.cafetera = cafetera;

        public void setAzucarero(Azuquero azuquero) => this.azuquero = azuquero;

        public void setVasosGrande(Vaso vasosGrande) => this.vasosGrandes = vasosGrande;

        public void setVasosMediano(Vaso vasosMediano) => this.vasosMedianos = vasosMediano;

        public void setVasosPequenos(Vaso vasosPequenos) => this.vasosPequenos = vasosPequenos;

        public Cafetera getCafetera() => this.cafetera;
        public Azuquero getAzuquero() => this.azuquero;
        public Vaso getVasosGrande() => this.vasosGrandes;
        public Vaso getVasosMediano() => this.vasosMedianos;
        public Vaso getVasosPequenos() => this.vasosPequenos;
    }
}

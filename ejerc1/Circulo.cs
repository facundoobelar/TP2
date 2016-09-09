using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerc1
{
    class Circulo
    {
        private double iRadio;
        private Punto iCentro;

        public Circulo(double pRadio) : this(null,pRadio) { }
        
        public Circulo(Punto pCentro,double pRadio)
        {
            iRadio = pRadio;
            iCentro = pCentro;
        }       

    public Circulo(double pX, double pY,double pRadio)
        {
            iRadio = pRadio;
            iCentro.X = pX;
            iCentro.Y = pY;
        }
    
    public double Radio
        {
            get { return this.iRadio; }
            set { this.iRadio = value; }
        }
    public Punto Centro
        {
            get { return this.iCentro; }
            set { this.iCentro = value; }
        } 
    public double Area
        {
            get { return (Math.PI * Math.Pow(this.iRadio, 2)); }
        }
    public double Perimetro
        {
            get { return (Math.PI*2*this.iRadio); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerc1
{
    class Punto
    {
        private double iX;
        private double iY;

        public Punto() : this(0,0) { }

        public Punto(double pX, double pY)
        {
            iX = pX;
            iY = pY;
        }

        public double X
        {
            get{return this.iX;}
            set {this.iX = value;}
        }

        public double Y
        {
            get {return this.iY;}
            set {this.iY = value;}
        }

        public double CalcularDistanciaDesde(Punto pPunto)
        {
            return this.Pitagoras(pPunto);
        }

        private double Pitagoras(Punto pPunto)
        {
            double difx;
            double dify;
            difx = this.iX - pPunto.iX;
            dify = this.iY - pPunto.iY;
            return Math.Sqrt((Math.Pow(difx,2))+(Math.Pow(dify,2)));
        }
    }
}

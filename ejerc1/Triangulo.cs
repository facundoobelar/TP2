using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerc1
{
    class Triangulo
    {
        private Punto iPunto1, iPunto2, iPunto3;
        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            this.iPunto1 = pPunto1;
            this.iPunto2 = pPunto2;
            this.iPunto3 = pPunto3;
        }
        public Punto Punto1
        {
            get { return this.iPunto1; }
            set { this.iPunto1 = value; }
        }
        public Punto Punto2
        {
            get { return this.iPunto2; }
            set { this.iPunto2 = value; }
        }
        public Punto Punto3
        {
            get { return this.iPunto3; }
            //no van los set
           set { this.iPunto3 = value; }
        }

        public double Perimetro
        {
            get{ return this.iPunto1.CalcularDistanciaDesde(this.iPunto2) + this.iPunto1.CalcularDistanciaDesde(this.iPunto3) + this.iPunto2.CalcularDistanciaDesde(this.iPunto3); }
        }

        public double Area 
        {
            //| X1 Y1 1 |
            //| X2 Y2 1 | = (X1*Y2*1+Y1*1*X3+X2*Y3*1-(1*Y2*X3+X2*Y1*1+Y3*1*X1) )/ 2 DA EL AREA DEL TRIANGULO
            //| X3 Y3 1 |
            get { return ((iPunto1.X * iPunto2.Y * 1 + iPunto1.Y * 1 * iPunto3.X + iPunto2.X * 1 * iPunto3.Y - (1 * iPunto2.Y * iPunto3.X + 1 * iPunto2.X * iPunto1.Y + 1 * iPunto1.X * iPunto3.Y))/2); }
        }
    }
}

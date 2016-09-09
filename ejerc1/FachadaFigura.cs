using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerc1
{
    class FachadaFigura
    {
        Punto iP1 = new Punto();
        Punto iP2 = new Punto();
        Punto iP3 = new Punto();

        public double AreaCirculo(double pRadio)
        {
            Circulo Cir = new Circulo(pRadio);
            return Cir.Area;
        }
        public double AreaTriangulo(double [] pPuntos)
        {
            iP1.X = pPuntos[0];
            iP1.Y = pPuntos[1];
            iP2.X = pPuntos[2];
            iP2.Y = pPuntos[3];
            iP3.X = pPuntos[4];
            iP3.Y = pPuntos[5];

            Triangulo Tri = new Triangulo(iP1,iP2,iP3);
            return Tri.Area;
        }
        public double PerimetroCirculo(double pRadio)
        {
            Circulo Cir = new Circulo(pRadio);
            return Cir.Perimetro;
        }
        public double PerimetroTriangulo(double [] pPuntos)
        {
            iP1.X = pPuntos[0];
            iP1.Y = pPuntos[1];
            iP2.X = pPuntos[2];
            iP2.Y = pPuntos[3];
            iP3.X = pPuntos[4];
            iP3.Y = pPuntos[5];

            Triangulo Tri = new Triangulo(iP1, iP2, iP3);
            return Tri.Perimetro;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerc4
{//modificar el public para el test
   public class Complejo
    {   //Declaro 
        private readonly double iReal, iImaginario;
        
        //Declaro Constructor
        public  Complejo(double pReal, double pImaginario)
        {
            this.iImaginario=pImaginario;
            this.iReal = pReal;
        }
        public double Real
        {
            get { return this.iReal; }
        }
        public double Imaginario
        {
            get { return this.iImaginario; }
        }
        public double ArgumentoEnRadianes
        {
            get { return Math.Atan2(this.Imaginario, this.Real); }
        }
        public double ArgumentoEnGrados
        {
            get {return ((Math.Atan2(this.Imaginario, this.Real)*180)/ Math.PI); }
        }
        public Complejo Conjugado
        {
            get { return( new Complejo(this.Real, (-1)*this.Imaginario)); }
        }
        public double Magnitud
        {
            get {return ((Math.Pow(this.Real,2))+(Math.Pow(this.Imaginario,2))); }
        }
        public bool EsReal()
        {
            return (this.Imaginario==0);
        }
        public bool EsImaginario()
        {
            return((this.Real==0)&&(this.Imaginario!=0));
        }
        public bool EsIgual(Complejo pOtroComplejo)
        {
            return ((this.Imaginario==pOtroComplejo.Imaginario)&&(this.Real==pOtroComplejo.Real));
        }
        public bool EsIgual(double pReal, double pImaginario)
        {
            return((this.iReal==pReal)&&(this.iImaginario==pImaginario));
        }
        public Complejo Sumar(Complejo pOtroComplejo)
        {
            return(new Complejo(this.Real + pOtroComplejo.Real,this.Imaginario + pOtroComplejo.Imaginario));
        }
        public Complejo Restar(Complejo pOtroComplejo)
        {
            return(new Complejo(this.Real - pOtroComplejo.Real, this.Imaginario- pOtroComplejo.Imaginario));
        }
        public Complejo Multiplicar(Complejo pOtroComplejo)
        {
            return(new Complejo((this.Real*pOtroComplejo.Real)-(this.Imaginario*pOtroComplejo.Imaginario),(this.Real*pOtroComplejo.Imaginario)+(this.Imaginario*pOtroComplejo.Real))); 
        }
        public Complejo DividirPor(Complejo pOtroComplejo)
        { double cociente = (Math.Pow(pOtroComplejo.Real, 2)) + (Math.Pow(pOtroComplejo.Imaginario, 2));
            return(new Complejo((((this.Real*pOtroComplejo.Real)+(this.Imaginario*pOtroComplejo.Imaginario))/cociente), ((this.Imaginario*pOtroComplejo.Real)-(this.Real*pOtroComplejo.Imaginario))/cociente));
        }
    }
}


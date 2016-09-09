using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerc2
{
    class Cuenta
    {
        //declaro los atributos de la clase
        private double iSaldo;
        private double iAcuerdo;
        //declaro constructores 
        public Cuenta(double pAcuerdo )
        {
            iAcuerdo = pAcuerdo;
            this.iSaldo = 0;
        }
        public Cuenta(double pSaldoInicial, double pAcuerdo)
        {
            iAcuerdo = pAcuerdo;
            iSaldo = pSaldoInicial;
        }
        //declaro property
        public double Saldo
        {
            get {return this.iSaldo; }
        }
        public double Acuerdo
        {
            get {return this.iAcuerdo; }
        }
        //declaro metodos
        public void AcreditarSaldo(double pSaldo)
        {
            this.iSaldo = this.iSaldo + pSaldo;
        }
        public bool DebitarSaldo(double pSaldo)
        {
            if (this.Saldo>=pSaldo)
            {
                this.iSaldo = this.iSaldo - pSaldo;
                return true;
            }
            else if((this.iSaldo + this.iAcuerdo)>=pSaldo)
            {
                this.iSaldo = this.iSaldo - pSaldo;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

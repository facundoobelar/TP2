using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerc2
{
    class Cuentas
    {   //declaro atributos
        private Cuenta iCajaAhorro;
        private Cuenta iCuentaCorriente;
        private Cliente iCliente;
        //declaro constructor
        public Cuentas()
        {
            this.iCajaAhorro = new Cuenta(2000);
            this.iCuentaCorriente = new Cuenta(1000);
            this.iCliente = new Cliente();
        }
        //declaro property
        public Cuenta CuentaCorriente
        {
            get { return this.iCuentaCorriente; }
        }
        public Cuenta CajaAhorro
        {
            get { return this.iCajaAhorro; }
        }
        public bool TransferirDeCCaCA(double pMonto)
        {
            if (this.iCuentaCorriente.DebitarSaldo(pMonto))
            {
                this.iCajaAhorro.AcreditarSaldo(pMonto);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TransferirDeCAaCC(double pMonto)
        {
            if (this.iCajaAhorro.DebitarSaldo(pMonto))
            {
                this.iCuentaCorriente.AcreditarSaldo(pMonto);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

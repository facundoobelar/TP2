using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerc2
{
    class FachadaCuenta
    {   //declaro una instancia de cuentas
        Cuentas iCuentas = new Cuentas();
     //metodos consultar cuenta corriente caja ahorro
    public double ConsultarSaldoCC()
        {
            return iCuentas.CuentaCorriente.Saldo;
        }
    public double ConsultarSaldoCa()
        {
            return iCuentas.CajaAhorro.Saldo;
        }
        //metodos consultar acuerdo
    public double ConsultarAcuerdoCa()
        {
            return iCuentas.CajaAhorro.Acuerdo;
        }
    public double ConsultarAcuerdoCC()
        {
            return iCuentas.CuentaCorriente.Acuerdo;
        }
     //metodos debitar cuenta corriente caja ahorro
    public bool DebitarSaldoCC(double pSaldo )
        {
           return iCuentas.CuentaCorriente.DebitarSaldo(pSaldo);
        }
    public bool DebitarSaldoCa(double pSaldo)
        {
            return iCuentas.CajaAhorro.DebitarSaldo(pSaldo);
        }
    //metodos acreditar saldo cuenta corriente caja ahorro
    public void AcreditarSaldoCC(double pSaldo)
        {
            iCuentas.CuentaCorriente.AcreditarSaldo(pSaldo);
        }
    public void AcreditarSaldoCa(double pSaldo)
        {
            iCuentas.CajaAhorro.AcreditarSaldo(pSaldo);
        }
        //metodo 
        public bool TransferirDeCCaCA(double pMonto)
        {
            return this.iCuentas.TransferirDeCCaCA(pMonto);
        }

        public bool TransferirDeCAaCC(double pMonto)
        {
            return this.iCuentas.TransferirDeCAaCC(pMonto);
        }
    }
}

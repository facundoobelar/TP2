using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            FachadaCuenta Fc = new FachadaCuenta();
            char letra;
            do
            {
                Console.Clear();
                Console.WriteLine("Elija sobre que cuenta operar:");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1- CUENTA CORRIENTE");
                Console.WriteLine("2- CAJA AHORRO:");
                Console.WriteLine("3- Salir:");
                Console.WriteLine("---------------------------------");
                Console.WriteLine();
                Console.Write("Ingrese Opción: ");
                letra = Console.ReadKey().KeyChar;
                switch (letra)
                {
                    case '1':
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("ELIJA SOBRE QUE CUENTA OPERAR: ");
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("1- CONSULTAR SALDO");
                            Console.WriteLine("2- CONSULTAR ACUERDO");
                            Console.WriteLine("3- DEBITAR");
                            Console.WriteLine("4- ACREDITAR");
                            Console.WriteLine("5- TRANSFERENCIA");
                            Console.WriteLine("6- VOLVER");
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine();
                            Console.Write("INGRESE OPCION: ");
                            letra = Console.ReadKey().KeyChar;
                            switch (letra)
                            {
                                case '1':
                                    Console.Clear();
                                    Console.WriteLine("El saldo de su cuenta es: " + Fc.ConsultarSaldoCC());
                                    Console.WriteLine();
                                    Console.WriteLine("--Presionar tecla para continuar--");
                                    Console.ReadKey();
                                    break;
                                case '2':
                                    Console.Clear();
                                    Console.WriteLine("El saldo de su Acuerdo es: " + Fc.ConsultarAcuerdoCC());
                                    Console.WriteLine();
                                    Console.WriteLine("--Presionar tecla para continuar--");
                                    Console.ReadKey();
                                    break;
                                case '3':
                                    Console.Clear();
                                    Console.WriteLine("Ingrese monto a debitar: ");
                                    double montoDebitar = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Debito realizado: " + Fc.DebitarSaldoCC(montoDebitar));
                                    Console.ReadLine();
                                    break;
                                case '4':
                                    Console.Clear();
                                    Console.WriteLine("Ingrese monto a acreditar: ");
                                    double montoAcreditar = Convert.ToDouble(Console.ReadLine());
                                    Fc.AcreditarSaldoCC(montoAcreditar);
                                    Console.WriteLine("Operacion realizada ");
                                    Console.ReadLine();
                                    break;
                                case '5':
                                    Console.Clear();
                                    Console.WriteLine("ingrese monto a transferir: ");
                                    double montoTransferir = Convert.ToDouble(Console.ReadLine());
                                    Fc.TransferirDeCCaCA(montoTransferir);
                                    Console.ReadLine();
                                    break;
                            }
                        } while (letra != '6');
                        break;
                    case '2':
                        
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("ELIJA SOBRE QUE CUENTA OPERAR: ");
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("1- CONSULTAR SALDO");
                            Console.WriteLine("2- CONSULTAR ACUERDO");
                            Console.WriteLine("3- DEBITAR");
                            Console.WriteLine("4- ACREDITAR");
                            Console.WriteLine("5- TRANSFERENCIA");
                            Console.WriteLine("6- VOLVER");
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine();
                            Console.Write("INGRESE OPCION: ");
                            letra = Console.ReadKey().KeyChar;
                            switch (letra)
                            {
                                case '1':
                                    Console.Clear();
                                    Console.WriteLine("El saldo de su cuenta es: " + Fc.ConsultarSaldoCa());
                                    Console.WriteLine();
                                    Console.WriteLine("--Presionar tecla para continuar--");
                                    Console.ReadKey();
                                    break;
                                case '2':
                                    Console.Clear();
                                    Console.WriteLine("El saldo de su Acuerdo es: " + Fc.ConsultarAcuerdoCa());
                                    Console.WriteLine();
                                    Console.WriteLine("--Presionar tecla para continuar--");
                                    Console.ReadKey();
                                    break;
                                case '3':
                                    Console.Clear();
                                    Console.WriteLine("Ingrese monto a debitar: ");
                                    double montoDebitar = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Debito realizado: " + Fc.DebitarSaldoCa(montoDebitar));
                                    Console.ReadLine();
                                    break;
                                case '4':
                                    Console.Clear();
                                    Console.WriteLine("Ingrese monto a acreditar: ");
                                    double montoAcreditar = Convert.ToDouble(Console.ReadLine());
                                    Fc.AcreditarSaldoCa(montoAcreditar);
                                    Console.WriteLine("Operacion realizada ");
                                    Console.ReadLine();
                                    break;
                                case '5':
                                    Console.Clear();
                                    Console.WriteLine("ingrese monto a transferir: ");
                                    double montoTransferir = Convert.ToDouble(Console.ReadLine());
                                    Fc.TransferirDeCAaCC(montoTransferir);
                                    Console.ReadLine();
                                    break;
                            }
                        }
                        while (letra != '6');
                        break;
                }
            } while (letra != '3');
        }
        
    }
}           
      

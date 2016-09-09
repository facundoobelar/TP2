using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            FachadaFigura Ff = new FachadaFigura();
            double[] vector =new double[6];
            bool oF = false;
            bool oC = false;
            while (oF==false)
            {
                string opcionFigura = MenuFigura();
                if (opcionFigura == "1")//Circulo 
                {
                    oF = true;
                    Console.Clear();
                    while (oC == false)
                    {
                        string opcionCalculo = MenuCalculo();
                        if (opcionCalculo == "1")//Áerea
                        {
                            oC = true;
                            Console.WriteLine("Ingresar radio: ");
                            double r = Convert.ToDouble(Console.Read());
                            Console.WriteLine("Área circulo: " + Ff.AreaCirculo(r));
                            Console.ReadLine();
                        }
                        else if (opcionCalculo=="2")//Perimetro
                        {
                            oC = true;
                            Console.WriteLine("Ingresar radio: ");
                            double r = Convert.ToDouble(Console.Read());
                            Console.WriteLine("Perimetro circulo: " + Ff.PerimetroCirculo(r));
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Opcion incorrecta (Enter para continuar");
                            Console.ReadLine();
                        }
                    }
                }
                else if (opcionFigura == "2")//Triangulo
                {
                    oF = true;
                    while (oC == false)
                    {
                        string opcionCalculo = MenuCalculo();
                        if (opcionCalculo == "1")//Áerea
                        {
                            oC = true;
                            for (int i = 0; i <= 5; i++)
                            {
                                Console.WriteLine("Ingresar punto : ");
                                double carPt = Convert.ToDouble(Console.ReadLine());
                                vector[i] = carPt;
                            }
                            Console.WriteLine("Área Triangulo: " + Ff.AreaTriangulo(vector));
                            Console.ReadLine();
                        }
                        else if (opcionCalculo == "2")//Perimetro
                        {
                            oC = true;
                            for (int i = 0; i <= 5; i++)
                            {
                                Console.WriteLine("Ingresar punto: ");
                                double carPt = Convert.ToDouble(Console.ReadLine());
                                vector[i] = carPt;
                            }
                            Console.WriteLine("Perimetro triangulo: " + Ff.PerimetroTriangulo(vector));
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Opcion incorrecta (Enter para continuar");
                            Console.ReadLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Opcion Incorrecta, Seleccione Nuevamente");
                }
                Console.ReadLine();
            }
        }
        private static string MenuFigura()
        {
            Console.WriteLine("FIGURAS GEOMETRICAS");
            Console.WriteLine();
            Console.WriteLine("SELECCIONAR UNA OPCION: ");
            Console.WriteLine("1) CIRCULO ");
            Console.WriteLine("2) TRIANGULO ");
            return Console.ReadLine();       
        }
        private static string MenuCalculo()
        {
            Console.WriteLine("INGRESE OPCION A CALCULAR");
            Console.WriteLine();
            Console.WriteLine("SELECCIONAR UNA OPCION: ");
            Console.WriteLine("1) AREA ");
            Console.WriteLine("2) PERIMETRO ");
            return Console.ReadLine();
        }
    }
}



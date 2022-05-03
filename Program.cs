using System;

namespace Demografia
{
    class Program
    {
        static void Main(string[] args)
        {
            Apariencia();

            while (2 > 1)
            {
                Calculos();
            }
        }

        static void Apariencia()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("----------------JatoMixo----------------");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("--------Calculador de demografía--------");

            Console.ForegroundColor = System.ConsoleColor.DarkBlue;
            Console.WriteLine("----------------------------------------");
            Console.Title = "JatoMixo: Calculador de exámenes";
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.WindowWidth = 40;
        }

        static void Calculos()
        {
            Console.ForegroundColor = System.ConsoleColor.DarkRed;

            Console.WriteLine("-DATOS-");

            Console.ForegroundColor = System.ConsoleColor.Green;

            double habitantes = PedirDato("Habitantes: ");
            double nacementos = PedirDato("Nacementos: ");
            double defuncions = PedirDato("Defuncións: ");
            double defuncionsnenos = PedirDato("Defuncións de nenos: ");
            double emigrantes = PedirDato("Emigrantes: ");
            double inmigrantes = PedirDato("Inmigrantes: ");

            Console.ForegroundColor = System.ConsoleColor.DarkRed;
            Console.WriteLine("-RESULTADOS-");
            Console.ForegroundColor = System.ConsoleColor.Green;

            double TN = TaxaNatalidade(nacementos, habitantes);
            double TM = TaxaMortalidade(defuncions, habitantes);
            double TMI = TaxaMortalidadeInfantil(defuncionsnenos, nacementos);
            double CN = CrecementoNatural(nacementos, defuncions);
            double TCN = TaxaCrecementoNatural(TN ,TM);

            DarDato("Taxa de natalidade: ", TN);
            DarDato("Taxa de mortalidade: ", TM);
            DarDato("Taxa de mortalidade infantil: ", TMI);
            DarDato("Crecemento natural: ", CN);
            DarDato("Taxa de crecemento natural: ", TCN);

            Console.ForegroundColor = System.ConsoleColor.DarkBlue;
            Console.WriteLine("----------------------------------------");
            Console.ForegroundColor = System.ConsoleColor.Green;
        }

        static void DarDato(string message, double dato)
        {
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.Write(message);
            Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
            Console.WriteLine(dato);
            Console.ForegroundColor = System.ConsoleColor.Green;
        }

        static double PedirDato(string message)
        {
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.Write(message);
            Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
            double returned = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = System.ConsoleColor.Green;
            return returned;
            
        }

        static double TaxaMortalidade(double falecementos, double poboacion)
        {
            double returned = (falecementos / poboacion) * 1000;
            return returned;
        }

        static double TaxaMortalidadeInfantil(double falecementos, double nacementos)
        {
            double returned = (falecementos / nacementos) * 1000;
            return returned;
        }

        static double CrecementoNatural(double nacementos, double defuncions)
        {
            double returned = nacementos - defuncions;
            return returned;
        }

        static double TaxaCrecementoNatural(double TN, double TM)
        {
            double returned = TN - TM;
            return returned;
        }

        static double TaxaNatalidade(double nacementos, double habitantes)
        {
            double returned = (nacementos / habitantes) * 1000;
            return returned;
        }
    }
}

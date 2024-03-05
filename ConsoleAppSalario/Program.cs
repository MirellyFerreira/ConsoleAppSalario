using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe qual o teu salário bruto: ");
            double s = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do vale alimentação: ");
            double va = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe quantos filhos você tem: ");
            double qf = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor por filho: ");
            double vf = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe quanto você fez de hora extra: ");
            double vhe = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da hora extra: ");
            double he = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do INSS: ");
            double din = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do IRPF: ");
            double dir = double.Parse(Console.ReadLine());

            double sl = s + va + (qf * vf) + (vhe * he) - din - dir;

            Console.WriteLine("Salário liquído: " , sl);

            Console.ReadKey();
           

        }

    }
}

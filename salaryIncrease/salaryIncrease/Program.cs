using System;
using System.Globalization;


namespace curso


{
    class Program
    {
        static void Main(string[] args)
        {

            double salarioAtual, salarioFinal = 0, reajuste;

            Console.WriteLine("Insira seu salario aqui:");
            salarioAtual = double.Parse(Console.ReadLine());

            if (salarioAtual > 0 && salarioAtual <= 400.00)
            {
                reajuste = salarioAtual * 15 / 100;
                salarioFinal = reajuste + salarioAtual;
                Console.WriteLine("Novo salario: " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salarioAtual >= 400.01 && salarioAtual <= 800.00)
            {
                reajuste = salarioAtual * 12 / 100;
                salarioFinal = reajuste + salarioAtual;
                Console.WriteLine("Novo salario: " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salarioAtual >= 800.01 && salarioAtual <= 1200.00)
            {
                reajuste = salarioAtual * 10 / 100;
                salarioFinal = reajuste + salarioAtual;
                Console.WriteLine("Novo salario: " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salarioAtual >= 1200.01 && salarioAtual <= 2000.00)
            {
                reajuste = salarioAtual * 7 / 100;
                salarioFinal = reajuste + salarioAtual;
                Console.WriteLine("Novo salario: " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7 %");
            }
            else if (salarioAtual >= 2000.00)
            {
                reajuste = salarioAtual * 4 / 100;
                salarioFinal = reajuste + salarioAtual;
                Console.WriteLine("Novo salario: " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }


        }
    }
}
using System;
using System.Globalization;


namespace curso


{
    class Program
    {
        static void Main(string[] args)
        {

            double diasLeo, receberLeo, totalLeo, diasDaniel, receberDaniel, totalDaniel, diasAilton, receberAilton, totalAilton, diasCelio, receberCelio, gasolina, totalCelio, valorTotal;

            receberLeo = 190.00;
            receberDaniel = 160.00;
            receberAilton = 130.00;
            receberCelio = 100.00;
            gasolina = 200.00;


            Console.WriteLine("Insira quantos dias LEO trabalhou!");
            diasLeo = double.Parse(Console.ReadLine());
            totalLeo = diasLeo * receberLeo;

            Console.WriteLine("Insira quantos dias DANIEL trabalhou!");
            diasDaniel = double.Parse(Console.ReadLine());
            totalDaniel = diasDaniel * receberDaniel;

            Console.WriteLine("Insira quantos dias AILTON trabalhou!");
            diasAilton = double.Parse(Console.ReadLine());
            totalAilton = diasAilton * receberAilton;

            Console.WriteLine("Insira quantos dias CELIO trabalhou!");
            diasCelio = double.Parse(Console.ReadLine());
            totalCelio = (diasCelio * receberCelio) + gasolina;

            valorTotal = (diasLeo * receberLeo) + (diasDaniel * receberDaniel) + (diasAilton * receberAilton) + (diasCelio * receberCelio) + gasolina;


            Console.WriteLine("Mão de obra da semana do LEO: R$ " + totalLeo);
            Console.WriteLine("Mão de obra da semana do DANIEL: R$ " + totalDaniel);
            Console.WriteLine("Mão de obra da semana do AILTON: R$ " + totalAilton);
            Console.WriteLine("Mão de obra da semana do CELIO: R$ " + totalCelio);

            Console.WriteLine("O valor de mão de obra da semana + gasolina foi: " + valorTotal);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_02_parte_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero = 0;
            int segundoNumero = 0;
            double resultadoTotal = 0;
            Console.Write("Digite o primeiro numero. ");
            primeiroNumero = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero. ");
            segundoNumero = int.Parse(Console.ReadLine());
            resultadoTotal = primeiroNumero / segundoNumero;
            Console.WriteLine("resultado da divisao é: {0}", resultadoTotal);
            

            
        }
    }
}

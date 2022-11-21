using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iniciante5_SalarioReajuste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n*******************************************************************");
            Console.WriteLine(">>>>>>>>>>  APLICAÇÃO PARA CALCULO DE REAJUSTE SALARIAL  <<<<<<<<<<");
            Console.WriteLine("*******************************************************************");

            int qtdFuncionarios = 0;
            double salario = 0;
            int i = 0;

            Console.Write("\n\n\n\nDigite o número de funcionários que deseja calcular: ");
            qtdFuncionarios = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*******************************************************************\n\n\n");

            while (i < qtdFuncionarios)
            {
                i++;
                Console.Write("Digite o salário do funcionário " + i + ": ");
                salario = Convert.ToDouble(Console.ReadLine());
            }





            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\n\n\n*******************************************************************");
            Console.WriteLine(">>>>>>>>>>       APLICAÇÃO FINALIZADA COM SUCESSO        <<<<<<<<<<");
            Console.WriteLine("*******************************************************************");
            Console.ReadKey();
        }
    }
}

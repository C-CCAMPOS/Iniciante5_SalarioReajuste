using System;

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
            int reaj = 0;
            double salReaj = 0;

            Console.Write("\n\n\n\nDigite o número de funcionários que deseja calcular: ");
            qtdFuncionarios = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*******************************************************************\n\n\n");

            while (i < qtdFuncionarios)
            {
                i++;
                Console.Write("Digite o salário do funcionário " + i + ": R$ ");
                salario = Convert.ToDouble(Console.ReadLine());

                if (salario <= 300)
                {
                    reaj++;

                    salReaj = ((salario * 50) / 100);
                    salReaj = salReaj + salario;

                    Console.WriteLine(" \nValor reajustado para: R$ " + salReaj);
                }
                else
                {
                    salReaj = ((salario * 30) / 100);
                    salReaj = salReaj + salario;

                    Console.WriteLine(" \nValor reajustado para: R$ " + salReaj);
                }
                Console.WriteLine("*******************************************************************\n");


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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOTORES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int motormaiorV = 0;
            int motormenorV = 0;
            int[] motor = new int[10];
            int z = 0;
            int i = 0;
            int valor = 0;
            int op;

            int maiorV = int.MinValue;
            int menorV = int.MaxValue;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("MENU");
                Console.WriteLine("[0]SAIR");
                Console.WriteLine("[1]LANÇAR");
                Console.WriteLine("[2]TABELA");
                Console.WriteLine("[3]MAIOR");
                Console.WriteLine("[4]MENOR");
                Console.WriteLine("");

                Console.Write("Selecione uma das opções: ");
                op = int.Parse(Console.ReadLine());
                while (op < 0 || op > 4)
                {
                    Console.Write("Selecione uma das opções: ");
                    op = int.Parse(Console.ReadLine());
                }


                switch (op)
                {

                    case 1://1LANÇAR
                        {
                            Console.Write("MOTOR (1 A 10) ");
                            i = int.Parse(Console.ReadLine());
                            while (i < 1 || i > 10)
                            {
                                Console.Write("MOTOR (1 A 10) ");
                                i = int.Parse(Console.ReadLine());
                            }

                            Console.Write("VALOR: ");
                            valor = int.Parse(Console.ReadLine());
                        }


                        motor[i - 1] += valor;

                        //maior e menor VALOR
                        if (valor > maiorV) { maiorV = valor; motormaiorV = i - 1; }
                        if (valor < menorV) { menorV = valor; motormenorV = i - 1; }
                        break;

                    case 2://2TABELA  
                        Console.WriteLine("TABELA DE VALORES:");
                        for (z = 0; z < motor.Length; z++)
                        { Console.WriteLine("MOTOR {0} | VALOR {1}", z + 1, motor[z]); }


                        break;

                    case 3://3MAIOR
                        if (menorV == int.MaxValue)
                            Console.WriteLine("Nenhum valor foi lançado ainda.");
                        else
                        { Console.WriteLine("MOTOR {0} ,MAIOR VALOR {1}", motormaiorV + 1, maiorV); }

                        break;

                    case 4://4MENOR
                        if (maiorV == int.MinValue)
                            Console.WriteLine("Nenhum valor foi lançado ainda.");
                        else
                        { Console.WriteLine("MOTOR {0} ,MENOR VALOR {1}", motormenorV + 1, menorV); }

                        break;



                }


            } while (op != 0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
           inicio:
            try
            {
         
                Console.Clear();
                Console.WriteLine("Digite o número 1\n");
                double numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o número 2\n");
                double numero2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Escolha uma operação (+ * /)");
                string operação = Console.ReadLine();
                double resultado;
                switch (operação)
                {
                    default:
                        goto inicio;
                    case "+":
                        resultado = numero1 + numero2;
                        Console.WriteLine($"O resultado da soma é igua a: {resultado}");
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        Console.WriteLine($"O resultado da subtração é igua a: {resultado}");
                        break;
                    case "*":
                        resultado = numero1 * numero2;
                        Console.WriteLine($"O resultado da multiplicação é igua a: {resultado}");
                        break;
                    case "/":

                        if (numero1 == 0 || numero2 == 0)
                        {
                            Console.WriteLine($"Não pode ser divido por 0");
                            goto inicio;
                        }

                        resultado = numero1 / numero2;
                        Console.WriteLine($"O resultado da divisão é igua a: {resultado}");
                        break;
                }


                Console.WriteLine($"Deseja continuar (s/n)");
                string mensagem = Console.ReadLine();

                if (mensagem == "s" || mensagem == "S")
                {
                    goto inicio;
                }else
                {
                    Console.ReadKey();
                }           
            }
            catch
            {
                goto inicio;
            }
        }
    }
}

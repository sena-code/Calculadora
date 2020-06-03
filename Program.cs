using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraCientifica calculo = new CalculadoraCientifica();
    

            calculo.resultado = 0;

            Console.WriteLine("Digite o numero 1 :");
            float number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero :");
            float number2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o simbolo da operação que deseja utilizar:");
            string operacao = Console.ReadLine();
            

            switch(operacao){

                case "+":
                Console.WriteLine("O resultado é "+number1 + number2);
                break;
                case "-":
                Console.WriteLine(number1 - number2);
                break;
                case "/":
                Console.WriteLine("O resultado é " +number1 / number2);
                break;
                case "*":
                Console.WriteLine("O resultado é" +number1 * number2);
                break;



            }

            

        }
    }
}

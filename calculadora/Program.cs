using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variavel
            double contaRealizada;
            //demonstração de conversão STRING para INT
            int numero = Convert.ToInt32("45");
            

            Console.Write("Insira o primeiro valor: ");
            //conversão necessaria pois ReadLine sempre pega o valor como STRING
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Selecione a operação para realizar (valor numérico): ");
            Console.WriteLine("1- Soma\n2- Subtração\n3- Divisão\n4- Multiplicação");
            
            int decisao = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine(decisao);

            switch(decisao)
            {
            case 1:
                contaRealizada = valor1 + valor2;
                Console.WriteLine("Resultado: "+contaRealizada);
                break;
            case 2:
                contaRealizada = valor1 - valor2;
                Console.WriteLine("Resultado: "+contaRealizada);
                break;
            case 3:
                contaRealizada = valor1 / valor2;
                Console.WriteLine("Resultado: "+contaRealizada);
            break;
            case 4:
                contaRealizada = valor1 * valor2;
                Console.WriteLine("Resultado: "+contaRealizada);
            break;
            default:
                Console.WriteLine("Favor inserir um valor valido!");
                break;
            }
            //Console.WriteLine("Hello World!");
        }
    }
}

using System;

namespace numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis
            int valorInt = 10;
            double valorDouble = 10.5;
            int negativoInt = -10;
            double negativoDouble = -10.5;

            //soma e subtração com os numeros
            Console.WriteLine("Soma entre valores positivos: "+  (valorInt + valorDouble));
            Console.WriteLine("Soma entre valores negativos: "+ (negativoInt + negativoDouble));
            Console.WriteLine("Subtração entre valores positivos: "+ (valorDouble - valorInt));
            Console.WriteLine("Subtração entre valores positivos e negativos: "+ (valorDouble - negativoDouble));
                                                                //se você tirar a operação do () ele printa como string...
            //salvar contas numa outra variavel e printar ela 
            double contaRealizada = valorInt + negativoDouble; //necessario declarar tipo de dado sempre; 
            Console.WriteLine("Resultado do valor positivo inteiro + valor negativo decimal: "+contaRealizada);
            contaRealizada = valorInt + negativoInt; 
            Console.WriteLine("Resultado do valor positivo inteiro + valor negativo inteiro: "+contaRealizada);
            
            //divisão e multiplicação com os numeros
            Console.WriteLine("Multiplicação: " + (valorInt * valorDouble));
            Console.WriteLine("Divisão: " + (valorDouble/valorInt));
            //observação: o resultado do calculo é realizado de acordo com o tipo dos dados, logo...
            Console.WriteLine("Divisão com resultado decimal entre valores INT (5/2): " + (5/2));
            Console.WriteLine("Divisão com resultado decimal com valor DOUBLE (5.0/2): " + (5.0/2));

            //pegar o resto da divisão (modulo)
            Console.WriteLine("Resto de 10 dividido por 2: " + (valorInt % 2) );
            Console.WriteLine("Resto de 5 dividido por 2: " + (5 % 2));

            //ordem de operações
            Console.WriteLine("7 + 3,5 * 2: "+ (7 + 3.5 * 2));
            Console.WriteLine("(7 + 3,5) * 2: "+ ( (7 + 3.5) * 2));

            //incrementar/diminuir numero por ++/--
            valorInt++;
            Console.WriteLine("valorInt++: "+ valorInt);
            valorInt--;
            Console.WriteLine("valorInt--: "+ valorInt);

            //metodos

            //ver o valor absoluto de um numero
            Console.WriteLine("Valor absoluto de negativoDouble: "+Math.Abs(negativoDouble));

            //calcular a potencia de um numero
            Console.WriteLine("5 elevado a 2: "+Math.Pow(5, 2));
            Console.WriteLine("10.5 elevado a 3: "+Math.Pow(valorDouble, 3));

            //calcular a raiz quadrada de um numero
            Console.WriteLine("Raiz quadrada de 36: "+ Math.Sqrt(36));
            Console.WriteLine("Raiz quadrada de 10.5: "+ Math.Sqrt(valorDouble));
            
            //ver qual numero é maior
            Console.WriteLine("Número maior entre 10 e 10.5: "+ Math.Max(valorInt, valorDouble));
            Console.WriteLine("Número maior entre 1 e -1: "+Math.Max(1, -1));

            //ver qual numero é menor
            Console.WriteLine("Número menor entre 10 e 10.5: "+ Math.Min(valorInt, valorDouble));
            Console.WriteLine("Número menor entre 1 e -1: "+Math.Min(1, -1));

            //arrendondar numeros
            Console.WriteLine("10.3 arredondado: "+ Math.Round(10.3));
            Console.WriteLine("10.5 arredondado: "+ Math.Round(valorDouble));        
            Console.WriteLine("10.6 arredondado: "+ Math.Round(10.6));    

            //Console.Clear();
            //Console.ReadLine();
        }
    }
}

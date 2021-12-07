using System;

namespace input
{
    class Program
    {
        static void Main(string[] args)
        {
            //texto para indicação
            //o "Write" sozinho (não confundir com o WriteLine) printa e fixa o que é colocado depois na mesma linha (diferente do WriteLine)
            Console.Write("Insira seu nome: ");
            //abre espaço para o input do usuario e salva o valor digitado numa variavel
            string nome = Console.ReadLine();
            //printa valor colocado
            Console.WriteLine("Bom dia "+nome+"!");

            Console.Write("Insira sua idade: ");
            string idade = Console.ReadLine();

            Console.WriteLine("Nossa, você tem "+idade+"! Tá velho ein!");
        
            //Console.Clear();
            //Console.ReadLine();
        }
    }
}

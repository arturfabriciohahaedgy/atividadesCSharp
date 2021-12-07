using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variavel
            string frase = "Artur Fabricio";
            
            //divisão de linhas por \n
            Console.WriteLine("Artur\nFabricio");
            
            //printar aspas
            Console.WriteLine("\"Artur Fabricio\"");

            //descobrir o numero de caracteres na string
            Console.WriteLine("Tamanho da string: "+frase.Length);

            //transformar string em uppercase
            Console.WriteLine("Uppercase: "+frase.ToUpper() );

            //transformar string em lowercase
            Console.WriteLine("Lowercase: "+frase.ToLower() );

            //descobrir se uma string contem algum valor em especifico dentro dela (retorna valor boolean)
            Console.WriteLine("Descobrir se contem \"Fabricio\": "+frase.Contains("Fabricio"));

            //descobrir caracteres especificos numa posição em string
            Console.WriteLine("Descobrir qual o primeiro cara: "+frase[0] );
            Console.WriteLine("Descobrir qual o terceiro cara: "+frase[2] );

            //descobrir se uma string contem algum valor em especifico E a poisção onde ele começa
            Console.WriteLine("Descobrir onde começa o Fabricio: "+ frase.IndexOf("Fabricio") );
            Console.WriteLine("Descobrir onde fica o primeiro 'u' da variavel: "+ frase.IndexOf('u') ); //é case sensitive
            // ^^^^^^^^ se lembre que ' ' = char, " " = string
            Console.WriteLine("Descobrir se o caractere \"Z\" está presente: (se o retorno de IndexOf der -1, então não está): "+ frase.IndexOf('z') );

            //printar os caractereses de uma string começando de um index especifico (e até quantos caracteres quer pegar)
            Console.WriteLine ("Printar os caracteres começando do index 4: "+frase.Substring(4) );
            Console.WriteLine ("Printar os 3 primeiros caracteres começando do index 4: "+frase.Substring(4, 3) );
            
            

            //Console.Clear();
            //Console.ReadLine();
        }
    }
}

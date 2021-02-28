using System;

namespace Exercicio_de_Classes_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa = new Pessoa();
            Pessoa pessoa1 = new Pessoa();

            Console.WriteLine("Dados da Primeira Pessoa :");
            Console.Write("Nome : ");
            pessoa.nome = Console.ReadLine();
            Console.Write("Idade : ");
            pessoa.idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados da Segunda Pessoa :");
            Console.Write("Nome : ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Idade : ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            if(pessoa.idade > pessoa1.idade)
            {
                Console.WriteLine("A Pessoa mais velha é : " + pessoa.nome);
            }
            else
            {
                Console.WriteLine("A Pessoa mais velha é : " + pessoa1.nome);
            }
        }
    }
}

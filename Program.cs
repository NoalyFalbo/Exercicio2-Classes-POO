using System;

namespace exercicioClasses2
{

  class Program
  {

    static void Main(string[] args)
    {

      Console.Clear();

      Pessoa pessoa1 = new Pessoa();
      Pessoa pessoa2 = new Pessoa();


      Console.WriteLine("Digite o nome da primeira pessoa: ");
      pessoa1.Nome = Console.ReadLine();
      Console.WriteLine("Digite a idade da primeira pessoa: ");
      int.TryParse(Console.ReadLine(), out pessoa1.Idade);
      Console.WriteLine("Digite o nome da segunda pessoa: ");
      pessoa2.Nome = (Console.ReadLine());
      Console.WriteLine("Digite a idade da segunda pessoa: ");
      int.TryParse(Console.ReadLine(), out pessoa2.Idade);

      if (pessoa1.Idade > pessoa2.Idade)

        Console.WriteLine("A pessoa mais velha é " + pessoa1.Nome);
      else
        Console.WriteLine("A pessoa mais velha é " + pessoa2.Nome);
    }
  }
}

using System;

class MainClass {
  public static void Main (string[] args) {
    
    string resp;
    int preco;
    string item;
    int conta= 0;

    soma paga = new soma();
    notafiscal nota = new notafiscal();

    Console.WriteLine("Seja bem vindo ao Compra Fácil");
    Console.WriteLine("Deseja realizar alguma compra?");
    resp = Console.ReadLine();

    while(resp=="sim" || resp=="SIM" || resp == "Sim")
    {
      

      Console.WriteLine("Digite o nome do item!");
      item = Console.ReadLine();
      nota.nome(item, conta);

      Console.WriteLine("Digite o valor!");
      preco = Convert.ToInt32(Console.ReadLine());
      paga.valor(preco, conta);
      paga.somatorio(preco);

      Console.WriteLine("Deseja realizar mais alguma compra?");
      resp = Console.ReadLine();
      conta++;
    }
    
    

    for(int i=0;i<=conta;i++)
    {
      for(int j=0;j<conta;j++)
      {
        Console.WriteLine("");
        Console.Write(nota.getNota(i));
        i++;
        Console.WriteLine(" {0}",paga.getDindin(j));
      }
    }
    Console.WriteLine(" ");
    Console.WriteLine("Sua Conta deu :");
    Console.WriteLine(paga.getSoma());

  }
}
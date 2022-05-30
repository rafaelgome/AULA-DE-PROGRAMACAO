using System;

public class Program{

  public static void Main(){
    
    Console.WriteLine("Digite dois valores inteiros positivos separados por um operador +, -, * ou /");
    
    string conta = Console.ReadLine();
    bool soma = conta.Contains('+');
    bool sub = conta.Contains('-');
    bool mult = conta.Contains('*');
    bool div = conta.Contains('/');
    string[] v = conta.Split();
    double total = 0;
    
    if (soma){
      v = conta.Split('+');
      int x = int.Parse(v[0]);
      int y = int.Parse(v[1]);
      total = x+y;
    }
    if (sub){
      v = conta.Split('-');
      int x = int.Parse(v[0]);
      int y = int.Parse(v[1]);
      total = x-y;
    }
    if (mult){
      v = conta.Split('*');
      int x = int.Parse(v[0]);
      int y = int.Parse(v[1]);
      total = x*y;
    }
    if (div){
      v = conta.Split('/');
      int x = int.Parse(v[0]);
      int y = int.Parse(v[1]);
      total = x/y;
    }
    Console.WriteLine($"O resultado da operação é {total}");
  }
}
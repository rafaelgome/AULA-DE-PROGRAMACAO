using System;

public class Program{

  public static void Main(){

    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    if (a>b) Console.WriteLine($"Maior = {a}");
    if (b>a) Console.WriteLine($"Maior = {b}");
    if (a == b) Console.WriteLine("Números iguais");  
  }
}
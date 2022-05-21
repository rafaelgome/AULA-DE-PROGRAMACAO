using System;
class Program{
  public static void Main(){

    Console.WriteLine("Digite a base a altura do retângulo");
    double b = Double.Parse(Console.ReadLine());
    double a = Double.Parse(Console.ReadLine());
    double area = a * b;
    double per = a * 2 + b * 2;
    double dia = Math.Sqrt(a * a + b * b); 
    Console.WriteLine($"Área:{area: 0.00} - Perímetro:{per: 0.00} - Diagonal:{dia: 0.00}");
    
  }
}
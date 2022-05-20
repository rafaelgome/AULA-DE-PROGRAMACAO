using System;

public class Program {

  public static void Main(string[] args) {

    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double peso1 = 3.5;
    double peso2 = 7.5;
    double peso = 11;
    double notas = (a * peso1 + b * peso2)/peso;
    Console.WriteLine($"MEDIA = {notas:0.00000}");
  }
}

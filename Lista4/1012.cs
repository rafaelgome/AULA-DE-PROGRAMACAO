using System;

public class Program{

  public static void Main(){

    string s = Console.ReadLine();
    string[] abc = s.Split(' ');
    double a = double.Parse(abc[0]);
    double b = double.Parse(abc[1]);
    double c = double.Parse(abc[2]);
    double tri = (a*c)/2;
    double cir = 3.14159*Math.Pow(c,2);
    double tra = (a+b)*c/2;
    double qua = b*b;
    double ret = a*b;
    Console.WriteLine($"TRIANGULO: {tri:0.000}");
    Console.WriteLine($"CIRCULO: {cir:0.000}");
    Console.WriteLine($"TRAPEZIO: {tra:0.000}");
    Console.WriteLine($"QUADRADO: {qua:0.000}");
    Console.WriteLine($"RETANGULO: {ret:0.000}");
    
  }
}

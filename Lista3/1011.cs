using System;

public class Program{

  public static void Main(){

    double r = double.Parse(Console.ReadLine());
    double pi = 3.14159;
    double a = 4/3.0;
    double vol = a * Math.Pow(r,3) * pi;
    Console.WriteLine($"VOLUME = {vol:0.000}");
    
  }
}

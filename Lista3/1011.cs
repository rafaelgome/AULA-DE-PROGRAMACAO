using System;

public class Program {

  public static void Main(string[] args) {

    string s = Console.ReadLine();
    double r = double.Parse(s);
    double pi = 3.14159;
    double a = 4/3.0;
    double v = a * Math.Pow(r,3) * pi;
    Console.WriteLine($"VOLUME = {v:0.000}");
  }
}

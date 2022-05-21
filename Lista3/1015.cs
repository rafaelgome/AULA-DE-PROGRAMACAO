using System;

public class Program{

  public static void Main(){

    string a = Console.ReadLine();
    string b = Console.ReadLine();
    string[] xy1 = a.Split(' ');
    string[] xy2 = b.Split(' ');
    double x1 = double.Parse(xy1[0]);
    double y1 = double.Parse(xy1[1]);
    double x2 = double.Parse(xy2[0]);
    double y2 = double.Parse(xy2[1]);
    double dis = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
    Console.WriteLine(Math.Round(dis, 4));
    
  }
}
//Math.Pow()
//Math.Round()
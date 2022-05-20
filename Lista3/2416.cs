using System;

public class Program {

  public static void Main(){

    string a = Console.ReadLine();
    string[] b = a.Split(' ');
    int c = int.Parse(b[0]);
    int d = int.Parse(b[1]);
    int divisao = c%d;
      Console.WriteLine(divisao);
  }
}
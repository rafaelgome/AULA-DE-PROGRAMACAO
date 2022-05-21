using System;

public class Program{

  public static void Main(){

    string a = Console.ReadLine();
    string[] t = a.Split(' ');
    int t1 = int.Parse(t[0]);
    int t2 = int.Parse(t[1]);
    int t3 = int.Parse(t[2]);
    int t4 = int.Parse(t[3]);
    int tomadas = (t1-1)+(t2-1)+(t3-1)+t4;
    Console.WriteLine(tomadas);
    
  }
}
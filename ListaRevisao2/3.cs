using System;

public class Program{

  public static void Main(){

    int a, b, c, d, numerospares, numerosimpares;
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    c = int.Parse(Console.ReadLine());
    d = int.Parse(Console.ReadLine());
    numerospares = 0;
    numerosimpares = 0; 

    if(a%2 == 0) numerospares = numerospares + a;
    else numerosimpares = numerosimpares + a;
    if(b%2 == 0) numerospares = numerospares + b;
    else numerosimpares = numerosimpares + b;
    if(c%2 == 0) numerospares = numerospares + c;
    else numerosimpares = numerosimpares + c;
    if(d%2 == 0) numerospares = numerospares + d;
    else numerosimpares = numerosimpares + d;

    Console.WriteLine($"Soma dos Pares = {numerospares}");
    Console.WriteLine($"Soma dos Impares = {numerosimpares}");
  }
}
    
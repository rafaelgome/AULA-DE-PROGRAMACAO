using System; 

public class Program {
    
  public static void Main(){

    Console.WriteLine("Digite três valores:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());

    if(a+b>c && a+c>b && b+c>a){
      if(a == c && a == b) Console.WriteLine("Esses valores formam um triângulo equilátero");
      else 
        if(a == c || a == b || b == c) Console.WriteLine("Esses valores formam um triângulo isósceles");
      else 
        if(a != c && a != b && b != c) Console.WriteLine("Esses valores formam um triângulo escaleno");
    }
    else Console.WriteLine("Esses valores não formam um triângulo");
  } 
}
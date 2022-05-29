using System; 

public class Program {
  
  public static void Main(){
    
    Console.WriteLine("Digite os coeficientes a, b, e c de uma equação do II grau");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());

    double delta = Math.Pow(b, 2) - 4.0*a*c;
    
    double raiz1 = (-b + Math.Sqrt(delta))/(2.0*a);
    double raiz2 = (-b - Math.Sqrt(delta))/(2.0*a);

    if (delta < 0 || a == 0) Console.WriteLine("Impossível calcular");
    else Console.WriteLine($"As raízes são {raiz1:0} e {raiz2:0}");
  }
}
//Math.Sqrt
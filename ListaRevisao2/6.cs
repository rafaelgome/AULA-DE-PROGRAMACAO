using System; 

public class Program {
  
  public static void Main(){
    
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());

    int maior = 0;
    int menor = 0;
    
    if (a > b && a > c){maior = maior + a;}
    if (b > a && b > c){maior = maior + b;}
    if (c > a && c > b){maior = maior + c;}
    
    if (a < b && a < c){menor = menor + a;}
    if (b < a && b < c){menor = menor + b;}
    if (c < a && c < b){menor = menor + c;} 

    int soma = (maior + menor);
    Console.WriteLine($"A soma do maior com o menor número é {soma}");
  }
}
using System; 

public class Program {
    
  public static void Main(){

    Console.WriteLine("Digite três valores:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int menor = 0;
    int meio = 0;
    int maior = 0;

    if(a>b && a>c && b>c){
      maior = maior + a;
      meio = meio + b;
      menor = menor + c;
    }
    if(a>b && a>c && b<c){
      maior = maior + a;
      meio = meio + c;
      menor = menor + b;
    }
    if(b>a && b<c && a>c){
      maior = maior + b;
      meio = meio + a;
      menor = menor + c;
    }
    if(b>a && b>c && a<c){
      maior = maior + b;
      meio = meio + c;
      menor = menor + a;
    }
    if(c>a && c>b && a>b){
      maior = maior + c;
      meio = meio + a;
      menor = menor + b;
    }
    if(c>a && c>b && a<b){
      maior = maior + c;
      meio = meio + b;
      menor = menor + a;
    }
    if(a == b && a>c){
      maior = maior + a;
      meio = meio + b;
      menor = menor + c;
    }
    if(a == b && a<c){
      maior = maior + c;
      meio = meio + a;
      menor = menor + b;
    }
    if(a == c && a>b){
      maior = maior + a;
      meio = meio + c;
      menor = menor + b;
    }
    if(a == c && a<b){
      maior = maior + b;
      meio = meio + a;
      menor = menor + c;
    }
    if(b == c && b>a){
      maior = maior + c;
      meio = meio + b;
      menor = menor + a;
    }
    if(b == c && b<a){
      maior = maior + a;
      meio = meio + b;
      menor = menor + c;
    }
    if(a == b && a == c){
      maior = maior + a;
      meio = meio + b;
      menor = menor + c;
    }
    Console.WriteLine($"{menor}, {meio}, {maior}");
  } 
}
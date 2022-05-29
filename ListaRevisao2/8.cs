using System; 

public class Program {
  
  public static void Main(){
    
    Console.WriteLine("Digite quatro valores inteiros");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());

    int maior = 0;
    int menor = 0;
    int segundomaior = 0;
    int segundomenor = 0;

    if(a>b && a>c && a>d) maior = maior + a;
    if(b>a && b>c && b>d) maior = maior + b;
    if(c>a && c>b && c>d) maior = maior + c;
    if(d>a && d>b && d>c) maior = maior + d;

    if(a<b && a<c && a<d) menor = menor + a;
    if(b<a && b<c && b<d) menor = menor + b;
    if(c<a && c<b && c<d) menor = menor + c;
    if(d<a && d<b && d<c) menor = menor + d;

    if(a == menor && b == maior && c<d){segundomenor = segundomenor + c; segundomaior = segundomaior + d;}
    if(a == menor && b == maior && c>d){segundomenor = segundomenor + d; segundomaior = segundomaior + c;} 
    if(a == menor && c == maior && b<d){segundomenor = segundomenor + b; segundomaior = segundomaior + d;} 
    if(a == menor && c == maior && b>d){segundomenor = segundomenor + d; segundomaior = segundomaior + b;} 
    if(a == menor && d == maior && c<b){segundomenor = segundomenor + c; segundomaior = segundomaior + b;} 
    if(a == menor && d == maior && c>b){segundomenor = segundomenor + b; segundomaior = segundomaior + c;}

    if(b == menor && a == maior && c<d){segundomenor = segundomenor + c; segundomaior = segundomaior + d;}
    if(b == menor && a == maior && c>d){segundomenor = segundomenor + d; segundomaior = segundomaior + c;} 
    if(b == menor && c == maior && a<d){segundomenor = segundomenor + a; segundomaior = segundomaior + d;} 
    if(b == menor && c == maior && a>d){segundomenor = segundomenor + d; segundomaior = segundomaior + a;} 
    if(b == menor && d == maior && c<a){segundomenor = segundomenor + c; segundomaior = segundomaior + a;} 
    if(b == menor && d == maior && c>a){segundomenor = segundomenor + a; segundomaior = segundomaior + c;}

    if(c == menor && a == maior && b<d){segundomenor = segundomenor + b; segundomaior = segundomaior + d;}
    if(c == menor && a == maior && b>d){segundomenor = segundomenor + d; segundomaior = segundomaior + b;} 
    if(c == menor && b == maior && a<d){segundomenor = segundomenor + a; segundomaior = segundomaior + d;} 
    if(c == menor && b == maior && a>d){segundomenor = segundomenor + d; segundomaior = segundomaior + a;} 
    if(c == menor && d == maior && b<a){segundomenor = segundomenor + b; segundomaior = segundomaior + a;} 
    if(c == menor && d == maior && b>a){segundomenor = segundomenor + a; segundomaior = segundomaior + b;}

    if(d == menor && a == maior && b<c){segundomenor = segundomenor + b; segundomaior = segundomaior + c;}
    if(d == menor && a == maior && b>c){segundomenor = segundomenor + c; segundomaior = segundomaior + b;} 
    if(d == menor && b == maior && a<c){segundomenor = segundomenor + a; segundomaior = segundomaior + c;} 
    if(d == menor && b == maior && a>c){segundomenor = segundomenor + c; segundomaior = segundomaior + a;} 
    if(d == menor && c == maior && b<a){segundomenor = segundomenor + b; segundomaior = segundomaior + a;} 
    if(d == menor && c == maior && b>a){segundomenor = segundomenor + a; segundomaior = segundomaior + b;}

    int soma = (segundomenor + segundomaior);
    
    if(a == b || a == c || a == d || b == c || b == d || c == d) Console.WriteLine("Os números precisam ser diferentes");
    else
    {
    Console.WriteLine($"Maior valor = {maior}");
    Console.WriteLine($"Menor valor = {menor}");
    Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {soma}");
    }    
  }
}
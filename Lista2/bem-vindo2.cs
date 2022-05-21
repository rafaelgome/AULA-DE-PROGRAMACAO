using System; 
class Program{
  public static void Main(){

    Console.WriteLine("Digite seu nome completo:");
    string n = Console.ReadLine();
    string[] t = n.Split(' ');
    Console.WriteLine($"Bem-vindo ao C#, {t[0]}");
    
  }
}
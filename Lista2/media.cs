using System; 
class Program{
  public static void Main(){

    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
    int s = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
    int t = int.Parse(Console.ReadLine());
    int peso1 = int.Parse("2");
    int peso2 = int.Parse("3");
    int media = (s * peso1 + t * peso2)/(peso1 + peso2);
    Console.WriteLine($"Média parcial: {media}");    
    
  }
}
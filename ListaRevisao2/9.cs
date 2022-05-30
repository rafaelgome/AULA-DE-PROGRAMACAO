using System; 

public class Program {
    
  public static void Main(){
    
    Console.WriteLine("Digite o horário no formato hh:mm");
    string[] s = Console.ReadLine().Split(":");
    int h = int.Parse(s[0]);
    int min = int.Parse(s[1]);
    int angulo = Math.Abs(((11 * min) - (60 * h)) / 2);
    int angulo2 = Math.Abs(360 - angulo);
    if (h < 24 && min >= 0 && h >= 0 && min < 60) {
      if (angulo < 180) Console.WriteLine($"Menor ângulo entre os ponteiros = {angulo} graus");
      if (angulo > 180) Console.WriteLine($"Menor ângulo entre os ponteiros = {angulo2} graus");
    }
      else Console.WriteLine("Hora Inválida");
  }
}

//Math.Abs = módulo
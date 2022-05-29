using System; 

public class Program {
    
  public static void Main(){

    Console.WriteLine("Digite o primeiro horário no formato hh:mm");
    string[] a = Console.ReadLine().Split(':');
    int hora = int.Parse(a[0]);
    int minuto = int.Parse(a[1]);

    Console.WriteLine("Digite o segundo horário no formato hh:mm");
    string[] b = Console.ReadLine().Split(':');
    int hora2 = int.Parse(b[0]);
    int minuto2 = int.Parse(b[1]);

    int horatotal = (hora + hora2);
    int minutototal = (minuto + minuto2);

    if(minutototal>=60)
    {
      minutototal = minutototal - 60;
      horatotal = horatotal + 1;
    }
    
    Console.WriteLine($"Total de horas = {horatotal:00}:{minutototal:00}");
  }
}
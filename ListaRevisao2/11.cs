using System; 

public class Program {
    
  public static void Main(){

    Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
    string[] a = Console.ReadLine().Split('/');
    int dia = int.Parse(a[0]);
    int mes = int.Parse(a[1]);
    int ano = int.Parse(a[2]);
    
    switch(mes){
      case 01: Console.WriteLine(dia>=1 && dia<=31 ? $"A data é {dia} de janeiro de {ano}" : "Data inválida");break;
      case 02: Console.WriteLine(dia>=1 && dia<=29 ? $"A data é {dia} de fevereiro de {ano}" : "Data inválida");break;
      case 03: Console.WriteLine(dia>=1 && dia<=31 ? $"A data é {dia} de março de {ano}" : "Data inválida");break;
      case 04: Console.WriteLine(dia>=1 && dia<=30 ? $"A data é {dia} de abril de {ano}" : "Data inválida");break;
      case 05: Console.WriteLine(dia>=1 && dia<=31 ? $"A data é {dia} de maio de {ano}" : "Data inválida");break;
      case 06: Console.WriteLine(dia>=1 && dia<=30 ? $"A data é {dia} de junho de {ano}" : "Data inválida");break;
      case 07: Console.WriteLine(dia>=1 && dia<=31 ? $"A data é {dia} de julho de {ano}" : "Data inválida");break;
      case 08: Console.WriteLine(dia>=1 && dia<=31 ? $"A data é {dia} de agosto de {ano}" : "Data inválida");break;
      case 09: Console.WriteLine(dia>=1 && dia<=30 ? $"A data é {dia} de setembro de {ano}" : "Data inválida");break;
      case 10: Console.WriteLine(dia>=1 && dia<=31 ? $"A data é {dia} de outubro de {ano}" : "Data inválida");break;
      case 11: Console.WriteLine(dia>=1 && dia<=30 ? $"A data é {dia} de novembro de {ano}" : "Data inválida");break;
      case 12: Console.WriteLine(dia>=1 && dia<=31 ? $"A data é {dia} de dezembro de {ano}" : "Data inválida");break;
      default: Console.WriteLine("Data inválida");break;
    }
  }
}
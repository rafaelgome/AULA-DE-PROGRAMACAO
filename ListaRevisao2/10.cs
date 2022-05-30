using System; 

public class Program {
    
  public static void Main(){

    Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
    string[] a = Console.ReadLine().Split('/');
    int dia = int.Parse(a[0]);
    int mes = int.Parse(a[1]);
    int ano = int.Parse(a[2]);
    int dia1 = 0;
    int dia2 = 0;
    int dia3 = 0;
    int dia4 = 0;
    int dia5 = 0;
    int dia6 = 0;
    int dia7 = 0;
    int dia8 = 0;
    int dia9 = 0;
    int dia10 = 0;
    int dia11 = 0;
    int dia12 = 0;
    
    switch(mes){
      case 01: dia1 = dia1+dia;break;
      case 02: dia2 = dia2+dia;break;
      case 03: dia3 = dia3+dia;break;
      case 04: dia4 = dia4+dia;break;
      case 05: dia5 = dia5+dia;break;
      case 06: dia6 = dia6+dia;break;
      case 07: dia7 = dia7+dia;break;
      case 08: dia8 = dia8+dia;break;
      case 09: dia9 = dia9+dia;break;
      case 10: dia10 = dia10+dia;break;
      case 11: dia11 = dia11+dia;break;
      case 12: dia12 = dia12+dia;break;
    }

    if(dia>=1 && ano>=1900 && ano<=2100 && mes>=1 && mes<=12 && dia1<=31 && dia2<=29 && dia3<=31 && dia4<=30 && dia5<=31 && dia6<=30 && dia7<=31 && dia8<=31 && dia9<=30 && dia10<=31 && dia11<=30 && dia12<=31) Console.WriteLine("Data válida");
    else Console.WriteLine("Data inválida");
  }
}
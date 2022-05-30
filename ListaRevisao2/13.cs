using System; 

public class Program {
    
  public static void Main(){

    Console.WriteLine("Digite 10 valores inteiros");
    
    string[] a = Console.ReadLine().Split(' ');
    int num = int.Parse(a[0]);
    int num2 = int.Parse(a[1]);
    int num3 = int.Parse(a[2]);
    int num4 = int.Parse(a[3]);
    int num5 = int.Parse(a[4]);
    int num6 = int.Parse(a[5]);
    int num7 = int.Parse(a[6]);
    int num8 = int.Parse(a[7]);
    int num9 = int.Parse(a[8]);
    int num10 = int.Parse(a[9]);

    int maior = 0;
    int menor = 0;

    if(num>num2 && num>num3 && num>num4 && num>num5 && num>num6 && num>num7 && num>num8 && num>num9 && num>num10) maior = maior+num;
    if(num2>num && num2>num3 && num2>num4 && num2>num5 && num2>num6 && num2>num7 && num2>num8 && num2>num9 && num2>num10) maior = maior+num2;
    if(num3>num2 && num3>num && num3>num4 && num3>num5 && num3>num6 && num3>num7 && num3>num8 && num3>num9 && num3>num10) maior = maior+num3;
    if(num4>num2 && num4>num3 && num4>num && num4>num5 && num4>num6 && num4>num7 && num4>num8 && num4>num9 && num4>num10) maior = maior+num4;
    if(num5>num2 && num5>num3 && num5>num4 && num5>num && num5>num6 && num5>num7 && num5>num8 && num5>num9 && num5>num10) maior = maior+num5;
    if(num6>num2 && num6>num3 && num6>num4 && num6>num5 && num6>num && num6>num7 && num6>num8 && num6>num9 && num6>num10) maior = maior+num6;
    if(num7>num2 && num7>num3 && num7>num4 && num7>num5 && num7>num6 && num7>num && num7>num8 && num7>num9 && num7>num10) maior = maior+num7;
    if(num8>num2 && num8>num3 && num8>num4 && num8>num5 && num8>num6 && num8>num7 && num8>num && num8>num9 && num8>num10) maior = maior+num8;
    if(num9>num2 && num9>num3 && num9>num4 && num9>num5 && num9>num6 && num9>num7 && num9>num8 && num9>num && num9>num10) maior = maior+num9;
    if(num10>num2 && num10>num3 && num10>num4 && num10>num5 && num10>num6 && num10>num7 && num10>num8 && num10>num9 && num10>num) maior = maior+num10;

    if(num<num2 && num<num3 && num<num4 && num<num5 && num<num6 && num<num7 && num<num8 && num<num9 && num<num10) menor = menor+num;
    if(num2<num && num2<num3 && num2<num4 && num2<num5 && num2<num6 && num2<num7 && num2<num8 && num2<num9 && num2<num10) menor = menor+num2;
    if(num3<num2 && num3<num && num3<num4 && num3<num5 && num3<num6 && num3<num7 && num3<num8 && num3<num9 && num3<num10) menor = menor+num3;
    if(num4<num2 && num4<num3 && num4<num && num4<num5 && num4<num6 && num4<num7 && num4<num8 && num4<num9 && num4<num10) menor = menor+num4;
    if(num5<num2 && num5<num3 && num5<num4 && num5<num && num5<num6 && num5<num7 && num5<num8 && num5<num9 && num5<num10) menor = menor+num5;
    if(num6<num2 && num6<num3 && num6<num4 && num6<num5 && num6<num && num6<num7 && num6<num8 && num6<num9 && num6<num10) menor = menor+num6;
    if(num7<num2 && num7<num3 && num7<num4 && num7<num5 && num7<num6 && num7<num && num7<num8 && num7<num9 && num7<num10) menor = menor+num7;
    if(num8<num2 && num8<num3 && num8<num4 && num8<num5 && num8<num6 && num8<num7 && num8<num && num8<num9 && num8<num10) menor = menor+num8;
    if(num9<num2 && num9<num3 && num9<num4 && num9<num5 && num9<num6 && num9<num7 && num9<num8 && num9<num && num9<num10) menor = menor+num9;
    if(num10<num2 && num10<num3 && num10<num4 && num10<num5 && num10<num6 && num10<num7 && num10<num8 && num10<num9 && num10<num) menor = menor+num10;

    Console.WriteLine($"O maior valor é {maior} e o menor é {menor}");
  } 
}
using System;

public class Program{
   
   public static void Main(){
       
       double a = double.Parse(Console.ReadLine());
       double b = double.Parse(Console.ReadLine());
       double pesoa = 3.5;
       double pesob = 7.5;
       double peso = 11;
       double nota = (a*pesoa + b*pesob)/peso;
       Console.WriteLine($"MEDIA ={nota: 0.00000}");
     
   } 
}
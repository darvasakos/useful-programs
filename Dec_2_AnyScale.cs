using System;

public class Program
{
    private static string DecToAnyScale(long Dec, long Scal)
    {
          long Hatv;
          
          long Mar;
          string Res;
          long Ch;
          
          Hatv = Scal;
          Res = "";
          
          for (int cv = 1; cv <= 5; cv++)
          {   
             Mar = (Dec % Hatv) / (Hatv / Scal);

             if (Mar < 10)
                { Ch = Mar + 48; }  
             else
                { Ch = Mar + 55; }

             Res = (char) Ch + Res;    
             Dec = Dec - (Mar * Hatv / Scal);
             Hatv = Hatv * Scal;
          }

          return Res; 
    }
    
    public static void Main()
    {
        Console.Write("Szám: ");
        string st = Console.ReadLine();
        Console.Write("Számrendszer: ");
        string szr = Console.ReadLine();
        
        string Result = DecToAnyScale(Int64.Parse(st), Int64.Parse(szr));
        Console.WriteLine($"Eredmény: {Result} ({szr}. számrendszerben)");
    }    
    
}

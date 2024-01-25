//https://www.beecrowd.com.br/judge/pt/problems/view/1066
using System.Collections.Generic;
using System.Linq;

public class Problem28
{
    public void Solve()
    {
        int[] numbers = new int[5];
        
        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int even = numbers.Where(x => x % 2 == 0).Count();
        int odd = numbers.Length - even;

        int positive = numbers.Where(x => x > 0).Count();
        int negative = numbers.Where(x => x < 0).Count();

        Console.WriteLine($"{ even } valor(es) par(es)");
        Console.WriteLine($"{ odd } valor(es) impar(es)");
        Console.WriteLine($"{ positive } valor(es) positivo(s)");
        Console.WriteLine($"{ negative } valor(es) negativo(s)");
    }
}
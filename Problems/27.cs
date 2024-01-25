// https://www.beecrowd.com.br/judge/pt/problems/view/1065
using System.Collections.Generic;
using System.Linq;
public class Problem27
{
    public void Solve()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            int aux = int.Parse(Console.ReadLine());
            numbers[i] = aux;
        }

        IEnumerable<int> even = numbers.Where(x => x % 2 == 0);
        Console.WriteLine($"{even.Count()} valores pares");
    }
}
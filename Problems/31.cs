//https://www.beecrowd.com.br/judge/pt/problems/view/1071
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.InteropServices;

public class Problem31
{
    public void Solve()

    {
        int input1 = int.Parse(Console.ReadLine()!);
        int input2 = int.Parse(Console.ReadLine()!);

        int x = Math.Min(input1, input2);
        int y = Math.Max(input1, input2);

        int sum = 0;
        for(int i = x+1; i < y; i++)
        {
            if(Math.Abs(i)%2 == 1) sum += i;
        }
        Console.WriteLine(sum);
    }
}
﻿//https://www.beecrowd.com.br/judge/pt/problems/view/1075
public class Problem35
{
    public void Solve()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10000; i++)
        {
            if (i % n == 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
//https://judge.beecrowd.com/pt/problems/view/1133

public class Problem54
{
    public void Solve()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        if (x > y)
        {
            int aux = x;
            x = y;
            y = aux;
        }

        for (int i = ++x; i < y; i++) {
            int rest = i % 5;
            if (rest == 2 || rest == 3) Console.WriteLine(i);
        }
    }
}
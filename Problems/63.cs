//https://judge.beecrowd.com/pt/problems/view/1151
public class Problem63
{
    public void Solve()
    {
        List<int> fibonacci = new List<int> {0, 1};
        int pos = 0;

        int n = int.Parse(Console.ReadLine());

        while (pos < n)
        {
            int len = fibonacci.Count;

            if (pos == len)
            {
                int aux = fibonacci[len - 1] + fibonacci[len - 2];
                fibonacci.Add(aux);
            }

            if (pos == n - 1) Console.Write(fibonacci[pos]);
            else Console.Write($"{fibonacci[pos]} ");
            pos++;
        }
        Console.WriteLine();
    }
}
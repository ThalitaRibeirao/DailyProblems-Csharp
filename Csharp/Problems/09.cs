// https://www.beecrowd.com.br/judge/pt/problems/view/1038
public class Problem9
{
	public void Solve()
    {
        Dictionary<int, decimal> prices = new Dictionary<int, decimal>()
        {
            { 1, 4.0m },
            { 2, 4.5m },
            { 3, 5.0m },
            { 4, 2.0m },
            { 5, 1.5m },
        };

        string[] input = Console.ReadLine().Split(' ');
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        decimal total = prices[a] * b;

        Console.WriteLine($"Total: R$ {total.ToString("F2")}");
    }
}

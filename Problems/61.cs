//https://judge.beecrowd.com/pt/problems/view/1149
public class Problem61 {
    public void Solve()
    {
        string[] input = Console.ReadLine().Split(' ');
        int n = int.Parse(input[input.Length - 1]);
        int x = int.Parse(input[0]);
        int y = x + (n - 1);
        int sum = ((x + y) * n)/2;
        Console.WriteLine(sum);
    }
}

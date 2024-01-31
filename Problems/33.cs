//https://www.beecrowd.com.br/judge/pt/problems/view/1073
public class Problem33
{
    public void Solve()
    {
        int n = int.Parse(Console.ReadLine()!);
        
        for (int i = 2; i <= n; i+=2) {
            Console.WriteLine($"{i}^2 = {i * i}");
        }
    }
}
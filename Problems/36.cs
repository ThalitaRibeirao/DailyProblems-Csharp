//https://www.beecrowd.com.br/judge/pt/problems/view/1075
public class Problem36
{
    public void Solve()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++) { 
            Console.WriteLine($"{i} x {n} = {i*n}");
        }
    }
}
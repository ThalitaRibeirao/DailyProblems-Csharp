//https://judge.beecrowd.com/pt/problems/view/1143
public class Problem57 { 
    public void Solve()
    {
        int n = int.Parse(Console.ReadLine());
        
        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{i} {i*i} {i*i*i}");
        }
    }
}
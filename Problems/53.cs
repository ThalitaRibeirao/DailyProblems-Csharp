//https://judge.beecrowd.com/pt/problems/view/1132
public class Problem53
{
    public void Solve() {
    
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        
        if (x > y)
        {
            int aux = x;
            x = y;
            y = aux;
        }
        
        int sum = 0;

        for (int i = x; i <= y; i++)
        {
            if (i % 13 != 0) sum += i;
        }
        Console.WriteLine(sum);
    }
}
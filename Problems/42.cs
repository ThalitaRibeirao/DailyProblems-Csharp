//https://www.beecrowd.com.br/judge/pt/problems/view/1097
public class Problem42
{
    public void Solve()
    {
        for (int i = 0; i < 15; i++) {
            int mod = i % 3;
            int div = i / 3;

            Console.WriteLine($"I={1 + (div * 2)} J={7 - mod + (div * 2)}");
        }
    }
}
//https://www.beecrowd.com.br/judge/pt/problems/view/1095
public class Problem40
{
    public void Solve()
    {
        for (int i = 0; i <= 12; i++)
        {
            Console.WriteLine($"I={1 + i*3} J={60 - i*5}");
        }
    }
}
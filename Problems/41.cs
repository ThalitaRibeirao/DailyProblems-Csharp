//https://www.beecrowd.com.br/judge/pt/problems/view/1096
public class Problem41
{
    public void Solve()
    {
        for(int i=0; i < 15; i++)
        {
            int mod = i % 3;
            int div = i / 3;
            Console.Writeline($"I={1 + i*2} J={7 - mod}");
        }
    }
}
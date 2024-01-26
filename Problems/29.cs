// https://www.beecrowd.com.br/judge/pt/problems/view/1067
public class Problem29
{
    public void Solve()
    {
        int number = int.Parse(Console.ReadLine()!);

        for(int i = 0; i <= number; i += 2) 
        {
            Console.WriteLine(i);
        }
    }
}
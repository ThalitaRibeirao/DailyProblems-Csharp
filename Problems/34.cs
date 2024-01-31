//https://www.beecrowd.com.br/judge/pt/problems/view/1074
public class Problem34
{
    public void Solve()
    {
        int n = int.Parse(Console.ReadLine()!);
        string message;

        for (int i = 0; i < n; i++)
        {
            
            int x = int.Parse(Console.ReadLine()!);

            if (x == 0) message = "NULL";
            else
            {
                if (x % 2 == 0) message = "EVEN";
                else message = "ODD";

                if (x > 0) message += " POSITIVE";
                else message += " NEGATIVE";
            }
            Console.WriteLine(message);
        }
    }
}
//https://www.beecrowd.com.br/judge/pt/problems/view/1099
public class Problem44
{
    public void Solve()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            
            if (x > y)
            {
                int aux = x;
                x = y; y = aux;
            }

            int sum = 0;

            for(int j = x + 1; j < y; j++)
            {
                if (j % 2 == 1) sum += j;
            }
            Console.WriteLine(sum);
        }
        
    }
}
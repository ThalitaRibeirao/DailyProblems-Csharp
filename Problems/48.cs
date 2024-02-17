//https://judge.beecrowd.com/pt/problems/view/1115
public class Problem48
{
    public void Solve()
    {
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);

            if (x == 0 || y == 0) break;
            else
            {
                string quadrant;

                if (x > 0)
                {
                    if (y > 0) quadrant = "primeiro";
                    else quadrant = "quarto";
                }
                else
                {
                    if (y > 0) quadrant = "segundo";
                    else quadrant = "terceiro";
                }
                Console.WriteLine(quadrant);
            }
        }
    }
}
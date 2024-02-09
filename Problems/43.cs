//https://www.beecrowd.com.br/judge/pt/problems/view/1098
public class Problem43
{
    public void Solve()
    {
        for (int x = 0; x < 33; x++)
        {
            int div = (x / 3);
            double I = 0.2 * div;
            double J = 1 + (x % 3) + I;

            Console.WriteLine($"I={I.ToString("0.#")} J={J.ToString("0.#")}");
        }
    }
}
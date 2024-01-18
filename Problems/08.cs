// https://www.beecrowd.com.br/judge/pt/problems/view/1037
public class Problem8
{
	public void Solve()
    {
        double[,] gaps = { { 0, 25 }, { 25, 50 }, { 50, 75 }, {75, 100}};
        double input = double.Parse(Console.ReadLine()!);

        // Get lenght from first dimension
        for (int i = 0; i < gaps.GetLength(0); i++)
        {
            double a = gaps[i, 0];
            double b = gaps[i, 1];


            if (i == 0)
            {
                if (a <= input && input <= b)
                {
                    Console.WriteLine($"Intervalo [{a},{b}]");
                    return;
                }
            }
            else
            {
                if (a < input && input <= b)
                {
                    Console.WriteLine($"Intervalo ({a},{b}]");
                    return;
                }
            }
        }

        Console.WriteLine("Fora de intervalo");
    }
}

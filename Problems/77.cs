//https://judge.beecrowd.com/pt/problems/view/1175
public class Problem77
{
    public void Solve()
    {
        int[] vector = new int[20];

        for (int i = 1; i <= 20; i++)
        {
            vector[20 - i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"N[{i}] = {vector[i]}");
        }
    }
}
//https://judge.beecrowd.com/pt/problems/view/1172
public class Problem74
{
    public void Solve()
    {
        int[] vector = new int[10];

        for(int i = 0; i < vector.Length; i++)
        {
            int aux = int.Parse(Console.ReadLine());
            vector[i] = aux > 0 ? aux : 1;
        }

        for(int i = 0; i < vector.Length; i++)
        {
            Console.WriteLine($"X[{i}] = {vector[i]}");
        }
    }
}
// https://www.beecrowd.com.br/judge/pt/problems/view/1018
public class Problem2
{
    public void Resolve()
    {
        int valor = int.Parse(Console.ReadLine()!);
        List<int> cedulas = new List<int> { 100, 50, 20, 10, 5, 2, 1 };

        Console.WriteLine(valor);

        foreach (int c in cedulas)
        {
            int n = valor / c;
            Console.WriteLine($"{n} nota(s) de R$ {c},00");
            valor -= n * c;
        }
    }
}
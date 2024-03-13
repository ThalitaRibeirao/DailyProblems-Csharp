//https://judge.beecrowd.com/pt/problems/view/1154
public class Problem65
{
    public void Solve()
    {
        double sum = 0;
        double i = 0;
        while (true)
        {
            double age = double.Parse(Console.ReadLine());
            if (age < 0) break;
            sum += age;
            i++;
        }
        double mean = i > 0 ? sum / i : 0;
        Console.WriteLine(mean.ToString("F2"));
    }
}
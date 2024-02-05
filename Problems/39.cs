//https://www.beecrowd.com.br/judge/pt/problems/view/1094
public class Problem39
{
    public void Solve()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, int> guineaPig = new Dictionary<string, int>
        {
            { "C", 0 },
            { "R", 0 },
            { "S", 0 },
        };

        for(int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            guineaPig[input[1]] += int.Parse(input[0]);
        }

        double total = guineaPig.Sum(x => x.Value);

        Console.WriteLine($"Total: {total.ToString("F0")} cobaias");
        Console.WriteLine($"Total de coelhos: {guineaPig["C"]}");
        Console.WriteLine($"Total de ratos: {guineaPig["R"]}");
        Console.WriteLine($"Total de sapos: {guineaPig["S"]}");

        double percentageC = 0.0;
        double percentageR = 0.0;
        double percentageS = 0.0;

        if (total > 0)
        {
            percentageC = (guineaPig["C"] / total) * 100.0;
            percentageR = (guineaPig["R"] / total) * 100.0;
            percentageS = (guineaPig["S"] / total) * 100.0;
        }
        Console.WriteLine($"Percentual de coelhos: {percentageC.ToString("F2")} %");
        Console.WriteLine($"Percentual de ratos: {percentageR.ToString("F2")} %");
        Console.WriteLine($"Percentual de sapos: {percentageS.ToString("F2")} %");
    }
}
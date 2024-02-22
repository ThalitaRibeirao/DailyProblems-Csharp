//https://judge.beecrowd.com/pt/problems/view/1131
public class Problem52
{
    public int[] getScore()
    {
        string[] input = Console.ReadLine().Split(' ');
        int interScore = int.Parse(input[0]);
        int gremioScore = int.Parse(input[1]);

        return [interScore, gremioScore];
    }

    public void Solve()
    {
        int inter = 0;
        int gremio = 0;
        int tie = 0;


        while (true)
        {
            int[] score = getScore();

            if (score[0] > score[1]) inter++;
            else if (score[1] > score[0]) gremio++;
            else tie++;

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            int option = int.Parse(Console.ReadLine());
            if (option == 2) break;
        }

        Console.WriteLine($"{inter + gremio + tie} grenais");
        Console.WriteLine($"Inter:{inter}");
        Console.WriteLine($"Gremio:{gremio}");
        Console.WriteLine($"Empates:{tie}");


        if (inter > gremio) Console.WriteLine("Inter venceu mais");
        else if (gremio > inter) Console.WriteLine("Gremio venceu mais");
        else Console.WriteLine("Nao houve vencedor");

    }
}
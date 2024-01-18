// https://www.beecrowd.com.br/judge/pt/problems/view/1046
public class Problem16
{
	public void Solve()
	{
		string[] input = Console.ReadLine().Split(' ');
		int start = int.Parse(input[0]);
		int end = int.Parse(input[1]);


        if (end <= start) end += 24;

        int duration = end - start;

        Console.WriteLine($"O JOGO DUROU {duration} HORA(S)");
    }
}

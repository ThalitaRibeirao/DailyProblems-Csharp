// https://www.beecrowd.com.br/judge/pt/problems/view/1046
public class Problem16
{
	public void Solve()
	{
		string[] input = Console.ReadLine().Split(' ');
		int start = int.Parse(input[0]);
		int end = int.Parse(input[1]);
        int duration = 0;

        if (end < start)
        {
            duration += 24 - end;
            duration += start;
        }
        else
        {
            duration = end - start;
        }

        Console.WriteLine($"O JOGO DUROU {duration} HORA(S)");
    }
}

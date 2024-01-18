// https://www.beecrowd.com.br/judge/pt/problems/view/1044
public class Problem14
{
	public void Solve()
	{
		string[] input = Console.ReadLine().Split(' ');
		int a = int.Parse(input[0]);
		int b = int.Parse(input[1]);

        if (a % b == 0 || b % a == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
	}
}

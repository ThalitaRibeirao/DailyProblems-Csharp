// https://www.beecrowd.com.br/judge/pt/problems/view/1041
public class Problem11
{
	public void Resolve()
	{
		string[] input = Console.ReadLine().Split(' ');
		double x = double.Parse(input[0]);
        double y = double.Parse(input[1]);

        if (x == 0 || y == 0)
        {
            if (x==0 && y == 0) Console.WriteLine("Origem");
            else if (x == 0) Console.WriteLine("Eixo Y");
            else Console.WriteLine("Eixo X");
        }
        else if (x > 0)
        {
            if (y > 0) Console.WriteLine("Q1");
            else Console.WriteLine("Q4");

        }
        else if (x < 0)
        {
            if (y > 0) Console.WriteLine("Q2");
            else Console.WriteLine("Q3");
        }
    }
}

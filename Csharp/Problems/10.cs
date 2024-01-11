// https://www.beecrowd.com.br/judge/pt/problems/view/1040
public class Problem10
{
	public void Resolve()
	{
		string[] input = Console.ReadLine().Split(' ');
		double n1 = double.Parse(input[0]) * 2.0;
        double n2 = double.Parse(input[1]) * 3.0;
        double n3 = double.Parse(input[2]) * 4.0;
        double n4 = double.Parse(input[3]) * 1.0;

        double media = Math.Round((n1 + n2 + n3 + n4) / 10.0, 1);

        Console.WriteLine($"Media: {media.ToString("F1")}");

        if (media >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media >= 5)
        {
            Console.WriteLine("Aluno em exame.");

            double n5 = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"Nota do exame: {n5.ToString("F1")}");

            media = (media + n5) / 2;

            if (media >= 5)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }

            Console.WriteLine($"Media final: {media.ToString("F1")}");
        }
        else
        {
            Console.WriteLine("Aluno reprovado.");
        }
    }
}

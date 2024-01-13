// https://www.beecrowd.com.br/judge/pt/problems/view/1020
public class Problem4
{
    public void Solve()
    {
            int idade = int.Parse(Console.ReadLine()!);
            int anos = idade / 360;
            int meses = (idade % 360) / 30;
            int dias = (idade % 360) % 30;
            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} mes(es)");
            Console.WriteLine($"{dias} dia(s)");
        }
}
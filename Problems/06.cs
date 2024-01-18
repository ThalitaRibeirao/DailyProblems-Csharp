// https://www.beecrowd.com.br/judge/pt/problems/view/1035
class Problem6()
{
    public void Solve()
    {
            string input = Console.ReadLine()!;
            string[] itens = input.Split(' ');
            int a, b, c, d;
            a = int.Parse(itens[0]);
            b = int.Parse(itens[1]);
            c = int.Parse(itens[2]);
            d = int.Parse(itens[3]);

            if (b > c && d > a && c + d > a + b && c > 0 && d > 0 && a % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
    }
}
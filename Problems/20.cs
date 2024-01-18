//https://www.beecrowd.com.br/judge/pt/problems/view/1050
public class Problem20
{
	public void Solve()
    {
        Dictionary<string, string> ddd = new Dictionary<string, string>
        {
            {"11", "Sao Paulo"},
            {"19", "Campinas"},
            {"21", "Rio de Janeiro"},
            {"27", "Vitoria"},
            {"31", "Belo Horizonte"},
            {"32", "Juiz de Fora"},
            {"61", "Brasilia"},
            {"71", "Salvador"},
        };

        string city = Console.ReadLine();

        if (ddd.ContainsKey(city))
        {
            Console.WriteLine(ddd[city]);
        }
        else
        {
            Console.WriteLine("DDD nao cadastrado");
        }
    }
}

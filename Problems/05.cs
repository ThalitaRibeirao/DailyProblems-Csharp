// https://www.beecrowd.com.br/judge/pt/problems/view/1021
using System.Globalization;
public class Problem5
{
    decimal value = Convert.ToDecimal(Console.ReadLine()!);
    private List<decimal> notes = new List<decimal> { 100.0m, 50.0m, 20.0m, 10.0m, 5.0m, 2.0m };
    private List<decimal> coins = new List<decimal> { 1.0m, 0.5m, 0.25m, 0.1m, 0.05m, 0.01m };
    
    public void Result(decimal y, string typeY)
    {
        int x = (int)(value / y);

        value -= x * y;
        Console.WriteLine($"{x} {typeY} de R$ {y.ToString("0.00")}");
    }
    public void Solve()
    {
        Console.WriteLine("NOTAS");
        notes.ForEach(y => Result(y, "nota(s)"));

        Console.WriteLine("MOEDAS");
        coins.ForEach(y => Result(y, "moeda(s)"));
    }
}
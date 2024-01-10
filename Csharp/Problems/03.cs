// https://www.beecrowd.com.br/judge/pt/problems/view/1019
public class Problem3
{
    public void Resolve()
    {
        int tempo = int.Parse(Console.ReadLine()!);
        int horas = tempo / (60 * 60);
        int minutos = (tempo % (60 * 60)) / 60;
        int segundos = tempo % 60;
        Console.WriteLine($"{horas}:{minutos}:{segundos}");
    }
}
//https://judge.beecrowd.com/pt/problems/view/1114
public class Problem47
{
    public void Solve()
    {
        const string password = "2002";

        while (true)
        {
            string input = Console.ReadLine();

            if (input == password)
            {
                Console.WriteLine("Acesso Permitido");
                break;
            }
            else Console.WriteLine("Senha Invalida");
        }
    }
}
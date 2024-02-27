//https://judge.beecrowd.com/pt/problems/view/1142
public class Problem56
{
    public void Solve()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string text = "";
            for (int j = 1; j <= 3; j++) {
                int aux = (i * 4) + j;
                text += aux + " ";
            }
            Console.WriteLine(text + "PUM");
        }
    }
}
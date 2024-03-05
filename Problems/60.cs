//https://judge.beecrowd.com/pt/problems/view/1146
public class Problem60
{
    public void Solve()
    {
        while (true)
        {
            int x = int.Parse(Console.ReadLine());
            if (x == 0) break;
            else
            {
                IEnumerable<string> list = Enumerable.Range(1, x).Select(num => num.ToString());
                string output = String.Join(" ", list.ToArray());
                Console.WriteLine(output);
            }
        }
    }
}
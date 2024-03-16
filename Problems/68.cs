//https://judge.beecrowd.com/pt/problems/view/1157
public class Problem68 { 
    public void Solve()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();

        for (int i = 1; i <= n / 2; i++) { 
            if (n % i == 0) list.Add(i);
        }

        if (n != 0) list.Add(n);
        foreach(int x in list) Console.WriteLine(x);
    }
}
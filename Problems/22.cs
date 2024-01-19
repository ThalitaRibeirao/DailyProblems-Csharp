// https://www.beecrowd.com.br/judge/pt/problems/view/1052

public class Problem22
{
	public void Solve()
    {
        Dictionary<int, string> monthString = new Dictionary<int, string>
        {
            { 1, "January" },
            { 2, "February" },
            { 3, "March" },
            { 4, "April" },
            { 5, "May" },
            { 6, "June" },
            { 7, "July" },
            { 8, "August" },
            { 9, "September" },
            { 10, "October" },
            { 11, "November" },
            { 12, "December" }
        };
		int month = int.Parse(Console.ReadLine());

        Console.WriteLine(monthString[month]);
	}
}

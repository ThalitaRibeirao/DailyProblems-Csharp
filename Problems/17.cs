// https://www.beecrowd.com.br/judge/pt/problems/view/1047
public class Problem17
{
	public void Solve()
	{
		string[] input = Console.ReadLine().Split(' ');

		int initialHour = int.Parse(input[0]);
		int initialMinute = int.Parse(input[1]);

		int endHour = int.Parse(input[2]);
		int endMinute = int.Parse(input[3]);

        if (endHour < initialHour || (endHour == initialHour && endMinute <= initialMinute)) endHour += 24;
        if (endMinute < initialMinute)
        {
            endMinute += 60;
            endHour--;
        }

        int durationHour = endHour - initialHour;
        int durationMinute = endMinute - initialMinute;

        Console.WriteLine($"O JOGO DUROU {durationHour} HORA(S) E {durationMinute} MINUTO(S)");
    }
}

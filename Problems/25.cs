//https://www.beecrowd.com.br/judge/pt/problems/view/1061
public class Problem25
{
	public int initDay;
    public int endDay;

    public int initHour;
    public int endHour;

    public int initMinute;
    public int endMinute;

    public int initSecond;
    public int endSecond;

	public void IncreaseHour()
	{
        endDay--;
        endHour += 24;
    }

	public void IncreaseMinute()
	{
		if (endHour == 0)
		{
            IncreaseHour();
		}
        endHour--;
        endMinute += 60;
    }

	public void IncreaseSecond ()
	{
		if (endMinute == 0) {
            IncreaseMinute();
		}
        endMinute--;
        endSecond += 60;
    }
	
	public void Solve()
	{
		string[] inputInitDay = Console.ReadLine()!.Split(' ');
		initDay = int.Parse(inputInitDay[1]);

		string[] inputInitTime = Console.ReadLine()!.Split(' ');
		initHour = int.Parse(inputInitTime[0]);
		initMinute = int.Parse(inputInitTime[2]);
        initSecond = int.Parse(inputInitTime[4]);

        string[] inputFinalDay = Console.ReadLine()!.Split(' ');
		endDay = int.Parse(inputFinalDay[1]);
		
		string[] inputEndTime = Console.ReadLine()!.Split(' ');
		endHour = int.Parse(inputEndTime[0]);
		endMinute = int.Parse(inputEndTime[2]);
		endSecond = int.Parse(inputEndTime[4]);

        if (endHour < initHour) IncreaseHour();
		if (endMinute < initMinute) {
            IncreaseMinute();
            if(endHour < initHour) IncreaseHour();
        }
		if (endSecond < initSecond) {
            IncreaseSecond();
            if (endMinute < initMinute) IncreaseMinute();
            if (endHour < initHour) IncreaseHour();
        } 

		int day = endDay - initDay;
		int hour = endHour - initHour;
		int minute = endMinute - initMinute;
		int second = endSecond - initSecond;

		Console.WriteLine($"{day} dia(s)");
        Console.WriteLine($"{hour} hora(s)");
        Console.WriteLine($"{minute} minuto(s)");
        Console.WriteLine($"{second} segundo(s)");
	}
}

// https://www.beecrowd.com.br/judge/pt/problems/view/1045
public class Problem15
{
	public void Solve()
	{
		string[] input = Console.ReadLine().Split(' ');
        List<double> numbers = new List<double>();

        foreach (string s in input)
        {
            numbers.Add(double.Parse(s));
        }

        numbers.Sort();

        double a = numbers[2];
        double b = numbers[1];
        double c = numbers[0];

        string typeAngleTriangle = "";
        string typeSizeTriangle = "";

        if (a >= b + c) typeAngleTriangle = "NAO FORMA TRIANGULO";
        else if (a * a == b * b + c * c) typeAngleTriangle = "TRIANGULO RETANGULO";
        else if (a * a > b * b + c * c) typeAngleTriangle = "TRIANGULO OBTUSANGULO";
        else if (a * a < b * b + c * c) typeAngleTriangle = "TRIANGULO ACUTANGULO";

        if (a == b && a == c) typeSizeTriangle = "TRIANGULO EQUILATERO";
        else if (a == b || a == c || b == c) typeSizeTriangle = "TRIANGULO ISOSCELES";


        Console.WriteLine(typeAngleTriangle);
        if (typeSizeTriangle != "") Console.WriteLine(typeSizeTriangle);

    }
}

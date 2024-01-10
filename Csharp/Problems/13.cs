// https://www.beecrowd.com.br/judge/pt/problems/view/1043
public class Problem13
{
    public void Resolve()
    {
        string[] input = Console.ReadLine()!.Split(' ');
        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);
        double c = double.Parse(input[2]);

        bool isTriangle = (a < b + c) && (b < c + a) && (c < a + b);

        if (isTriangle)
        {
            double perimeter = a + b + c;
            string perimeterString = perimeter.ToString("F1");
            Console.WriteLine($"Perimetro = {perimeterString}");
        }
        else
        {
            double area = ((a + b) / 2.0 ) * c;
            string areaString = area.ToString("F1");
            Console.WriteLine($"Area = {areaString}");
        }
    } 


}
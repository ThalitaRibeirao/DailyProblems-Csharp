//https://judge.beecrowd.com/pt/problems/view/1178
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

public class Problem80
{
    public void Solve()
    {
        string[] input = Console.ReadLine().Split('.');
        double intPart = double.Parse(input[0]);
        double decimalPart = double.Parse(input[1]);

        for (int i = 0; i < 100; i++)
        {
            // Int Part
            string intPartString = intPart.ToString("F1");
            IEnumerable<char> intPartResult = intPartString.ToArray().Take(intPartString.Length - 2);
            string intPartOutput = "";
            foreach (char c in intPartResult) intPartOutput += c;

            // Fixing values
            double sum = (intPartString[intPartString.Count() - 1] - '0') * 1000.0;
            decimalPart += sum;
            intPart = double.Parse(intPartOutput);

            // Decimal Part
            string decimalPartOutPut = Math.Round(decimalPart).ToString("F0");

            // Log
            Console.Write($"N[{i}] = {intPartOutput}.");
            for (int j = 0; j < 4 - decimalPartOutPut.Count(); j++) Console.Write('0');
            Console.WriteLine(decimalPartOutPut);

            intPart /= 2.0;
            decimalPart /= 2.0;
        }
    }
}
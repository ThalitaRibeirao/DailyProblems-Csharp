// https://www.beecrowd.com.br/judge/pt/problems/view/1042
public class Problem12
{
    public bool isSorted(List<int> vector)
    {
        for (int i = 0; i < vector.Count - 1; i++)
        {
            if (vector[i] > vector[i + 1]) return false;
        }

        return true;
    }


    public void sort(int pos, List<int> vector)
    {
        // Check if it's in the last position
        if (pos >= vector.Count - 1)
        {
            // If isn't sorted already, try again
            if (!isSorted(vector)) sort(0, vector);
            else return;
        }
        else
        {
            // Change places if isn't in order
            if (vector[pos] > vector[pos + 1])
            {
                int aux = vector[pos];
                vector[pos] = vector[pos + 1];
                vector[pos + 1] = aux;
            }

            sort(pos + 1, vector);
        }
    }

	public void Resolve()
	{
		string[] input = Console.ReadLine().Split(' ');
        List<int> init = new List<int>();
        // Parsing string to int
        foreach (string s in input)
        {
            init.Add(int.Parse(s));
        }

        // Sorting the list
        List<int> sorted = new List<int>(init);
        sort(0, sorted);

        // Showing the result
        foreach (int i in sorted)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();

        foreach (int i in init)
        {
            Console.WriteLine(i);
        }

    }
}

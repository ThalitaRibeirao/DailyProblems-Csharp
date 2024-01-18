// https://www.beecrowd.com.br/judge/pt/problems/view/1049

public class Dictionary3D : Dictionary<string, Dictionary<string, Dictionary<string, string>>>{ }
public class Dictionary2D : Dictionary<string, Dictionary<string, string>> { }
public class Dictionary1D : Dictionary<string, string> { }

public class Problem19
{
    public void Solve()
    {
        Dictionary3D animals = new Dictionary3D
        {
            { "vertebrado", new Dictionary2D
                {
                    {
                        "ave", new Dictionary1D
                        {
                            { "carnivoro", "aguia" },
                            { "onivoro", "pomba" }
                        }
                    },
                    {
                        "mamifero", new Dictionary1D
                        {
                            { "onivoro", "homem" },
                            { "herbivoro", "vaca" }
                        }
                    }

                }
            },
            { "invertebrado", new Dictionary2D
                {
                    {
                        "inseto", new Dictionary1D
                        {
                            { "hematofago", "pulga" },
                            { "herbivoro", "lagarta" }
                        }
                    },
                    {
                        "anelideo", new Dictionary1D
                        {
                            { "hematofago", "sanguessuga" },
                            { "onivoro", "minhoca" }
                        }
                    }
                }
            }
        };

        string typeSkeleton = Console.ReadLine();
        string typeAnimal = Console.ReadLine();
        string typeFood = Console.ReadLine();

        string animal = animals[typeSkeleton][typeAnimal][typeFood];
        Console.WriteLine(animal);
    }
}

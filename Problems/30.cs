//https://www.beecrowd.com.br/judge/pt/runs/code/37365120
public class Problem30{
public void Solve(){
int number = int.Parse(Console.ReadLine()!);
if (number % 2 == 0) number++;
for(int i=0; i < 6; i++) {
Console.WriteLine(number + i * 2);
}
}
}
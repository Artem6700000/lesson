internal class Program
{
    private static void Main(string[] args)
    {
        Vivo vivo = new Vivo();
        vivo.Suka();
        vivo.Suka2();
        int agility = 101;
        int agilityBoost = 10;
        int totalAgility = agility + agilityBoost;
        int intellect = agility - agilityBoost;
        int del = agility / agilityBoost;
        int jjj = agility * agilityBoost;
        int ggg = agility % agilityBoost;

        if (totalAgility == 121) {
            Console.WriteLine("loh");
        } else
        {
            Console.WriteLine("chmo");
        }

        string name = "loh";
        decimal xp = 20.2m;
        float mp = 1.3f;

        bool yes = true;
        //object a = true; любая переменная

        Console.WriteLine(totalAgility);
        Console.WriteLine(intellect);
        Console.WriteLine(del);
        Console.WriteLine(jjj);
        Console.WriteLine(ggg);
    }
}

public class Vivo {
    Program prog = new Program();
    int agility2 = 101;
    int agilityBoost2 = 10;

    public void Suka()
    {
        int totalAgility = agility2 + agilityBoost2;
        Console.WriteLine(totalAgility);
    }
    public void Suka2()
        {
        int totalAgility = agility2 - agilityBoost2;
        Console.WriteLine(totalAgility);
        }
}
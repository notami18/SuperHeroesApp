using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        var canFly = new SuperPower
        {
            Name = "Volar 🥏",
            Description = "Capacidad de poder volar y planear en el aire",
            Level = LevelPower.LevelTwo
        };

        var superPower = new SuperPower
        {
            Name = "Super Fuerza 💪",
            Level = LevelPower.LevelFive
        };

        var xRayVision = new SuperPower
        {
            Name = "Rayos X 🩻",
            Description = "Capacidad de poder ver atravez de las paredes",
            Level = LevelPower.LevelThree
        };

        var speed = new SuperPower
        {
            Name = "Velocidad ⚡️",
            Description = "Capacidad de poder ir mas rapido que el propio flash 🦸🏽",
            Level = LevelPower.LevelFour
        };

        List<SuperPower> supermanPower = new()
        {
            canFly,
            superPower,
            xRayVision,
            speed
        };

        var superMan = new SuperHero
        {
            Id = 1,
            Name = "Superman",
            SecretIdentity = "Clark Kent",
            City = "Metropolis",
            Flying = true,
            SuperPowers = supermanPower
        };

        var superMan2 = new SuperHero
        {
            Id = 1,
            Name = "Superman",
            SecretIdentity = "Clark Kent",
            City = "Metropolis",
            Flying = true
        };
        Console.WriteLine(superMan == superMan2);

        SuperHeroRecord superHeroRecord = new(1, "superman", "Clark Kent");
        SuperHeroRecord superHeroRecord2 = new(1, "superman", "Clark Kent");
        Console.WriteLine(superHeroRecord == superHeroRecord2);

        string resultSuperPower = superMan.UseSuperHero();
        Console.WriteLine(resultSuperPower);
    }
}

class SuperHero
{
    public int Id;
    public string? Name;
    public string? SecretIdentity;
    public string? City;
    public List<SuperPower>? SuperPowers;
    public bool Flying;

    public SuperHero()
    {
        Id = 1;
        SuperPowers = new List<SuperPower>();
        Flying = false;
    }

    public string UseSuperHero()
    {
        StringBuilder sb = new();
        if (SuperPowers != null && SuperPowers.Count > 0)
            foreach (var power in SuperPowers)
            {
                sb.AppendLine($"{Name} esta usando el súper poder {power.Name} !!");
            }
        return sb.ToString();
    }
}

class SuperPower
{
    public string? Name;
    public string? Description;
    public LevelPower Level;

    public SuperPower()
    {
        Level = LevelPower.LevelOne;

    }
}

enum LevelPower
{
    LevelOne,
    LevelTwo,
    LevelThree,
    LevelFour,
    LevelFive,
}

public record SuperHeroRecord(int Id, string? Name, string? SecretIdentity);
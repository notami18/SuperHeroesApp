using SuperHeroesApp.Models;

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


        var regenerate = new SuperPower
        {
            Name = "Regeneracion 💥",
            Level = LevelPower.LevelFive
        };

        var superPowerWolverine = new SuperPower
        {
            Name = "Super Fuerza 💥",
            Level = LevelPower.LevelFive
        };

        List<SuperPower> supermanPower = new()
        {
            canFly,
            superPower,
            xRayVision,
            speed
        };

        List<SuperPower> wolverinePower = new()
        {
            regenerate,
            superPowerWolverine
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

        string resultSuperPower = superMan.UseSuperHero();
        Console.WriteLine(resultSuperPower);
        string resultSalvarMundo = superMan.SaveTheWorld();
        Console.WriteLine(resultSalvarMundo);

        string resultSalvarTierra = superMan.SalvarLaTierra();
        Console.WriteLine(resultSalvarTierra);

        var wolverine = new AntiHero()
        {
            Id = 5,
            Name = "Wolverine",
            SecretIdentity = "Logan",
            Flying = false,
            SuperPowers = wolverinePower
        };

        string resultSuperPowerWolverine = wolverine.UseSuperHero();
        Console.WriteLine($"{resultSuperPowerWolverine}");

        string actionAntiHero = wolverine.PerformAntiHeroAction("Acata la policia");
        Console.WriteLine(actionAntiHero);
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
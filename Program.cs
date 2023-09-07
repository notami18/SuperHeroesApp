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

        string resultSuperPower = superMan.UseSuperHero();
        Console.WriteLine(resultSuperPower);
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
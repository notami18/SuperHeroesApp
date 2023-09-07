// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var canFly = new SuperPower
{
    Name = "Volar",
    Description = "Capacidad de poder volar y planear en el aire",
    Level = LevelPower.LevelTwo
};

var superPower = new SuperPower
{
    Name = "Super Fuerza",
    Level = LevelPower.LevelFive
};



List<SuperPower> supermanPower = new()
{
    canFly,
    superPower
};

var superMan = new SuperHero
{
    Id = 1,
    Name = "Sperma",
    SecretIdentity = "Clark Kent",
    City = "Metropolis",
    Flying = true,
    SuperPowers = supermanPower
};

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
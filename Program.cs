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

var superMan = new SuperHeroe
{
    Id = 1,
    Name = "Sperma",
    SecretIdentity = "Clark Kent",
    City = "Metropolis",
    Flying = true
};

List<SuperPower> supermanPower = new()
{
    canFly,
    superPower
};

superMan.SuperPowers = supermanPower;

class SuperHeroe
{
    public int Id;
    public string? Name;
    public string? SecretIdentity;
    public string? City;
    public List<SuperPower>? SuperPowers;
    public bool Flying;
}

class SuperPower
{
    public string? Name;
    public string? Description;
    public LevelPower Level;
}

enum LevelPower
{
    LevelOne,
    LevelTwo,
    LevelThree,
    LevelFour,
    LevelFive,
}
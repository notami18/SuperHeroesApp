// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var superMan = new SuperHeroe();
superMan.Id = 1;
superMan.Name = "Sperma";
superMan.SecretIdentity = "Clark Kent";
superMan.city = "Metropolis";
superMan.Flying = true;
superMan.SuperPowers = new[] { "Vision lazer", "Super fuerza", "Volar", "Vision de rayos X" };


class SuperHeroe
{
    public int Id;
    public string? Name;
    public string? SecretIdentity;
    public string? city;
    public string[]? SuperPowers;
    public bool Flying;

}
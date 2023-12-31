using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroesApp.Interface
{
    public interface ISuperHero
    {
        int Id { get; set; }
        string Name { get; set; }
        string? SecretIdentity { get; set; }
    }
}
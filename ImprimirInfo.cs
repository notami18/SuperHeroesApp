using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SuperHeroesApp.Interface;

namespace SuperHeroesApp
{
    internal class ImprimirInfo
    {
        public void ImPrimirSuperHeroe(ISuperHero superHero)
        {
            Console.WriteLine($"ID: {superHero.Id}");
            Console.WriteLine($"Nombre: {superHero.Name}");
            Console.WriteLine($"Identidad secreta: {superHero.SecretIdentity}");
        }
    }
}
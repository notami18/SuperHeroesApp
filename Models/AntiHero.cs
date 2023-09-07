using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class AntiHero : SuperHero
    {
        public string PerformAntiHeroAction(string action)
        {
            return $"El AntiHeroe {NombreEIdentidadSerecreta} ha realizado: {action}";
        }
    }
}
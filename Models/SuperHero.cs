using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class SuperHero
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
}
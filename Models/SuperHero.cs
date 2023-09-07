using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class SuperHero
    {
        private string? _name;
        public int Id;
        public string? Name
        {
            get => _name;
            set => _name = value?.Trim();
        }
        public string? SecretIdentity;

        public string NombreEIdentidadSerecreta
        {
            get => $"{Name} ({SecretIdentity})";

        }

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
                    sb.AppendLine($"{NombreEIdentidadSerecreta} esta usando el súper poder {power.Name} !!");
                }
            return sb.ToString();
        }
    }
}
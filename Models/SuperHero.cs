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
        private string? _Name;
        public int Id;
        public string? Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value?.Trim();
            }
        }
        public string? SecretIdentity;

        public string NombreEIdentidadSerecreta
        {
            get
            {
                return $"{Name} ({SecretIdentity})";
            }
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal abstract class Hero
    {
        public abstract string Name { get; set; }
        public abstract string SaveTheWorld();
        public virtual string SalvarLaTierra()
        {
            return $"{Name} ha salvado la tierra";
        }
    }
}
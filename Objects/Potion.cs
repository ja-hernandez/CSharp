using System;
namespace Classes
{
    public class Potion : Item
    {
        public double MagicGained { get; set; }

        public Potion(string name, int numUses, double magic)
        {
            this.Name = name;
            this.NumUses = numUses;

            this.MagicGained = magic;

            this.Portable = true;
            this.Usable = true;
        }
    }
}

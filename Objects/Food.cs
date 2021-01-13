using System;
namespace Classes
{
    public class Food : Item
    {
        public double HealthGained { get; set; }

        public Food(string name, int numUses, double health)
        {
            this.Name = name;
            this.NumUses = numUses;
            this.HealthGained = health;

            this.Portable = true;
            this.Usable = true;
        }
    }
}

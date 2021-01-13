using System;
namespace Classes
{
    public class Hero
    {
        private const int MAX_HEALTH = 100;
        private const int MAX_MAGIC = 100;

        private const int START_MAGIC = 50;

        public Inventory Inventory { get; set; }

        public string Name { get; set; }
        public double Health { get; set; }
        public double Magic { get; set; }
        public double Wallet { get; set; }

        public Hero(string name)
        {
            this.Name = name;

            this.Health = MAX_HEALTH;
            this.Magic = START_MAGIC;
            this.Wallet = 0;

            this.Inventory = new Inventory();
        }

        public void AddToInventory(Item item)
        {
            // TODO
        }
    }
}

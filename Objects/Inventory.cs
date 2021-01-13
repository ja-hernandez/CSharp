using System;
using System.Collections.Generic;

namespace Classes
{
    public class Inventory
    {
        public List<Item> Items { get; set; }
        public int Size { get; set; }

        public Inventory()
        {
            Items = new List<Item>();
            Size = 4;
        }

        public Inventory(List<Item> items, int size)
        {
            this.Items = items;
            this.Size = size;
        }

        //TODO: update constructors


        public void AddItem(Item item)
        {
            // TODO
        }

        public bool RemoveItem(Item item)
        {
            //TODO

            return false;
        }
    }
}

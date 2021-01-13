using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Item
    {
        public string Name { get; set; }

        public bool Portable { get; set; }

        public bool Usable { get; set; }
        public int NumUses { get; set; }

        public int Space { get; set; }
    }

}

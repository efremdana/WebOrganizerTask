using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrganizeTask
{
    public class Resource
    {
        private string name = null;

        private double quantity = 0;

        public Guid? ID { get; set; }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Quantity
        {
            get { return quantity; } 
            set
            {
                if (value < 0) quantity = 0;
                else quantity = value;
            }
        }

        public Resource()
        {
            ID = Guid.NewGuid();
        }
        public Resource(string name)
        {
            ID = Guid.NewGuid();
            Name = name;
        }
        public Resource(string name, double quantity)
        {
            ID = Guid.NewGuid();
            Name = name;
            Quantity = quantity;
        }

        public override string ToString()
        {
            if (Quantity != 0)
                return $"{Name} - {Quantity}";
            else
                return Name;
        }
    }
}

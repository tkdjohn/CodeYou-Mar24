﻿namespace PetStore
{
    public abstract class Product: ICostPerUnit
    {
        private readonly string _id;    
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public virtual decimal CostPerUnit
        {
            get { return Price; }
        }

        public virtual string Unit => Name;
    }
}

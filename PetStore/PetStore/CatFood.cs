namespace PetStore
{
    public class CatFood : Product

    {
        public double WeightPounds { get; set; }
        public bool KittenFood { get; set; }

        public new decimal CostPerUnit
        {
            get { return Price / (decimal)WeightPounds; }
        }

        public new string Unit => "Pound";
    }
}

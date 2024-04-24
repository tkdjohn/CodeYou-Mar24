namespace PetStore
{
    public  interface ICostPerUnit
    {
        decimal CostPerUnit { get; }
        string Unit {  get; }
    }
}

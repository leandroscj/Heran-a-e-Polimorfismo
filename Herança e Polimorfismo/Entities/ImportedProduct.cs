namespace Herança_e_Polimorfismo.Entities
{
    internal class ImportedProduct : Product

    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public void TotalPrice()
        {
            Price += CustomsFee;
        }

        public sealed override string Pricetag()
        {
            return Name + " $ " + Price + " (CustomsFee: $ " + CustomsFee + ")";
        }
    }
}
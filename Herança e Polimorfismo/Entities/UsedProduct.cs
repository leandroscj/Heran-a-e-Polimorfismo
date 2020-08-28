using System;

namespace Herança_e_Polimorfismo.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public sealed override string Pricetag()
        {
            return Name + " (used) $ " + Price + "(Manufacture date: " + ManufactureDate + ")";
        }
    }
}
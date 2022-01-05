using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfApp14
{
    public enum ProductTypes
    {
        Eat,
        Byttechn

    }
    public class Product
    {
        public string ProductName { get; set; }
        public int ProductPrise { get; set; }
        public ProductTypes ProductType { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}

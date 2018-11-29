using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion01
{
    public abstract class Product
    {
        #region Atributes
        private int productId;

        private string name;
        private decimal price;
        private float taxRate;
        #endregion

        #region Properties
        public int ProductId { get; set; }

        public String Name { get; set; }
        #endregion

        #region Constructors
        public Product(int productId, String name)
        {
            this.ProductId = productId;
            this.Name = name;
        }

        public Product(int productId, string name, decimal price, float taxRate) : this(productId, name)
        {
            this.price = price;
            this.taxRate = taxRate;
        }
        #endregion


        #region Methods
        public abstract decimal GetPrice();

        public abstract decimal GetTax();

        public override string ToString()
        {
            return $"{this.ProductId} {this.name}"; //Extrapolación
        }

        #endregion

    }
}

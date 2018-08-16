using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACME.Common;

namespace ACM.BL
{
    //Product
    //track product name, description, current price
    //Validate(), Retrieve(), Save()
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; } //? allows nullable.
        public int ProductId { get; private set; }
        private string _ProductName;

        public string ProductName
        {
            get {
                return _ProductName.InsertSpaces(); }
            set { _ProductName = value; }
        }


        public override bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName) || CurrentPrice == null)
            {
                isValid = false;
            }

            return isValid;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges && product.IsValid)
            {
                if (product.IsNew)
                {
                    //Insert SP
                }
                else
                {
                    //Update SP
                }
            }
            return success;
        }

        public override string ToString()
        {
            return ProductName;
        }

        public string Log()
        {
            var logString = this.ProductId + ": " +
                            this.ProductName + " " +
                            "Detail: " + this.Description;
            return logString;
        }
    }
}

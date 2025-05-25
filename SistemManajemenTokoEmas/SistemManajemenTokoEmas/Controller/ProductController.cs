using SistemManajemenTokoEmas.Models;
using System;
using System.Data;

namespace SistemManajemenTokoEmas.Controllers
{
    public class ProductController
    {
        private readonly ProductModel _model = new ProductModel();

        public DataTable GetAllProducts()
        {
            return _model.GetAllProducts();
        }

        public DataTable SearchProduct(string keyword)
        {
            return _model.SearchProduct(keyword);
        }

        public bool AddProduct(string id, string name, string category, int quantity, decimal unitPrice)
        {
            if (_model.IsProductIdExists(id))
                throw new Exception("ID produk sudah ada.");

            return _model.AddProduct(id, name, category, quantity, unitPrice);
        }

        public bool UpdateProduct(string id, string name, string category, int quantity, decimal unitPrice)
        {
            return _model.UpdateProduct(id, name, category, quantity, unitPrice);
        }

        public bool DeleteProduct(string id)
        {
            return _model.DeleteProduct(id);
        }
    }
}

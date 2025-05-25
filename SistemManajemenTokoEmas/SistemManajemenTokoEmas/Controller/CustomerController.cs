using SistemManajemenTokoEmas.Models;
using System;
using System.Data;

namespace SistemManajemenTokoEmas.Controllers
{
    public class CustomerController
    {
        private readonly CustomerModel _model = new CustomerModel();

        public DataTable GetAllCustomers() => _model.GetAllCustomers();

        public DataTable SearchCustomer(string keyword) => _model.SearchCustomer(keyword);

        public DataTable GetCustomerByDate(DateTime date) => _model.GetCustomerByDate(date);

        public bool AddCustomer(string id, string name, DateTime date, string phone)
        {
            if (_model.IsCustomerIdExists(id))
                throw new Exception("ID pelanggan sudah ada.");
            return _model.AddCustomer(id, name, date, phone);
        }

        public bool UpdateCustomer(string id, string name, DateTime date, string phone)
            => _model.UpdateCustomer(id, name, date, phone);

        public bool DeleteCustomer(string id) => _model.DeleteCustomer(id);
    }
}

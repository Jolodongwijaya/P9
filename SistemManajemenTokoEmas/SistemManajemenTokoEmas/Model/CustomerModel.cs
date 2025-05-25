using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemManajemenTokoEmas.Models
{
    public class CustomerModel
    {
        public DataTable GetAllCustomers()
        {
            string query = "SELECT * FROM [Customer]";
            return Connection.ExecuteQuery(query);
        }

        public DataTable SearchCustomer(string keyword)
        {
            string query = "SELECT * FROM [Customer] WHERE CusId LIKE @search OR CusName LIKE @search";
            SqlParameter[] parameters = { new SqlParameter("@search", "%" + keyword + "%") };
            return Connection.ExecuteQuery(query, parameters);
        }

        public DataTable GetCustomerByDate(DateTime date)
        {
            string query = "SELECT * FROM [Customer] WHERE CAST(CusDate AS DATE) = @SelectedDate";
            SqlParameter[] parameters = { new SqlParameter("@SelectedDate", date.Date) };
            return Connection.ExecuteQuery(query, parameters);
        }

        public bool IsCustomerIdExists(string id)
        {
            string query = "SELECT COUNT(*) FROM [Customer] WHERE CusId = @ID";
            SqlParameter[] parameters = { new SqlParameter("@ID", id) };
            int count = Convert.ToInt32(Connection.ExecuteScalar(query, parameters));
            return count > 0;
        }

        public bool AddCustomer(string id, string name, DateTime date, string phone)
        {
            string query = "INSERT INTO [Customer] (CusId, CusName, CusDate, CusPhone) VALUES (@ID, @Name, @CusDate, @Phone)";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@CusDate", date),
                new SqlParameter("@Phone", phone)
            };
            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateCustomer(string id, string name, DateTime date, string phone)
        {
            string query = "UPDATE [Customer] SET CusName = @Name, CusPhone = @Phone, CusDate = @CusDate WHERE CusId = @ID";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@CusDate", date),
                new SqlParameter("@Phone", phone)
            };
            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteCustomer(string id)
        {
            string query = "DELETE FROM [Customer] WHERE CusId = @ID";
            SqlParameter[] parameters = { new SqlParameter("@ID", id) };
            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}

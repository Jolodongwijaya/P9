using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemManajemenTokoEmas.Models
{
    public class ProductModel
    {
        public DataTable GetAllProducts()
        {
            string query = "SELECT * FROM [Product]";
            return Connection.ExecuteQuery(query);
        }

        public DataTable SearchProduct(string keyword)
        {
            string query = "SELECT * FROM [Product] WHERE ProId LIKE @search OR ProName LIKE @search";
            SqlParameter[] parameters = { new SqlParameter("@search", "%" + keyword + "%") };
            return Connection.ExecuteQuery(query, parameters);
        }

        public bool IsProductIdExists(string id)
        {
            string query = "SELECT COUNT(*) FROM [Product] WHERE ProId = @ID";
            SqlParameter[] parameters = { new SqlParameter("@ID", id) };
            int count = Convert.ToInt32(Connection.ExecuteScalar(query, parameters));
            return count > 0;
        }

        public bool AddProduct(string id, string name, string category, int quantity, decimal unitPrice)
        {
            string query = "INSERT INTO [Product] (ProId, ProName, ProCategory, Quantity, UnitPrice) " +
                           "VALUES (@ID, @Name, @Category, @Quantity, @UnitPrice)";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@Category", category),
                new SqlParameter("@Quantity", quantity),
                new SqlParameter("@UnitPrice", unitPrice)
            };
            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateProduct(string id, string name, string category, int quantity, decimal unitPrice)
        {
            string query = "UPDATE [Product] SET ProName = @Name, ProCategory = @Category, Quantity = @Quantity, UnitPrice = @UnitPrice WHERE ProId = @ID";
            SqlParameter[] parameters = {
                new SqlParameter("@ID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@Category", category),
                new SqlParameter("@Quantity", quantity),
                new SqlParameter("@UnitPrice", unitPrice)
            };
            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteProduct(string id)
        {
            string query = "DELETE FROM [Product] WHERE ProId = @ID";
            SqlParameter[] parameters = { new SqlParameter("@ID", id) };
            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}

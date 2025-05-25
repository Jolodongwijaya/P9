using SistemManajemenTokoEmas.Models;

namespace SistemManajemenTokoEmas.Controllers
{
    public class LoginController
    {
        public bool Authenticate(UserModel user)
        {
            // Validasi login sederhana, bisa diganti dengan query ke database
            return user.Username == "Admin" && user.Password == "Admin";
        }
    }
}

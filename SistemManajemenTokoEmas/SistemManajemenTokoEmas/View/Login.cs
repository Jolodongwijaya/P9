using System;
using System.Windows.Forms;
using SistemManajemenTokoEmas.Controllers;
using SistemManajemenTokoEmas.Models;

namespace SistemManajemenTokoEmas
{
    public partial class Login : Form
    {
        private readonly LoginController loginController;

        public Login()
        {
            InitializeComponent();
            loginController = new LoginController();
            PasswordTb.UseSystemPasswordChar = true;
        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            UNameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = UNameTb.Text.Trim();
                string password = PasswordTb.Text.Trim();

                if (username == "" || password == "")
                {
                    MessageBox.Show("Nama pengguna atau kata sandi tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var user = new UserModel { Username = username, Password = password };

                if (loginController.Authenticate(user))
                {
                    MessageBox.Show("Login Berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Customer obj = new Customer(); // View berikutnya
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tolong masukkan nama dan password yang benar.", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTb.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

    }
}

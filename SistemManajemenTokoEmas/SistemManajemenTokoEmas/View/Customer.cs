using SistemManajemenTokoEmas.Controllers;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemManajemenTokoEmas
{
    public partial class Customer : Form
    {
        private readonly CustomerController controller = new CustomerController();

        public Customer()
        {
            InitializeComponent();
            CusDateDtp.ValueChanged += CusDateDtp_ValueChanged;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            CustomerDgv.DataSource = controller.GetAllCustomers();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                if (controller.AddCustomer(CusIdTb.Text, CusNameTb.Text, CusDateDtp.Value, CusPhoneTb.Text))
                {
                    MessageBox.Show("Data berhasil ditambahkan.");
                    ResetForm();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data: " + ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (controller.UpdateCustomer(CusIdTb.Text, CusNameTb.Text, CusDateDtp.Value, CusPhoneTb.Text))
            {
                MessageBox.Show("Data berhasil diperbarui.");
                ResetForm();
                LoadData();
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (CusIdTb.Text == "") return;

            if (MessageBox.Show("Yakin ingin menghapus?", "Hapus", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (controller.DeleteCustomer(CusIdTb.Text))
                {
                    MessageBox.Show("Data berhasil dihapus.");
                    ResetForm();
                    LoadData();
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e) => ResetForm();

        private void ResetForm()
        {
            CusIdTb.Text = CusNameTb.Text = CusPhoneTb.Text = "";
            CusDateDtp.Value = DateTime.Now;
            LoadData();
        }

        private void CustomerDgv_DoubleClick(object sender, EventArgs e)
        {
            if (CustomerDgv.CurrentRow == null) return;
            CusIdTb.Text = CustomerDgv.CurrentRow.Cells["CusId"].Value.ToString();
            CusNameTb.Text = CustomerDgv.CurrentRow.Cells["CusName"].Value.ToString();
            CusPhoneTb.Text = CustomerDgv.CurrentRow.Cells["CusPhone"].Value.ToString();
            CusDateDtp.Value = Convert.ToDateTime(CustomerDgv.CurrentRow.Cells["CusDate"].Value);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            CustomerDgv.DataSource = Search.Text == "" ? controller.GetAllCustomers() : controller.SearchCustomer(Search.Text);
        }

        private void Search_TextChanged(object sender, EventArgs e) => BtnSearch_Click(sender, e);

        private void CusDateDtp_ValueChanged(object sender, EventArgs e)
        {
            CustomerDgv.DataSource = controller.GetCustomerByDate(CusDateDtp.Value);
        }

        private bool ValidateForm()
        {
            if (CusIdTb.Text == "" || CusNameTb.Text == "" || CusPhoneTb.Text == "")
            {
                MessageBox.Show("Semua kolom wajib diisi.");
                return false;
            }
            return true;
        }

        private void Logoutlbl_Click(object sender, EventArgs e)
        {
            // Logika logout: kembali ke form login dan sembunyikan form ini
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void Billlbl_Click(object sender, EventArgs e)
        {
            Bill billForm = new Bill();
            billForm.Show();
            this.Hide();
        }

        private void Productlbl_Click(object sender, EventArgs e)
        {
            Product productForm = new Product();
            productForm.Show();
            this.Hide();
        }

    }
}

using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OrganizationApp
{
    public partial class FrmOrganization : Form
    {
        string connectionString =
            ConfigurationManager.ConnectionStrings["OrgDB"].ConnectionString;

        public FrmOrganization()
        {
            InitializeComponent();
        }

        private string ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtOrgName.Text))
                return "Organization Name is required";

            if (txtOrgName.Text.Length < 3 || txtOrgName.Text.Length > 255)
                return "Organization Name must be 3–255 characters";

            if (!string.IsNullOrEmpty(txtPhone.Text) &&
                !Regex.IsMatch(txtPhone.Text, @"^\d{9,12}$"))
                return "Phone must be 9–12 digits";

            if (!string.IsNullOrEmpty(txtEmail.Text) &&
                !Regex.IsMatch(txtEmail.Text,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return "Invalid email format";

            return null;
        }

        private bool IsOrgNameExists(string name)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT COUNT(*) FROM ORGANIZATION WHERE OrgName_Lower = LOWER(@name)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);

                conn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string error = ValidateInput();
            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            if (IsOrgNameExists(txtOrgName.Text))
            {
                MessageBox.Show("Organization Name already exists");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO ORGANIZATION
                               (OrgName, Address, Phone, Email)
                               VALUES (@name, @address, @phone, @email)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", txtOrgName.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Save successfully");
            btnDirector.Enabled = true;
        }

        private void btnDirector_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Director form");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }
    }
}

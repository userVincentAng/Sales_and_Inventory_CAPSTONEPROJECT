using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_and_Inventory_CAPSTONEPROJECT
{
    public partial class Login : Form
    {
        private SqlConnection connection;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\angja\OneDrive\Desktop\Python\Database\CapstoneProject.mdf;Integrated Security=True;Connect Timeout=30";
        public Login()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
        }

    }
}

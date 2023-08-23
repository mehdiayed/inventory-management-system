using System.Data;
using System.Data.SqlClient;

namespace system_dinventaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // communication with the database 
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-O2GVR5N; Initial Catalog=inventory; Integrated Security=true");
        SqlCommand cmd;


        string sql;
        private void button2_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from UsersTable where Uname ='" + textBoxUsername.Text + "' and Upassword ='" + textBoxPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                ManageCustomers manageCustomers = new ManageCustomers();
                manageCustomers.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("wrong username or password");
            }
            con.Close();


        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
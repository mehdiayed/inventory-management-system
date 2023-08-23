using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace system_dinventaire
{
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }

        // communication with the database 
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-O2GVR5N; Initial Catalog=inventory; Integrated Security=true");
        SqlCommand cmd;


        string sql;

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate()
        {
            try
            {
                con.Open();
                string MyQuery = "select * from UsersTable";
                SqlDataAdapter drr = new SqlDataAdapter(MyQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(drr);

                var dataset = new DataSet();
                drr.Fill(dataset);
                UserDataGridView.DataSource = dataset.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string name = textBoxUsername.Text;
                string lastname = textBoxLastname.Text;
                string password = textBoxPassword.Text;
                string phonenumber = textBoxPhonenumber.Text;


                sql = "insert into UsersTable(Uname,Ufullname,Upassword,Uphone) values(@Uname,@Ufullname,@Upassword,@Uphone)";
                con.Open();
                cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Uname", name);
                cmd.Parameters.AddWithValue("@Ufullname", lastname);
                cmd.Parameters.AddWithValue("@Upassword", password);
                cmd.Parameters.AddWithValue("@Uphone", phonenumber);

                MessageBox.Show("redcord aded seccessfully 💚 ");
                cmd.ExecuteNonQuery();
                con.Close();

                textBoxUsername.Clear();
                textBoxLastname.Clear();
                textBoxPassword.Clear();
                textBoxPhonenumber.Clear();

                textBoxUsername.Focus();
                populate();


            }
            catch (Exception ex)
            {
            }

        }



        private void ManageUser_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string MyQuery = "DELETE FROM UsersTable WHERE Uphone = '" + textBoxPhonenumber.Text + "';";
                cmd = new SqlCommand(MyQuery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User has been deleted successfully");
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        private void UserDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < UserDataGridView.Rows.Count)
            {
                textBoxUsername.Text = UserDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxLastname.Text = UserDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxPassword.Text = UserDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxPhonenumber.Text = UserDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxLastname.Clear();
            textBoxPassword.Clear();
            textBoxPhonenumber.Clear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string name = textBoxUsername.Text;
            string lastname = textBoxLastname.Text;
            string password = textBoxPassword.Text;
            string phonenumber = textBoxPhonenumber.Text;

            sql = "update UsersTable set Uname=@Uname,Ufullname=@Ufullname,Upassword=@Upassword where Uphone = @Uphone";
            con.Open();
            cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@Uname", name);
            cmd.Parameters.AddWithValue("@Ufullname", lastname);
            cmd.Parameters.AddWithValue("@Upassword", password);
            cmd.Parameters.AddWithValue("@Uphone", phonenumber);

            MessageBox.Show("redcord updated seccessfully 💚 ");
            cmd.ExecuteNonQuery();
            con.Close();

            textBoxUsername.Clear();
            textBoxLastname.Clear();
            textBoxPassword.Clear();
            textBoxPhonenumber.Clear();

            textBoxUsername.Focus();
            populate();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}

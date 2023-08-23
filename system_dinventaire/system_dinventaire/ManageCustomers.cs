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

namespace system_dinventaire
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-O2GVR5N; Initial Catalog=inventory; Integrated Security=true");
        SqlCommand cmd;
        string sql;

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string nCustomerame = textBoxCustomerName.Text;

                string CustomerPhoneNumber = textBoxCustomerPhoneNumber.Text;



                sql = "insert into CustomersTable(CustName,CustPhone) values(@CustName,@CustPhone)";
                con.Open();
                cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@CustName", nCustomerame);
                cmd.Parameters.AddWithValue("@CustPhone", CustomerPhoneNumber);


                MessageBox.Show("redcord aded seccessfully 💚 ");
                cmd.ExecuteNonQuery();
                con.Close();

                textBoxCustomerName.Clear();
                textBoxCustomerPhoneNumber.Clear();


                textBoxCustomerName.Focus();
                populate();


            }
            catch (Exception ex)
            {
            }
        }
        void populate()
        {
            try
            {
                con.Open();
                string MyQuery = "select * from CustomersTable";
                SqlDataAdapter drr = new SqlDataAdapter(MyQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(drr);

                var dataset = new DataSet();
                drr.Fill(dataset);
                CustomersDataGridView.DataSource = dataset.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string MyQuery = "DELETE FROM CustomersTable WHERE CustId = '" + textBoxCustomerID.Text + "';";
                cmd = new SqlCommand(MyQuery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer has been deleted successfully");
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

        private void CustomersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CustomersDataGridView.Rows.Count)
            {
                textBoxCustomerID.Text = CustomersDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxCustomerName.Text = CustomersDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxCustomerPhoneNumber.Text = CustomersDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from OrderTable where CustId = " + textBoxCustomerID.Text + "", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                OrderLableCount.Text = dt.Rows[0][0].ToString();

                SqlDataAdapter sda1 = new SqlDataAdapter("select SUM(TotalAmount) from OrderTable where CustId = " + textBoxCustomerID.Text + "", con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                LableAmount.Text = dt1.Rows[0][0].ToString();

                SqlDataAdapter sda3 = new SqlDataAdapter("select Max(OrderDate) from OrderTable where CustId = " + textBoxCustomerID.Text + "", con);
                DataTable dt3 = new DataTable();
                sda3.Fill(dt3);
                labelDate.Text = dt3.Rows[0][0].ToString();
                con.Close();
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCustomerID.Clear();
            textBoxCustomerName.Clear();
            textBoxCustomerPhoneNumber.Clear();

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string CustomerId = textBoxCustomerID.Text;

            string nCustomerame = textBoxCustomerName.Text;

            string CustomerPhoneNumber = textBoxCustomerPhoneNumber.Text;


            sql = "UPDATE CustomersTable SET CustName=@CustName, CustPhone=@CustPhone WHERE CustId ='" + CustomerId + "'";
            con.Open();
            cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@CustName", nCustomerame);
            cmd.Parameters.AddWithValue("@CustPhone", CustomerPhoneNumber);


            cmd.ExecuteNonQuery();
            MessageBox.Show("redcord updated seccessfully 💚 ");
            con.Close();

            textBoxCustomerID.Clear();
            textBoxCustomerName.Clear();
            textBoxCustomerPhoneNumber.Clear();


            textBoxCustomerName.Focus();
            populate();
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
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

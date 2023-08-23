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
    public partial class ManageOrders : Form
    {
        private DataTable table = new DataTable();

        public ManageOrders()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-O2GVR5N; Initial Catalog=inventory; Integrated Security=true");
        SqlCommand cmd;
        string sql, product;
        int num = 0;
        int uprice, totalprice, qty, idselected;
        int flag = 0;
        int sum = 0;
        int stock;
        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populate();
            populateProducts();
            fillCategory();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Uprice", typeof(int));
            table.Columns.Add("TotalPrice", typeof(int));
            OrderdataGridView1.DataSource = table;

        }

        // Customers table GridView
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
        // Product table GridView
        void populateProducts()
        {
            try
            {
                con.Open();
                string MyQuery = "select * from ProductsTable";
                SqlDataAdapter drr = new SqlDataAdapter(MyQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(drr);

                var dataset = new DataSet();
                drr.Fill(dataset);
                ProductsDataGridView.DataSource = dataset.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }
        // Get all Categories friom catergory table GridView
        void fillCategory()
        {
            string MyQuery = "select * from CategoryTable";
            cmd = new SqlCommand(MyQuery, con);
            SqlDataReader readerrr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                readerrr = cmd.ExecuteReader();
                dt.Load(readerrr);
                comboBoxSearch.ValueMember = "CatName";
                comboBoxSearch.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
            }
        }
        // ComboBox selection and Trie 
        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string MyQuery = "select * from ProductsTable where ProdCat='" + comboBoxSearch.SelectedValue.ToString() + "'";
                SqlDataAdapter drr = new SqlDataAdapter(MyQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(drr);

                var dataset = new DataSet();
                drr.Fill(dataset);
                ProductsDataGridView.DataSource = dataset.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }


        //Exit button 

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //select from the Customers gridview 
        private void CustomersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CustomersDataGridView.Rows.Count)
            {
                textBoxCustomerId.Text = CustomersDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxCustomerName.Text = CustomersDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        //select from the product gridview 

        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ProductsDataGridView.Rows.Count)
            {
                idselected = Convert.ToInt32(ProductsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                product = ProductsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                stock = Convert.ToInt32(ProductsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                uprice = Convert.ToInt32(ProductsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());

                flag = 1; // Set the flag to 1 to indicate that a product has been selected
            }
        }

        // ADD an order 
        private void buttonAddCostomer_Click(object sender, EventArgs e)
        {
            if (textBoxProductQty.Text == "")
            {
                MessageBox.Show("Enter the Quantity of the Products first");
            }
            else if (flag == 0) // Check if the flag is still 0, meaning no product has been selected
            {
                MessageBox.Show("Select the product");
            }
            else if (Convert.ToInt32(textBoxProductQty.Text) > stock)
            {
                MessageBox.Show("Not Enough stock available");
            }
            else
            {
                // Add the product to the order
                num = num + 1;
                qty = Convert.ToInt32(textBoxProductQty.Text);
                totalprice = qty * uprice;
                table.Rows.Add(num, product, qty, uprice, totalprice);
                OrderdataGridView1.DataSource = table;
                sum = sum + totalprice;
                resultTotalAmount.Text = "" + sum.ToString();
                updateproduct();
            }
        }

        // UPDATE product Quantity after making an order
        void updateproduct()
        {
            if (Convert.ToInt32(textBoxProductQty.Text) == 0)
            {
                MessageBox.Show("you cannot make any other order is from this product");
            }
            else
            {

                con.Open();
                string Query = "update ProductsTable set ProdQty=ProdQty-'" + Convert.ToInt32(textBoxProductQty.Text) + "'where ProdId='" + idselected + "'";
                cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                populateProducts();
                con.Close();
            }

        }
        // INSERT order function on click 
        private void buttonInsertOrder_Click(object sender, EventArgs e)
        {
            if (textBoxOrderId.Text == "" || textBoxCustomerId.Text == "" || textBoxCustomerName.Text == "" || resultTotalAmount.Text == "")
            {
                MessageBox.Show("Fill the data Correctly");
            }
            else
            {

                string orderid = textBoxOrderId.Text;
                string customerid = textBoxCustomerId.Text;
                string customername = textBoxCustomerName.Text;
                // Convert the date from the DateTimePicker to DateTime object
                DateTime orderDate = dateTimePicker1.Value;
                string resultattoalamount = resultTotalAmount.Text;

                sql = "insert into OrderTable(OrderId,CustId,CustName,OrderDate,TotalAmount) values(@OrderId,@CustId,@CustName,@OrderDate,@TotalAmount)";
                con.Open();
                cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@OrderId", orderid);
                cmd.Parameters.AddWithValue("@CustId", customerid);
                cmd.Parameters.AddWithValue("@CustName", customername);
                cmd.Parameters.AddWithValue("@OrderDate", orderDate);
                cmd.Parameters.AddWithValue("@TotalAmount", resultattoalamount);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Order added seccessfully 💚 ");

                textBoxOrderId.Clear();
                textBoxCustomerId.Clear();
                textBoxCustomerName.Clear();

                //populate();


            }
        }

        private void buttonViewOrders_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}

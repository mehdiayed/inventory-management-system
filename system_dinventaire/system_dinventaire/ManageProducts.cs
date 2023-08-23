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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-O2GVR5N; Initial Catalog=inventory; Integrated Security=true");
        SqlCommand cmd;
        string sql;

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
                comboBoxCategory.ValueMember = "CatName";
                comboBoxCategory.DataSource = dt;
                comboBoxSearch.ValueMember = "CatName";
                comboBoxSearch.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
            }
        }
        //void fillCategorySearch()
        //{
        //    string MyQuery = "select * from CategoryTable where CatName='" + comboBoxSearch.SelectedValue.ToString() + "'";
        //    cmd = new SqlCommand(MyQuery, con);
        //    SqlDataReader readerrr;
        //    try
        //    {
        //        con.Open();
        //        DataTable dt = new DataTable();
        //        dt.Columns.Add("CatName", typeof(string));
        //        readerrr = cmd.ExecuteReader();
        //        dt.Load(readerrr);
        //        comboBoxCategory.ValueMember = "CatName";
        //        comboBoxCategory.DataSource = dt;
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            fillCategory();
            populate();
        }
        void populate()
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
        void filtrerbycategory()
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
        private void buttonAddCostomer_Click(object sender, EventArgs e)
        {
            try
            {
                string ProductId = textBoxProductID.Text;
                string ProductName = textBoxProductName.Text;
                string ProductQTY = textBoxProductQty.Text;
                string ProductPRICE = textBoxProductPrice.Text;
                string ProductDisc = textBoxProductDescription.Text;
                string ProductCategory = comboBoxCategory.SelectedValue.ToString();

                sql = "insert into ProductsTable(ProdName,ProdQty,ProdPrice,ProdDesc,ProdCat) values(@ProdName,@ProdQty,@ProdPrice,@ProdDesc,@ProdCat)";
                con.Open();
                cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@ProdName", ProductName);
                cmd.Parameters.AddWithValue("@ProdQty", ProductQTY);
                cmd.Parameters.AddWithValue("@ProdPrice", ProductPRICE);
                cmd.Parameters.AddWithValue("@ProdDesc", ProductDisc);
                cmd.Parameters.AddWithValue("@ProdCat", ProductCategory);


                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Product added seccessfully 💚 ");

                textBoxProductID.Clear();
                textBoxProductName.Clear();
                textBoxProductQty.Clear();
                textBoxProductPrice.Clear();
                textBoxProductDescription.Clear();

                textBoxProductName.Focus();
                populate();


            }
            catch (Exception ex)
            {
            }
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string ProductId = textBoxProductID.Text;
            string ProductName = textBoxProductName.Text;
            string ProductQTY = textBoxProductQty.Text;
            string ProductPRICE = textBoxProductPrice.Text;
            string ProductDisc = textBoxProductDescription.Text;
            string ProductCategory = comboBoxCategory.SelectedValue.ToString();


            sql = "UPDATE ProductsTable SET ProdName=@ProdName, ProdQty=@ProdQty, ProdPrice=@ProdPrice, ProdDesc=@ProdDesc, ProdCat=@ProdCat  WHERE ProdId ='" + ProductId + "'";
            con.Open();
            cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@ProdName", ProductName);
            cmd.Parameters.AddWithValue("@ProdQty", ProductQTY);
            cmd.Parameters.AddWithValue("@ProdPrice", ProductPRICE);
            cmd.Parameters.AddWithValue("@ProdDesc", ProductDisc);
            cmd.Parameters.AddWithValue("@ProdCat", ProductCategory);


            cmd.ExecuteNonQuery();
            MessageBox.Show("Product updated seccessfully 💚 ");
            con.Close();

            textBoxProductID.Clear();
            textBoxProductName.Clear();
            textBoxProductQty.Clear();
            textBoxProductPrice.Clear();
            textBoxProductDescription.Clear();


            textBoxProductName.Focus();
            populate();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string MyQuery = "DELETE FROM ProductsTable WHERE ProdId = '" + textBoxProductID.Text + "';";
                cmd = new SqlCommand(MyQuery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product has been deleted successfully");
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
                    populate();
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxProductID.Clear();
            textBoxProductName.Clear();
            textBoxProductQty.Clear();
            textBoxProductPrice.Clear();
            textBoxProductDescription.Clear();
        }

        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ProductsDataGridView.Rows.Count)
            {
                textBoxProductID.Text = ProductsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxProductName.Text = ProductsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxProductQty.Text = ProductsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxProductPrice.Text = ProductsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxProductDescription.Text = ProductsDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                comboBoxCategory.SelectedValue = ProductsDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filtrerbycategory();
        }

        private void button2_Click(object sender, EventArgs e)
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

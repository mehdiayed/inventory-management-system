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

namespace system_dinventaire
{
    public partial class ManageCategories : Form
    {
        public ManageCategories()
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

        private void buttonAddCostomer_Click(object sender, EventArgs e)
        {
            try
            {
                string CategoryName = textBoxCategoryName.Text;

                sql = "insert into CategoryTable(CatName) values(@CatName)";
                con.Open();
                cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@CatName", CategoryName);

                MessageBox.Show("category added seccessfully 💚 ");
                cmd.ExecuteNonQuery();
                con.Close();

                textBoxCategoryID.Clear();
                textBoxCategoryName.Clear();

                textBoxCategoryName.Focus();
                populate();

            }
            catch (Exception ex)
            {
            }
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string CategoryId = textBoxCategoryID.Text;

            string CategoryName = textBoxCategoryName.Text;


            sql = "UPDATE CategoryTable SET CatName=@CatName WHERE CatId ='" + CategoryId + "'";
            con.Open();
            cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@CatName", CategoryName);


            cmd.ExecuteNonQuery();
            MessageBox.Show("category updated seccessfully 💚 ");
            con.Close();

            textBoxCategoryID.Clear();
            textBoxCategoryName.Clear();


            textBoxCategoryName.Focus();
            populate();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCategoryID.Clear();
            textBoxCategoryName.Clear();
        }

        private void CategoriesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CategoriesDataGridView.Rows.Count)
            {
                textBoxCategoryID.Text = CategoriesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxCategoryName.Text = CategoriesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string MyQuery = "DELETE FROM CategoryTable WHERE CatId = '" + textBoxCategoryID.Text + "';";
                cmd = new SqlCommand(MyQuery, con);
                cmd.ExecuteNonQuery();
                populate();
                MessageBox.Show("Category has been deleted successfully");
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
        void populate()
        {
            try
            {
                con.Open();
                string MyQuery = "select * from CategoryTable";
                SqlDataAdapter drr = new SqlDataAdapter(MyQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(drr);

                var dataset = new DataSet();
                drr.Fill(dataset);
                CategoriesDataGridView.DataSource = dataset.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}

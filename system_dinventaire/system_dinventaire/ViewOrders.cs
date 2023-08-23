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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-O2GVR5N; Initial Catalog=inventory; Integrated Security=true");
        SqlCommand cmd;
        string sql;
        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        void populateOrders()
        {
            try
            {
                con.Open();
                string MyQuery = "select * from OrderTable";
                SqlDataAdapter drr = new SqlDataAdapter(MyQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(drr);

                var dataset = new DataSet();
                drr.Fill(dataset);
                OrderdataGridView2.DataSource = dataset.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }
        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populateOrders();
        }

        private void buttonViewOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OrderdataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

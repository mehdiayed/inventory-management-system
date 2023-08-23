namespace system_dinventaire
{
    partial class ManageOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            CustomersDataGridView = new DataGridView();
            OrderDatelable = new Label();
            textBoxOrderId = new TextBox();
            textBoxCustomerId = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBoxSearch = new ComboBox();
            ProductsDataGridView = new DataGridView();
            label6 = new Label();
            OrderdataGridView1 = new DataGridView();
            buttonAddCostomer = new Button();
            textBoxProductQty = new TextBox();
            textBoxCustomerName = new TextBox();
            label7 = new Label();
            resultTotalAmount = new Label();
            buttonInsertOrder = new Button();
            buttonViewOrders = new Button();
            buttonHome = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderdataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 100);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(893, 0);
            label3.Name = "label3";
            label3.Size = new Size(26, 29);
            label3.TabIndex = 2;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(391, 53);
            label2.Name = "label2";
            label2.Size = new Size(156, 29);
            label2.TabIndex = 1;
            label2.Text = "Manage Orders";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(290, 9);
            label1.Name = "label1";
            label1.Size = new Size(357, 29);
            label1.TabIndex = 0;
            label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 555);
            panel2.Name = "panel2";
            panel2.Size = new Size(922, 17);
            panel2.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(113, 103);
            label4.Name = "label4";
            label4.Size = new Size(125, 23);
            label4.TabIndex = 3;
            label4.Text = "Customers List";
            // 
            // CustomersDataGridView
            // 
            CustomersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomersDataGridView.BackgroundColor = SystemColors.ButtonFace;
            CustomersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersDataGridView.Location = new Point(22, 129);
            CustomersDataGridView.Name = "CustomersDataGridView";
            CustomersDataGridView.RowTemplate.Height = 25;
            CustomersDataGridView.Size = new Size(343, 192);
            CustomersDataGridView.TabIndex = 35;
            CustomersDataGridView.CellContentClick += CustomersDataGridView_CellContentClick;
            // 
            // OrderDatelable
            // 
            OrderDatelable.AutoSize = true;
            OrderDatelable.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            OrderDatelable.Location = new Point(22, 449);
            OrderDatelable.Name = "OrderDatelable";
            OrderDatelable.Size = new Size(91, 23);
            OrderDatelable.TabIndex = 36;
            OrderDatelable.Text = "Order Date";
            // 
            // textBoxOrderId
            // 
            textBoxOrderId.ForeColor = SystemColors.MenuHighlight;
            textBoxOrderId.Location = new Point(22, 332);
            textBoxOrderId.Multiline = true;
            textBoxOrderId.Name = "textBoxOrderId";
            textBoxOrderId.PlaceholderText = "OrderId";
            textBoxOrderId.Size = new Size(267, 34);
            textBoxOrderId.TabIndex = 37;
            // 
            // textBoxCustomerId
            // 
            textBoxCustomerId.Enabled = false;
            textBoxCustomerId.ForeColor = SystemColors.MenuHighlight;
            textBoxCustomerId.Location = new Point(22, 374);
            textBoxCustomerId.Multiline = true;
            textBoxCustomerId.Name = "textBoxCustomerId";
            textBoxCustomerId.PlaceholderText = "CustomerId";
            textBoxCustomerId.Size = new Size(267, 34);
            textBoxCustomerId.TabIndex = 38;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(22, 478);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(267, 23);
            dateTimePicker1.TabIndex = 39;
            // 
            // comboBoxSearch
            // 
            comboBoxSearch.FormattingEnabled = true;
            comboBoxSearch.Location = new Point(710, 103);
            comboBoxSearch.Name = "comboBoxSearch";
            comboBoxSearch.Size = new Size(125, 23);
            comboBoxSearch.TabIndex = 41;
            comboBoxSearch.Text = "Select Category";
            comboBoxSearch.SelectedIndexChanged += comboBoxSearch_SelectedIndexChanged;
            // 
            // ProductsDataGridView
            // 
            ProductsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsDataGridView.BackgroundColor = SystemColors.ButtonFace;
            ProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGridView.Location = new Point(391, 129);
            ProductsDataGridView.Name = "ProductsDataGridView";
            ProductsDataGridView.RowTemplate.Height = 25;
            ProductsDataGridView.Size = new Size(519, 168);
            ProductsDataGridView.TabIndex = 40;
            ProductsDataGridView.CellContentClick += ProductsDataGridView_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(593, 103);
            label6.Name = "label6";
            label6.Size = new Size(111, 23);
            label6.TabIndex = 42;
            label6.Text = "Products List";
            // 
            // OrderdataGridView1
            // 
            OrderdataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrderdataGridView1.BackgroundColor = SystemColors.ButtonFace;
            OrderdataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderdataGridView1.Location = new Point(391, 357);
            OrderdataGridView1.Name = "OrderdataGridView1";
            OrderdataGridView1.RowTemplate.Height = 25;
            OrderdataGridView1.Size = new Size(519, 144);
            OrderdataGridView1.TabIndex = 43;
            // 
            // buttonAddCostomer
            // 
            buttonAddCostomer.BackColor = SystemColors.GradientActiveCaption;
            buttonAddCostomer.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddCostomer.Location = new Point(735, 303);
            buttonAddCostomer.Name = "buttonAddCostomer";
            buttonAddCostomer.Size = new Size(126, 38);
            buttonAddCostomer.TabIndex = 45;
            buttonAddCostomer.Text = "Add To Order";
            buttonAddCostomer.UseVisualStyleBackColor = false;
            buttonAddCostomer.Click += buttonAddCostomer_Click;
            // 
            // textBoxProductQty
            // 
            textBoxProductQty.ForeColor = SystemColors.MenuHighlight;
            textBoxProductQty.Location = new Point(479, 307);
            textBoxProductQty.Multiline = true;
            textBoxProductQty.Name = "textBoxProductQty";
            textBoxProductQty.PlaceholderText = "Product Qty";
            textBoxProductQty.Size = new Size(250, 34);
            textBoxProductQty.TabIndex = 44;
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Enabled = false;
            textBoxCustomerName.ForeColor = SystemColors.MenuHighlight;
            textBoxCustomerName.Location = new Point(22, 414);
            textBoxCustomerName.Multiline = true;
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.PlaceholderText = "Customer Name";
            textBoxCustomerName.Size = new Size(267, 34);
            textBoxCustomerName.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(497, 514);
            label7.Name = "label7";
            label7.Size = new Size(119, 23);
            label7.TabIndex = 47;
            label7.Text = "Total amount :";
            // 
            // resultTotalAmount
            // 
            resultTotalAmount.AutoSize = true;
            resultTotalAmount.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            resultTotalAmount.ForeColor = SystemColors.MenuHighlight;
            resultTotalAmount.Location = new Point(622, 514);
            resultTotalAmount.Name = "resultTotalAmount";
            resultTotalAmount.Size = new Size(58, 23);
            resultTotalAmount.TabIndex = 48;
            resultTotalAmount.Text = "Result";
            // 
            // buttonInsertOrder
            // 
            buttonInsertOrder.BackColor = SystemColors.GradientActiveCaption;
            buttonInsertOrder.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInsertOrder.Location = new Point(22, 508);
            buttonInsertOrder.Name = "buttonInsertOrder";
            buttonInsertOrder.Size = new Size(126, 38);
            buttonInsertOrder.TabIndex = 49;
            buttonInsertOrder.Text = "Insert Order";
            buttonInsertOrder.UseVisualStyleBackColor = false;
            buttonInsertOrder.Click += buttonInsertOrder_Click;
            // 
            // buttonViewOrders
            // 
            buttonViewOrders.BackColor = SystemColors.GradientActiveCaption;
            buttonViewOrders.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonViewOrders.Location = new Point(163, 508);
            buttonViewOrders.Name = "buttonViewOrders";
            buttonViewOrders.Size = new Size(126, 38);
            buttonViewOrders.TabIndex = 50;
            buttonViewOrders.Text = "View Orders";
            buttonViewOrders.UseVisualStyleBackColor = false;
            buttonViewOrders.Click += buttonViewOrders_Click;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.Gray;
            buttonHome.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHome.Location = new Point(770, 511);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(140, 38);
            buttonHome.TabIndex = 51;
            buttonHome.Text = "HOME";
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // ManageOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 572);
            Controls.Add(buttonHome);
            Controls.Add(buttonViewOrders);
            Controls.Add(buttonInsertOrder);
            Controls.Add(resultTotalAmount);
            Controls.Add(label7);
            Controls.Add(textBoxCustomerName);
            Controls.Add(buttonAddCostomer);
            Controls.Add(textBoxProductQty);
            Controls.Add(OrderdataGridView1);
            Controls.Add(label6);
            Controls.Add(comboBoxSearch);
            Controls.Add(ProductsDataGridView);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxCustomerId);
            Controls.Add(textBoxOrderId);
            Controls.Add(OrderDatelable);
            Controls.Add(CustomersDataGridView);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageOrders";
            Text = "ManageOrders";
            Load += ManageOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderdataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private DataGridView CustomersDataGridView;
        private Label OrderDatelable;
        private TextBox textBoxOrderId;
        private TextBox textBoxCustomerId;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxSearch;
        private DataGridView ProductsDataGridView;
        private Label label6;
        private DataGridView OrderdataGridView1;
        private Button buttonAddCostomer;
        private TextBox textBoxProductQty;
        private TextBox textBoxCustomerName;
        private Label label7;
        private Label resultTotalAmount;
        private Button buttonInsertOrder;
        private Button buttonViewOrders;
        private Button buttonHome;
    }
}
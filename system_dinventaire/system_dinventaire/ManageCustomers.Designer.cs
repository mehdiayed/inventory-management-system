namespace system_dinventaire
{
    partial class ManageCustomers
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
            textBoxCustomerPhoneNumber = new TextBox();
            textBoxCustomerName = new TextBox();
            textBoxCustomerID = new TextBox();
            label4 = new Label();
            CustomersDataGridView = new DataGridView();
            buttonClear = new Button();
            buttonHome = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAddCostomer = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            OrderLableCount = new Label();
            label5 = new Label();
            panel4 = new Panel();
            LableAmount = new Label();
            label6 = new Label();
            panel5 = new Panel();
            labelDate = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersDataGridView).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
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
            panel1.TabIndex = 1;
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
            label2.Size = new Size(195, 29);
            label2.TabIndex = 1;
            label2.Text = "Manage Customers";
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
            // textBoxCustomerPhoneNumber
            // 
            textBoxCustomerPhoneNumber.ForeColor = SystemColors.MenuHighlight;
            textBoxCustomerPhoneNumber.Location = new Point(39, 257);
            textBoxCustomerPhoneNumber.Multiline = true;
            textBoxCustomerPhoneNumber.Name = "textBoxCustomerPhoneNumber";
            textBoxCustomerPhoneNumber.PlaceholderText = "Customer Phone Number";
            textBoxCustomerPhoneNumber.Size = new Size(250, 34);
            textBoxCustomerPhoneNumber.TabIndex = 7;
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.ForeColor = SystemColors.MenuHighlight;
            textBoxCustomerName.Location = new Point(39, 200);
            textBoxCustomerName.Multiline = true;
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.PlaceholderText = "Customer Name";
            textBoxCustomerName.Size = new Size(250, 34);
            textBoxCustomerName.TabIndex = 6;
            // 
            // textBoxCustomerID
            // 
            textBoxCustomerID.Enabled = false;
            textBoxCustomerID.ForeColor = SystemColors.MenuHighlight;
            textBoxCustomerID.Location = new Point(39, 143);
            textBoxCustomerID.Multiline = true;
            textBoxCustomerID.Name = "textBoxCustomerID";
            textBoxCustomerID.PlaceholderText = "Customer ID";
            textBoxCustomerID.Size = new Size(250, 34);
            textBoxCustomerID.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(543, 111);
            label4.Name = "label4";
            label4.Size = new Size(168, 29);
            label4.TabIndex = 12;
            label4.Text = "Customers Liste";
            // 
            // CustomersDataGridView
            // 
            CustomersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomersDataGridView.BackgroundColor = SystemColors.ButtonFace;
            CustomersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersDataGridView.Location = new Point(326, 143);
            CustomersDataGridView.Name = "CustomersDataGridView";
            CustomersDataGridView.RowTemplate.Height = 25;
            CustomersDataGridView.Size = new Size(571, 262);
            CustomersDataGridView.TabIndex = 13;
            CustomersDataGridView.CellContentClick += CustomersDataGridView_CellContentClick;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = SystemColors.ButtonFace;
            buttonClear.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClear.Location = new Point(37, 367);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(250, 38);
            buttonClear.TabIndex = 18;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.Gray;
            buttonHome.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHome.Location = new Point(37, 411);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(250, 38);
            buttonHome.TabIndex = 17;
            buttonHome.Text = "HOME";
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.GradientActiveCaption;
            buttonDelete.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(212, 316);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 38);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = SystemColors.GradientActiveCaption;
            buttonEdit.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(124, 316);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 38);
            buttonEdit.TabIndex = 15;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAddCostomer
            // 
            buttonAddCostomer.BackColor = SystemColors.GradientActiveCaption;
            buttonAddCostomer.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddCostomer.Location = new Point(37, 316);
            buttonAddCostomer.Name = "buttonAddCostomer";
            buttonAddCostomer.Size = new Size(75, 38);
            buttonAddCostomer.TabIndex = 14;
            buttonAddCostomer.Text = "Add";
            buttonAddCostomer.UseVisualStyleBackColor = false;
            buttonAddCostomer.Click += buttonAdd_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 555);
            panel2.Name = "panel2";
            panel2.Size = new Size(922, 17);
            panel2.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Bisque;
            panel3.Controls.Add(OrderLableCount);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(304, 430);
            panel3.Name = "panel3";
            panel3.Size = new Size(174, 100);
            panel3.TabIndex = 20;
            // 
            // OrderLableCount
            // 
            OrderLableCount.AutoSize = true;
            OrderLableCount.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            OrderLableCount.Location = new Point(76, 48);
            OrderLableCount.Name = "OrderLableCount";
            OrderLableCount.Size = new Size(22, 25);
            OrderLableCount.TabIndex = 3;
            OrderLableCount.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(41, 3);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 3;
            label5.Text = "Oders Count";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Bisque;
            panel4.Controls.Add(LableAmount);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(496, 430);
            panel4.Name = "panel4";
            panel4.Size = new Size(174, 100);
            panel4.TabIndex = 21;
            // 
            // LableAmount
            // 
            LableAmount.AutoSize = true;
            LableAmount.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LableAmount.Location = new Point(85, 47);
            LableAmount.Name = "LableAmount";
            LableAmount.Size = new Size(22, 26);
            LableAmount.TabIndex = 4;
            LableAmount.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(40, 3);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 3;
            label6.Text = "Orders Amount";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Bisque;
            panel5.Controls.Add(labelDate);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(687, 430);
            panel5.Name = "panel5";
            panel5.Size = new Size(232, 100);
            panel5.TabIndex = 21;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelDate.Location = new Point(18, 47);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(51, 26);
            labelDate.TabIndex = 5;
            labelDate.Text = "Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(70, 3);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 3;
            label7.Text = "Last Order Date";
            // 
            // ManageCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 572);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(buttonClear);
            Controls.Add(buttonHome);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAddCostomer);
            Controls.Add(label4);
            Controls.Add(CustomersDataGridView);
            Controls.Add(textBoxCustomerPhoneNumber);
            Controls.Add(textBoxCustomerName);
            Controls.Add(textBoxCustomerID);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCustomers";
            Load += ManageCustomers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersDataGridView).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxCustomerPhoneNumber;
        private TextBox textBoxCustomerName;
        private TextBox textBoxCustomerID;
        private Label label4;
        private DataGridView CustomersDataGridView;
        private Button buttonClear;
        private Button buttonHome;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAddCostomer;
        private Panel panel2;
        private Panel panel3;
        private Label label5;
        private Label OrderLableCount;
        private Panel panel4;
        private Label label6;
        private Panel panel5;
        private Label label7;
        private Label LableAmount;
        private Label labelDate;
    }
}
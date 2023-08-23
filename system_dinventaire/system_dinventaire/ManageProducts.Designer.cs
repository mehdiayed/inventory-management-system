namespace system_dinventaire
{
    partial class ManageProducts
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
            textBoxProductQty = new TextBox();
            textBoxProductName = new TextBox();
            textBoxProductID = new TextBox();
            textBoxProductDescription = new TextBox();
            textBoxProductPrice = new TextBox();
            comboBoxCategory = new ComboBox();
            buttonClear = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAddCostomer = new Button();
            buttonHome = new Button();
            label4 = new Label();
            ProductsDataGridView = new DataGridView();
            comboBoxSearch = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
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
            panel1.TabIndex = 2;
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
            label2.Size = new Size(177, 29);
            label2.TabIndex = 1;
            label2.Text = "Manage Products";
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
            panel2.TabIndex = 20;
            // 
            // textBoxProductQty
            // 
            textBoxProductQty.ForeColor = SystemColors.MenuHighlight;
            textBoxProductQty.Location = new Point(26, 245);
            textBoxProductQty.Multiline = true;
            textBoxProductQty.Name = "textBoxProductQty";
            textBoxProductQty.PlaceholderText = "Product Qty";
            textBoxProductQty.Size = new Size(250, 34);
            textBoxProductQty.TabIndex = 24;
            // 
            // textBoxProductName
            // 
            textBoxProductName.ForeColor = SystemColors.MenuHighlight;
            textBoxProductName.Location = new Point(26, 188);
            textBoxProductName.Multiline = true;
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.PlaceholderText = "Product Name";
            textBoxProductName.Size = new Size(250, 34);
            textBoxProductName.TabIndex = 23;
            // 
            // textBoxProductID
            // 
            textBoxProductID.Enabled = false;
            textBoxProductID.ForeColor = SystemColors.MenuHighlight;
            textBoxProductID.Location = new Point(26, 131);
            textBoxProductID.Multiline = true;
            textBoxProductID.Name = "textBoxProductID";
            textBoxProductID.PlaceholderText = "Product  ID";
            textBoxProductID.Size = new Size(250, 34);
            textBoxProductID.TabIndex = 22;
            // 
            // textBoxProductDescription
            // 
            textBoxProductDescription.ForeColor = SystemColors.MenuHighlight;
            textBoxProductDescription.Location = new Point(26, 355);
            textBoxProductDescription.Multiline = true;
            textBoxProductDescription.Name = "textBoxProductDescription";
            textBoxProductDescription.PlaceholderText = "Product description";
            textBoxProductDescription.Size = new Size(250, 34);
            textBoxProductDescription.TabIndex = 26;
            // 
            // textBoxProductPrice
            // 
            textBoxProductPrice.ForeColor = SystemColors.MenuHighlight;
            textBoxProductPrice.Location = new Point(26, 298);
            textBoxProductPrice.Multiline = true;
            textBoxProductPrice.Name = "textBoxProductPrice";
            textBoxProductPrice.PlaceholderText = "Product price";
            textBoxProductPrice.Size = new Size(250, 34);
            textBoxProductPrice.TabIndex = 25;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(26, 409);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(250, 23);
            comboBoxCategory.TabIndex = 27;
            comboBoxCategory.Text = "Product Category";
            // 
            // buttonClear
            // 
            buttonClear.BackColor = SystemColors.ButtonFace;
            buttonClear.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClear.Location = new Point(26, 500);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(113, 38);
            buttonClear.TabIndex = 31;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.GradientActiveCaption;
            buttonDelete.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(201, 449);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 38);
            buttonDelete.TabIndex = 30;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = SystemColors.GradientActiveCaption;
            buttonEdit.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(113, 449);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 38);
            buttonEdit.TabIndex = 29;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAddCostomer
            // 
            buttonAddCostomer.BackColor = SystemColors.GradientActiveCaption;
            buttonAddCostomer.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddCostomer.Location = new Point(26, 449);
            buttonAddCostomer.Name = "buttonAddCostomer";
            buttonAddCostomer.Size = new Size(75, 38);
            buttonAddCostomer.TabIndex = 28;
            buttonAddCostomer.Text = "Add";
            buttonAddCostomer.UseVisualStyleBackColor = false;
            buttonAddCostomer.Click += buttonAddCostomer_Click;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.Gray;
            buttonHome.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHome.Location = new Point(156, 500);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(120, 38);
            buttonHome.TabIndex = 32;
            buttonHome.Text = "HOME";
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(529, 103);
            label4.Name = "label4";
            label4.Size = new Size(150, 29);
            label4.TabIndex = 33;
            label4.Text = "Products Liste";
            // 
            // ProductsDataGridView
            // 
            ProductsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsDataGridView.BackgroundColor = SystemColors.ButtonFace;
            ProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGridView.Location = new Point(317, 188);
            ProductsDataGridView.Name = "ProductsDataGridView";
            ProductsDataGridView.RowTemplate.Height = 25;
            ProductsDataGridView.Size = new Size(571, 244);
            ProductsDataGridView.TabIndex = 34;
            ProductsDataGridView.CellContentClick += ProductsDataGridView_CellContentClick;
            // 
            // comboBoxSearch
            // 
            comboBoxSearch.FormattingEnabled = true;
            comboBoxSearch.Location = new Point(513, 142);
            comboBoxSearch.Name = "comboBoxSearch";
            comboBoxSearch.Size = new Size(125, 23);
            comboBoxSearch.TabIndex = 35;
            comboBoxSearch.Text = "Select Category";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(644, 135);
            button1.Name = "button1";
            button1.Size = new Size(67, 40);
            button1.TabIndex = 36;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(717, 135);
            button2.Name = "button2";
            button2.Size = new Size(101, 40);
            button2.TabIndex = 37;
            button2.Text = "Refresh ALL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 572);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBoxSearch);
            Controls.Add(label4);
            Controls.Add(ProductsDataGridView);
            Controls.Add(buttonHome);
            Controls.Add(buttonClear);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAddCostomer);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxProductDescription);
            Controls.Add(textBoxProductPrice);
            Controls.Add(textBoxProductQty);
            Controls.Add(textBoxProductName);
            Controls.Add(textBoxProductID);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageProducts";
            Load += ManageProducts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TextBox textBoxProductQty;
        private TextBox textBoxProductName;
        private TextBox textBoxProductID;
        private TextBox textBoxProductDescription;
        private TextBox textBoxProductPrice;
        private ComboBox comboBoxCategory;
        private Button buttonClear;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAddCostomer;
        private Button buttonHome;
        private Label label4;
        private DataGridView ProductsDataGridView;
        private ComboBox comboBoxSearch;
        private Button button1;
        private Button button2;
    }
}
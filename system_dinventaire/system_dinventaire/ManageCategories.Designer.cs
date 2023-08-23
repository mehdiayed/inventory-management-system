namespace system_dinventaire
{
    partial class ManageCategories
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
            CategoriesDataGridView = new DataGridView();
            textBoxCategoryName = new TextBox();
            textBoxCategoryID = new TextBox();
            buttonClear = new Button();
            buttonHome = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAddCostomer = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoriesDataGridView).BeginInit();
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
            label2.Size = new Size(193, 29);
            label2.TabIndex = 1;
            label2.Text = "Manage Categories";
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
            panel2.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(539, 111);
            label4.Name = "label4";
            label4.Size = new Size(166, 29);
            label4.TabIndex = 16;
            label4.Text = "Categories Liste";
            // 
            // CategoriesDataGridView
            // 
            CategoriesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CategoriesDataGridView.BackgroundColor = SystemColors.ButtonFace;
            CategoriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoriesDataGridView.Location = new Point(322, 143);
            CategoriesDataGridView.Name = "CategoriesDataGridView";
            CategoriesDataGridView.RowTemplate.Height = 25;
            CategoriesDataGridView.Size = new Size(571, 384);
            CategoriesDataGridView.TabIndex = 17;
            CategoriesDataGridView.CellContentClick += CategoriesDataGridView_CellContentClick;
            // 
            // textBoxCategoryName
            // 
            textBoxCategoryName.ForeColor = SystemColors.MenuHighlight;
            textBoxCategoryName.Location = new Point(35, 200);
            textBoxCategoryName.Multiline = true;
            textBoxCategoryName.Name = "textBoxCategoryName";
            textBoxCategoryName.PlaceholderText = "Category Name";
            textBoxCategoryName.Size = new Size(250, 34);
            textBoxCategoryName.TabIndex = 15;
            // 
            // textBoxCategoryID
            // 
            textBoxCategoryID.Enabled = false;
            textBoxCategoryID.ForeColor = SystemColors.MenuHighlight;
            textBoxCategoryID.Location = new Point(35, 143);
            textBoxCategoryID.Multiline = true;
            textBoxCategoryID.Name = "textBoxCategoryID";
            textBoxCategoryID.PlaceholderText = "Category ID";
            textBoxCategoryID.Size = new Size(250, 34);
            textBoxCategoryID.TabIndex = 14;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = SystemColors.ButtonFace;
            buttonClear.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClear.Location = new Point(37, 309);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(250, 38);
            buttonClear.TabIndex = 23;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.Gray;
            buttonHome.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHome.Location = new Point(37, 431);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(250, 38);
            buttonHome.TabIndex = 22;
            buttonHome.Text = "HOME";
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.GradientActiveCaption;
            buttonDelete.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(212, 258);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 38);
            buttonDelete.TabIndex = 21;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = SystemColors.GradientActiveCaption;
            buttonEdit.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(124, 258);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 38);
            buttonEdit.TabIndex = 20;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAddCostomer
            // 
            buttonAddCostomer.BackColor = SystemColors.GradientActiveCaption;
            buttonAddCostomer.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddCostomer.Location = new Point(37, 258);
            buttonAddCostomer.Name = "buttonAddCostomer";
            buttonAddCostomer.Size = new Size(75, 38);
            buttonAddCostomer.TabIndex = 19;
            buttonAddCostomer.Text = "Add";
            buttonAddCostomer.UseVisualStyleBackColor = false;
            buttonAddCostomer.Click += buttonAddCostomer_Click;
            // 
            // ManageCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 572);
            Controls.Add(buttonClear);
            Controls.Add(buttonHome);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAddCostomer);
            Controls.Add(label4);
            Controls.Add(CategoriesDataGridView);
            Controls.Add(textBoxCategoryName);
            Controls.Add(textBoxCategoryID);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCategories";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CategoriesDataGridView).EndInit();
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
        private DataGridView CategoriesDataGridView;
        private TextBox textBoxCategoryName;
        private TextBox textBoxCategoryID;
        private Button buttonClear;
        private Button buttonHome;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAddCostomer;
    }
}
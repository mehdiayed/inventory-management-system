namespace system_dinventaire
{
    partial class ManageUser
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
            textBoxUsername = new TextBox();
            textBoxLastname = new TextBox();
            textBoxPassword = new TextBox();
            textBoxPhonenumber = new TextBox();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonHome = new Button();
            UserDataGridView = new DataGridView();
            panel2 = new Panel();
            buttonClear = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).BeginInit();
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
            panel1.TabIndex = 0;
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
            label2.Size = new Size(146, 29);
            label2.TabIndex = 1;
            label2.Text = "Manage Users";
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
            // textBoxUsername
            // 
            textBoxUsername.ForeColor = SystemColors.MenuHighlight;
            textBoxUsername.Location = new Point(34, 149);
            textBoxUsername.Multiline = true;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "User Name";
            textBoxUsername.Size = new Size(250, 34);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxLastname
            // 
            textBoxLastname.ForeColor = SystemColors.MenuHighlight;
            textBoxLastname.Location = new Point(34, 206);
            textBoxLastname.Multiline = true;
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.PlaceholderText = "User Last Name";
            textBoxLastname.Size = new Size(250, 34);
            textBoxLastname.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.ForeColor = SystemColors.MenuHighlight;
            textBoxPassword.Location = new Point(34, 263);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "User password";
            textBoxPassword.Size = new Size(250, 34);
            textBoxPassword.TabIndex = 4;
            // 
            // textBoxPhonenumber
            // 
            textBoxPhonenumber.ForeColor = SystemColors.MenuHighlight;
            textBoxPhonenumber.Location = new Point(34, 320);
            textBoxPhonenumber.Multiline = true;
            textBoxPhonenumber.Name = "textBoxPhonenumber";
            textBoxPhonenumber.PlaceholderText = "User Phone number";
            textBoxPhonenumber.Size = new Size(250, 34);
            textBoxPhonenumber.TabIndex = 5;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.GradientActiveCaption;
            buttonAdd.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(34, 371);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 38);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += button1_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = SystemColors.GradientActiveCaption;
            buttonEdit.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(121, 371);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 38);
            buttonEdit.TabIndex = 8;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.GradientActiveCaption;
            buttonDelete.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(209, 371);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 38);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.Gray;
            buttonHome.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHome.Location = new Point(34, 470);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(250, 38);
            buttonHome.TabIndex = 10;
            buttonHome.Text = "HOME";
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // UserDataGridView
            // 
            UserDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UserDataGridView.BackgroundColor = SystemColors.ButtonFace;
            UserDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDataGridView.Location = new Point(327, 149);
            UserDataGridView.Name = "UserDataGridView";
            UserDataGridView.RowTemplate.Height = 25;
            UserDataGridView.Size = new Size(571, 384);
            UserDataGridView.TabIndex = 11;
            UserDataGridView.CellContentClick += UserDataGridView_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 555);
            panel2.Name = "panel2";
            panel2.Size = new Size(922, 17);
            panel2.TabIndex = 12;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = SystemColors.ButtonFace;
            buttonClear.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClear.Location = new Point(34, 422);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(250, 38);
            buttonClear.TabIndex = 13;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(557, 117);
            label4.Name = "label4";
            label4.Size = new Size(119, 29);
            label4.TabIndex = 3;
            label4.Text = "Users Liste";
            // 
            // ManageUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 572);
            Controls.Add(label4);
            Controls.Add(buttonClear);
            Controls.Add(panel2);
            Controls.Add(UserDataGridView);
            Controls.Add(buttonHome);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxPhonenumber);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLastname);
            Controls.Add(textBoxUsername);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageUser";
            Load += ManageUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBoxUsername;
        private TextBox textBoxLastname;
        private TextBox textBoxPassword;
        private TextBox textBoxPhonenumber;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonHome;
        private DataGridView UserDataGridView;
        private Label label3;
        private Panel panel2;
        private Button buttonClear;
        private Label label4;
    }
}
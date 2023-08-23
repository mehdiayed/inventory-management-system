namespace system_dinventaire
{
    partial class ViewOrders
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
            OrderdataGridView2 = new DataGridView();
            buttonViewOrders = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderdataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 100);
            panel1.TabIndex = 4;
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
            label2.Size = new Size(127, 29);
            label2.TabIndex = 1;
            label2.Text = "View Orders";
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
            // OrderdataGridView2
            // 
            OrderdataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrderdataGridView2.BackgroundColor = SystemColors.ButtonFace;
            OrderdataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderdataGridView2.Location = new Point(132, 133);
            OrderdataGridView2.Name = "OrderdataGridView2";
            OrderdataGridView2.RowTemplate.Height = 25;
            OrderdataGridView2.Size = new Size(634, 245);
            OrderdataGridView2.TabIndex = 44;
            OrderdataGridView2.CellContentClick += OrderdataGridView2_CellContentClick;
            // 
            // buttonViewOrders
            // 
            buttonViewOrders.BackColor = Color.DarkSeaGreen;
            buttonViewOrders.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonViewOrders.Location = new Point(363, 459);
            buttonViewOrders.Name = "buttonViewOrders";
            buttonViewOrders.Size = new Size(189, 38);
            buttonViewOrders.TabIndex = 51;
            buttonViewOrders.Text = "Back To Manage Orders";
            buttonViewOrders.UseVisualStyleBackColor = false;
            buttonViewOrders.Click += buttonViewOrders_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 555);
            panel2.Name = "panel2";
            panel2.Size = new Size(922, 17);
            panel2.TabIndex = 52;
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 572);
            Controls.Add(panel2);
            Controls.Add(buttonViewOrders);
            Controls.Add(OrderdataGridView2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrders";
            Text = "ViewOrders";
            Load += ViewOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrderdataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView OrderdataGridView2;
        private Button buttonViewOrders;
        private Panel panel2;
    }
}
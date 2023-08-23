namespace system_dinventaire
{
    partial class SplashFormcs
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            progressBar = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(164, 19);
            label1.Name = "label1";
            label1.Size = new Size(357, 29);
            label1.TabIndex = 1;
            label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(236, 48);
            label2.Name = "label2";
            label2.Size = new Size(202, 16);
            label2.TabIndex = 2;
            label2.Text = "selft learning purposes project ";
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.Black;
            progressBar.Location = new Point(194, 107);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(290, 23);
            progressBar.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // SplashFormcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(677, 212);
            Controls.Add(progressBar);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashFormcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashFormcs";
            Load += SplashFormcs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
    }
}
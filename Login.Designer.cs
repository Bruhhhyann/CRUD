namespace MySQL
{
    partial class Login
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
            txtuser = new TextBox();
            txtpass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // txtuser
            // 
            txtuser.Location = new Point(138, 96);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(206, 23);
            txtuser.TabIndex = 0;
            txtuser.TextChanged += textBox1_TextChanged;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(138, 140);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(206, 23);
            txtpass.TabIndex = 1;
            txtpass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 99);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 2;
            label1.Text = "USERNAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 143);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "PASSWORD";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = SystemColors.ControlDark;
            btnlogin.Location = new Point(138, 169);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(206, 37);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 287);
            Controls.Add(btnlogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtuser;
        private TextBox txtpass;
        private Label label1;
        private Label label2;
        private Button btnlogin;
    }
}
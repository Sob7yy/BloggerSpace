namespace EF_Project
{
    partial class AuthorLogin
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
            tb_login_password = new TextBox();
            tb_login_username = new TextBox();
            label4 = new Label();
            label2 = new Label();
            Btn_Login = new Button();
            label1 = new Label();
            login_error_msg = new Label();
            label7 = new Label();
            link_register = new LinkLabel();
            SuspendLayout();
            // 
            // tb_login_password
            // 
            tb_login_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_login_password.Location = new Point(428, 211);
            tb_login_password.Name = "tb_login_password";
            tb_login_password.Size = new Size(120, 29);
            tb_login_password.TabIndex = 19;
            // 
            // tb_login_username
            // 
            tb_login_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_login_username.Location = new Point(428, 131);
            tb_login_username.Name = "tb_login_username";
            tb_login_username.Size = new Size(120, 29);
            tb_login_username.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(211, 207);
            label4.Name = "label4";
            label4.Size = new Size(103, 30);
            label4.TabIndex = 17;
            label4.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(211, 127);
            label2.Name = "label2";
            label2.Size = new Size(183, 30);
            label2.TabIndex = 16;
            label2.Text = "Username / Email";
            // 
            // Btn_Login
            // 
            Btn_Login.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Login.Location = new Point(339, 357);
            Btn_Login.Name = "Btn_Login";
            Btn_Login.Size = new Size(100, 40);
            Btn_Login.TabIndex = 15;
            Btn_Login.Text = "Login";
            Btn_Login.UseVisualStyleBackColor = true;
            Btn_Login.Click += Btn_Login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(136, 49);
            label1.Name = "label1";
            label1.Size = new Size(508, 45);
            label1.TabIndex = 14;
            label1.Text = "Welcome Back To Blogger Space";
            // 
            // login_error_msg
            // 
            login_error_msg.AutoSize = true;
            login_error_msg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            login_error_msg.ForeColor = Color.Red;
            login_error_msg.Location = new Point(306, 293);
            login_error_msg.Name = "login_error_msg";
            login_error_msg.Size = new Size(181, 15);
            login_error_msg.TabIndex = 20;
            login_error_msg.Text = "Wrong Username Or Password!";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(306, 413);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 23;
            label7.Text = "New Member?";
            // 
            // link_register
            // 
            link_register.AutoSize = true;
            link_register.Location = new Point(396, 413);
            link_register.Name = "link_register";
            link_register.Size = new Size(80, 15);
            link_register.TabIndex = 22;
            link_register.TabStop = true;
            link_register.Text = "Register Here.";
            link_register.VisitedLinkColor = Color.Blue;
            link_register.LinkClicked += link_register_LinkClicked;
            // 
            // AuthorLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(link_register);
            Controls.Add(login_error_msg);
            Controls.Add(tb_login_password);
            Controls.Add(tb_login_username);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(Btn_Login);
            Controls.Add(label1);
            Name = "AuthorLogin";
            Text = "AuthorLogin";
            Load += AuthorLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_login_password;
        private TextBox tb_login_username;
        private Label label4;
        private Label label2;
        private Button Btn_Login;
        private Label label1;
        private Label login_error_msg;
        private Label label7;
        private LinkLabel link_register;
    }
}
namespace EF_Project
{
    partial class AuthorRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Btn_Register = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tb_register_name = new TextBox();
            nud_register_age = new NumericUpDown();
            tb_register_email = new TextBox();
            tb_register_password = new TextBox();
            tb_register_confirm = new TextBox();
            name_error_msg = new Label();
            email_error_msg = new Label();
            password_error_msg = new Label();
            confirm_error_msg = new Label();
            age_error_msg = new Label();
            link_login = new LinkLabel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)nud_register_age).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(175, 35);
            label1.Name = "label1";
            label1.Size = new Size(428, 45);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Blogger Space";
            // 
            // Btn_Register
            // 
            Btn_Register.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Register.Location = new Point(328, 339);
            Btn_Register.Name = "Btn_Register";
            Btn_Register.Size = new Size(100, 40);
            Btn_Register.TabIndex = 1;
            Btn_Register.Text = "Register";
            Btn_Register.UseVisualStyleBackColor = true;
            Btn_Register.Click += Btn_Register_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(200, 109);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(200, 148);
            label3.Name = "label3";
            label3.Size = new Size(64, 30);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(200, 189);
            label4.Name = "label4";
            label4.Size = new Size(103, 30);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(200, 227);
            label5.Name = "label5";
            label5.Size = new Size(187, 30);
            label5.TabIndex = 5;
            label5.Text = "Confirm Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(200, 274);
            label6.Name = "label6";
            label6.Size = new Size(52, 30);
            label6.TabIndex = 6;
            label6.Text = "Age";
            // 
            // tb_register_name
            // 
            tb_register_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_register_name.Location = new Point(417, 113);
            tb_register_name.Name = "tb_register_name";
            tb_register_name.Size = new Size(120, 29);
            tb_register_name.TabIndex = 7;
            // 
            // nud_register_age
            // 
            nud_register_age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nud_register_age.Location = new Point(417, 279);
            nud_register_age.Name = "nud_register_age";
            nud_register_age.Size = new Size(120, 29);
            nud_register_age.TabIndex = 11;
            // 
            // tb_register_email
            // 
            tb_register_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_register_email.Location = new Point(417, 152);
            tb_register_email.Name = "tb_register_email";
            tb_register_email.Size = new Size(120, 29);
            tb_register_email.TabIndex = 12;
            // 
            // tb_register_password
            // 
            tb_register_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_register_password.Location = new Point(417, 193);
            tb_register_password.Name = "tb_register_password";
            tb_register_password.PasswordChar = '*';
            tb_register_password.Size = new Size(120, 29);
            tb_register_password.TabIndex = 13;
            // 
            // tb_register_confirm
            // 
            tb_register_confirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_register_confirm.Location = new Point(417, 231);
            tb_register_confirm.Name = "tb_register_confirm";
            tb_register_confirm.PasswordChar = '*';
            tb_register_confirm.Size = new Size(120, 29);
            tb_register_confirm.TabIndex = 14;
            // 
            // name_error_msg
            // 
            name_error_msg.AutoSize = true;
            name_error_msg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            name_error_msg.ForeColor = Color.Red;
            name_error_msg.Location = new Point(563, 121);
            name_error_msg.Name = "name_error_msg";
            name_error_msg.Size = new Size(106, 15);
            name_error_msg.TabIndex = 15;
            name_error_msg.Text = "Name is not valid!";
            // 
            // email_error_msg
            // 
            email_error_msg.AutoSize = true;
            email_error_msg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            email_error_msg.ForeColor = Color.Red;
            email_error_msg.Location = new Point(563, 160);
            email_error_msg.Name = "email_error_msg";
            email_error_msg.Size = new Size(102, 15);
            email_error_msg.TabIndex = 16;
            email_error_msg.Text = "Email is not valid!";
            // 
            // password_error_msg
            // 
            password_error_msg.AutoSize = true;
            password_error_msg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            password_error_msg.ForeColor = Color.Red;
            password_error_msg.Location = new Point(563, 201);
            password_error_msg.Name = "password_error_msg";
            password_error_msg.Size = new Size(248, 15);
            password_error_msg.TabIndex = 17;
            password_error_msg.Text = "Password must contain at least 6 characters";
            // 
            // confirm_error_msg
            // 
            confirm_error_msg.AutoSize = true;
            confirm_error_msg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            confirm_error_msg.ForeColor = Color.Red;
            confirm_error_msg.Location = new Point(563, 239);
            confirm_error_msg.Name = "confirm_error_msg";
            confirm_error_msg.Size = new Size(151, 15);
            confirm_error_msg.TabIndex = 18;
            confirm_error_msg.Text = "Password is not matching!";
            // 
            // age_error_msg
            // 
            age_error_msg.AutoSize = true;
            age_error_msg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            age_error_msg.ForeColor = Color.Red;
            age_error_msg.Location = new Point(563, 286);
            age_error_msg.Name = "age_error_msg";
            age_error_msg.Size = new Size(137, 15);
            age_error_msg.TabIndex = 19;
            age_error_msg.Text = "Age must be at least 18";
            // 
            // link_login
            // 
            link_login.AutoSize = true;
            link_login.Location = new Point(393, 400);
            link_login.Name = "link_login";
            link_login.Size = new Size(68, 15);
            link_login.TabIndex = 20;
            link_login.TabStop = true;
            link_login.Text = "Login Here.";
            link_login.VisitedLinkColor = Color.Blue;
            link_login.LinkClicked += link_login_LinkClicked;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(239, 400);
            label7.Name = "label7";
            label7.Size = new Size(148, 15);
            label7.TabIndex = 21;
            label7.Text = "Already Have An Account?";
            // 
            // AuthorRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(822, 450);
            Controls.Add(label7);
            Controls.Add(link_login);
            Controls.Add(age_error_msg);
            Controls.Add(confirm_error_msg);
            Controls.Add(password_error_msg);
            Controls.Add(email_error_msg);
            Controls.Add(name_error_msg);
            Controls.Add(tb_register_confirm);
            Controls.Add(tb_register_password);
            Controls.Add(tb_register_email);
            Controls.Add(nud_register_age);
            Controls.Add(tb_register_name);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Btn_Register);
            Controls.Add(label1);
            Name = "AuthorRegister";
            Text = "Form1";
            Load += AuthorRegister_Load;
            ((System.ComponentModel.ISupportInitialize)nud_register_age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Btn_Register;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tb_register_name;
        private NumericUpDown nud_register_age;
        private TextBox tb_register_email;
        private TextBox tb_register_password;
        private TextBox tb_register_confirm;
        private Label name_error_msg;
        private Label email_error_msg;
        private Label password_error_msg;
        private Label confirm_error_msg;
        private Label age_error_msg;
        private LinkLabel link_login;
        private Label label7;
    }
}
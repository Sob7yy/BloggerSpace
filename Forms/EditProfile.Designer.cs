namespace EF_Project
{
    partial class EditProfile
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
            blogMenuStrip1 = new BlogMenuStrip();
            age_error_msg = new Label();
            email_error_msg = new Label();
            name_error_msg = new Label();
            tb_edit_email = new TextBox();
            nud_edit_age = new NumericUpDown();
            tb_edit_name = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            Btn_Save = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nud_edit_age).BeginInit();
            SuspendLayout();
            // 
            // blogMenuStrip1
            // 
            blogMenuStrip1.Location = new Point(0, 1);
            blogMenuStrip1.Name = "blogMenuStrip1";
            blogMenuStrip1.Size = new Size(801, 32);
            blogMenuStrip1.TabIndex = 2;
            // 
            // age_error_msg
            // 
            age_error_msg.AutoSize = true;
            age_error_msg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            age_error_msg.ForeColor = Color.Red;
            age_error_msg.Location = new Point(526, 232);
            age_error_msg.Name = "age_error_msg";
            age_error_msg.Size = new Size(137, 15);
            age_error_msg.TabIndex = 30;
            age_error_msg.Text = "Age must be at least 18";
            // 
            // email_error_msg
            // 
            email_error_msg.AutoSize = true;
            email_error_msg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            email_error_msg.ForeColor = Color.Red;
            email_error_msg.Location = new Point(526, 186);
            email_error_msg.Name = "email_error_msg";
            email_error_msg.Size = new Size(102, 15);
            email_error_msg.TabIndex = 29;
            email_error_msg.Text = "Email is not valid!";
            // 
            // name_error_msg
            // 
            name_error_msg.AutoSize = true;
            name_error_msg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            name_error_msg.ForeColor = Color.Red;
            name_error_msg.Location = new Point(526, 139);
            name_error_msg.Name = "name_error_msg";
            name_error_msg.Size = new Size(106, 15);
            name_error_msg.TabIndex = 28;
            name_error_msg.Text = "Name is not valid!";
            // 
            // tb_edit_email
            // 
            tb_edit_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_edit_email.Location = new Point(380, 178);
            tb_edit_email.Name = "tb_edit_email";
            tb_edit_email.Size = new Size(120, 29);
            tb_edit_email.TabIndex = 27;
            // 
            // nud_edit_age
            // 
            nud_edit_age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nud_edit_age.Location = new Point(380, 225);
            nud_edit_age.Name = "nud_edit_age";
            nud_edit_age.Size = new Size(120, 29);
            nud_edit_age.TabIndex = 26;
            // 
            // tb_edit_name
            // 
            tb_edit_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_edit_name.Location = new Point(380, 131);
            tb_edit_name.Name = "tb_edit_name";
            tb_edit_name.Size = new Size(120, 29);
            tb_edit_name.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(227, 220);
            label6.Name = "label6";
            label6.Size = new Size(52, 30);
            label6.TabIndex = 24;
            label6.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(227, 174);
            label3.Name = "label3";
            label3.Size = new Size(64, 30);
            label3.TabIndex = 23;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(227, 127);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 22;
            label2.Text = "Name";
            // 
            // Btn_Save
            // 
            Btn_Save.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Save.Location = new Point(313, 300);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(187, 40);
            Btn_Save.TabIndex = 21;
            Btn_Save.Text = "Save Changes";
            Btn_Save.UseVisualStyleBackColor = true;
            Btn_Save.Click += Btn_Save_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(313, 36);
            label1.Name = "label1";
            label1.Size = new Size(187, 45);
            label1.TabIndex = 20;
            label1.Text = "Edit Profile";
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(age_error_msg);
            Controls.Add(email_error_msg);
            Controls.Add(name_error_msg);
            Controls.Add(tb_edit_email);
            Controls.Add(nud_edit_age);
            Controls.Add(tb_edit_name);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Btn_Save);
            Controls.Add(label1);
            Controls.Add(blogMenuStrip1);
            Name = "EditProfile";
            Text = "EditProfile";
            Load += EditProfile_Load;
            ((System.ComponentModel.ISupportInitialize)nud_edit_age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BlogMenuStrip blogMenuStrip1;
        private Label age_error_msg;
        private Label email_error_msg;
        private Label name_error_msg;
        private TextBox tb_edit_email;
        private NumericUpDown nud_edit_age;
        private TextBox tb_edit_name;
        private Label label6;
        private Label label3;
        private Label label2;
        private Button Btn_Save;
        private Label label1;
    }
}
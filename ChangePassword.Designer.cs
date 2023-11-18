namespace EF_Project
{
    partial class ChangePassword
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
            lbl_confirm_error_msg = new Label();
            lbl_new_error_msg = new Label();
            tb_confirm_pass = new TextBox();
            tb_new_pass = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            Btn_Save = new Button();
            lbl_current_error_msg = new Label();
            tb_current_pass = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // blogMenuStrip1
            // 
            blogMenuStrip1.Location = new Point(-1, 0);
            blogMenuStrip1.Name = "blogMenuStrip1";
            blogMenuStrip1.Size = new Size(801, 32);
            blogMenuStrip1.TabIndex = 2;
            // 
            // lbl_confirm_error_msg
            // 
            lbl_confirm_error_msg.AutoSize = true;
            lbl_confirm_error_msg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_confirm_error_msg.ForeColor = Color.Red;
            lbl_confirm_error_msg.Location = new Point(509, 272);
            lbl_confirm_error_msg.Name = "lbl_confirm_error_msg";
            lbl_confirm_error_msg.Size = new Size(151, 15);
            lbl_confirm_error_msg.TabIndex = 24;
            lbl_confirm_error_msg.Text = "Password is not matching!";
            // 
            // lbl_new_error_msg
            // 
            lbl_new_error_msg.AutoSize = true;
            lbl_new_error_msg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_new_error_msg.ForeColor = Color.Red;
            lbl_new_error_msg.Location = new Point(509, 220);
            lbl_new_error_msg.Name = "lbl_new_error_msg";
            lbl_new_error_msg.Size = new Size(248, 15);
            lbl_new_error_msg.TabIndex = 23;
            lbl_new_error_msg.Text = "Password must contain at least 6 characters";
            // 
            // tb_confirm_pass
            // 
            tb_confirm_pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_confirm_pass.Location = new Point(357, 264);
            tb_confirm_pass.Name = "tb_confirm_pass";
            tb_confirm_pass.PasswordChar = '*';
            tb_confirm_pass.Size = new Size(120, 29);
            tb_confirm_pass.TabIndex = 22;
            // 
            // tb_new_pass
            // 
            tb_new_pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_new_pass.Location = new Point(357, 212);
            tb_new_pass.Name = "tb_new_pass";
            tb_new_pass.PasswordChar = '*';
            tb_new_pass.Size = new Size(120, 29);
            tb_new_pass.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(95, 260);
            label5.Name = "label5";
            label5.Size = new Size(237, 30);
            label5.TabIndex = 20;
            label5.Text = "Confirm New Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(95, 208);
            label4.Name = "label4";
            label4.Size = new Size(153, 30);
            label4.TabIndex = 19;
            label4.Text = "New Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(169, 79);
            label1.Name = "label1";
            label1.Size = new Size(284, 45);
            label1.TabIndex = 25;
            label1.Text = "Change Password";
            // 
            // Btn_Save
            // 
            Btn_Save.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Save.Location = new Point(207, 339);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(211, 40);
            Btn_Save.TabIndex = 26;
            Btn_Save.Text = "Save New Password";
            Btn_Save.UseVisualStyleBackColor = true;
            Btn_Save.Click += Btn_Save_Click;
            // 
            // lbl_current_error_msg
            // 
            lbl_current_error_msg.AutoSize = true;
            lbl_current_error_msg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_current_error_msg.ForeColor = Color.Red;
            lbl_current_error_msg.Location = new Point(509, 167);
            lbl_current_error_msg.Name = "lbl_current_error_msg";
            lbl_current_error_msg.Size = new Size(133, 15);
            lbl_current_error_msg.TabIndex = 29;
            lbl_current_error_msg.Text = "Old Password is Wrong";
            // 
            // tb_current_pass
            // 
            tb_current_pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_current_pass.Location = new Point(357, 159);
            tb_current_pass.Name = "tb_current_pass";
            tb_current_pass.PasswordChar = '*';
            tb_current_pass.Size = new Size(120, 29);
            tb_current_pass.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(95, 155);
            label3.Name = "label3";
            label3.Size = new Size(182, 30);
            label3.TabIndex = 27;
            label3.Text = "Current Password";
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_current_error_msg);
            Controls.Add(tb_current_pass);
            Controls.Add(label3);
            Controls.Add(Btn_Save);
            Controls.Add(label1);
            Controls.Add(lbl_confirm_error_msg);
            Controls.Add(lbl_new_error_msg);
            Controls.Add(tb_confirm_pass);
            Controls.Add(tb_new_pass);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(blogMenuStrip1);
            Name = "ChangePassword";
            Text = "ChangePassword";
            Load += ChangePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BlogMenuStrip blogMenuStrip1;
        private Label lbl_confirm_error_msg;
        private Label lbl_new_error_msg;
        private TextBox tb_confirm_pass;
        private TextBox tb_new_pass;
        private Label label5;
        private Label label4;
        private Label label1;
        private Button Btn_Save;
        private Label lbl_current_error_msg;
        private TextBox tb_current_pass;
        private Label label3;
    }
}
namespace EF_Project
{
    partial class AddCatalog
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
            lbl_title = new Label();
            tb_register_name = new TextBox();
            label2 = new Label();
            Btn_Register = new Button();
            SuspendLayout();
            // 
            // blogMenuStrip1
            // 
            blogMenuStrip1.Location = new Point(0, 0);
            blogMenuStrip1.Name = "blogMenuStrip1";
            blogMenuStrip1.Size = new Size(801, 32);
            blogMenuStrip1.TabIndex = 0;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_title.Location = new Point(286, 77);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(207, 45);
            lbl_title.TabIndex = 21;
            lbl_title.Text = "Add Catalog";
            // 
            // tb_register_name
            // 
            tb_register_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_register_name.Location = new Point(434, 168);
            tb_register_name.Name = "tb_register_name";
            tb_register_name.Size = new Size(120, 29);
            tb_register_name.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(217, 164);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 23;
            label2.Text = "Name";
            // 
            // Btn_Register
            // 
            Btn_Register.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Register.Location = new Point(335, 310);
            Btn_Register.Name = "Btn_Register";
            Btn_Register.Size = new Size(100, 40);
            Btn_Register.TabIndex = 22;
            Btn_Register.Text = "Register";
            Btn_Register.UseVisualStyleBackColor = true;
            // 
            // AddCatalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_register_name);
            Controls.Add(label2);
            Controls.Add(Btn_Register);
            Controls.Add(lbl_title);
            Controls.Add(blogMenuStrip1);
            Name = "AddCatalog";
            Text = "AddCatalog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BlogMenuStrip blogMenuStrip1;
        private Label lbl_title;
        private TextBox tb_register_name;
        private Label label2;
        private Button Btn_Register;
    }
}
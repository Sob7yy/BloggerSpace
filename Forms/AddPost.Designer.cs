namespace EF_Project
{
    partial class AddPost
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
            tb_post_title = new TextBox();
            label2 = new Label();
            Btn_Add_Post = new Button();
            rb_post_brief = new TextBox();
            label1 = new Label();
            tb_post_catalog = new TextBox();
            label3 = new Label();
            label4 = new Label();
            rtb_post_body = new RichTextBox();
            SuspendLayout();
            // 
            // blogMenuStrip1
            // 
            blogMenuStrip1.Location = new Point(-1, 1);
            blogMenuStrip1.Name = "blogMenuStrip1";
            blogMenuStrip1.Size = new Size(801, 32);
            blogMenuStrip1.TabIndex = 1;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_title.Location = new Point(34, 45);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(157, 45);
            lbl_title.TabIndex = 21;
            lbl_title.Text = "Add Post";
            // 
            // tb_post_title
            // 
            tb_post_title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_post_title.Location = new Point(163, 125);
            tb_post_title.Name = "tb_post_title";
            tb_post_title.Size = new Size(120, 29);
            tb_post_title.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 121);
            label2.Name = "label2";
            label2.Size = new Size(54, 30);
            label2.TabIndex = 23;
            label2.Text = "Title";
            // 
            // Btn_Add_Post
            // 
            Btn_Add_Post.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Add_Post.Location = new Point(318, 363);
            Btn_Add_Post.Name = "Btn_Add_Post";
            Btn_Add_Post.Size = new Size(100, 40);
            Btn_Add_Post.TabIndex = 22;
            Btn_Add_Post.Text = "Add";
            Btn_Add_Post.UseVisualStyleBackColor = true;
            // 
            // rb_post_brief
            // 
            rb_post_brief.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rb_post_brief.Location = new Point(163, 203);
            rb_post_brief.Name = "rb_post_brief";
            rb_post_brief.Size = new Size(120, 29);
            rb_post_brief.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 199);
            label1.Name = "label1";
            label1.Size = new Size(58, 30);
            label1.TabIndex = 25;
            label1.Text = "Brief";
            // 
            // tb_post_catalog
            // 
            tb_post_catalog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_post_catalog.Location = new Point(163, 279);
            tb_post_catalog.Name = "tb_post_catalog";
            tb_post_catalog.Size = new Size(120, 29);
            tb_post_catalog.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(34, 275);
            label3.Name = "label3";
            label3.Size = new Size(87, 30);
            label3.TabIndex = 27;
            label3.Text = "Catalog";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(339, 121);
            label4.Name = "label4";
            label4.Size = new Size(63, 30);
            label4.TabIndex = 29;
            label4.Text = "Body";
            // 
            // rtb_post_body
            // 
            rtb_post_body.Location = new Point(425, 125);
            rtb_post_body.Name = "rtb_post_body";
            rtb_post_body.Size = new Size(306, 183);
            rtb_post_body.TabIndex = 31;
            rtb_post_body.Text = "";
            // 
            // AddPost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtb_post_body);
            Controls.Add(label4);
            Controls.Add(tb_post_catalog);
            Controls.Add(label3);
            Controls.Add(rb_post_brief);
            Controls.Add(label1);
            Controls.Add(tb_post_title);
            Controls.Add(label2);
            Controls.Add(Btn_Add_Post);
            Controls.Add(lbl_title);
            Controls.Add(blogMenuStrip1);
            Name = "AddPost";
            Text = "AddPost";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BlogMenuStrip blogMenuStrip1;
        private Label lbl_title;
        private TextBox tb_post_title;
        private Label label2;
        private Button Btn_Add_Post;
        private TextBox rb_post_brief;
        private Label label1;
        private TextBox tb_post_catalog;
        private Label label3;
        private Label label4;
        private RichTextBox rtb_post_body;
    }
}
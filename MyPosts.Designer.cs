namespace EF_Project
{
    partial class MyPosts
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
            Btn_Next = new Button();
            Btn_Previous = new Button();
            blogMenuStrip1 = new BlogMenuStrip();
            lbl_info = new Label();
            lbl_title = new Label();
            pb_image = new PictureBox();
            rtb_body = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pb_image).BeginInit();
            SuspendLayout();
            // 
            // Btn_Next
            // 
            Btn_Next.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Next.Location = new Point(489, 367);
            Btn_Next.Name = "Btn_Next";
            Btn_Next.Size = new Size(100, 40);
            Btn_Next.TabIndex = 22;
            Btn_Next.Text = "Next";
            Btn_Next.UseVisualStyleBackColor = true;
            Btn_Next.Click += Btn_Next_Click;
            // 
            // Btn_Previous
            // 
            Btn_Previous.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Previous.Location = new Point(254, 367);
            Btn_Previous.Name = "Btn_Previous";
            Btn_Previous.Size = new Size(100, 40);
            Btn_Previous.TabIndex = 21;
            Btn_Previous.Text = "Previous";
            Btn_Previous.UseVisualStyleBackColor = true;
            Btn_Previous.Click += Btn_Previous_Click;
            // 
            // blogMenuStrip1
            // 
            blogMenuStrip1.Location = new Point(0, 0);
            blogMenuStrip1.Name = "blogMenuStrip1";
            blogMenuStrip1.Size = new Size(800, 26);
            blogMenuStrip1.TabIndex = 25;
            // 
            // lbl_info
            // 
            lbl_info.AutoSize = true;
            lbl_info.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_info.Location = new Point(12, 98);
            lbl_info.Name = "lbl_info";
            lbl_info.Size = new Size(174, 21);
            lbl_info.TabIndex = 29;
            lbl_info.Text = "AuthorName && Catalog";
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_title.Location = new Point(12, 44);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(160, 45);
            lbl_title.TabIndex = 28;
            lbl_title.Text = "Post Title";
            // 
            // pb_image
            // 
            pb_image.Location = new Point(541, 98);
            pb_image.Name = "pb_image";
            pb_image.Size = new Size(205, 223);
            pb_image.TabIndex = 27;
            pb_image.TabStop = false;
            // 
            // rtb_body
            // 
            rtb_body.BackColor = SystemColors.Control;
            rtb_body.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtb_body.Location = new Point(12, 132);
            rtb_body.Name = "rtb_body";
            rtb_body.Size = new Size(485, 189);
            rtb_body.TabIndex = 26;
            rtb_body.Text = "";
            // 
            // MyPosts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_info);
            Controls.Add(lbl_title);
            Controls.Add(pb_image);
            Controls.Add(rtb_body);
            Controls.Add(blogMenuStrip1);
            Controls.Add(Btn_Next);
            Controls.Add(Btn_Previous);
            Name = "MyPosts";
            Text = "MyPosts";
            Load += MyPosts_Load;
            ((System.ComponentModel.ISupportInitialize)pb_image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Btn_Next;
        private Button Btn_Previous;
        private BlogMenuStrip blogMenuStrip1;
        private Label lbl_info;
        private Label lbl_title;
        private PictureBox pb_image;
        private RichTextBox rtb_body;
    }
}
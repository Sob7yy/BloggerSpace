namespace EF_Project
{
    partial class AllPosts
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
            Btn_Previous = new Button();
            Btn_Next = new Button();
            rtb_body = new RichTextBox();
            pb_image = new PictureBox();
            lbl_title = new Label();
            lbl_info = new Label();
            blogMenuStrip1 = new BlogMenuStrip();
            ((System.ComponentModel.ISupportInitialize)pb_image).BeginInit();
            SuspendLayout();
            // 
            // Btn_Previous
            // 
            Btn_Previous.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Previous.Location = new Point(254, 367);
            Btn_Previous.Name = "Btn_Previous";
            Btn_Previous.Size = new Size(100, 40);
            Btn_Previous.TabIndex = 16;
            Btn_Previous.Text = "Previous";
            Btn_Previous.UseVisualStyleBackColor = true;
            Btn_Previous.Click += Btn_Previous_Click;
            // 
            // Btn_Next
            // 
            Btn_Next.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Next.Location = new Point(489, 367);
            Btn_Next.Name = "Btn_Next";
            Btn_Next.Size = new Size(100, 40);
            Btn_Next.TabIndex = 17;
            Btn_Next.Text = "Next";
            Btn_Next.UseVisualStyleBackColor = true;
            Btn_Next.Click += Btn_Next_Click;
            // 
            // rtb_body
            // 
            rtb_body.BackColor = SystemColors.Control;
            rtb_body.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtb_body.Location = new Point(12, 130);
            rtb_body.Name = "rtb_body";
            rtb_body.Size = new Size(485, 189);
            rtb_body.TabIndex = 18;
            rtb_body.Text = "";
            // 
            // pb_image
            // 
            pb_image.Location = new Point(541, 96);
            pb_image.Name = "pb_image";
            pb_image.Size = new Size(205, 223);
            pb_image.TabIndex = 19;
            pb_image.TabStop = false;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_title.Location = new Point(12, 42);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(160, 45);
            lbl_title.TabIndex = 20;
            lbl_title.Text = "Post Title";
            // 
            // lbl_info
            // 
            lbl_info.AutoSize = true;
            lbl_info.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_info.Location = new Point(12, 96);
            lbl_info.Name = "lbl_info";
            lbl_info.Size = new Size(174, 21);
            lbl_info.TabIndex = 21;
            lbl_info.Text = "AuthorName && Catalog";
            // 
            // blogMenuStrip1
            // 
            blogMenuStrip1.Location = new Point(0, 1);
            blogMenuStrip1.Name = "blogMenuStrip1";
            blogMenuStrip1.Size = new Size(801, 32);
            blogMenuStrip1.TabIndex = 22;
            // 
            // AllPosts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(blogMenuStrip1);
            Controls.Add(lbl_info);
            Controls.Add(lbl_title);
            Controls.Add(pb_image);
            Controls.Add(rtb_body);
            Controls.Add(Btn_Next);
            Controls.Add(Btn_Previous);
            Name = "AllPosts";
            Text = "AllPosts";
            Load += AllPosts_Load;
            ((System.ComponentModel.ISupportInitialize)pb_image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Btn_Previous;
        private Button Btn_Next;
        private RichTextBox rtb_body;
        private PictureBox pb_image;
        private Label lbl_title;
        private Label lbl_info;
        private BlogMenuStrip blogMenuStrip1;
    }
}
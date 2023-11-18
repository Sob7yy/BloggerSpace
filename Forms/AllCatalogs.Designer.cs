namespace EF_Project
{
    partial class AllCatalogs
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            blogMenuStrip1 = new BlogMenuStrip();
            lbl_title = new Label();
            dgv_allCatalogs = new DataGridView();
            tb_catalog_name = new TextBox();
            label2 = new Label();
            Btn_Add_Catalog = new Button();
            label1 = new Label();
            tb_catalog_description = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_allCatalogs).BeginInit();
            SuspendLayout();
            // 
            // blogMenuStrip1
            // 
            blogMenuStrip1.Location = new Point(-2, 0);
            blogMenuStrip1.Name = "blogMenuStrip1";
            blogMenuStrip1.Size = new Size(801, 32);
            blogMenuStrip1.TabIndex = 1;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_title.Location = new Point(134, 61);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(149, 45);
            lbl_title.TabIndex = 23;
            lbl_title.Text = "Catalogs";
            // 
            // dgv_allCatalogs
            // 
            dgv_allCatalogs.BackgroundColor = SystemColors.Control;
            dgv_allCatalogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_allCatalogs.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_allCatalogs.Location = new Point(39, 133);
            dgv_allCatalogs.Name = "dgv_allCatalogs";
            dgv_allCatalogs.RowTemplate.Height = 25;
            dgv_allCatalogs.Size = new Size(359, 305);
            dgv_allCatalogs.TabIndex = 24;
            // 
            // tb_catalog_name
            // 
            tb_catalog_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_catalog_name.Location = new Point(631, 152);
            tb_catalog_name.Name = "tb_catalog_name";
            tb_catalog_name.Size = new Size(120, 29);
            tb_catalog_name.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(422, 148);
            label2.Name = "label2";
            label2.Size = new Size(151, 30);
            label2.TabIndex = 27;
            label2.Text = "Catalog Name";
            // 
            // Btn_Add_Catalog
            // 
            Btn_Add_Catalog.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Add_Catalog.Location = new Point(536, 281);
            Btn_Add_Catalog.Name = "Btn_Add_Catalog";
            Btn_Add_Catalog.Size = new Size(100, 40);
            Btn_Add_Catalog.TabIndex = 26;
            Btn_Add_Catalog.Text = "Add";
            Btn_Add_Catalog.UseVisualStyleBackColor = true;
            Btn_Add_Catalog.Click += Btn_Add_Catalog_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(455, 61);
            label1.Name = "label1";
            label1.Size = new Size(284, 45);
            label1.TabIndex = 25;
            label1.Text = "Add New Catalog";
            // 
            // tb_catalog_description
            // 
            tb_catalog_description.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_catalog_description.Location = new Point(631, 211);
            tb_catalog_description.Name = "tb_catalog_description";
            tb_catalog_description.Size = new Size(120, 29);
            tb_catalog_description.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(422, 207);
            label3.Name = "label3";
            label3.Size = new Size(202, 30);
            label3.TabIndex = 29;
            label3.Text = "Catalog Description";
            // 
            // AllCatalogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_catalog_description);
            Controls.Add(label3);
            Controls.Add(tb_catalog_name);
            Controls.Add(label2);
            Controls.Add(Btn_Add_Catalog);
            Controls.Add(label1);
            Controls.Add(dgv_allCatalogs);
            Controls.Add(lbl_title);
            Controls.Add(blogMenuStrip1);
            Name = "AllCatalogs";
            Text = "AllCatalogs";
            Load += AllCatalogs_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_allCatalogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BlogMenuStrip blogMenuStrip1;
        private Label lbl_title;
        private DataGridView dgv_allCatalogs;
        private TextBox tb_catalog_name;
        private Label label2;
        private Button Btn_Add_Catalog;
        private Label label1;
        private TextBox tb_catalog_description;
        private Label label3;
    }
}
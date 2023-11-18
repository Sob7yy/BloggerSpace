namespace EF_Project
{
    partial class BlogMenuStrip
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            postsToolStripMenuItem = new ToolStripMenuItem();
            mi_allPosts = new ToolStripMenuItem();
            mi_myPosts = new ToolStripMenuItem();
            mi_newPost = new ToolStripMenuItem();
            catalogsToolStripMenuItem = new ToolStripMenuItem();
            mi_allCatalogs = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            mi_editProfile = new ToolStripMenuItem();
            mi_changePassword = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { postsToolStripMenuItem, catalogsToolStripMenuItem, profileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(360, 29);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // postsToolStripMenuItem
            // 
            postsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mi_allPosts, mi_myPosts, mi_newPost });
            postsToolStripMenuItem.Name = "postsToolStripMenuItem";
            postsToolStripMenuItem.Size = new Size(58, 25);
            postsToolStripMenuItem.Text = "Posts";
            // 
            // mi_allPosts
            // 
            mi_allPosts.Name = "mi_allPosts";
            mi_allPosts.Size = new Size(177, 26);
            mi_allPosts.Text = "All Posts";
            mi_allPosts.Click += mi_allPosts_Click;
            // 
            // mi_myPosts
            // 
            mi_myPosts.Name = "mi_myPosts";
            mi_myPosts.Size = new Size(177, 26);
            mi_myPosts.Text = "My Posts";
            mi_myPosts.Click += mi_myPosts_Click;
            // 
            // mi_newPost
            // 
            mi_newPost.Name = "mi_newPost";
            mi_newPost.Size = new Size(177, 26);
            mi_newPost.Text = "Add New Post";
            mi_newPost.Click += mi_newPost_Click;
            // 
            // catalogsToolStripMenuItem
            // 
            catalogsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mi_allCatalogs });
            catalogsToolStripMenuItem.Name = "catalogsToolStripMenuItem";
            catalogsToolStripMenuItem.Size = new Size(82, 25);
            catalogsToolStripMenuItem.Text = "Catalogs";
            // 
            // mi_allCatalogs
            // 
            mi_allCatalogs.Name = "mi_allCatalogs";
            mi_allCatalogs.Size = new Size(180, 26);
            mi_allCatalogs.Text = "All Catalogs";
            mi_allCatalogs.Click += mi_allCatalogs_Click;
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mi_editProfile, mi_changePassword });
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(67, 25);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // mi_editProfile
            // 
            mi_editProfile.Name = "mi_editProfile";
            mi_editProfile.Size = new Size(203, 26);
            mi_editProfile.Text = "Edit Profile";
            mi_editProfile.Click += mi_editProfile_Click;
            // 
            // mi_changePassword
            // 
            mi_changePassword.Name = "mi_changePassword";
            mi_changePassword.Size = new Size(203, 26);
            mi_changePassword.Text = "Change Password";
            mi_changePassword.Click += mi_changePassword_Click;
            // 
            // BlogMenuStrip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(menuStrip1);
            Name = "BlogMenuStrip";
            Size = new Size(360, 71);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem postsToolStripMenuItem;
        private ToolStripMenuItem mi_allPosts;
        private ToolStripMenuItem mi_myPosts;
        private ToolStripMenuItem mi_newPost;
        private ToolStripMenuItem catalogsToolStripMenuItem;
        private ToolStripMenuItem mi_allCatalogs;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem mi_editProfile;
        private ToolStripMenuItem mi_changePassword;
    }
}

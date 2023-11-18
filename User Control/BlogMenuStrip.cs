using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project
{
    public partial class BlogMenuStrip : UserControl
    {
        public BlogMenuStrip()
        {
            InitializeComponent();
        }

        private void mi_allPosts_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            AllPosts allPosts = new AllPosts();
            allPosts.ShowDialog();
            this.FindForm().Close();
        }

        private void mi_myPosts_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            MyPosts myPosts = new MyPosts();
            myPosts.ShowDialog();
            this.FindForm().Close();
        }

        private void mi_newPost_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            AddPost addPost = new AddPost();
            addPost.ShowDialog();
            this.FindForm().Close();
        }

        private void mi_allCatalogs_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            AllCatalogs allCatalogs = new AllCatalogs();
            allCatalogs.ShowDialog();
            this.FindForm().Close();
        }

        private void mi_newCatalog_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            AddCatalog addCatalog = new AddCatalog();
            addCatalog.ShowDialog();
            this.FindForm().Close();
        }

        private void mi_editProfile_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            EditProfile editProfile = new EditProfile();
            editProfile.ShowDialog();
            this.FindForm().Close();
        }

        private void mi_changePassword_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
            this.FindForm().Close();
        }
    }
}

using EF_Project.Models;
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
    public partial class AuthorLogin : Form
    {
        BlogContext db;
        public AuthorLogin()
        {
            InitializeComponent();
            db = new BlogContext();
        }

        private void AuthorLogin_Load(object sender, EventArgs e)
        {
            login_error_msg.Visible = false;
        }

        public static int currentAuthorId;
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            login_error_msg.Visible = false;

            var result = db.Authors.Where(a => (a.UserName == tb_login_username.Text || a.Email == tb_login_username.Text) && a.Password == tb_login_password.Text).FirstOrDefault();


            if (result is not null)
            {
                currentAuthorId = (int)result.Id;
                MessageBox.Show("Logged In Successfully");
                this.Hide();
                AllPosts allPosts = new AllPosts();
                allPosts.ShowDialog();
                this.Close();
            }
            else
            {
                login_error_msg.Visible = true;
            }
            tb_login_username.Text = tb_login_password.Text = "";
        }

        private void link_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AuthorRegister authorRegister = new AuthorRegister();
            authorRegister.ShowDialog();
            this.Close();
        }
    }
}

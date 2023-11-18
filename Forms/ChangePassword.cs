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
    public partial class ChangePassword : Form
    {
        BlogContext db;
        public ChangePassword()
        {
            InitializeComponent();
            db = new BlogContext();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            lbl_current_error_msg.Visible = lbl_new_error_msg.Visible = lbl_confirm_error_msg.Visible = false;
        }

        bool passwordError;
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            passwordError = false;
            lbl_current_error_msg.Visible = lbl_new_error_msg.Visible = lbl_confirm_error_msg.Visible = false;
            var currentProfile = db.Authors.FirstOrDefault(a => a.Id == AuthorLogin.currentAuthorId);
            
            if (tb_current_pass.Text != currentProfile.Password)
            {
                lbl_current_error_msg.Visible = true;
                passwordError = true;
            }

            else if (tb_new_pass.Text.Length < 6)
            {
                lbl_new_error_msg.Visible = true;
                passwordError = true;
            }

            else if (tb_confirm_pass.Text != tb_new_pass.Text)
            {
                lbl_confirm_error_msg.Visible = true;
                passwordError = true;
            }
            else
            {
                currentProfile.Password = tb_new_pass.Text;
                db.SaveChanges();
                MessageBox.Show("Password Changed!");
            }
            tb_current_pass.Text = tb_new_pass.Text = tb_confirm_pass.Text = "";
        }
    }
}

using EF_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project
{
    public partial class EditProfile : Form
    {
        BlogContext db;
        public EditProfile()
        {
            InitializeComponent();
            db = new BlogContext();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            name_error_msg.Visible = email_error_msg.Visible = age_error_msg.Visible = false;
            var currentProfile = db.Authors.FirstOrDefault(a => a.Id == AuthorLogin.currentAuthorId);
            tb_edit_name.Text = currentProfile.UserName;
            tb_edit_email.Text = currentProfile.Email;
            nud_edit_age.Value = currentProfile.Age == null ? 0 : (int)currentProfile.Age;
        }

        bool editError;
        Regex regex = new Regex(@"^\w+@\w+.com$");
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            editError = false;
            name_error_msg.Visible = email_error_msg.Visible = age_error_msg.Visible = false;

            if (tb_edit_name.Text == "" || tb_edit_name.Text.Length < 3)
            {
                name_error_msg.Visible = true;
                editError = true;
            }

            if (!regex.IsMatch(tb_edit_email.Text))
            {
                email_error_msg.Visible = true;
                editError = true;
            }

            if (nud_edit_age.Value == 0) { }
            else if (nud_edit_age.Value < 18)
            {
                age_error_msg.Visible = true;
                editError = true;
            }

            if (!editError)
            {
                var currentProfile = db.Authors.FirstOrDefault(a => a.Id == AuthorLogin.currentAuthorId);

                currentProfile.UserName = tb_edit_name.Text;
                currentProfile.Email = tb_edit_email.Text;
                if (nud_edit_age.Value != 0)
                    currentProfile.Age = (int)nud_edit_age.Value;

                db.SaveChanges();

                MessageBox.Show("Saved!");
            }
        }
    }
}

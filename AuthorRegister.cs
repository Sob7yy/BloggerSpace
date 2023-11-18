using EF_Project.Models;
using System.Text.RegularExpressions;

namespace EF_Project
{
    public partial class AuthorRegister : Form
    {
        BlogContext db;
        public AuthorRegister()
        {
            InitializeComponent();
            db = new BlogContext();
        }

        private void AuthorRegister_Load(object sender, EventArgs e)
        {
            name_error_msg.Visible = email_error_msg.Visible = password_error_msg.Visible = confirm_error_msg.Visible = age_error_msg.Visible = false;
        }

        bool registerError;
        Regex regex = new Regex(@"^\w+@\w+.com$");
        private void Btn_Register_Click(object sender, EventArgs e)
        {
            registerError = false;
            name_error_msg.Visible = email_error_msg.Visible = password_error_msg.Visible = confirm_error_msg.Visible = age_error_msg.Visible = false;

            if (tb_register_name.Text == "" || tb_register_name.Text.Length < 3)
            {
                name_error_msg.Visible = true;
                registerError = true;
            }

            if (!regex.IsMatch(tb_register_email.Text))
            {
                email_error_msg.Visible = true;
                registerError = true;
            }

            if (tb_register_password.Text.Length < 6)
            {
                password_error_msg.Visible = true;
                registerError = true;
            }

            if (tb_register_confirm.Text != tb_register_password.Text)
            {
                confirm_error_msg.Visible = true;
                registerError = true;
            }

            if (nud_register_age.Value == 0) { }
            else if (nud_register_age.Value < 18)
            {
                age_error_msg.Visible = true;
                registerError = true;
            }

            if (!registerError)
            {
                Author author = new Author()
                {
                    UserName = tb_register_name.Text,
                    Email = tb_register_email.Text,
                    Password = tb_register_password.Text,
                    Age = nud_register_age.Value == 0 ? null : (int)nud_register_age.Value,
                };

                db.Add(author);
                db.SaveChanges();

                MessageBox.Show("You Are Now Registered!");
                MessageBox.Show("Use Your Name And Password To Login!");
                tb_register_name.Text = tb_register_email.Text = tb_register_password.Text = tb_register_confirm.Text = "";
                nud_register_age.Value = 0;
                this.Hide();
                AuthorLogin authorLogin = new AuthorLogin();
                authorLogin.ShowDialog();
                this.Close();
            }


        }

        private void link_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AuthorLogin authorLogin = new AuthorLogin();
            authorLogin.ShowDialog();
            this.Close();
        }
    }
}
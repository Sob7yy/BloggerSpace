using EF_Project.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class MyPosts : Form
    {
        BlogContext db;
        dynamic myPosts;
        public MyPosts()
        {
            InitializeComponent();
            db = new BlogContext();
            myPosts = db.Posts
                .Where(p => p.Id == AuthorLogin.currentAuthorId)
                .Include(p => p.Author)
                .Include(p => p.Catalog)
                .Select(p => new
                {
                    p.Title,
                    p.Brief,
                    p.Description,
                    AuthorName = p.Author.UserName,
                    p.Date,
                    CatalogName = p.Catalog.Name
                })
                .ToList();
        }

        private void DisplayPost(dynamic myPosts, int currentPostNum)
        {
            lbl_title.Text = myPosts[currentPostNum].Title;
            lbl_info.Text = $"By {myPosts[currentPostNum].AuthorName} on {myPosts[currentPostNum].Date}\t#{myPosts[currentPostNum].CatalogName}";
            rtb_body.Text = myPosts[currentPostNum].Description;
        }

        int currentPost = 0;
        private void MyPosts_Load(object sender, EventArgs e)
        {
            DisplayPost(myPosts, currentPost);
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            if (currentPost == myPosts.Count - 1)
                currentPost = 0;
            else
                currentPost++;

            DisplayPost(myPosts, currentPost);
        }

        private void Btn_Previous_Click(object sender, EventArgs e)
        {
            if (currentPost == 0)
                currentPost = myPosts.Count - 1;
            else
                currentPost--;

            DisplayPost(myPosts, currentPost);
        }
    }
}

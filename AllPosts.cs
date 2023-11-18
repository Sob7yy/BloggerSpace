using EF_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Project
{
    public partial class AllPosts : Form
    {
        BlogContext db;
        dynamic allPosts;
        public AllPosts()
        {
            InitializeComponent();
            db = new BlogContext();
            allPosts = db.Posts
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

        private void DisplayPost(dynamic allPosts, int currentPostNum)
        {
            lbl_title.Text = allPosts[currentPostNum].Title;
            lbl_info.Text = $"By {allPosts[currentPostNum].AuthorName} on {allPosts[currentPostNum].Date}\t#{allPosts[currentPostNum].CatalogName}";
            rtb_body.Text = allPosts[currentPostNum].Description;
        }
        int currentPost = 0;
        private void AllPosts_Load(object sender, EventArgs e)
        {
            DisplayPost(allPosts, currentPost);
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            if (currentPost == allPosts.Count - 1)
                currentPost = 0;
            else
                currentPost++;

            DisplayPost(allPosts, currentPost);
        }

        private void Btn_Previous_Click(object sender, EventArgs e)
        {
            if (currentPost == 0)
                currentPost = allPosts.Count - 1;
            else
                currentPost--;

            DisplayPost(allPosts, currentPost);
        }
    }
}

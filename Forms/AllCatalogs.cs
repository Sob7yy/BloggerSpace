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
    public partial class AllCatalogs : Form
    {
        BlogContext db;
        public AllCatalogs()
        {
            InitializeComponent();
            db = new BlogContext();
        }

        private void ShowAllCatalogs()
        {
            dgv_allCatalogs.DataSource = db.Catalogs
                .Include(c => c.Posts).AsEnumerable()
                .Select(c =>  new
                {
                    CatalogName = c.Name,
                    Posts = c.Posts == null ? "" : c.Posts.Aggregate("", (acc, p) => $"{acc}{p.Title}, ")
                })
                .OrderBy(c => c.CatalogName)
                .ToList();
        }

        private void AllCatalogs_Load(object sender, EventArgs e)
        {
            ShowAllCatalogs();
        }

        private void Btn_Add_Catalog_Click(object sender, EventArgs e)
        {
            if (tb_catalog_name.Text.Length >= 3)
            {
                Catalog c = new Catalog()
                {
                    Name = tb_catalog_name.Text,
                    Description = tb_catalog_description.Text == "" ? null : tb_catalog_description.Text,
                    Posts = null
                };
                db.Add(c);
                db.SaveChanges();
                MessageBox.Show("Catalog Added!");
                ShowAllCatalogs();
            }
        }
    }
}

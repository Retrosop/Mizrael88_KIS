using Bookstore.DBC;
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

namespace Bookstore
{
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
            using (var db = new DataContext())
            {
                var dlist = db.Books.ToList();
                foreach (var s in dlist)
                {
                    dataGridView1.Rows.Add(s.idBooks, s.title, 
                        s.SectionsId, s.AuthorId, s.SuppliersId, s.PublishersId,
                            s.year, s.quantity, s.price);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

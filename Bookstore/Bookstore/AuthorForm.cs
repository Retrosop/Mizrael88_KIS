using Bookstore.DBC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bookstore
{
    public partial class AuthorForm : Form
    {
        public AuthorForm()
        {
            InitializeComponent();
            using (var db = new DataContext())
            {
                var dlist = db.Author.ToList();
                foreach (var s in dlist)
                {
                    dataGridView1.Rows.Add(s.idAuthor, s.surname, s.name, s.patronymic);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var Surname = editSurname.Text;
                var Name = editName.Text;
                var Patronymic = editPatronymic.Text;
                var zapis = new Author()
                {
                    surname = Surname,
                    name = Name,
                    patronymic = Patronymic
                };
                db.Add(zapis);
                db.SaveChanges();
                editSurname.Clear();
                editName.Clear();
                editPatronymic.Clear();
                dataGridView1.Rows.Clear();
                var dlist = db.Author.ToList();
                foreach (var s in dlist)
                {
                    dataGridView1.Rows.Add(s.idAuthor, s.surname, s.name, s.patronymic);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            int v = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            dataGridView1.Rows.Remove(dataGridView1.Rows[a]);

            using (var db = new DataContext())
            {
                var zapis = new Author
                {
                    idAuthor = v
                };

                db.Author.Attach(zapis);
                db.Author.Remove(zapis);

                db.SaveChanges();
            }
        }
    }
}

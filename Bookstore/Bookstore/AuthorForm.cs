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
                if (editSurname.Text == "" || editName.Text == "" || editPatronymic.Text == "")
                {
                    MessageBox.Show("Заполнены не все поля!", "Ошибка!");
                }
                else
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить данную запись?", "Предупреждение!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int a = dataGridView1.CurrentRow.Index;
                    int v = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
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

        private void издателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new PublishersForm();
            frm.Show();
            this.Close();
        }

        private void разделToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new SectionsForm();
            frm.Show();
            this.Close();
        }

        private void покупателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new СustomerForm();
            frm.Show();
            this.Close();
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new SuppliersForm();
            frm.Show();
            this.Close();
        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new BooksForm();
            frm.Show();
            this.Close();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new OrdersForm();
            frm.Show();
            this.Close();
        }
    }
}

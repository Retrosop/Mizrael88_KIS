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

namespace Bookstore
{
    public partial class SectionsForm : Form
    {
        public SectionsForm()
        {
            InitializeComponent();
            using (var db = new DataContext())
            {
                var dlist = db.Sections.ToList();
                foreach (var s in dlist)
                {
                    dataGridView1.Rows.Add(s.idSections, s.section);
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
                if (editSections.Text == "")
                {
                    MessageBox.Show("Заполнены не все поля!", "Ошибка!");
                }
                else
                {
                    var Sections = editSections.Text;
                    var zapis = new Sections()
                    {
                        section = Sections
                    };
                    db.Add(zapis);
                    db.SaveChanges();
                    editSections.Clear();
                    dataGridView1.Rows.Clear();
                    var dlist = db.Sections.ToList();
                    foreach (var s in dlist)
                    {
                        dataGridView1.Rows.Add(s.idSections, s.section);
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
                    var zapis = new Sections
                    {
                        idSections = v
                    };

                    db.Sections.Attach(zapis);
                    db.Sections.Remove(zapis);

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

        private void авторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new AuthorForm();
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

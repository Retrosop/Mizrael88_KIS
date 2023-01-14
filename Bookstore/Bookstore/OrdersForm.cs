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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
            using (var db = new DataContext())
            {
                var dlist = db.Orders.ToList();
                foreach (var s in dlist)
                {
                    dataGridView1.Rows.Add(s.idOrders, s.CustomerId,
                        s.BooksId, s.quantity, s.sum);
                }
                var dCustomerlist = db.Сustomer.ToList();
                editCustomerId.DataSource = dCustomerlist;
                editCustomerId.DisplayMember = "fio";
                editCustomerId.ValueMember = "idCustomer";
                var dBookslist = db.Books.ToList();
                editBooksId.DataSource = dBookslist;
                editBooksId.DisplayMember = "title";
                editBooksId.ValueMember = "idBooks";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    var zapis = new Orders
                    {
                        idOrders = v
                    };

                    db.Orders.Attach(zapis);
                    db.Orders.Remove(zapis);

                    db.SaveChanges();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                if (editQuantity.Text == "" || editSum.Text == "")
                {
                    MessageBox.Show("Заполнены не все поля!", "Ошибка!");
                }
                else
                {
                    int IdCustomer = int.Parse(editCustomerId.SelectedValue.ToString());
                    int IdBooks = int.Parse(editBooksId.SelectedValue.ToString());
                    int Quantity = int.Parse(editQuantity.Text);
                    int Sum = int.Parse(editSum.Text);
                    var zapis = new Orders()
                    {
                        CustomerId = IdCustomer,
                        BooksId = IdBooks,
                        quantity = Quantity,
                        sum = Sum
                    };
                    db.Add(zapis);
                    db.SaveChanges();
                    editQuantity.Clear();
                    editSum.Clear();
                    dataGridView1.Rows.Clear();
                    var dlist = db.Orders.ToList();
                    foreach (var s in dlist)
                    {
                        dataGridView1.Rows.Add(s.idOrders, s.CustomerId,
                        s.BooksId, s.quantity, s.sum);
                    }
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
    }
}

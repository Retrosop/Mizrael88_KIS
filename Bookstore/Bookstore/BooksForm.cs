﻿using Bookstore.DBC;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

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
                var dSectionslist = db.Sections.ToList();
                editSectionsId.DataSource = dSectionslist;
                editSectionsId.DisplayMember = "section";
                editSectionsId.ValueMember = "idSections";
                var dAuthorlist = db.Author.ToList();
                editAuthorId.DataSource = dAuthorlist;
                editAuthorId.DisplayMember = "surname";
                editAuthorId.ValueMember = "idAuthor";
                var dSupplierslist = db.Suppliers.ToList();
                editSuppliersId.DataSource = dSupplierslist;
                editSuppliersId.DisplayMember = "title";
                editSuppliersId.ValueMember = "idSuppliers";
                var dPublisherslist = db.Publishers.ToList();
                editPublishersId.DataSource = dPublisherslist;
                editPublishersId.DisplayMember = "title";
                editPublishersId.ValueMember = "idPublisher";
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
                    var zapis = new Books
                    {
                        idBooks = v
                    };

                    db.Books.Attach(zapis);
                    db.Books.Remove(zapis);

                    db.SaveChanges();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                if (editTitle.Text == "" || editYear.Text == "" || editQuantity.Text == "" || editPrice.Text == "")
                {
                    MessageBox.Show("Заполнены не все поля!", "Ошибка!");
                }
                else
                {
                    var Title = editTitle.Text;
                    int IdSection = int.Parse(editSectionsId.SelectedValue.ToString());
                    int IdAuthor = int.Parse(editAuthorId.SelectedValue.ToString());
                    int IdSuppliers = int.Parse(editSuppliersId.SelectedValue.ToString());
                    int IdPublishers = int.Parse(editPublishersId.SelectedValue.ToString());
                    int Year = int.Parse(editYear.Text);
                    int Quantity = int.Parse(editQuantity.Text);
                    int Price = int.Parse(editPrice.Text);
                    var zapis = new Books()
                    {
                        title = Title,
                        SectionsId = IdSection,
                        AuthorId = IdAuthor,
                        SuppliersId = IdSuppliers,
                        PublishersId = IdPublishers,
                        year = Year,
                        quantity = Quantity,
                        price = Price
                    };
                    db.Add(zapis);
                    db.SaveChanges();
                    editTitle.Clear();
                    editYear.Clear();
                    editQuantity.Clear();
                    editPrice.Clear();
                    dataGridView1.Rows.Clear();
                    var dlist = db.Books.ToList();
                    foreach (var s in dlist)
                    {
                        dataGridView1.Rows.Add(s.idBooks, s.title,
                            s.SectionsId, s.AuthorId, s.SuppliersId, s.PublishersId,
                                s.year, s.quantity, s.price);
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

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new OrdersForm();
            frm.Show();
            this.Close();
        }
    }
}

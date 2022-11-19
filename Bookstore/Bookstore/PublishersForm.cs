using Bookstore.DBC;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore;
public partial class PublishersForm : Form
{
    public PublishersForm()
    {
        InitializeComponent();
        using (var db = new DataContext())
        {
            var dlist = db.Publishers.ToList();
            foreach (var s in dlist)
            {
                dataGridView1.Rows.Add(s.idPublisher, s.title);
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
            var zapis = new Publishers
            {
                idPublisher = v
            };

            db.Publishers.Attach(zapis);
            db.Publishers.Remove(zapis);

            db.SaveChanges();
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        using (var db = new DataContext())
        {
            var Title = editTitle.Text;
            var zapis = new Publishers()
            {
                title = Title
            };
            db.Add(zapis);
            db.SaveChanges();
            editTitle.Clear();
            dataGridView1.Rows.Clear();
            var dlist = db.Publishers.ToList();
            foreach (var s in dlist)
            {
                dataGridView1.Rows.Add(s.idPublisher, s.title);
            }
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}

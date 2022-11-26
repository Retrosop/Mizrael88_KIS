using Bookstore.DBC;
using FastReport;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ToolStripMenuItem fileItem = new ToolStripMenuItem("����");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new PublishersForm();
            frm.Show();
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new SectionsForm();
            frm.Show();
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new AuthorForm();
            frm.Show();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new �ustomerForm();
            frm.Show();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new SuppliersForm();
            frm.Show();
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new BooksForm();
            frm.Show();
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new OrdersForm();
            frm.Show();
        }

        private void �����ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var ReportBookslist = db.Books.ToList();

                Report rep = new Report();

                rep.SetParameterValue("Parameter1", "���������� ������");
                rep.SetParameterValue("Parameter2", "���������");

                rep.RegisterData(ReportBookslist, "BooksReport");

                
            }
        }
    }
}
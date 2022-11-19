using Bookstore.DBC;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ToolStripMenuItem fileItem = new ToolStripMenuItem("Ôàéë");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void èçäàòåëèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new PublishersForm();
            frm.Show();
        }

        private void ğàçäåëToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new SectionsForm();
            frm.Show();
        }

        private void àâòîğûToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new AuthorForm();
            frm.Show();
        }

        private void ïîêóïàòåëèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new ÑustomerForm();
            frm.Show();
        }

        private void ïîñòàâùèêèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new SuppliersForm();
            frm.Show();
        }

        private void êíèãèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new BooksForm();
            frm.Show();
        }
    }
}
using Bookstore.DBC;
using FastReport;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FastReport.Export.PdfSimple;
using Aspose.Words.Reporting;
using System.Reflection;
using Aspose.Words;
using System.Text.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Aspose.Words.Tables;

namespace Bookstore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ToolStripMenuItem fileItem = new ToolStripMenuItem("‘‡ÈÎ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ËÁ‰‡ÚÂÎËToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new PublishersForm();
            frm.Show();
        }

        private void ‡Á‰ÂÎToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new SectionsForm();
            frm.Show();
        }

        private void ‡‚ÚÓ˚ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new AuthorForm();
            frm.Show();
        }

        private void ÔÓÍÛÔ‡ÚÂÎËToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new —ustomerForm();
            frm.Show();
        }

        private void ÔÓÒÚ‡‚˘ËÍËToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new SuppliersForm();
            frm.Show();
        }

        private void ÍÌË„ËToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new BooksForm();
            frm.Show();
        }

        private void Á‡Í‡Á˚ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new OrdersForm();
            frm.Show();
        }

        private void ÍÌË„ËToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var ReportBookslist = new List<Books>();
            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);
            builder.Writeln(DateTime.Now.TimeOfDay.ToString());
            string dataDir = "D:\\ÕÓ‚‡ˇ Ô‡ÔÍ‡ (3)\\Mizrael88_KIS\\Bookstore\\Bookstore\\bin\\Debug\\net6.0-windows\\";
            using (var db = new DataContext())
            {
                ReportBookslist = db.Books.ToList();
            }
            builder.Writeln(" ÌË„Ë");
            Table table = builder.StartTable();
            builder.InsertCell();
            builder.Write("idBooks");
            builder.InsertCell();
            builder.Write("title");
            builder.InsertCell();
            builder.Write("SectionsId");
            builder.InsertCell();
            builder.Write("AuthorId");
            builder.InsertCell();
            builder.Write("SuppliersId");
            builder.InsertCell();
            builder.Write("PublishersId");
            builder.InsertCell();
            builder.Write("year");
            builder.InsertCell();
            builder.Write("quantity");
            builder.InsertCell();
            builder.Write("price");
            builder.EndRow();
            foreach(var Books in ReportBookslist)
            {
                builder.InsertCell();
                builder.Write(Books.idBooks.ToString());
                builder.InsertCell();
                builder.Write(Books.title.ToString());
                builder.InsertCell();
                builder.Write(Books.SectionsId.ToString());
                builder.InsertCell();
                builder.Write(Books.AuthorId.ToString());
                builder.InsertCell();
                builder.Write(Books.SuppliersId.ToString());
                builder.InsertCell();
                builder.Write(Books.PublishersId.ToString());
                builder.InsertCell();
                builder.Write(Books.year.ToString());
                builder.InsertCell();
                builder.Write(Books.quantity.ToString());
                builder.InsertCell();
                builder.Write(Books.price.ToString());
                builder.EndRow();
            }
            builder.EndTable();
            dataDir = dataDir + "report" + DateTime.Now.ToString() + ".docx";
            doc.Save("Report Books.docx");
        }

        private void ‡Á‰ÂÎ˚ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ReportSectionslist = new List<Sections>();
            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);
            builder.Writeln(DateTime.Now.TimeOfDay.ToString());
            string dataDir = "D:\\ÕÓ‚‡ˇ Ô‡ÔÍ‡ (3)\\Mizrael88_KIS\\Bookstore\\Bookstore\\bin\\Debug\\net6.0-windows\\";
            using (var db = new DataContext())
            {
                ReportSectionslist = db.Sections.ToList();
            }
            builder.Writeln("–‡Á‰ÂÎ˚");
            Table table = builder.StartTable();
            builder.InsertCell();
            builder.Write("idSections");
            builder.InsertCell();
            builder.Write("section");
            builder.EndRow();
            foreach (var Sections in ReportSectionslist)
            {
                builder.InsertCell();
                builder.Write(Sections.idSections.ToString());
                builder.InsertCell();
                builder.Write(Sections.section.ToString());
                builder.EndRow();
            }
            builder.EndTable();
            dataDir = dataDir + "report" + DateTime.Now.ToString() + ".docx";
            doc.Save("Report Sections.docx");
        }

        private void ‡‚ÚÓ˚ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var ReportAuthorlist = new List<Author>();
            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);
            builder.Writeln(DateTime.Now.TimeOfDay.ToString());
            string dataDir = "D:\\ÕÓ‚‡ˇ Ô‡ÔÍ‡ (3)\\Mizrael88_KIS\\Bookstore\\Bookstore\\bin\\Debug\\net6.0-windows\\";
            using (var db = new DataContext())
            {
                ReportAuthorlist = db.Author.ToList();
            }
            builder.Writeln("¿‚ÚÓ˚");
            Table table = builder.StartTable();
            builder.InsertCell();
            builder.Write("idAuthor");
            builder.InsertCell();
            builder.Write("surname");
            builder.InsertCell();
            builder.Write("name");
            builder.InsertCell();
            builder.Write("patronymic");
            builder.EndRow();
            foreach (var Author in ReportAuthorlist)
            {
                builder.InsertCell();
                builder.Write(Author.idAuthor.ToString());
                builder.InsertCell();
                builder.Write(Author.surname.ToString());
                builder.InsertCell();
                builder.Write(Author.name.ToString());
                builder.InsertCell();
                builder.Write(Author.patronymic.ToString());
                builder.EndRow();
            }
            builder.EndTable();
            dataDir = dataDir + "report" + DateTime.Now.ToString() + ".docx";
            doc.Save("Report Author.docx");
        }

        private void ËÁ‰‡ÚÂÎËToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var ReportPublisherslist = new List<Publishers>();
            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);
            builder.Writeln(DateTime.Now.TimeOfDay.ToString());
            string dataDir = "D:\\ÕÓ‚‡ˇ Ô‡ÔÍ‡ (3)\\Mizrael88_KIS\\Bookstore\\Bookstore\\bin\\Debug\\net6.0-windows\\";
            using (var db = new DataContext())
            {
                ReportPublisherslist = db.Publishers.ToList();
            }
            builder.Writeln("»Á‰‡ÚÂÎË");
            Table table = builder.StartTable();
            builder.InsertCell();
            builder.Write("idPublisher");
            builder.InsertCell();
            builder.Write("title");
            builder.EndRow();
            foreach (var Publishers in ReportPublisherslist)
            {
                builder.InsertCell();
                builder.Write(Publishers.idPublisher.ToString());
                builder.InsertCell();
                builder.Write(Publishers.title.ToString());
                builder.EndRow();
            }
            builder.EndTable();
            dataDir = dataDir + "report" + DateTime.Now.ToString() + ".docx";
            doc.Save("Report Publishers.docx");
        }

        private void ÔÓÍÛÔ‡ÚÂÎËToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var ReportCustomerlist = new List<—ustomer>();
            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);
            builder.Writeln(DateTime.Now.TimeOfDay.ToString());
            string dataDir = "D:\\ÕÓ‚‡ˇ Ô‡ÔÍ‡ (3)\\Mizrael88_KIS\\Bookstore\\Bookstore\\bin\\Debug\\net6.0-windows\\";
            using (var db = new DataContext())
            {
                ReportCustomerlist = db.—ustomer.ToList();
            }
            builder.Writeln("œÓÍÛÔ‡ÚÂÎË");
            Table table = builder.StartTable();
            builder.InsertCell();
            builder.Write("idCustomer");
            builder.InsertCell();
            builder.Write("fio");
            builder.InsertCell();
            builder.Write("address");
            builder.InsertCell();
            builder.Write("telephone");
            builder.EndRow();
            foreach (var Customer in ReportCustomerlist)
            {
                builder.InsertCell();
                builder.Write(Customer.idCustomer.ToString());
                builder.InsertCell();
                builder.Write(Customer.fio.ToString());
                builder.InsertCell();
                builder.Write(Customer.address.ToString());
                builder.InsertCell();
                builder.Write(Customer.telephone.ToString());
                builder.EndRow();
            }
            builder.EndTable();
            dataDir = dataDir + "report" + DateTime.Now.ToString() + ".docx";
            doc.Save("Report Customer.docx");
        }

        private void ÔÓÒÚ‡‚˘ËÍËToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var ReportSupplierslist = new List<Suppliers>();
            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);
            builder.Writeln(DateTime.Now.TimeOfDay.ToString());
            string dataDir = "D:\\ÕÓ‚‡ˇ Ô‡ÔÍ‡ (3)\\Mizrael88_KIS\\Bookstore\\Bookstore\\bin\\Debug\\net6.0-windows\\";
            using (var db = new DataContext())
            {
                ReportSupplierslist = db.Suppliers.ToList();
            }
            builder.Writeln("œÓÒÚ‡‚˘ËÍË");
            Table table = builder.StartTable();
            builder.InsertCell();
            builder.Write("idSuppliers");
            builder.InsertCell();
            builder.Write("title");
            builder.InsertCell();
            builder.Write("address");
            builder.InsertCell();
            builder.Write("telephone");
            builder.EndRow();
            foreach (var Suppliers in ReportSupplierslist)
            {
                builder.InsertCell();
                builder.Write(Suppliers.idSuppliers.ToString());
                builder.InsertCell();
                builder.Write(Suppliers.title.ToString());
                builder.InsertCell();
                builder.Write(Suppliers.address.ToString());
                builder.InsertCell();
                builder.Write(Suppliers.telephone.ToString());
                builder.EndRow();
            }
            builder.EndTable();
            dataDir = dataDir + "report" + DateTime.Now.ToString() + ".docx";
            doc.Save("Report Suppliers.docx");
        }

        private void Á‡Í‡Á˚ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var ReportOrderslist = new List<Orders>();
            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);
            builder.Writeln(DateTime.Now.ToString("hh:mm:ss tt"));
            string dataDir = "D:\\ÕÓ‚‡ˇ Ô‡ÔÍ‡ (3)\\Mizrael88_KIS\\Bookstore\\Bookstore\\bin\\Debug\\net6.0-windows\\";
            using (var db = new DataContext())
            {
                ReportOrderslist = db.Orders.ToList();
            }
            builder.Writeln("«‡Í‡Á˚");
            Table table = builder.StartTable();
            builder.InsertCell();
            builder.Write("idOrders");
            builder.InsertCell();
            builder.Write("CustomerId");
            builder.InsertCell();
            builder.Write("BooksId");
            builder.InsertCell();
            builder.Write("quantity");
            builder.InsertCell();
            builder.Write("sum");
            builder.EndRow();
            foreach (var Orders in ReportOrderslist)
            {
                builder.InsertCell();
                builder.Write(Orders.idOrders.ToString());
                builder.InsertCell();
                builder.Write(Orders.CustomerId.ToString());
                builder.InsertCell();
                builder.Write(Orders.BooksId.ToString());
                builder.InsertCell();
                builder.Write(Orders.quantity.ToString());
                builder.InsertCell();
                builder.Write(Orders.sum.ToString());
                builder.EndRow();
            }
            builder.EndTable();
            dataDir = dataDir + "report" + DateTime.Now.ToString() + ".docx";
            doc.Save("Report Orders.docx");
        }

        private void Ó·˘ËÈŒÚ˜∏ÚToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new ReportDesigner();
            frm.Show();
        }
    }
}
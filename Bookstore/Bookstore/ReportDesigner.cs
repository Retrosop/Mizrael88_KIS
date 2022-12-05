using Aspose.Words;
using Aspose.Words.Tables;
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
    public partial class ReportDesigner : Form
    {
        public ReportDesigner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ReportBookslist = new List<Books>();
            var ReportSectionslist = new List<Sections>();
            var ReportAuthorlist = new List<Author>();
            var ReportPublisherslist = new List<Publishers>();
            var ReportCustomerlist = new List<Сustomer>();
            var ReportSupplierslist = new List<Suppliers>();
            var ReportOrderslist = new List<Orders>();

            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);
            string dataDir = "D:\\Новая папка (3)\\Mizrael88_KIS\\Bookstore\\Bookstore\\bin\\Debug\\net6.0-windows\\";
            if (checkBox1.Checked == true)
            {
                builder.Writeln(DateTime.Now.TimeOfDay.ToString());
                using (var db = new DataContext())
                {
                    ReportBookslist = db.Books.ToList();
                }
                builder.Writeln("Книги");
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
                foreach (var Books in ReportBookslist)
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
            }
            if(checkBox2.Checked == true)
            {
                builder.Writeln(DateTime.Now.TimeOfDay.ToString());
                using (var db = new DataContext())
                {
                    ReportSectionslist = db.Sections.ToList();
                }
                builder.Writeln("Разделы");
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
            }
            if (checkBox3.Checked == true)
            {
                builder.Writeln(DateTime.Now.TimeOfDay.ToString());
                using (var db = new DataContext())
                {
                    ReportAuthorlist = db.Author.ToList();
                }
                builder.Writeln("Авторы");
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
            }
            if (checkBox4.Checked == true)
            {
                builder.Writeln(DateTime.Now.TimeOfDay.ToString());
                using (var db = new DataContext())
                {
                    ReportPublisherslist = db.Publishers.ToList();
                }
                builder.Writeln("Издатели");
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
            }
            if (checkBox5.Checked == true)
            {
                builder.Writeln(DateTime.Now.TimeOfDay.ToString());
                using (var db = new DataContext())
                {
                    ReportSupplierslist = db.Suppliers.ToList();
                }
                builder.Writeln("Поставщики");
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
            }
            if (checkBox6.Checked == true)
            {
                builder.Writeln(DateTime.Now.TimeOfDay.ToString());
                using (var db = new DataContext())
                {
                    ReportCustomerlist = db.Сustomer.ToList();
                }
                builder.Writeln("Покупатели");
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
            }
            if (checkBox7.Checked == true)
            {
                builder.Writeln(DateTime.Now.TimeOfDay.ToString());
                using (var db = new DataContext())
                {
                    ReportOrderslist = db.Orders.ToList();
                }
                builder.Writeln("Заказы");
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
            }
            dataDir = dataDir + "report" + DateTime.Now.ToString() + ".docx";
            doc.Save("Report.docx");
        }
    }
}

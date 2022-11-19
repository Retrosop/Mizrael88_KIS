using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Collections.Specialized.BitVector32;

namespace Bookstore.DBC;
public class Books
{
    [Key]
    public int idBooks { get; set; }
    public string? title { get; set; }
    public Sections sections_ { get; set; }
    public Author author_ { get; set; }
    public Suppliers suppliers_ { get; set; }
    public Publishers publishers_ { get; set; }
    public int year { get; set; }
    public int quantity { get; set; }
    public int price { get; set; }
}
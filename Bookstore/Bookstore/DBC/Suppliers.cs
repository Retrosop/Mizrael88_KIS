using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.DBC;
public class Suppliers
{
    [Key]
    public int idSuppliers { get; set; }
    public string? title { get; set; }
    public string? address { get; set; }
    public string? telephone { get; set; }
    public List<Books> Books { get; set; }
}
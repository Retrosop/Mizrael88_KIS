using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.DBC;
public class Сustomer
{
    [Key]
    public int idCustomer { get; set; }
    public string? fio { get; set; }
    public string? address { get; set; }
    public string? telephone { get; set; }
}
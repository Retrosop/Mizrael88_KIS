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

public class Orders
{
    [Key]
    public int idOrders { get; set; }
    [Required]
    [Column("idCustomer")]
    public int CustomerId { get; set; }
    [Required]
    [Column("idBooks")]
    public int BooksId { get; set; }
    public int quantity { get; set; }
    public int sum { get; set; }

    public Сustomer Customer { get; set; }
    public Books Books { get; set; }

}

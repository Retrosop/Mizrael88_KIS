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
    [Required]
    [Column("idSections")]
    public int SectionsId { get; set; }
    [Required]
    [Column("idAuthor")]
    public int AuthorId { get; set; }
    [Required]
    [Column("idSuppliers")]
    public int SuppliersId { get; set; }
    [Required]
    [Column("idPublishers")]
    public int PublishersId { get; set; }
    public int year { get; set; }
    public int quantity { get; set; }
    public int price { get; set; }

    public Sections Sections { get; set; }
    public Author Author { get; set; }
    public Suppliers Suppliers { get; set; }
    public Publishers Publishers { get; set; }
    public ICollection<Orders> Orders { get; set; }
}
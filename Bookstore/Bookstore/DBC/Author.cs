using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.DBC;
public class Author
{
    [Key]
    public int idAuthor { get; set; }
    public string? surname { get; set; }
    public string? name { get; set; }
    public string? patronymic { get; set; }
    public ICollection<Books> Books { get; set; }
}
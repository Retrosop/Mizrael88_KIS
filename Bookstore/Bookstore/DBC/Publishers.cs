using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.DBC;
public class Publishers
{
    [Key]
    public int idPublisher { get; set; }
    public string? title { get; set; }
    public ICollection<Books> Books { get; set; }
}
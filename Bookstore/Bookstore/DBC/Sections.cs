using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.DBC;
public class Sections
{
    [Key]
    public int idSections { get; set; }
    public string? section { get; set; }
    public List<Books> books { get; set; }
}
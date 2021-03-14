using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        [Key] //znaci da je primary key da
        public int Id { get; set; }
        
        [Required] // znaci da ne moze biti null
        public string Name { get; set; }

        public string Author { get; set; }
    }
}

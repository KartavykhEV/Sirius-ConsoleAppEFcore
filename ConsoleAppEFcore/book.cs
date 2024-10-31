using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppEFcore
{
    public class book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public author Author { get; set; }
        public int AuthorId { get; set; }   

    }

    public class category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class book_category
    {
        public int BookId { get; set; }
        public int CategoryId { get; set; }
        public book Book { get; set; }
        public category Category { get; set; }
    }


    public class author
    {
        [Key]
        public int Id { get; set; }
        public string Fio { get; set; }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ConsoleAppEFcore
{
    public class person
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime BDay { get; set; }

        public override string ToString()
        {
            return $"{FName} {LName} рожденный {BDay}";
        }

        public gender gender { get; set; }
        public int? genderId { get; set; }
    }

    public class gender
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }


}

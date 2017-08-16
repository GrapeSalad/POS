using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace POS.Models
{
    [Table("Tables")]
    public class Table
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public string Location { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace POS.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public virtual ICollection<Dessert> Dessert { get; set; }
        public virtual ICollection<Beer> Beer { get; set; }
        public virtual ICollection<Entre> Entre { get; set; }
        public virtual ICollection<MixedDrink> MixedDrink { get; set; }
        public virtual ICollection<Wine> Wine { get; set; }
        public virtual ICollection<App> App { get; set; }
    }
}

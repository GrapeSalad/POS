using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    [Table("Beers")]
    public class Beer
    {
        [Key]
        public int Id { get; set; }
        public string Producer { get; set; }
        public string Name { get; set; }
        public string Style { get; set; }
        [DataType(DataType.Currency)]
        public float BottlePrice { get; set; }
        [DataType(DataType.Currency)]
        public float GlassPrice { get; set; }
        public int ABV { get; set; }
        public bool Availability { get; set; }
    }
}

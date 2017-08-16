using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace POS.Models
{
    [Table("Wines")]
    public class Wine
    {
        [Key]
        public int Id { get; set; }
        public string Producer { get; set; }
        public string Name { get; set; }
        public string Varietals { get; set; }
        public int Year { get; set; }
        [DataType(DataType.Currency)]
        public float BottlePrice { get; set; }
        [DataType(DataType.Currency)]
        public float GlassPrice { get; set; }
        public float ABV { get; set; }
        public bool Availability { get; set; }
    }
}

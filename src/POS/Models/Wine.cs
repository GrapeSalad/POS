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
        public double BottlePrice { get; set; }
        [DataType(DataType.Currency)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double GlassPrice;
        //{ get{ return this.GlassPrice; } set { this.GlassPrice = this.Cost * 1.5; } }
        [DataType(DataType.Currency)]
        public double Cost { get; set; }
        public double Markup { get; set; }
        public float ABV { get; set; }
        public bool Availability { get; set; }
        public int OrderId { get; set; }

        public double GetGlassPrice()
        {
            return this.GlassPrice;
        }

        public void SetGlassPrice()
        {
            this.GlassPrice = this.Cost * 1.5;
        }
    }
}

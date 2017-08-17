using POS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace POS.Tests.ModelTests
{
    public class WineTests
    {
        [Fact]
        public void CreateWineObject_Test()
        {
            Wine newWine = new Wine();
            newWine.Name = "Mysterious";
            newWine.Producer = "Patricia Green Cellars";
            newWine.Varietals = "Undisclosed";
            newWine.Year = 2015;
            newWine.Cost = 31.80;
            newWine.Markup = 3.5;
            newWine.ABV = 13.5F;
            newWine.Availability = false;
            newWine.OrderId = 1;

            var name = newWine.Name;
            var producer = newWine.Producer;
            var varietals = newWine.Varietals;
            var year = newWine.Year;
            var cost = newWine.Cost;
            var markup = newWine.Markup;
            var abv = newWine.ABV;
            var availability = newWine.Availability;

            Assert.Equal("Mysterious", name);
            Assert.Equal("Patricia Green Cellars", producer);
            Assert.Equal("Undisclosed", varietals);
            Assert.Equal(2015, year);
            Assert.Equal(31.80, cost);
            Assert.Equal(3.5, markup);
            Assert.Equal(13.5F, abv);
            Assert.Equal(false, availability);
        }
        [Fact]
        public void ComputedColumn_Test()
        {
            Wine newWine = new Wine();
            newWine.Cost = 7;
            newWine.Markup = 2.5;

            var total = 7 * 2.5;

            Assert.Equal(total, newWine.Cost * newWine.Markup);
        }
        [Fact]
        public void ComputedGlassCost_Test()
        {
            Wine newWine = new Wine();
            newWine.Cost = 7;

            newWine.SetGlassPrice();
            var total = 7D * 1.5D;

            Assert.Equal(total, newWine.GlassPrice);
        }
    }
}

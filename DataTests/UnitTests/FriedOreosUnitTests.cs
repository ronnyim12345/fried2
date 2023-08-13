using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FriedPiper.Data.MenuItems;
using FriedPiper.Data.Enums;
using System.ComponentModel;

namespace DataTests.UnitTests
{
    /// <summary>
    /// Units tests for fried oreos
    /// </summary>
    public class FriedOreosUnitTests
    {
        /// <summary>
        /// Sees if IMenuItem is being utilized
        /// </summary>
        [Fact]
        public void ShouldImplementIMenuItem()
        {
            var friedOreos = new FriedOreos();
            Assert.IsAssignableFrom<IMenuItem>(friedOreos);
        }




        /// <summary>
        /// Sees if Popper is being inherited
        /// </summary>
        [Fact]
        public void ShouldExtendPopper()
        {
            var friedOreos = new FriedOreos();
            Assert.IsAssignableFrom<Popper>(friedOreos);
        }




        /// <summary>
        /// Sees if able to set glazed
        /// </summary>
        /// <param name="glazed">whether its glazed</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldBeAbleToSetGlazed(bool glazed)
        {
            var friedOreos = new FriedOreos();
            friedOreos.Glazed = glazed;
            Assert.Equal(glazed, friedOreos.Glazed);
        }



        /// <summary>
        /// Sees if named correctly
        /// </summary>
        /// <param name="size">size of fried oreos</param>
        /// <param name="name">name of fried oreos</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Fried Oreos")]
        [InlineData(ServingSize.Medium, "Medium Fried Oreos")]
        [InlineData(ServingSize.Large, "Large Fried Oreos")]
        public void ShouldBeNamedCorrectly(ServingSize size, string name)
        {
            var friedOreos = new FriedOreos();
            friedOreos.Size = size;
            Assert.Equal(name, friedOreos.Name);
        }



        /// <summary>
        /// Sees if price is correct
        /// </summary>
        /// <param name="size">size of fried oreos</param>
        /// <param name="price">price of fried oreos</param>
        [Theory]
        [InlineData(ServingSize.Small, 3.75)]
        [InlineData(ServingSize.Medium, 4.5)]
        [InlineData(ServingSize.Large, 5.25)]
        public void ShouldHaveCorrectPrice(ServingSize size, decimal price)
        {
            var friedOreos = new FriedOreos();
            friedOreos.Size = size;
            Assert.Equal(price, friedOreos.Price);
        }


        /// <summary>
        /// Sees if calories are correct
        /// </summary>
        /// <param name="size">size of fried oreos</param>
        /// <param name="glazed">whether its glazed</param>
        /// <param name="calories">calories of fried oreos</param>
        [Theory]
        [InlineData(ServingSize.Small, true, 500 + 130)]
        [InlineData(ServingSize.Medium, true, 750 + 130)]
        [InlineData(ServingSize.Large, true, 1000 + 130)]
        [InlineData(ServingSize.Small, false, 500)]
        [InlineData(ServingSize.Medium, false, 750)]
        [InlineData(ServingSize.Large, false, 1000)]
        public void ShouldHaveCorrectCalories(ServingSize size, bool glazed, uint calories)
        {
            var friedOreos = new FriedOreos();
            friedOreos.Size = size;
            friedOreos.Glazed = glazed;
            Assert.Equal(calories, friedOreos.Calories);
        }











        // INotifyPropertyChanged TESTING:




        //  CHANGING SIZE:

        /// <summary>
        /// notify size changed
        /// </summary>
        /// <param name="size">size</param>
        [Theory]
        [InlineData(ServingSize.Small)]
        [InlineData(ServingSize.Medium)]
        [InlineData(ServingSize.Large)]
        public void ChangingSizeShouldNotifyOfSizeChange(ServingSize size)
        {
            var friedOreos = new FriedOreos();
            Assert.PropertyChanged(friedOreos, "Size", () => {
                friedOreos.Size = size;
            });
        }

        /// <summary>
        /// notify price changed
        /// </summary>
        /// <param name="size">size</param>
        [Theory]
        [InlineData(ServingSize.Small)]
        [InlineData(ServingSize.Medium)]
        [InlineData(ServingSize.Large)]
        public void ChangingSizeShouldNotifyOfPriceChange(ServingSize size)
        {
            var friedOreos = new FriedOreos();
            Assert.PropertyChanged(friedOreos, "Price", () => {
                friedOreos.Size = size;
            });
        }


        /// <summary>
        /// notify calories changed
        /// </summary>
        /// <param name="size">size</param>
        [Theory]
        [InlineData(ServingSize.Small)]
        [InlineData(ServingSize.Medium)]
        [InlineData(ServingSize.Large)]
        public void ChangingSizeShouldNotifyOfCaloriesChange(ServingSize size)
        {
            var friedOreos = new FriedOreos();
            Assert.PropertyChanged(friedOreos, "Calories", () => {
                friedOreos.Size = size;
            });
        }



        /// <summary>
        /// notify name changed
        /// </summary>
        /// <param name="size">size</param>
        [Theory]
        [InlineData(ServingSize.Small)]
        [InlineData(ServingSize.Medium)]
        [InlineData(ServingSize.Large)]
        public void ChangingSizeShouldNotifyOfNameChange(ServingSize size)
        {
            var friedOreos = new FriedOreos();
            Assert.PropertyChanged(friedOreos, "Name", () => {
                friedOreos.Size = size;
            });
        }














        //  CHANGING GLAZED:

        /// <summary>
        /// notify glazed changed
        /// </summary>
        /// <param name="glazed">glazed</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingGlazedShouldNotifyOfGlazedChange(bool glazed)
        {
            var friedOreos = new FriedOreos();
            Assert.PropertyChanged(friedOreos, "Glazed", () => {
                friedOreos.Glazed = glazed;
            });
        }

        /// <summary>
        /// notify calories changed
        /// </summary>
        /// <param name="glazed">glazed</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingGlazedShouldNotifyOfCaloriesChange(bool glazed)
        {
            var friedOreos = new FriedOreos();
            Assert.PropertyChanged(friedOreos, "Calories", () => {
                friedOreos.Glazed = glazed;
            });
        }










        // IMPLEMENT INOTIFY ???


        /// <summary>
        /// see if fried oreos implement inotifpropchanged
        /// </summary>
        [Fact]
        public void FriedOreosShouldImplementINotifyPropertyChanged()
        {
            var friedOreos = new FriedOreos();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(friedOreos);
        }















        // TESTING ToString() Method:






        /// <summary>
        /// see if tostring works
        /// </summary>
        /// <param name="size">size</param>
        /// <param name="name">name</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Fried Oreos")]
        [InlineData(ServingSize.Medium, "Medium Fried Oreos")]
        [InlineData(ServingSize.Large, "Large Fried Oreos")]
        public void ToStringShouldReturnExpectedValue(ServingSize size, string name)
        {
            var friedOreos = new FriedOreos();
            friedOreos.Size = size;
            Assert.Equal(friedOreos.ToString(), name);
        }










    }
}

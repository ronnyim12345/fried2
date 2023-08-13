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
    /// Unit tests for fried bananas
    /// </summary>
    public class FriedBananasUnitTests
    {

        /// <summary>
        /// Sees if IMenuItem is being utilized
        /// </summary>
        [Fact]
        public void ShouldImplementIMenuItem()
        {
            var friedBananas = new FriedBananas();
            Assert.IsAssignableFrom<IMenuItem>(friedBananas);
        }




        /// <summary>
        /// Sees if Popper is being inherited
        /// </summary>
        [Fact]
        public void ShouldExtendPopper()
        {
            var friedBananas = new FriedBananas();
            Assert.IsAssignableFrom<Popper>(friedBananas);
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
            var friedBananas = new FriedBananas();
            friedBananas.Glazed = glazed;
            Assert.Equal(glazed, friedBananas.Glazed);
        }



        /// <summary>
        /// Sees if named correctly
        /// </summary>
        /// <param name="size">size of fried bananas</param>
        /// <param name="name">name of fried bananas</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Fried Bananas")]
        [InlineData(ServingSize.Medium, "Medium Fried Bananas")]
        [InlineData(ServingSize.Large, "Large Fried Bananas")]
        public void ShouldBeNamedCorrectly(ServingSize size, string name)
        {
            var friedBananas = new FriedBananas();
            friedBananas.Size = size;
            Assert.Equal(name, friedBananas.Name);
        }




        /// <summary>
        /// Sees if price is correct
        /// </summary>
        /// <param name="size">size of fried bananas</param>
        /// <param name="price">price of fried bananas</param>
        [Theory]
        [InlineData(ServingSize.Small, 3.75)]
        [InlineData(ServingSize.Medium, 4.5)]
        [InlineData(ServingSize.Large, 5.25)]
        public void ShouldHaveCorrectPrice(ServingSize size, decimal price)
        {
            var friedBananas = new FriedBananas();
            friedBananas.Size = size;
            Assert.Equal(price, friedBananas.Price);
        }


        /// <summary>
        /// Sees if calories are correct
        /// </summary>
        /// <param name="size">size of fried bananas</param>
        /// <param name="glazed">whether its glazed</param>
        /// <param name="calories">calories of fried bananas</param>
        [Theory]
        [InlineData(ServingSize.Small, true, 160+130)]
        [InlineData(ServingSize.Medium, true, 240+130)]
        [InlineData(ServingSize.Large, true, 320+130)]
        [InlineData(ServingSize.Small, false, 160)]
        [InlineData(ServingSize.Medium, false, 240)]
        [InlineData(ServingSize.Large, false, 320)]
        public void ShouldHaveCorrectCalories(ServingSize size, bool glazed, uint calories)
        {
            var friedBananas = new FriedBananas();
            friedBananas.Size = size;
            friedBananas.Glazed = glazed;
            Assert.Equal(calories, friedBananas.Calories);
        }









        // INotifyPropertyChanged TESTING:


        //  CHANGING SIZE:

        /// <summary>
        /// Notify size changed
        /// </summary>
        /// <param name="size">size</param>
        [Theory]
        [InlineData(ServingSize.Small)]
        [InlineData(ServingSize.Medium)]
        [InlineData(ServingSize.Large)]
        public void ChangingSizeShouldNotifyOfSizeChange(ServingSize size)
        {
            var friedBananas = new FriedBananas();
            Assert.PropertyChanged(friedBananas, "Size", () => {
                friedBananas.Size = size;
            });
        }

        /// <summary>
        /// Notify price changed
        /// </summary>
        /// <param name="size">size</param>
        [Theory]
        [InlineData(ServingSize.Small)]
        [InlineData(ServingSize.Medium)]
        [InlineData(ServingSize.Large)]
        public void ChangingSizeShouldNotifyOfPriceChange(ServingSize size)
        {
            var friedBananas = new FriedBananas();
            Assert.PropertyChanged(friedBananas, "Price", () => {
                friedBananas.Size = size;
            });
        }


        /// <summary>
        /// Notify calories changed
        /// </summary>
        /// <param name="size">size</param>
        [Theory]
        [InlineData(ServingSize.Small)]
        [InlineData(ServingSize.Medium)]
        [InlineData(ServingSize.Large)]
        public void ChangingSizeShouldNotifyOfCaloriesChange(ServingSize size)
        {
            var friedBananas = new FriedBananas();
            Assert.PropertyChanged(friedBananas, "Calories", () => {
                friedBananas.Size = size;
            });
        }



        /// <summary>
        /// Notify name changed
        /// </summary>
        /// <param name="size">size</param>
        [Theory]
        [InlineData(ServingSize.Small)]
        [InlineData(ServingSize.Medium)]
        [InlineData(ServingSize.Large)]
        public void ChangingSizeShouldNotifyOfNameChange(ServingSize size)
        {
            var friedBananas = new FriedBananas();
            Assert.PropertyChanged(friedBananas, "Name", () => {
                friedBananas.Size = size;
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
            var friedBananas = new FriedBananas();
            Assert.PropertyChanged(friedBananas, "Glazed", () => {
                friedBananas.Glazed = glazed;
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
            var friedBananas = new FriedBananas();
            Assert.PropertyChanged(friedBananas, "Calories", () => {
                friedBananas.Glazed = glazed;
            });
        }






        // IMPLEMENT INOTIFY ???


        /// <summary>
        /// if fried bananas implements inotifypropchanged
        /// </summary>
        [Fact]
        public void FriedBananasShouldImplementINotifyPropertyChanged()
        {
            var friedBananas = new FriedBananas();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(friedBananas);
        }






        // TESTING ToString() Method:



        /// <summary>
        /// if tostring returns name
        /// </summary>
        /// <param name="size">size</param>
        /// <param name="name">name</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Fried Bananas")]
        [InlineData(ServingSize.Medium, "Medium Fried Bananas")]
        [InlineData(ServingSize.Large, "Large Fried Bananas")]
        public void ToStringShouldReturnExpectedValue(ServingSize size, string name)
        {
            var friedBananas = new FriedBananas();
            friedBananas.Size = size;
            Assert.Equal(friedBananas.ToString(), name);
        }





    }
}

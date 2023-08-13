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
    /// Unit tests for fried cheesecake
    /// </summary>
    public class FriedCheesecakeUnitTests
    {
        /// <summary>
        /// Sees if IMenuItem is being utilized
        /// </summary>
        [Fact]
        public void ShouldImplementIMenuItem()
        {
            var friedCheesecake = new FriedCheesecake();
            Assert.IsAssignableFrom<IMenuItem>(friedCheesecake);
        }




        /// <summary>
        /// Sees if Popper is being inherited
        /// </summary>
        [Fact]
        public void ShouldExtendPopper()
        {
            var friedCheesecake = new FriedCheesecake();
            Assert.IsAssignableFrom<Popper>(friedCheesecake);
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
            var friedCheesecake = new FriedCheesecake();
            friedCheesecake.Glazed = glazed;
            Assert.Equal(glazed, friedCheesecake.Glazed);
        }



        /// <summary>
        /// Sees if named correctly
        /// </summary>
        /// <param name="size">size of fried cheesecake</param>
        /// <param name="name">name of fried cheesecake</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Fried Cheesecake")]
        [InlineData(ServingSize.Medium, "Medium Fried Cheesecake")]
        [InlineData(ServingSize.Large, "Large Fried Cheesecake")]
        public void ShouldBeNamedCorrectly(ServingSize size, string name)
        {
            var friedCheesecake = new FriedCheesecake();
            friedCheesecake.Size = size;
            Assert.Equal(name, friedCheesecake.Name);
        }



        /// <summary>
        /// Sees if price is correct
        /// </summary>
        /// <param name="size">size of fried cheesecake</param>
        /// <param name="price">price of fried cheesecake</param>
        [Theory]
        [InlineData(ServingSize.Small, 3.75)]
        [InlineData(ServingSize.Medium, 4.5)]
        [InlineData(ServingSize.Large, 5.25)]
        public void ShouldHaveCorrectPrice(ServingSize size, decimal price)
        {
            var friedCheesecake = new FriedCheesecake();
            friedCheesecake.Size = size;
            Assert.Equal(price, friedCheesecake.Price);
        }


        /// <summary>
        /// Sees if calories are correct
        /// </summary>
        /// <param name="size">size of fried cheesecake</param>
        /// <param name="glazed">whether its glazed</param>
        /// <param name="calories">calories of fried cheesecake</param>
        [Theory]
        [InlineData(ServingSize.Small, true, 310 + 130)]
        [InlineData(ServingSize.Medium, true, 425 + 130)]
        [InlineData(ServingSize.Large, true, 620 + 130)]
        [InlineData(ServingSize.Small, false, 310)]
        [InlineData(ServingSize.Medium, false, 425)]
        [InlineData(ServingSize.Large, false, 620)]
        public void ShouldHaveCorrectCalories(ServingSize size, bool glazed, uint calories)
        {
            var friedCheesecake = new FriedCheesecake();
            friedCheesecake.Size = size;
            friedCheesecake.Glazed = glazed;
            Assert.Equal(calories, friedCheesecake.Calories);
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
            var friedCheesecake = new FriedCheesecake();
            Assert.PropertyChanged(friedCheesecake, "Size", () => {
                friedCheesecake.Size = size;
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
            var friedCheesecake = new FriedCheesecake();
            Assert.PropertyChanged(friedCheesecake, "Price", () => {
                friedCheesecake.Size = size;
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
            var friedCheesecake = new FriedCheesecake();
            Assert.PropertyChanged(friedCheesecake, "Calories", () => {
                friedCheesecake.Size = size;
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
            var friedCheesecake = new FriedCheesecake();
            Assert.PropertyChanged(friedCheesecake, "Name", () => {
                friedCheesecake.Size = size;
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
            var friedCheesecake = new FriedCheesecake();
            Assert.PropertyChanged(friedCheesecake, "Glazed", () => {
                friedCheesecake.Glazed = glazed;
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
            var friedCheesecake = new FriedCheesecake();
            Assert.PropertyChanged(friedCheesecake, "Calories", () => {
                friedCheesecake.Glazed = glazed;
            });
        }










        // IMPLEMENT INOTIFY ???


        /// <summary>
        /// fried chee cake should implement inotifpropchanged
        /// </summary>
        [Fact]
        public void FriedCheesecakeShouldImplementINotifyPropertyChanged()
        {
            var friedCheesecake = new FriedCheesecake();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(friedCheesecake);
        }










        // TESTING ToString() Method:




        /// <summary>
        /// see if tostring works
        /// </summary>
        /// <param name="size">size</param>
        /// <param name="name">name</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Fried Cheesecake")]
        [InlineData(ServingSize.Medium, "Medium Fried Cheesecake")]
        [InlineData(ServingSize.Large, "Large Fried Cheesecake")]
        public void ToStringShouldReturnExpectedValue(ServingSize size, string name)
        {
            var friedCheesecake = new FriedCheesecake();
            friedCheesecake.Size = size;
            Assert.Equal(friedCheesecake.ToString(), name);
        }








    }
}

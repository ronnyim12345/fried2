using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FriedPiper.Data.Enums;
using FriedPiper.Data.MenuItems;
using System.ComponentModel;

namespace DataTests.UnitTests
{
    /// <summary>
    /// Units tests for fried twinkies
    /// </summary>
    public class FriedTwinkieUnitTests
    {
        /// <summary>
        /// Sees if IMenuItem is being utilized
        /// </summary>
        [Fact]
        public void ShouldImplementIMenuItem()
        {
            var friedTwinkie = new FriedTwinkie();
            Assert.IsAssignableFrom<IMenuItem>(friedTwinkie);
        }


        /// <summary>
        /// Sees if it is named correctly
        /// </summary>
        [Fact]
        public void ShouldBeNamedCorrectly()
        {
            var friedTwinkie = new FriedTwinkie();
            Assert.Equal("Fried Twinkie", friedTwinkie.Name);
        }

        /// <summary>
        /// Sees if price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPrice()
        {
            var friedTwinkie = new FriedTwinkie();
            Assert.Equal(2.25m, friedTwinkie.Price);
        }


        /// <summary>
        /// Sees if price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCalories()
        {
            var friedTwinkie = new FriedTwinkie();
            Assert.Equal((uint)420, friedTwinkie.Calories);
        }













        // IMPLEMENT INOTIFY ???


        /// <summary>
        /// See if popper platter implement INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void FriedTwinkieShouldImplementINotifyPropertyChanged()
        {
            var friedTwinkie = new FriedTwinkie();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(friedTwinkie);
        }







        // TESTING ToString() Method:


        /// <summary>
        /// see if to string works
        /// </summary>
        [Fact]
        public void ToStringShouldReturnExpectedValue()
        {
            var friedTwinkie = new FriedTwinkie();
            Assert.Equal("Fried Twinkie", friedTwinkie.ToString());
        }









    }
}

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
    /// Unit tests for Fried pie
    /// </summary>
    public class FriedPieUnitTests
    {



        /// <summary>
        /// Sees if IMenuItem is being utilized
        /// </summary>
        [Fact]
        public void ShouldImplementIMenuItem()
        {
            var friedPie = new FriedPie();
            Assert.IsAssignableFrom<IMenuItem>(friedPie);
        }


        /// <summary>
        /// Sees if flavor is able to be set
        /// </summary>
        /// <param name="flavor">flavor of pie</param>
        [Theory]
        [InlineData(PieFilling.Cherry)]
        [InlineData(PieFilling.Peach)]
        [InlineData(PieFilling.Apricot)]
        [InlineData(PieFilling.Pineapple)]
        [InlineData(PieFilling.Blueberry)]
        [InlineData(PieFilling.Apple)]
        [InlineData(PieFilling.Pecan)]
        public void ShouldBeAbleToSetPieFilling(PieFilling flavor)
        {
            var friedPie = new FriedPie();
            friedPie.Flavor = flavor;
            Assert.Equal(flavor, friedPie.Flavor);
        }





        /// <summary>
        /// Sees if flavor changes name accordingly
        /// </summary>
        /// <param name="flavor">flavor of pie</param>
        /// <param name="name">name of pie</param>
        [Theory]
        [InlineData(PieFilling.Cherry, "Fried Cherry Pie")]
        [InlineData(PieFilling.Peach, "Fried Peach Pie")]
        [InlineData(PieFilling.Apricot, "Fried Apricot Pie")]
        [InlineData(PieFilling.Pineapple, "Fried Pineapple Pie")]
        [InlineData(PieFilling.Blueberry, "Fried Blueberry Pie")]
        [InlineData(PieFilling.Apple, "Fried Apple Pie")]
        [InlineData(PieFilling.Pecan, "Fried Pecan Pie")]
        public void ShouldBeNamedCorrectly(PieFilling flavor, string name)
        {
            var friedPie = new FriedPie();
            friedPie.Flavor = flavor;
            Assert.Equal(name, friedPie.Name);
        }



        /// <summary>
        /// Sees if price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPrice()
        {
            var friedPie = new FriedPie();
            Assert.Equal(3.50m, friedPie.Price);
        }




        /// <summary>
        /// Sees if calories is correct
        /// </summary>
        /// <param name="flavor">pie filling</param>
        /// <param name="calories">calories of pie</param>
        [Theory]
        [InlineData(PieFilling.Cherry, 287)]
        [InlineData(PieFilling.Peach,  304)]
        [InlineData(PieFilling.Apricot, 314)]
        [InlineData(PieFilling.Pineapple, 302)]
        [InlineData(PieFilling.Blueberry, 314)]
        [InlineData(PieFilling.Apple, 289)]
        [InlineData(PieFilling.Pecan, 314)]
        public void ShouldHaveCorrectCalories(PieFilling flavor, uint calories)
        {
            var friedPie = new FriedPie();
            friedPie.Flavor = flavor;

            Assert.Equal(calories, friedPie.Calories);
        }












        // INotifyPropertyChanged TESTING:




        //  CHANGING FILLING:

        /// <summary>
        /// notify flavor changed
        /// </summary>
        /// <param name="pieFilling">piefilling</param>
        [Theory]
        [InlineData(PieFilling.Cherry)]
        [InlineData(PieFilling.Peach)]
        [InlineData(PieFilling.Apricot)]
        [InlineData(PieFilling.Pineapple)]
        [InlineData(PieFilling.Blueberry)]
        [InlineData(PieFilling.Apple)]
        [InlineData(PieFilling.Pecan)]
        public void ChangingSizeShouldNotifyOfFlavorChange(PieFilling pieFilling)
        {
            var friedPie = new FriedPie();
            Assert.PropertyChanged(friedPie, "Flavor", () => {
                friedPie.Flavor = pieFilling;
            });
        }

        /// <summary>
        /// notify name changed
        /// </summary>
        /// <param name="pieFilling">piefilling</param>
        [Theory]
        [InlineData(PieFilling.Cherry)]
        [InlineData(PieFilling.Peach)]
        [InlineData(PieFilling.Apricot)]
        [InlineData(PieFilling.Pineapple)]
        [InlineData(PieFilling.Blueberry)]
        [InlineData(PieFilling.Apple)]
        [InlineData(PieFilling.Pecan)]
        public void ChangingSizeShouldNotifyOfNameChange(PieFilling pieFilling)
        {
            var friedPie = new FriedPie();
            Assert.PropertyChanged(friedPie, "Name", () => {
                friedPie.Flavor = pieFilling;
            });
        }


        /// <summary>
        /// notify calories change
        /// </summary>
        /// <param name="pieFilling">piefilling</param>
        [Theory]
        [InlineData(PieFilling.Cherry)]
        [InlineData(PieFilling.Peach)]
        [InlineData(PieFilling.Apricot)]
        [InlineData(PieFilling.Pineapple)]
        [InlineData(PieFilling.Blueberry)]
        [InlineData(PieFilling.Apple)]
        [InlineData(PieFilling.Pecan)]
        public void ChangingSizeShouldNotifyOfCaloriesChange(PieFilling pieFilling)
        {
            var friedPie = new FriedPie();
            Assert.PropertyChanged(friedPie, "Calories", () => {
                friedPie.Flavor = pieFilling;
            });
        }








        // IMPLEMENT INOTIFY ???


        /// <summary>
        /// fried pie should implement inotifpropchanged
        /// </summary>
        [Fact]
        public void FriedPieShouldImplementINotifyPropertyChanged()
        {
            var friedPie = new FriedPie();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(friedPie);
        }




























        // TESTING ToString() Method:






        /// <summary>
        /// see if to string works
        /// </summary>
        /// <param name="flavor">flavor</param>
        /// <param name="name">name</param>
        [Theory]
        [InlineData(PieFilling.Cherry, "Fried Cherry Pie")]
        [InlineData(PieFilling.Peach, "Fried Peach Pie")]
        [InlineData(PieFilling.Apricot, "Fried Apricot Pie")]
        [InlineData(PieFilling.Pineapple, "Fried Pineapple Pie")]
        [InlineData(PieFilling.Blueberry, "Fried Blueberry Pie")]
        [InlineData(PieFilling.Apple, "Fried Apple Pie")]
        [InlineData(PieFilling.Pecan, "Fried Pecan Pie")]
        public void ToStringShouldReturnExpectedValue(PieFilling flavor, string name)
        {
            var friedPie = new FriedPie();
            friedPie.Flavor = flavor;
            Assert.Equal(friedPie.ToString(), name);
        }








    }
}

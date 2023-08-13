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
    /// Unit tests for Piper Platter
    /// </summary>
    public class PiperPlatterUnitTests
    {
        /// <summary>
        /// Sees if IMenuItem is being utilized
        /// </summary>
        [Fact]
        public void ShouldImplementIMenuItem()
        {
            var piperPlatter = new PiperPlatter();
            Assert.IsAssignableFrom<IMenuItem>(piperPlatter);
        }


        /// <summary>
        /// Sees if we can set left pie filling
        /// </summary>
        /// <param name="pieFilling">the filling</param>
        [Theory]
        [InlineData(PieFilling.Cherry)]
        [InlineData(PieFilling.Peach)]
        [InlineData(PieFilling.Apricot)]
        [InlineData(PieFilling.Pineapple)]
        [InlineData(PieFilling.Blueberry)]
        [InlineData(PieFilling.Apple)]
        [InlineData(PieFilling.Pecan)]
        public void ShouldBeAbleToSetLeftPieFilling(PieFilling pieFilling)
        {
            var piperPlatter = new PiperPlatter();
            piperPlatter.LeftPie.Flavor = pieFilling;
            Assert.Equal(pieFilling, piperPlatter.LeftPie.Flavor);
        }


        /// <summary>
        /// Sees if we can set right pie filling
        /// </summary>
        /// <param name="pieFilling">the filling</param>
        [Theory]
        [InlineData(PieFilling.Cherry)]
        [InlineData(PieFilling.Peach)]
        [InlineData(PieFilling.Apricot)]
        [InlineData(PieFilling.Pineapple)]
        [InlineData(PieFilling.Blueberry)]
        [InlineData(PieFilling.Apple)]
        [InlineData(PieFilling.Pecan)]
        public void ShouldBeAbleToSetRightPieFilling(PieFilling pieFilling)
        {
            var piperPlatter = new PiperPlatter();
            piperPlatter.RightPie.Flavor = pieFilling;
            Assert.Equal(pieFilling, piperPlatter.RightPie.Flavor);
        }



        /// <summary>
        /// Sees if we can set left ice cream flavor
        /// </summary>
        /// <param name="flavor">the flavor</param>
        [Theory]
        [InlineData(IceCreamFlavor.Vanilla)]
        [InlineData(IceCreamFlavor.Chocolate)]
        [InlineData(IceCreamFlavor.Strawberry)]

        public void ShouldBeAbleToSetLeftIceCreamFlavor(IceCreamFlavor flavor)
        {
            var piperPlatter = new PiperPlatter();
            piperPlatter.LeftIceCream.Flavor = flavor;
            Assert.Equal(flavor, piperPlatter.LeftIceCream.Flavor);
        }



        /// <summary>
        /// Sees if we can set right ice cream flavor
        /// </summary>
        /// <param name="flavor">the flavor</param>
        [Theory]
        [InlineData(IceCreamFlavor.Vanilla)]
        [InlineData(IceCreamFlavor.Chocolate)]
        [InlineData(IceCreamFlavor.Strawberry)]

        public void ShouldBeAbleToSetRightIceCreamFlavor(IceCreamFlavor flavor)
        {
            var piperPlatter = new PiperPlatter();
            piperPlatter.RightIceCream.Flavor = flavor;
            Assert.Equal(flavor, piperPlatter.RightIceCream.Flavor);
        }





        /// <summary>
        /// Sees if named correctly
        /// </summary>
        [Fact]
        public void ShouldBeNamedCorrectly()
        {
            var piperPlatter = new PiperPlatter();
            Assert.Equal("Piper Platter", piperPlatter.Name);
        }





        /// <summary>
        /// Sees if price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPrice()
        {
            var piperPlatter = new PiperPlatter();
            Assert.Equal(12.00m, piperPlatter.Price);
        }






        /// <summary>
        /// Sees if calories is correct
        /// </summary>
        /// <param name="leftPie">the left pie</param>
        /// <param name="rightPie">the right pie</param>
        /// <param name="leftIce">the left ice cream</param>
        /// <param name="rightIce">the right ice cream</param>
        /// <param name="calories">the calories of piper platter</param>
        [Theory]
        [InlineData(PieFilling.Cherry, PieFilling.Cherry, IceCreamFlavor.Vanilla,
            IceCreamFlavor.Vanilla, 287 + 287 + 355 + 355)]
        [InlineData(PieFilling.Peach, PieFilling.Cherry, IceCreamFlavor.Vanilla,
            IceCreamFlavor.Vanilla, 304 + 287 + 355 + 355)]
        [InlineData(PieFilling.Cherry, PieFilling.Peach, IceCreamFlavor.Vanilla,
            IceCreamFlavor.Vanilla, 287 + 304 + 355 + 355)]
        [InlineData(PieFilling.Cherry, PieFilling.Peach, IceCreamFlavor.Strawberry,
            IceCreamFlavor.Chocolate, 287 + 304 + 321 + 353)]
        [InlineData(PieFilling.Pecan, PieFilling.Pecan, IceCreamFlavor.Strawberry,
            IceCreamFlavor.Strawberry, 314 + 314 + 321 + 321)]
        [InlineData(PieFilling.Pecan, PieFilling.Apple, IceCreamFlavor.Strawberry,
            IceCreamFlavor.Strawberry, 314 + 289 + 321 + 321)]
        [InlineData(PieFilling.Pecan, PieFilling.Apple, IceCreamFlavor.Strawberry,
            IceCreamFlavor.Vanilla, 314 + 289 + 321 + 355)]
        [InlineData(PieFilling.Pecan, PieFilling.Apple, IceCreamFlavor.Chocolate,
            IceCreamFlavor.Vanilla, 314 + 289 + 353 + 355)]

        public void ShouldHaveCorrectCalories(PieFilling leftPie, PieFilling rightPie, IceCreamFlavor leftIce,
            IceCreamFlavor rightIce, uint calories)
        {
            var piperPlatter = new PiperPlatter();
            piperPlatter.LeftPie.Flavor = leftPie;
            piperPlatter.RightPie.Flavor = rightPie;
            piperPlatter.LeftIceCream.Flavor = leftIce;
            piperPlatter.RightIceCream.Flavor = rightIce;
            Assert.Equal(calories, piperPlatter.Calories);
        }












        // IMPLEMENT INOTIFY ???


        /// <summary>
        /// See if popper platter implement INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void PiperPlatterShouldImplementINotifyPropertyChanged()
        {
            var piperPlatter = new PiperPlatter();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(piperPlatter);
        }












        // TESTING ToString() Method:



        /// <summary>
        /// tests to string
        /// </summary>
        [Fact]
        public void ToStringShouldReturnExpectedValue()
        {
            var piperPlatter = new PiperPlatter();
            Assert.Equal("Piper Platter", piperPlatter.ToString());
        }







        // UNIT TESTING INOTIFPROP


        /// <summary>
        /// should notify left pie calories change
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
        public void ChangingLeftPieShouldNotifyOfCaloriesChange(PieFilling pieFilling)
        {
            var piperPlatter = new PiperPlatter();

            Assert.PropertyChanged(piperPlatter, "Calories", () => {
                piperPlatter.LeftPie.Flavor = pieFilling;
            });
        }




        /// <summary>
        /// should notify right pie calories change
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
        public void ChangingRightPieShouldNotifyOfCaloriesChange(PieFilling pieFilling)
        {
            var piperPlatter = new PiperPlatter();
            Assert.PropertyChanged(piperPlatter, "Calories", () => {
                piperPlatter.RightPie.Flavor = pieFilling;
            });
        }





        /// <summary>
        /// should notify left ice cream calories change
        /// </summary>
        /// <param name="flavor">flavor</param>
        [Theory]
        [InlineData(IceCreamFlavor.Vanilla)]
        [InlineData(IceCreamFlavor.Chocolate)]
        [InlineData(IceCreamFlavor.Strawberry)]
        public void ChangingLeftIceCreamShouldNotifyOfCaloriesChange(IceCreamFlavor flavor)
        {
            var piperPlatter = new PiperPlatter();
            Assert.PropertyChanged(piperPlatter, "Calories", () => {
                piperPlatter.LeftIceCream.Flavor = flavor;
            });
        }




        /// <summary>
        /// should notify right ice cream calories change
        /// </summary>
        /// <param name="flavor">flavor</param>
        [Theory]
        [InlineData(IceCreamFlavor.Vanilla)]
        [InlineData(IceCreamFlavor.Chocolate)]
        [InlineData(IceCreamFlavor.Strawberry)]
        public void ChangingRightIceCreamShouldNotifyOfCaloriesChange(IceCreamFlavor flavor)
        {
            var piperPlatter = new PiperPlatter();
            Assert.PropertyChanged(piperPlatter, "Calories", () => {
                piperPlatter.RightIceCream.Flavor = flavor;
            });
        }




    }
}

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
    /// Unit tests for fried candy bar
    /// </summary>
    public class FriedCandyBarUnitTests
    {


        /// <summary>
        /// Sees if IMenuItem is being utilized
        /// </summary>
        [Fact]
        public void ShouldImplementIMenuItem()
        {
            var friedCandyBar = new FriedCandyBar();
            Assert.IsAssignableFrom<IMenuItem>(friedCandyBar);
        }



        /// <summary>
        /// Sees if able to set candy bar
        /// </summary>
        /// <param name="type">type of candy bar</param>
        [Theory]
        [InlineData(CandyBar.Snickers)]
        [InlineData(CandyBar.MilkyWay)]
        [InlineData(CandyBar.Twix)]
        [InlineData(CandyBar.ThreeMusketeers)]
        [InlineData(CandyBar.ButterFingers)]
        public void ShouldBeAbleToSetCandyBar(CandyBar type)
        {
            var friedCandyBar = new FriedCandyBar();
            friedCandyBar.CandyBar = type;
            Assert.Equal(type, friedCandyBar.CandyBar);
        }




        /// <summary>
        /// Sees if it is named correctly
        /// </summary>
        /// <param name="type">type of candy bar</param>
        /// <param name="name">the name of fried candy bar</param>
        [Theory]
        [InlineData(CandyBar.Snickers, "Fried Snickers")]
        [InlineData(CandyBar.MilkyWay, "Fried Milky Way")]
        [InlineData(CandyBar.Twix, "Fried Twix")]
        [InlineData(CandyBar.ThreeMusketeers, "Fried Three Musketeers")]
        [InlineData(CandyBar.ButterFingers, "Fried Butter Fingers")]
        public void ShouldBeNamedCorrectly(CandyBar type, string name)
        {
            var friedCandyBar = new FriedCandyBar();
            friedCandyBar.CandyBar = type;
            Assert.Equal(name, friedCandyBar.Name);
        }




        /// <summary>
        /// Sees if price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPrice()
        {
            var friedCandyBar = new FriedCandyBar();
            Assert.Equal(2.50m, friedCandyBar.Price);
        }



        /// <summary>
        /// Sees if calories are correct
        /// </summary>
        /// <param name="type">type of candy bar</param>
        /// <param name="calories">calories of candy bar</param>
        [Theory]
        [InlineData(CandyBar.Snickers, 325)]
        [InlineData(CandyBar.MilkyWay, 213)]
        [InlineData(CandyBar.Twix, 396)]
        [InlineData(CandyBar.ThreeMusketeers, 350)]
        [InlineData(CandyBar.ButterFingers, 385)]
        public void ShouldHaveCorrectCalories(CandyBar type, uint calories)
        {
            var friedCandyBar = new FriedCandyBar();
            friedCandyBar.CandyBar = type;
            Assert.Equal(calories, friedCandyBar.Calories);
        }



















        // INotifyPropertyChanged TESTING:




        //  CHANGING FILLING:





        /// <summary>
        /// Notify flavor changed
        /// </summary>
        /// <param name="candyBar">candy bar</param>
        [Theory]
        [InlineData(CandyBar.Snickers)]
        [InlineData(CandyBar.MilkyWay)]
        [InlineData(CandyBar.Twix)]
        [InlineData(CandyBar.ThreeMusketeers)]
        [InlineData(CandyBar.ButterFingers)]
        public void ChangingCandyBarShouldNotifyOfFlavorChange(CandyBar candyBar)
        {
            var friedCandyBar = new FriedCandyBar();
            Assert.PropertyChanged(friedCandyBar, "CandyBAr", () => {
                friedCandyBar.CandyBar = candyBar;
            });
        }



        /// <summary>
        /// notify name changed
        /// </summary>
        /// <param name="candyBar">candy bar</param>
        [Theory]
        [InlineData(CandyBar.Snickers)]
        [InlineData(CandyBar.MilkyWay)]
        [InlineData(CandyBar.Twix)]
        [InlineData(CandyBar.ThreeMusketeers)]
        [InlineData(CandyBar.ButterFingers)]
        public void ChangingCandyBarShouldNotifyOfNameChange(CandyBar candyBar)
        {
            var friedCandyBar = new FriedCandyBar();
            Assert.PropertyChanged(friedCandyBar, "Name", () => {
                friedCandyBar.CandyBar = candyBar;
            });
        }


        /// <summary>
        /// notify calories changed
        /// </summary>
        /// <param name="candyBar">candy bar</param>
        [Theory]
        [InlineData(CandyBar.Snickers)]
        [InlineData(CandyBar.MilkyWay)]
        [InlineData(CandyBar.Twix)]
        [InlineData(CandyBar.ThreeMusketeers)]
        [InlineData(CandyBar.ButterFingers)]
        public void ChangingCandyBarShouldNotifyOfCaloriesChange(CandyBar candyBar)
        {
            var friedCandyBar = new FriedCandyBar();
            Assert.PropertyChanged(friedCandyBar, "Calories", () =>
            {
                friedCandyBar.CandyBar = candyBar;
            });
        }






        // IMPLEMENT INOTIFY ???


        /// <summary>
        /// candy bar should implement inotifypropchanged
        /// </summary>
        [Fact]
        public void FriedCandyBarShouldImplementINotifyPropertyChanged()
        {
            var friedCandyBar = new FriedCandyBar();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(friedCandyBar);
        }








        // TESTING ToString() Method:






        /// <summary>
        /// see if tostring works
        /// </summary>
        /// <param name="candyBar">candy bar</param>
        /// <param name="name">name</param>
        [Theory]
        [InlineData(CandyBar.Snickers, "Fried Snickers")]
        [InlineData(CandyBar.MilkyWay, "Fried Milky Way")]
        [InlineData(CandyBar.Twix, "Fried Twix")]
        [InlineData(CandyBar.ThreeMusketeers, "Fried Three Musketeers")]
        [InlineData(CandyBar.ButterFingers, "Fried Butter Fingers")]
        public void ToStringShouldReturnExpectedValue(CandyBar candyBar, string name)
        {
            var friedCandyBar = new FriedCandyBar();
            friedCandyBar.CandyBar = candyBar;
            Assert.Equal(friedCandyBar.ToString(), name);
        }













    }
}


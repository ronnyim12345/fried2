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
    /// Units tests for fried ice cream
    /// </summary>
    public class FriedIceCreamUnitTests
    {

        /// <summary>
        /// Sees if IMenuItem is being utilized
        /// </summary>
        [Fact]
        public void ShouldImplementIMenuItem()
        {
            var friedIceCream = new FriedIceCream();
            Assert.IsAssignableFrom<IMenuItem>(friedIceCream);
        }




        /// <summary>
        /// Sees if flavor is able to be set
        /// </summary>
        /// <param name="flavor">flavor of ice cream</param>
        [Theory]
        [InlineData(IceCreamFlavor.Vanilla)]
        [InlineData(IceCreamFlavor.Chocolate)]
        [InlineData(IceCreamFlavor.Strawberry)]
        public void ShouldBeAbleToSetIceCreamFlavor(IceCreamFlavor flavor)
        {
            var friedIceCream = new FriedIceCream();
            friedIceCream.Flavor = flavor;
            Assert.Equal(flavor, friedIceCream.Flavor);
        }





        /// <summary>
        /// Sees if flavor changes name accordingly
        /// </summary>
        /// <param name="flavor">flavor of ice cream</param>
        /// <param name="name">name of ice cream</param>
        [Theory]
        [InlineData(IceCreamFlavor.Vanilla, "Fried Vanilla Ice Cream")]
        [InlineData(IceCreamFlavor.Chocolate, "Fried Chocolate Ice Cream")]
        [InlineData(IceCreamFlavor.Strawberry, "Fried Strawberry Ice Cream")]
        public void ShouldBeNamedCorrectly(IceCreamFlavor flavor, string name)
        {
            var friedIceCream = new FriedIceCream();
            friedIceCream.Flavor = flavor;
            Assert.Equal(name, friedIceCream.Name);
        }



        /// <summary>
        /// Sees if price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPrice()
        {
            var friedIceCream = new FriedIceCream();
            Assert.Equal(3.50m, friedIceCream.Price);
        }




        /// <summary>
        /// Sees if calories is correct
        /// </summary>
        /// <param name="flavor">Ice Cream flavor</param>
        /// <param name="calories">calories of ice cream</param>
        [Theory]
        [InlineData(IceCreamFlavor.Vanilla, 355)]
        [InlineData(IceCreamFlavor.Chocolate, 353)]
        [InlineData(IceCreamFlavor.Strawberry, 321)]
        public void ShouldHaveCorrectCalories(IceCreamFlavor flavor, uint calories)
        {
            var friedIceCream = new FriedIceCream();
            friedIceCream.Flavor = flavor;
            Assert.Equal(calories, friedIceCream.Calories);
        }






        // INotifyPropertyChanged TESTING:




        //  CHANGING FILLING:

        /// <summary>
        /// notify flavor changed
        /// </summary>
        /// <param name="flavor">flavor</param>
        [Theory]
        [InlineData(IceCreamFlavor.Vanilla)]
        [InlineData(IceCreamFlavor.Chocolate)]
        [InlineData(IceCreamFlavor.Strawberry)]
        public void ChangingSizeShouldNotifyOfFlavorChange(IceCreamFlavor flavor)
        {
            var friedIceCream = new FriedIceCream();
            Assert.PropertyChanged(friedIceCream, "Flavor", () => {
                friedIceCream.Flavor = flavor;
            });
        }

        /// <summary>
        /// notify name changed
        /// </summary>
        /// <param name="flavor">flavor</param>
        [Theory]
        [InlineData(IceCreamFlavor.Vanilla)]
        [InlineData(IceCreamFlavor.Chocolate)]
        [InlineData(IceCreamFlavor.Strawberry)]
        public void ChangingSizeShouldNotifyOfNameChange(IceCreamFlavor flavor)
        {
            var friedIceCream = new FriedIceCream();
            Assert.PropertyChanged(friedIceCream, "Name", () => {
                friedIceCream.Flavor = flavor;
            });
        }


        /// <summary>
        /// notify calories changed
        /// </summary>
        /// <param name="flavor">flavor</param>
        [Theory]
        [InlineData(IceCreamFlavor.Vanilla)]
        [InlineData(IceCreamFlavor.Chocolate)]
        [InlineData(IceCreamFlavor.Strawberry)]
        public void ChangingSizeShouldNotifyOfCaloriesChange(IceCreamFlavor flavor)
        {
            var friedIceCream = new FriedIceCream();
            Assert.PropertyChanged(friedIceCream, "Calories", () => {
                friedIceCream.Flavor = flavor;
            });
        }








        // IMPLEMENT INOTIFY ???


        /// <summary>
        /// fried ice cream should implement inotifpropchanged
        /// </summary>
        [Fact]
        public void FriedIceCreamShouldImplementINotifyPropertyChanged()
        {
            var friedIceCream = new FriedIceCream();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(friedIceCream);
        }












        // TESTING ToString() Method:





        /// <summary>
        /// see if tostring works
        /// </summary>
        /// <param name="flavor">flavor</param>
        /// <param name="name">name</param>
        [Theory]
        [InlineData(IceCreamFlavor.Vanilla, "Fried Vanilla Ice Cream")]
        [InlineData(IceCreamFlavor.Chocolate, "Fried Chocolate Ice Cream")]
        [InlineData(IceCreamFlavor.Strawberry, "Fried Strawberry Ice Cream")]
        public void ToStringShouldReturnExpectedValue(IceCreamFlavor flavor, string name)
        {
            var friedIceCream = new FriedIceCream();
            friedIceCream.Flavor = flavor;
            Assert.Equal(friedIceCream.ToString(), name);
        }













    }
}

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
    /// Unit tests for popper platter
    /// </summary>
    public class PopperPlatterUnitTests
    {
        /// <summary>
        /// Sees if IMenuItem is being utilized
        /// </summary>
        [Fact]
        public void ShouldImplementIMenuItem()
        {

            var popperPlatter = new PopperPlatter();
            Assert.IsAssignableFrom<IMenuItem>(popperPlatter);

        }


        /// <summary>
        /// Sees if size is "set"-able
        /// </summary>
        /// <param name="size">the size of popper platter</param>
        [Theory]
        [InlineData(ServingSize.Small)]
        [InlineData(ServingSize.Medium)]
        [InlineData(ServingSize.Large)]
        public void ShouldBeAbleToSetSize(ServingSize size)
        {
            var popperPlatter = new PopperPlatter();
            popperPlatter.Size = size;
            Assert.Equal(size, popperPlatter.Size);

        }


        /// <summary>
        /// Sees if size is sets individual poppers
        /// </summary>
        /// <param name="size">the size of popper platter</param>
        [Theory]
        [InlineData(ServingSize.Small)]
        [InlineData(ServingSize.Medium)]
        [InlineData(ServingSize.Large)]
        public void SettingSizeShouldAlsoSetPopperSize(ServingSize size)
        {
            var popperPlatter = new PopperPlatter();
            popperPlatter.Size = size;
            Assert.Equal(size, popperPlatter.AppleFritters.Size);
            Assert.Equal(size, popperPlatter.FriedBananas.Size);
            Assert.Equal(size, popperPlatter.FriedCheesecake.Size);
            Assert.Equal(size, popperPlatter.FriedOreos.Size);


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
            var popperPlatter = new PopperPlatter();
            popperPlatter.Glazed = glazed;
            Assert.Equal(glazed, popperPlatter.Glazed);
        }



        /// <summary>
        /// Sees if making glazed true, makes individual poppers glazed
        /// </summary>
        /// <param name="glazed">whether its glazed</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]

        public void SettingGlazedShouldAlsoSetPopperGlazed(bool glazed)
        {
            var popperPlatter = new PopperPlatter();
            popperPlatter.Glazed = glazed;
            Assert.Equal(glazed, popperPlatter.AppleFritters.Glazed);
            Assert.Equal(glazed, popperPlatter.FriedBananas.Glazed);
            Assert.Equal(glazed, popperPlatter.FriedCheesecake.Glazed);
            Assert.Equal(glazed, popperPlatter.FriedOreos.Glazed);


        }



        /// <summary>
        /// Sees if its named correctly
        /// </summary>
        /// <param name="size">size of popper platter</param>
        /// <param name="name">name of popper plattter</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small")]
        [InlineData(ServingSize.Medium, "Medium")]
        [InlineData(ServingSize.Large, "Large")]
        public void ShouldBeNamedCorrectly(ServingSize size, string name)
        {
            var popperPlatter = new PopperPlatter();
            popperPlatter.Size = size;
            Assert.Equal(name + " Popper Platter", popperPlatter.Name);
        }




        /// <summary>
        /// Sees if price is correct
        /// </summary>
        /// <param name="size">size of the popper platter</param>
        /// <param name="price">price of the popper platter</param>
        [Theory]
        [InlineData(ServingSize.Small, 12)]
        [InlineData(ServingSize.Medium, 16)]
        [InlineData(ServingSize.Large, 20)]
        public void ShouldHaveCorrectPrice(ServingSize size, decimal price)
        {
            var popperPlatter = new PopperPlatter();
            popperPlatter.Size = size;
            Assert.Equal(price, popperPlatter.Price);
        }




        /// <summary>
        /// Sees if calories is correct.
        /// </summary>
        /// <param name="size">size of popper platter</param>
        /// <param name="glazed">whether its glazed</param>
        /// <param name="calories">calories of popper platter</param>
        [Theory]
        [InlineData(ServingSize.Small, true, 240 + 160 + 500 + 310 + 130 * 4)]
        [InlineData(ServingSize.Medium, true, 360 + 240 + 750 + 425 + 130 * 4)]
        [InlineData(ServingSize.Large, true, 480 + 320 + 1000 + 620 + 130 * 4)]
        [InlineData(ServingSize.Small, false, 240 + 160 + 500 + 310)]
        [InlineData(ServingSize.Medium, false, 360 + 240 + 750 + 425)]
        [InlineData(ServingSize.Large, false, 480 + 320 + 1000 + 620)]
        public void ShouldHaveCorrectCalories(ServingSize size, bool glazed, decimal calories)
        {
            var popperPlatter = new PopperPlatter();
            popperPlatter.Size = size;
            popperPlatter.Glazed = glazed;
            Assert.Equal(calories, popperPlatter.Calories);
        }














        // INotifyPropertyChanged TESTING:




        //  CHANGING SIZE:

        /// <summary>
        /// Notify if size changed
        /// </summary>
        /// <param name="size">size</param>
        [Theory]
        [InlineData(ServingSize.Small)]
        [InlineData(ServingSize.Medium)]
        [InlineData(ServingSize.Large)]
        public void ChangingSizeShouldNotifyOfSizeChange(ServingSize size)
        {
            var popperPlatter = new PopperPlatter();
            Assert.PropertyChanged(popperPlatter, "Size", () => {
                popperPlatter.Size = size;
            });
        }

        /// <summary>
        /// Notify if price changed
        /// </summary>
        /// <param name="size">size</param>
        [Theory]
        [InlineData(ServingSize.Small)]
        [InlineData(ServingSize.Medium)]
        [InlineData(ServingSize.Large)]
        public void ChangingSizeShouldNotifyOfPriceChange(ServingSize size)
        {
            var popperPlatter = new PopperPlatter();
            Assert.PropertyChanged(popperPlatter, "Price", () => {
                popperPlatter.Size = size;
            });
        }


        /// <summary>
        /// Notify if calories changed
        /// </summary>
        /// <param name="size">size</param>
        [Theory]
        [InlineData(ServingSize.Small)]
        [InlineData(ServingSize.Medium)]
        [InlineData(ServingSize.Large)]
        public void ChangingSizeShouldNotifyOfCaloriesChange(ServingSize size)
        {
            var popperPlatter = new PopperPlatter();
            Assert.PropertyChanged(popperPlatter, "Calories", () => {
                popperPlatter.Size = size;
            });
        }



        /// <summary>
        /// Notify if Name changed
        /// </summary>
        /// <param name="size">size</param>
        [Theory]
        [InlineData(ServingSize.Small)]
        [InlineData(ServingSize.Medium)]
        [InlineData(ServingSize.Large)]
        public void ChangingSizeShouldNotifyOfNameChange(ServingSize size)
        {
            var popperPlatter = new PopperPlatter();
            Assert.PropertyChanged(popperPlatter, "Name", () => {
                popperPlatter.Size = size;
            });
        }














        //  CHANGING GLAZED:

        /// <summary>
        /// Notify if glazed changed
        /// </summary>
        /// <param name="glazed">glazed</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingGlazedShouldNotifyOfGlazedChange(bool glazed)
        {
            var popperPlatter = new PopperPlatter();
            Assert.PropertyChanged(popperPlatter, "Glazed", () => {
                popperPlatter.Glazed = glazed;
            });
        }

        /// <summary>
        /// Notify if calories changed
        /// </summary>
        /// <param name="glazed">glazed</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingGlazedShouldNotifyOfCaloriesChange(bool glazed)
        {
            var popperPlatter = new PopperPlatter();
            Assert.PropertyChanged(popperPlatter, "Calories", () => {
                popperPlatter.Glazed = glazed;
            });
        }







        // IMPLEMENT INOTIFY ???


        /// <summary>
        /// See if popper platter implement INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void PopperPlatterShouldImplementINotifyPropertyChanged()
        {
            var popperPlatter = new PopperPlatter();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(popperPlatter);
        }








        // TESTING ToString() Method:



        /// <summary>
        /// see if to string works
        /// </summary>
        /// <param name="size">size</param>
        /// <param name="name">name</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Popper Platter")]
        [InlineData(ServingSize.Medium, "Medium Popper Platter")]
        [InlineData(ServingSize.Large, "Large Popper Platter")]
        public void ToStringShouldReturnExpectedValue(ServingSize size, string name)
        {
            var popperPlatter = new PopperPlatter();
            popperPlatter.Size = size;
            Assert.Equal(popperPlatter.ToString(), name);
        }










    }
}

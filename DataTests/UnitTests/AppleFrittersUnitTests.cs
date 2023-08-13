using System;
using Xunit;
using FriedPiper.Data.MenuItems;
using FriedPiper.Data.Enums;
using System.ComponentModel;

namespace DataTests.UnitTests
{
    /// <summary>
    /// These are the unit tests for Apple Fritters
    /// </summary>
    public class AppleFrittersUnitTests
    {
        /// <summary>
        /// Sees if size is adjustable; changes name accordingly
        /// </summary>
        /// <param name="size">size of apple fritters</param>
        /// <param name="name">name of apple fritters</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Apple Fritters")]
        [InlineData(ServingSize.Medium, "Medium Apple Fritters")]
        [InlineData(ServingSize.Large, "Large Apple Fritters")]
        public void ShouldBeAbleToSetSize(ServingSize size, string name)
        {
            var fritters = new AppleFritters();
            fritters.Size = size;
            Assert.Equal(name, fritters.Name);
        }




        /// <summary>
        /// Sees if Calories is correct
        /// </summary>
        /// <param name="size">Size of apple fritter</param>
        /// <param name="glazed">whether its glazed</param>
        /// <param name="calories">calories of apple fritters</param>
        [Theory]
        [InlineData(ServingSize.Small, true, 370)]
        [InlineData(ServingSize.Medium, true, 490)]
        [InlineData(ServingSize.Large, true, 610)]
        [InlineData(ServingSize.Small, false, 240)]
        [InlineData(ServingSize.Medium, false, 360)]
        [InlineData(ServingSize.Large, false, 480)]
        public void CaloriesShouldBeCorrect(ServingSize size, bool glazed, uint calories)
        {
            var appleFritters = new AppleFritters();
            appleFritters.Size = size;
            appleFritters.Glazed = glazed;
            Assert.Equal(calories, appleFritters.Calories);
        }



        /// <summary>
        /// Sees if price is correct
        /// </summary>
        /// <param name="size">size of apple fritter</param>
        /// <param name="price">price of apple fritter</param>
        [Theory]
        [InlineData(ServingSize.Small, 3)]
        [InlineData(ServingSize.Medium, 4)]
        [InlineData(ServingSize.Large, 5)]
        public void PriceShouldBeCorrect(ServingSize size, decimal price)
        {
            var appleFritters = new AppleFritters();
            appleFritters.Size = size;
            Assert.Equal(price, appleFritters.Price);
        }




        /// <summary>
        /// Sees if IMenuItem is being utilized
        /// </summary>
        [Fact]
        public void ShouldImplementIMenuItem()
        {
            var fritters = new AppleFritters();
            Assert.IsAssignableFrom<IMenuItem>(fritters);
        }


        /// <summary>
        /// Sees if Popper is being inherited
        /// </summary>
        [Fact]
        public void ShouldExtendPopper()
        {
            var fritters = new AppleFritters();
            Assert.IsAssignableFrom<Popper>(fritters);
        }






        // EXTRA TESTING:

        /// <summary>
        /// Sees if glazed is true by default
        /// </summary>
        [Fact]
        public void ShouldBeGlazedByDefault()
        {
            var appleFritters = new AppleFritters();
            Assert.True(appleFritters.Glazed);
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
            var appleFritters = new AppleFritters();
            appleFritters.Glazed = glazed;
            Assert.Equal(glazed, appleFritters.Glazed);
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
            var appleFritters = new AppleFritters();
            Assert.PropertyChanged(appleFritters, "Size", () => {
                appleFritters.Size = size;
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
            var appleFritters = new AppleFritters();
            Assert.PropertyChanged(appleFritters, "Price", () => {
                appleFritters.Size = size;
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
            var appleFritters = new AppleFritters();
            Assert.PropertyChanged(appleFritters, "Calories", () => {
                appleFritters.Size = size;
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
            var appleFritters = new AppleFritters();
            Assert.PropertyChanged(appleFritters, "Name", () => {
                appleFritters.Size = size;
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
            var appleFritters = new AppleFritters();
            Assert.PropertyChanged(appleFritters, "Glazed", () => {
                appleFritters.Glazed = glazed;
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
            var appleFritters = new AppleFritters();
            Assert.PropertyChanged(appleFritters, "Calories", () => {
                appleFritters.Glazed = glazed;
            });
        }










        // IMPLEMENT INOTIFY ???


        /// <summary>
        /// See if apple frit implement INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void AppleFrittersShouldImplementINotifyPropertyChanged()
        {
            var appleFritters = new AppleFritters();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(appleFritters);
        }













        // TESTING ToString() Method:
      





        /// <summary>
        /// See if ToString works
        /// </summary>
        /// <param name="size">size</param>
        /// <param name="name">name</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Apple Fritters")]
        [InlineData(ServingSize.Medium, "Medium Apple Fritters")]
        [InlineData(ServingSize.Large, "Large Apple Fritters")]
        public void ToStringShouldReturnExpectedValue(ServingSize size, string name)
        {
            var appleFritters = new AppleFritters();
            appleFritters.Size = size;
            Assert.Equal(appleFritters.ToString(), name);
        }




    }
}

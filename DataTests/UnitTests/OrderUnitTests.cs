using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FriedPiper.Data.MenuItems;
using FriedPiper.Data.Enums;
using FriedPiper.Data;
using System.ComponentModel;
using System.Collections;
using System.Collections.Specialized;


namespace DataTests.UnitTests
{
    /// <summary>
    /// Unit tests for Order
    /// </summary>
    public class OrderUnitTests
    {
        


        /// <summary>
        /// Sees if item adds
        /// </summary>
        [Fact]
        public void AddingItemResultsInItemBeingIncluded()
        {

            var order = new Order();
            var fb = new FriedBananas();
            order.Add(fb);
            Assert.Contains(fb, order);

        }



        /// <summary>
        /// Sees if item is removed
        /// </summary>
        [Fact]
        public void RemovingItemResultsInItemNotBeingIncluded()
        {

            var order = new Order();
            var fb = new FriedBananas();
            order.Add(fb);
            order.Remove(fb);
            Assert.DoesNotContain(fb, order);


        }


        /// <summary>
        /// Sees if INotifyCollectionChanged
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyCollectionChanged()
        {

            var order = new Order();
            Assert.IsAssignableFrom<INotifyCollectionChanged>(order);

        }




        /// <summary>
        /// Sees if INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {

            var order = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);

        }


        /// <summary>
        /// Sees if adding notifies subtotal change
        /// </summary>
        [Fact]
        public void AddingItemNotifiesSubtotalChange()
        {

            var order = new Order();
            var fb = new FriedBananas();
            Assert.PropertyChanged(order, "Subtotal", () => {
                order.Add(fb);
            });

        }


        /// <summary>
        /// Sees if adding notifies tax change
        /// </summary>
        [Fact]
        public void AddingItemNotifiesTaxChange()
        {

            var order = new Order();
            var fb = new FriedBananas();
            Assert.PropertyChanged(order, "Tax", () => {
                order.Add(fb);
            });

        }



        /// <summary>
        /// Sees if adding notifies total change
        /// </summary>
        [Fact]
        public void AddingItemNotifiesTotalChange()
        {

            var order = new Order();
            var fb = new FriedBananas();
            Assert.PropertyChanged(order, "Total", () => {
                order.Add(fb);
            });

        }



        /// <summary>
        /// Sees if adding notifies calories change
        /// </summary>
        [Fact]
        public void AddingItemNotifiesCaloriesChange()
        {

            var order = new Order();
            var fb = new FriedBananas();
            Assert.PropertyChanged(order, "Calories", () => {
                order.Add(fb);
            });

        }







        /// <summary>
        /// Sees if removing notifies calories change
        /// </summary>
        [Fact]
        public void RemovingItemNotifiesSubtotalChange()
        {

            var order = new Order();
            var fb = new FriedBananas();
            order.Add(fb);
            Assert.PropertyChanged(order, "Subtotal", () => {
                order.Remove(fb);
            });

        }






        /// <summary>
        /// Sees if removing notifies tax change
        /// </summary>
        [Fact]
        public void RemovingItemNotifiesTaxChange()
        {

            var order = new Order();
            var fb = new FriedBananas();
            order.Add(fb);
            Assert.PropertyChanged(order, "Tax", () => {
                order.Remove(fb);
            });

        }



        /// <summary>
        /// Sees if removing notifies total change
        /// </summary>
        [Fact]
        public void RemovingItemNotifiesTotalChange()
        {

            var order = new Order();
            var fb = new FriedBananas();
            Assert.PropertyChanged(order, "Total", () => {
                order.Remove(fb);
            });

        }




        /// <summary>
        /// Sees if removing notifies calories change
        /// </summary>
        [Fact]
        public void RemovingItemNotifiesCaloriesChange()
        {

            var order = new Order();
            var fb = new FriedBananas();
            Assert.PropertyChanged(order, "Calories", () => {
                order.Remove(fb);
            });

        }





    }
}
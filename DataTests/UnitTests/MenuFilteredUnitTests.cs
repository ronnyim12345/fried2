using System;
using Xunit;
using FriedPiper.Data.MenuItems;
using FriedPiper.Data.Enums;
using FriedPiper.Data;
using System.ComponentModel;
using System.Linq;

namespace DataTests.UnitTests
{
    /// <summary>
    /// These are the unit tests for Menu
    /// </summary>
    public class MenuFilteredUnitTests
    {

        // SEARCHING TREATS


        /// <summary>
        /// Treats searching terms work
        /// </summary>
        [Fact]
        public void SearchingTreatsWorks_SearchTerm()
        {
            MenuFiltered mf = new MenuFiltered();

            mf.SearchTreats("cheRRy", 0, 5000, 0, 100);

            Assert.Collection(mf.Treats,

                item =>
                {
                    var it = (FriedPie)item;
                    Assert.Equal(PieFilling.Cherry, it.Flavor);
                });
                

        }



        /// <summary>
        /// Treats searching cal works
        /// </summary>
        [Fact]
        public void SearchingTreatsWorks_Calories()
        {
            MenuFiltered mf = new MenuFiltered();

            mf.SearchTreats(null, 420, 5000, 0, 100);

            Assert.Collection(mf.Treats,

                item =>
                {
                    Assert.Equal("Fried Twinkie", item.Name);
                });


        }



        /// <summary>
        /// Treats searching price works
        /// </summary>
        [Fact]
        public void SearchingTreatsWorks_Prices()
        {
            MenuFiltered mf = new MenuFiltered();

            mf.SearchTreats(null, 420, 5000, 0, 2.25m);

            Assert.Collection(mf.Treats,

                item =>
                {
                    Assert.Equal("Fried Twinkie", item.Name);
                });


        }










        // SEARCHING POPPERS


        /// <summary>
        /// Poppers searching terms work
        /// </summary>
        [Fact]
        public void SearchingPoppersWorks_SearchTerm()
        {
            MenuFiltered mf = new MenuFiltered();

            mf.SearchPoppers("apple small", 0, 5000, 0, 100);

            Assert.Collection(mf.Poppers,

                // APPLEFRITTERS

                item =>
                {
                    var it = (AppleFritters)item;
                    Assert.Equal(ServingSize.Small, it.Size);
                    Assert.True(it.Glazed);
                },
                item =>
                {
                    var it = (AppleFritters)item;
                    Assert.Equal(ServingSize.Medium, it.Size);
                    Assert.True(it.Glazed);
                },
                item =>
                {
                    var it = (AppleFritters)item;
                    Assert.Equal(ServingSize.Large, it.Size);
                    Assert.True(it.Glazed);
                },
                item =>
                {
                    var it = (AppleFritters)item;
                    Assert.Equal(ServingSize.Small, it.Size);
                    Assert.False(it.Glazed);
                },
                item =>
                {
                    var it = (AppleFritters)item;
                    Assert.Equal(ServingSize.Medium, it.Size);
                    Assert.False(it.Glazed);
                },
                item =>
                {
                    var it = (AppleFritters)item;
                    Assert.Equal(ServingSize.Large, it.Size);
                    Assert.False(it.Glazed);
                },



                // THE REST OF "SMALL"


                item =>
                {
                    var it = (FriedBananas)item;
                    Assert.Equal(ServingSize.Small, it.Size);
                    Assert.True(it.Glazed);
                },
                item =>
                {
                    var it = (FriedBananas)item;
                    Assert.Equal(ServingSize.Small, it.Size);
                    Assert.False(it.Glazed);
                },




                item =>
                {
                    var it = (FriedCheesecake)item;
                    Assert.Equal(ServingSize.Small, it.Size);
                    Assert.True(it.Glazed);
                },
                item =>
                {
                    var it = (FriedCheesecake)item;
                    Assert.Equal(ServingSize.Small, it.Size);
                    Assert.False(it.Glazed);
                },




                item =>
                {
                    var it = (FriedOreos)item;
                    Assert.Equal(ServingSize.Small, it.Size);
                    Assert.True(it.Glazed);
                },
                item =>
                {
                    var it = (FriedOreos)item;
                    Assert.Equal(ServingSize.Small, it.Size);
                    Assert.False(it.Glazed);
                }




                );


        }





        /// <summary>
        /// Poppers searching cal works
        /// </summary>
        [Fact]
        public void SearchingPoppersWorks_Calories()
        {
            MenuFiltered mf = new MenuFiltered();

            mf.SearchPoppers(null, 1130, 5000, 0, 100);

            Assert.Collection(mf.Poppers,

                item =>
                {
                    var it = (FriedOreos)item;
                    Assert.Equal(ServingSize.Large, it.Size);
                    Assert.True(it.Glazed);
                });


        }






        /// <summary>
        /// Poppers searching price works
        /// </summary>
        [Fact]
        public void SearchingPoppersWorks_Prices()
        {
            MenuFiltered mf = new MenuFiltered();

            mf.SearchPoppers(null, 0, 5000, 0, 3m);

            Assert.Collection(mf.Poppers,

                 item =>
                 {
                     var it = (AppleFritters)item;
                     Assert.Equal(ServingSize.Small, it.Size);
                     Assert.True(it.Glazed);
                 },
                item =>
                {
                    var it = (AppleFritters)item;
                    Assert.Equal(ServingSize.Small, it.Size);
                    Assert.False(it.Glazed);
                });


        }












        // SEARCHING PLATTERS


        /// <summary>
        /// Platters searching terms works
        /// </summary>
        [Fact]
        public void SearchingPlattersWorks_SearchTerm()
        {
            MenuFiltered mf = new MenuFiltered();

            mf.SearchPlatters("popper", 0, 5000, 0, 100m);




            // POPPER PLATTERS

            // GLAZED:

            for (int m = 0; m < 3; m++)
            {
                Assert.Contains(mf.Platters, item =>
                {
                    if (item is PopperPlatter pop)
                    {
                        if (pop.Size == (ServingSize)m
                            && pop.Glazed)
                        {
                            return true;
                        }

                    }
                    return false;
                });
            }

            // NOT GLAZED:

            for (int m = 0; m < 3; m++)
            {
                Assert.Contains(mf.Platters, item =>
                {
                    if (item is PopperPlatter pop)
                    {
                        if (pop.Size == (ServingSize)m
                            && pop.Glazed == false)
                        {
                            return true;
                        }

                    }
                    return false;
                });
            }

        }




        /// <summary>
        /// platters searching calories works
        /// </summary>
        [Fact]
        public void SearchingPlattersWorks_Calories()
        {
            MenuFiltered mf = new MenuFiltered();

            mf.SearchPlatters(null, 2940, 5000, 0, 100m);

            Assert.Collection(mf.Platters,

               item =>
               {
                   var it = (PopperPlatter)item;
                   Assert.Equal(ServingSize.Large, it.Size);
                   Assert.True(it.Glazed);
               });


        }










        /// <summary>
        /// platters searching prices works
        /// </summary>
        [Fact]
        public void SearchingPlattersWorks_Prices()
        {
            MenuFiltered mf = new MenuFiltered();

            mf.SearchPlatters(null, 0, 5000, 20m, 100m);

            Assert.Collection(mf.Platters,

                 item =>
                 {
                     var it = (PopperPlatter)item;
                     Assert.Equal(ServingSize.Large, it.Size);
                     Assert.True(it.Glazed);
                 },
                item =>
                {
                    var it = (PopperPlatter)item;
                    Assert.Equal(ServingSize.Large, it.Size);
                    Assert.False(it.Glazed);
                });


        }




    }
}
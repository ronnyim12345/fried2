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
    public class MenuUnitTests
    {

        // COUNTING:


        /// <summary>
        /// Sees if Poppers has 24 items
        /// </summary>
        [Fact]
        public void PoppersHas24Items()
        {
            Assert.Equal(24, Menu.Poppers.Count());
        }

        /// <summary>
        /// Sees if Treats has 16 items
        /// </summary>
        [Fact]
        public void TreatsHas16Items()
        {
            Assert.Equal(16, Menu.Treats.Count());
        }

        /// <summary>
        /// Sees if Platters has 447 items
        /// </summary>
        [Fact]
        public void PlattersHas447Items()
        {
            Assert.Equal(447, Menu.Platters.Count());
        }

        /// <summary>
        /// Sees if Full Menu has 487 items
        /// </summary>
        [Fact]
        public void FullMenuHas487Items()
        {
            Assert.Equal(487, Menu.FullMenu.Count());
        }






        // EVERY COMBINATIONS:



        // POPPERS


        /// <summary>
        /// Poppers has every combination
        /// </summary>
        [Fact]
        public void PoppersHasEveryCombination()
        {
            Assert.Collection(Menu.Poppers,

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


                // FRIED BANANAS

                item =>
                {
                    var it = (FriedBananas)item;
                    Assert.Equal(ServingSize.Small, it.Size);
                    Assert.True(it.Glazed);
                },
                item =>
                {
                    var it = (FriedBananas)item;
                    Assert.Equal(ServingSize.Medium, it.Size);
                    Assert.True(it.Glazed);
                },
                item =>
                {
                    var it = (FriedBananas)item;
                    Assert.Equal(ServingSize.Large, it.Size);
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
                    var it = (FriedBananas)item;
                    Assert.Equal(ServingSize.Medium, it.Size);
                    Assert.False(it.Glazed);
                },
                item =>
                {
                    var it = (FriedBananas)item;
                    Assert.Equal(ServingSize.Large, it.Size);
                    Assert.False(it.Glazed);
                },


                // FRIED CHEESECAKE

                item =>
                {
                    var it = (FriedCheesecake)item;
                    Assert.Equal(ServingSize.Small, it.Size);
                    Assert.True(it.Glazed);
                },
                item =>
                {
                    var it = (FriedCheesecake)item;
                    Assert.Equal(ServingSize.Medium, it.Size);
                    Assert.True(it.Glazed);
                },
                item =>
                {
                    var it = (FriedCheesecake)item;
                    Assert.Equal(ServingSize.Large, it.Size);
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
                    var it = (FriedCheesecake)item;
                    Assert.Equal(ServingSize.Medium, it.Size);
                    Assert.False(it.Glazed);
                },
                item =>
                {
                    var it = (FriedCheesecake)item;
                    Assert.Equal(ServingSize.Large, it.Size);
                    Assert.False(it.Glazed);
                },


                // FRIED OREOS

                item =>
                {
                    var it = (FriedOreos)item;
                    Assert.Equal(ServingSize.Small, it.Size);
                    Assert.True(it.Glazed);
                },
                item =>
                {
                    var it = (FriedOreos)item;
                    Assert.Equal(ServingSize.Medium, it.Size);
                    Assert.True(it.Glazed);
                },
                item =>
                {
                    var it = (FriedOreos)item;
                    Assert.Equal(ServingSize.Large, it.Size);
                    Assert.True(it.Glazed);
                },
                item =>
                {
                    var it = (FriedOreos)item;
                    Assert.Equal(ServingSize.Small, it.Size);
                    Assert.False(it.Glazed);
                },
                item =>
                {
                    var it = (FriedOreos)item;
                    Assert.Equal(ServingSize.Medium, it.Size);
                    Assert.False(it.Glazed);
                },
                item =>
                {
                    var it = (FriedOreos)item;
                    Assert.Equal(ServingSize.Large, it.Size);
                    Assert.False(it.Glazed);
                }
           );
        }






        // TREATS

        /// <summary>
        /// Treats has every combination
        /// </summary>
        [Fact]
        public void TreatsHasEveryCombination()
        {
            Assert.Collection(Menu.Treats,

                // FRIED PIE

                item =>
                {
                    var it = (FriedPie)item;
                    Assert.Equal(PieFilling.Cherry, it.Flavor);
                },
                item =>
                {
                    var it = (FriedPie)item;
                    Assert.Equal(PieFilling.Peach, it.Flavor);
                },
                item =>
                {
                    var it = (FriedPie)item;
                    Assert.Equal(PieFilling.Apricot, it.Flavor);
                },
                item =>
                {
                    var it = (FriedPie)item;
                    Assert.Equal(PieFilling.Pineapple, it.Flavor);
                },
                item =>
                {
                    var it = (FriedPie)item;
                    Assert.Equal(PieFilling.Blueberry, it.Flavor);
                },
                item =>
                {
                    var it = (FriedPie)item;
                    Assert.Equal(PieFilling.Apple, it.Flavor);
                },
                item =>
                {
                    var it = (FriedPie)item;
                    Assert.Equal(PieFilling.Pecan, it.Flavor);
                },


                // FRIED ICE CREAM

                item =>
                {
                    var it = (FriedIceCream)item;
                    Assert.Equal(IceCreamFlavor.Chocolate, it.Flavor);
                },
                item =>
                {
                    var it = (FriedIceCream)item;
                    Assert.Equal(IceCreamFlavor.Vanilla, it.Flavor);
                },
                item =>
                {
                    var it = (FriedIceCream)item;
                    Assert.Equal(IceCreamFlavor.Strawberry, it.Flavor);
                },


                // FRIED CANDY BAR

                item =>
                {
                    var it = (FriedCandyBar)item;
                    Assert.Equal(CandyBar.Snickers, it.CandyBar);
                },
                item =>
                {
                    var it = (FriedCandyBar)item;
                    Assert.Equal(CandyBar.MilkyWay, it.CandyBar);
                },
                item =>
                {
                    var it = (FriedCandyBar)item;
                    Assert.Equal(CandyBar.Twix, it.CandyBar);
                },
                item =>
                {
                    var it = (FriedCandyBar)item;
                    Assert.Equal(CandyBar.ThreeMusketeers, it.CandyBar);
                },
                item =>
                {
                    var it = (FriedCandyBar)item;
                    Assert.Equal(CandyBar.ButterFingers, it.CandyBar);
                },


                // FRIED TWINKIE

                item =>
                {
                    var it = (FriedTwinkie)item;
                    Assert.Equal("Fried Twinkie", it.Name);
                }
           );
        }





        // PLATTERS

        /// <summary>
        /// Platters has every combination
        /// </summary>
        [Fact]
        public void PlattersHasEveryCombination()
        {
            // PIPER PLATTERS

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            Assert.Contains(Menu.Platters, item =>
                            {
                                if (item is PiperPlatter pip)
                                {
                                    if (pip.LeftIceCream.Flavor == (IceCreamFlavor)k
                                        && pip.RightIceCream.Flavor == (IceCreamFlavor)l
                                        && pip.LeftPie.Flavor == (PieFilling)i
                                        && pip.RightPie.Flavor == (PieFilling)j)
                                    {
                                        return true;
                                    }

                                }
                                return false;
                            });
                        }
                    }
                }
            }




            // POPPER PLATTERS

            // GLAZED:

            for (int m = 0; m < 3; m++)
            {
                Assert.Contains(Menu.Platters, item =>
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
                Assert.Contains(Menu.Platters, item =>
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




        // FULL MENU

        /// <summary>
        /// Full menu has every combination
        /// </summary>
        [Fact]
        public void FullMenuHasEveryCombination()
        {

            // POPPERS:

            // APPLE FRITTERS

            // GLAZED:

            for (int m = 0; m < 3; m++)
            {
                Assert.Contains(Menu.FullMenu, item =>
                {
                    if (item is AppleFritters it)
                    {
                        if (it.Size == (ServingSize)m
                            && it.Glazed)
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
                Assert.Contains(Menu.FullMenu, item =>
                {
                    if (item is AppleFritters it)
                    {
                        if (it.Size == (ServingSize)m
                            && it.Glazed == false)
                        {
                            return true;
                        }

                    }
                    return false;
                });
            }




            // FRIED BANANAS

            // GLAZED:

            for (int m = 0; m < 3; m++)
            {
                Assert.Contains(Menu.FullMenu, item =>
                {
                    if (item is FriedBananas it)
                    {
                        if (it.Size == (ServingSize)m
                            && it.Glazed)
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
                Assert.Contains(Menu.FullMenu, item =>
                {
                    if (item is FriedBananas it)
                    {
                        if (it.Size == (ServingSize)m
                            && it.Glazed == false)
                        {
                            return true;
                        }

                    }
                    return false;
                });
            }




            // FRIED CHEESECAKE

            // GLAZED:

            for (int m = 0; m < 3; m++)
            {
                Assert.Contains(Menu.FullMenu, item =>
                {
                    if (item is FriedCheesecake it)
                    {
                        if (it.Size == (ServingSize)m
                            && it.Glazed)
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
                Assert.Contains(Menu.FullMenu, item =>
                {
                    if (item is FriedCheesecake it)
                    {
                        if (it.Size == (ServingSize)m
                            && it.Glazed == false)
                        {
                            return true;
                        }

                    }
                    return false;
                });
            }






            // FRIED OREOS

            // GLAZED:

            for (int m = 0; m < 3; m++)
            {
                Assert.Contains(Menu.FullMenu, item =>
                {
                    if (item is FriedOreos it)
                    {
                        if (it.Size == (ServingSize)m
                            && it.Glazed)
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
                Assert.Contains(Menu.FullMenu, item =>
                {
                    if (item is FriedOreos it)
                    {
                        if (it.Size == (ServingSize)m
                            && it.Glazed == false)
                        {
                            return true;
                        }

                    }
                    return false;
                });
            }




            // TREATS:

            // FRIED PIE

            for (int m = 0; m < 7; m++)
            {
                Assert.Contains(Menu.FullMenu, item =>
                {
                    if (item is FriedPie it)
                    {
                        if (it.Flavor == (PieFilling)m)
                        {
                            return true;
                        }

                    }
                    return false;
                });
            }


            // FRIED ICE CREAM

            for (int m = 0; m < 3; m++)
            {
                Assert.Contains(Menu.FullMenu, item =>
                {
                    if (item is FriedIceCream it)
                    {
                        if (it.Flavor == (IceCreamFlavor)m)
                        {
                            return true;
                        }

                    }
                    return false;
                });
            }


            // FRIED CANDY BAR

            for (int m = 0; m < 5; m++)
            {
                Assert.Contains(Menu.FullMenu, item =>
                {
                    if (item is FriedCandyBar it)
                    {
                        if (it.CandyBar == (CandyBar)m)
                        {
                            return true;
                        }

                    }
                    return false;
                });
            }




            // PLATTERS:

            // PIPER PLATTERS

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            Assert.Contains(Menu.FullMenu, item =>
                            {
                                if (item is PiperPlatter pip)
                                {
                                    if (pip.LeftIceCream.Flavor == (IceCreamFlavor)k
                                        && pip.RightIceCream.Flavor == (IceCreamFlavor)l
                                        && pip.LeftPie.Flavor == (PieFilling)i
                                        && pip.RightPie.Flavor == (PieFilling)j)
                                    {
                                        return true;
                                    }

                                }
                                return false;
                            });
                        }
                    }
                }
            }




            // POPPER PLATTERS

            // GLAZED:

            for (int m = 0; m < 3; m++)
            {
                Assert.Contains(Menu.FullMenu, item =>
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
                Assert.Contains(Menu.FullMenu, item =>
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



    }
}
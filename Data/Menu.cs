using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriedPiper.Data.Enums;
using FriedPiper.Data.MenuItems;

namespace FriedPiper.Data
{
    /// <summary>
    /// Menu class for the website
    /// </summary>
    public static class Menu
    {


        // TREATS:
        

        /// <summary>
        /// List of treats
        /// </summary>
        private static List<IMenuItem> _treats = new List<IMenuItem>();



        /// <summary>
        /// Gets all the treats
        /// </summary>
        public static IEnumerable<IMenuItem> Treats { get { return _treats; } }





        // POPPERS:


        /// <summary>
        /// List of poppers
        /// </summary>
        private static List<IMenuItem> _poppers = new List<IMenuItem>();



        /// <summary>
        /// Gets all the poppers
        /// </summary>
        public static IEnumerable<IMenuItem> Poppers { get { return _poppers; } }





        // PLATTERS:


        /// <summary>
        /// List of platters
        /// </summary>
        private static List<IMenuItem> _platters = new List<IMenuItem>();



        /// <summary>
        /// Gets all the platters
        /// </summary>
        public static IEnumerable<IMenuItem> Platters { get { return _platters; } }





        // FULL MENU:


        /// <summary>
        /// List of full menu
        /// </summary>
        private static List<IMenuItem> _fullMenu = new List<IMenuItem>();



        /// <summary>
        /// Gets all the full menu
        /// </summary>
        public static IEnumerable<IMenuItem> FullMenu { get { return _fullMenu; } }









        /// <summary>
        /// Constructor
        /// </summary>
        static Menu()
        {

            // ALL THE TREATS:


            // FRIED PIE

            FriedPie fp_cherry = new FriedPie();
            fp_cherry.Flavor = PieFilling.Cherry;
            _treats.Add(fp_cherry);

            FriedPie fp_peach = new FriedPie();
            fp_peach.Flavor = PieFilling.Peach;
            _treats.Add(fp_peach);

            FriedPie fp_apricot = new FriedPie();
            fp_apricot.Flavor = PieFilling.Apricot;
            _treats.Add(fp_apricot);

            FriedPie fp_pineapple = new FriedPie();
            fp_pineapple.Flavor = PieFilling.Pineapple;
            _treats.Add(fp_pineapple);

            FriedPie fp_blueberry = new FriedPie();
            fp_blueberry.Flavor = PieFilling.Blueberry;
            _treats.Add(fp_blueberry);

            FriedPie fp_apple = new FriedPie();
            fp_apple.Flavor = PieFilling.Apple;
            _treats.Add(fp_apple);

            FriedPie fp_pecan = new FriedPie();
            fp_pecan.Flavor = PieFilling.Pecan;
            _treats.Add(fp_pecan);



            // FRIED ICE CREAM

            FriedIceCream fic_chocolate = new FriedIceCream();
            fic_chocolate.Flavor = IceCreamFlavor.Chocolate;
            _treats.Add(fic_chocolate);

            FriedIceCream fic_vanilla = new FriedIceCream();
            fic_vanilla.Flavor = IceCreamFlavor.Vanilla;
            _treats.Add(fic_vanilla);

            FriedIceCream fic_strawberry = new FriedIceCream();
            fic_strawberry.Flavor = IceCreamFlavor.Strawberry;
            _treats.Add(fic_strawberry);



            // FRIED CANDY BAR

            FriedCandyBar cb_snickers = new FriedCandyBar();
            cb_snickers.CandyBar = CandyBar.Snickers;
            _treats.Add(cb_snickers);

            FriedCandyBar cb_milkyway = new FriedCandyBar();
            cb_milkyway.CandyBar = CandyBar.MilkyWay;
            _treats.Add(cb_milkyway);

            FriedCandyBar cb_twix = new FriedCandyBar();
            cb_twix.CandyBar = CandyBar.Twix;
            _treats.Add(cb_twix);

            FriedCandyBar cb_threemusketeers = new FriedCandyBar();
            cb_threemusketeers.CandyBar = CandyBar.ThreeMusketeers;
            _treats.Add(cb_threemusketeers);

            FriedCandyBar cb_butterfingers = new FriedCandyBar();
            cb_butterfingers.CandyBar = CandyBar.ButterFingers;
            _treats.Add(cb_butterfingers);



            // FRIED TWINKIE

            FriedTwinkie ft = new FriedTwinkie();
            _treats.Add(ft);










            // ALL THE POPPERS:


            // APPLEFRITTERS

            AppleFritters af_small_g = new AppleFritters();
            af_small_g.Size = ServingSize.Small;
            _poppers.Add(af_small_g);

            AppleFritters af_medium_g = new AppleFritters();
            af_medium_g.Size = ServingSize.Medium;
            _poppers.Add(af_medium_g);

            AppleFritters af_large_g = new AppleFritters();
            af_large_g.Size = ServingSize.Large;
            _poppers.Add(af_large_g);

            AppleFritters af_small = new AppleFritters();
            af_small.Size = ServingSize.Small;
            af_small.Glazed = false;
            _poppers.Add(af_small);

            AppleFritters af_medium = new AppleFritters();
            af_medium.Size = ServingSize.Medium;
            af_medium.Glazed = false;
            _poppers.Add(af_medium);

            AppleFritters af_large = new AppleFritters();
            af_large.Size = ServingSize.Large;
            af_large.Glazed = false;
            _poppers.Add(af_large);




            // FRIED BANANAS

            FriedBananas fb_small_g = new FriedBananas();
            fb_small_g.Size = ServingSize.Small;
            _poppers.Add(fb_small_g);

            FriedBananas fb_medium_g = new FriedBananas();
            fb_medium_g.Size = ServingSize.Medium;
            _poppers.Add(fb_medium_g);

            FriedBananas fb_large_g = new FriedBananas();
            fb_large_g.Size = ServingSize.Large;
            _poppers.Add(fb_large_g);

            FriedBananas fb_small = new FriedBananas();
            fb_small.Size = ServingSize.Small;
            fb_small.Glazed = false;
            _poppers.Add(fb_small);

            FriedBananas fb_medium = new FriedBananas();
            fb_medium.Size = ServingSize.Medium;
            fb_medium.Glazed = false;
            _poppers.Add(fb_medium);

            FriedBananas fb_large = new FriedBananas();
            fb_large.Size = ServingSize.Large;
            fb_large.Glazed = false;
            _poppers.Add(fb_large);






            // FRIED CHEESECAKE

            FriedCheesecake fc_small_g = new FriedCheesecake();
            fc_small_g.Size = ServingSize.Small;
            _poppers.Add(fc_small_g);

            FriedCheesecake fc_medium_g = new FriedCheesecake();
            fc_medium_g.Size = ServingSize.Medium;
            _poppers.Add(fc_medium_g);

            FriedCheesecake fc_large_g = new FriedCheesecake();
            fc_large_g.Size = ServingSize.Large;
            _poppers.Add(fc_large_g);

            FriedCheesecake fc_small = new FriedCheesecake();
            fc_small.Size = ServingSize.Small;
            fc_small.Glazed = false;
            _poppers.Add(fc_small);

            FriedCheesecake fc_medium = new FriedCheesecake();
            fc_medium.Size = ServingSize.Medium;
            fc_medium.Glazed = false;
            _poppers.Add(fc_medium);

            FriedCheesecake fc_large = new FriedCheesecake();
            fc_large.Size = ServingSize.Large;
            fc_large.Glazed = false;
            _poppers.Add(fc_large);










            // FRIED OREOS

            FriedOreos fo_small_g = new FriedOreos();
            fo_small_g.Size = ServingSize.Small;
            _poppers.Add(fo_small_g);

            FriedOreos fo_medium_g = new FriedOreos();
            fo_medium_g.Size = ServingSize.Medium;
            _poppers.Add(fo_medium_g);

            FriedOreos fo_large_g = new FriedOreos();
            fo_large_g.Size = ServingSize.Large;
            _poppers.Add(fo_large_g);

            FriedOreos fo_small = new FriedOreos();
            fo_small.Size = ServingSize.Small;
            fo_small.Glazed = false;
            _poppers.Add(fo_small);

            FriedOreos fo_medium = new FriedOreos();
            fo_medium.Size = ServingSize.Medium;
            fo_medium.Glazed = false;
            _poppers.Add(fo_medium);

            FriedOreos fo_large = new FriedOreos();
            fo_large.Size = ServingSize.Large;
            fo_large.Glazed = false;
            _poppers.Add(fo_large);








            // PLATTERS:


            // PIPER PLATTER



            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {

                            PiperPlatter pip = new PiperPlatter();
                            pip.LeftIceCream.Flavor = (IceCreamFlavor)k;
                            pip.RightIceCream.Flavor = (IceCreamFlavor)l;
                            pip.LeftPie.Flavor = (PieFilling)i;
                            pip.RightPie.Flavor = (PieFilling)j;
                            _platters.Add(pip);



                        }

                    }

                }

            }





            // POPPER PLATTER

            PopperPlatter pop_small_g = new PopperPlatter();
            pop_small_g.Size = ServingSize.Small;
            _platters.Add(pop_small_g);

            PopperPlatter pop_medium_g = new PopperPlatter();
            pop_medium_g.Size = ServingSize.Medium;
            _platters.Add(pop_medium_g);

            PopperPlatter pop_large_g = new PopperPlatter();
            pop_large_g.Size = ServingSize.Large;
            _platters.Add(pop_large_g);

            PopperPlatter pop_small = new PopperPlatter();
            pop_small.Size = ServingSize.Small;
            pop_small.Glazed = false;
            _platters.Add(pop_small);

            PopperPlatter pop_medium = new PopperPlatter();
            pop_medium.Size = ServingSize.Medium;
            pop_medium.Glazed = false;
            _platters.Add(pop_medium);

            PopperPlatter pop_large = new PopperPlatter();
            pop_large.Size = ServingSize.Large;
            pop_large.Glazed = false;
            _platters.Add(pop_large);





            // FULL MENU:

            foreach (IMenuItem item in _treats)
            {
                _fullMenu.Add(item);

            }

            foreach (IMenuItem item in _poppers)
            {
                _fullMenu.Add(item);

            }

            foreach (IMenuItem item in _platters)
            {
                _fullMenu.Add(item);

            }









        }






    }
}

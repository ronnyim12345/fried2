using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.ComponentModel;
using FriedPiper.Data.Enums;
using FriedPiper.Data.MenuItems;

namespace FriedPiper.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizePiperPlatter.xaml
    /// </summary>
    public partial class CustomizePiperPlatter : UserControl
    {

        


        /// <summary>
        /// Constructor for piper platter
        /// </summary>
        public CustomizePiperPlatter()
        {
            InitializeComponent();

            this.DataContext = new PiperPlatter();

        }

        /// <summary>
        /// Updates the flavors
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void UserControl_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (DataContext is PiperPlatter piperPlatter)
            {
                comboBoxLeftPie.DataContext = piperPlatter.LeftPie;
                comboBoxRightPie.DataContext = piperPlatter.RightPie;
                comboBoxLeftIceCream.DataContext = piperPlatter.LeftIceCream;
                comboBoxRightIceCream.DataContext = piperPlatter.RightIceCream;
            }



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FriedPiper.Data.MenuItems;
using System.ComponentModel;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace FriedPiper.Data
{
    /// <summary>
    /// The order(s) of customers
    /// </summary>
    public class Order : INotifyPropertyChanged, ICollection<IMenuItem>, INotifyCollectionChanged
    {


        /// <summary>
        /// Property changed updates
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void HandlePropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            if (e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }

            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }

            if (e.PropertyName == "Size")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }


        }



        /// <summary>
        /// Property Changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Collection changed event handler
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        /// order number field
        /// </summary>
        public static int nextOrderNumber = 1;


        /// <summary>
        /// order number property
        /// </summary>
        public int Number { get; }


        /// <summary>
        /// Constructor
        /// </summary>
        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber++;

        }

        /// <summary>
        /// The list of order(s)
        /// </summary>
        private List<IMenuItem> _items = new List<IMenuItem>();




        /// <summary>
        /// tax rate field
        /// </summary>
        public decimal _salesTaxRate = 0.09m;

        /// <summary>
        /// tax rate property
        /// </summary>
        public decimal SalesTaxRate
        {
            get => _salesTaxRate;
            set
            {
                _salesTaxRate = value;
            }

        }


        // SUB = ALL ITEMS

        /// <summary>
        /// Subtotal property
        /// </summary>
        public decimal Subtotal
        {
            get
            {
                decimal price = 0;


                foreach (IMenuItem item in this)
                {
                    price += item.Price;

                }


                return price;
            }
        }




        // TAX = SUB * SalesTaxRate

        /// <summary>
        /// Tax property
        /// </summary>
        public decimal Tax
        {
            get
            {
                return Subtotal * SalesTaxRate;
            }
        }



        // TOTAL = SUB + TAX

        /// <summary>
        /// Total property
        /// </summary>
        public decimal Total
        {
            get
            {
                return Subtotal + Tax;
            }
        }






        /// <summary>
        /// Total Calories
        /// </summary>
        public uint Calories
        {
            get
            {
                uint cal = 0;


                foreach (IMenuItem item in this)
                {
                    cal += item.Calories;

                }


                return cal;
            }
        }







        /// <summary>
        /// Date and time
        /// </summary>
        public DateTime PlacedAt
        {
            get
            {
                DateTime dt = DateTime.Now;

                return dt;
            }
        }

        /// <summary>
        /// Count property
        /// </summary>
        public int Count => throw new NotImplementedException();

        /// <summary>
        /// IsReadOnly property
        /// </summary>
        public bool IsReadOnly => throw new NotImplementedException();




        /// <summary>
        /// Updates the totals
        /// </summary>
        public void UpdateTotals()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }



        /// <summary>
        /// adds item
        /// </summary>
        /// <param name="item">item</param>
        public void Add(IMenuItem item)
        {
            item.PropertyChanged += HandlePropertyChanged;

            _items.Add(item);


            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));


            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));




        }



        /// <summary>
        /// Removes Item
        /// </summary>
        /// <param name="item">item</param>
        /// <returns>whether it was removed</returns>
        public bool Remove(IMenuItem item)
        {


            int itemIndex = _items.IndexOf(item);

            bool success = _items.Remove(item);


            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));


            if (itemIndex != -1) {
                CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, itemIndex));
            }


            return success;


        }




        /// <summary>
        /// Clear method
        /// </summary>
        public void Clear()
        {

            _items.Clear();

        }


        /// <summary>
        /// Sees if it contains
        /// </summary>
        /// <param name="item">item</param>
        /// <returns>whether successful</returns>
        public bool Contains(IMenuItem item)
        {
            return _items.Contains(item);
        }


        /// <summary>
        /// Copy method
        /// </summary>
        /// <param name="array">the array</param>
        /// <param name="arrayIndex">index</param>
        public void CopyTo(IMenuItem[] array, int arrayIndex)
        {
            _items.CopyTo(array, arrayIndex);
        }


        /// <summary>
        /// Remove for collection
        /// </summary>
        /// <param name="item">item</param>
        /// <returns>whether success</returns>
        bool ICollection<IMenuItem>.Remove(IMenuItem item)
        {

            return Remove(item);

        }



        /// <summary>
        /// Enumerator method
        /// </summary>
        /// <returns>enum</returns>
        public IEnumerator<IMenuItem> GetEnumerator()
        {
            return _items.GetEnumerator();
        }



        /// <summary>
        /// Enumerator method
        /// </summary>
        /// <returns>enum</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }







        /// <summary>
        /// listener for adding/remove
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {


            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IMenuItem item in e.NewItems)
                    {
                        item.PropertyChanged += HandlePropertyChanged;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IMenuItem item in e.OldItems)
                    {
                        item.PropertyChanged -= HandlePropertyChanged;
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedACtion.Reset not supported");
            }



        }

    }
}

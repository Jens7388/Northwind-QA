using NT.Entities.Models;
using NT.Gui.ViewModels.Base;
using NT.Services;
using NT.Utilities;
using NT.Utilities.NT.Utilities;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace NT.ViewModels.ViewModels
{
    public class OrderViewModel : ViewModelBase
    {
        #region Fields
        protected ObservableCollection<Shippers> shippers;
        protected ObservableCollection<Orders> orders;
        protected Orders selectedOrder;
        #endregion

        #region Constructor
        public OrderViewModel()
        {
            Shippers = new ObservableCollection<Shippers>();
            Orders = new ObservableCollection<Orders>();
        }
        #endregion

        #region Properties
        public virtual ObservableCollection<Shippers> Shippers
        {
            get
            {
                return shippers;
            }
            set
            {
                SetProperty(ref shippers, value);
            }
        }

        public virtual ObservableCollection<Orders> Orders
        {
            get
            {
                return orders;
            }
            set
            {
                SetProperty(ref orders, value);
            }
        }

        public virtual Orders SelectedOrder
        {
            get
            {
                return selectedOrder;
            }
            set
            {
                SetProperty(ref selectedOrder, value);
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Loads all orders from the endpoint
        /// </summary>
        protected override async Task LoadAllAsync()
        {
            try
            {
                OrderService orderService = new OrderService();
                List<Orders> orders = await orderService.GetAllOrdersAsync();
                Orders.ReplaceWith(orders);

                ShipperService shipperService = new ShipperService();
                List<Shippers> shippers = await shipperService.GetAllShippersAsync();
                Shippers.ReplaceWith(shippers);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes an order
        /// </summary>
        private void DeleteOrder()
        {
            // Needs implementing
            throw new NotImplementedException();

        }
        /// <summary>
        ///  Adds an order
        /// </summary>
        private void AddOrder()
        {
            // Needs implementing
            throw new NotImplementedException();

        }
        #endregion
    }
}
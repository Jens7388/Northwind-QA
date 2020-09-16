using NT.Entities.Models;
using NT.Gui;
using NT.Gui.ViewModels.Base;
using NT.Services;
using NT.Utilities.NT.Utilities;

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace NT.ViewModels.ViewModels
{
    public class ProductViewModel: ViewModelBase
    {
        #region Fields
        ObservableCollection<Products> products;
        Products selectedProduct;
        #endregion

        #region Constructor
        public ProductViewModel()
        {
            products = new ObservableCollection<Products>();
        }
        #endregion

        #region Properties
        public ObservableCollection<Products> Products
        {
            get
            {
                return products;
            }
            set
            {
                SetProperty(ref products, value);
            }
        }

        public Products SelectedProduct
        {
            get
            {
                return selectedProduct;
            }
            set
            {
                SetProperty(ref selectedProduct, value);
            }
        }
        #endregion

        #region Methods
        protected override async Task LoadAllAsync()
        {
            try
            {
                ProductService service = new ProductService();

                List<Products> products = await service.GetAllProductsAsync();

                Products.ReplaceWith(products);
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
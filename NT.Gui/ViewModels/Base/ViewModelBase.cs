using System;
using System.Threading.Tasks;

namespace NT.Gui.ViewModels.Base
{
    /// <summary>
    /// Base class for ViewModel classes
    /// </summary>
    public class ViewModelBase : BindableBase
    {
        #region Methods
        /// <summary>
        /// Runs the <see cref="LoadAllAsync"/> method
        /// </summary>
        public virtual async Task InitializeAsync()
        {
            // Try to load suppliers
            try
            {
                await LoadAllAsync();
            }
            catch
            {
                throw;
            }
            
        }

        /// <summary>
        /// Loads data from the database
        /// </summary>
        protected virtual Task LoadAllAsync()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
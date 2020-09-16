
using Microsoft.Extensions.Logging;

using NT.Logging;
using NT.ViewModels.ViewModels;

using System;
using System.Windows;
using System.Windows.Controls;

namespace NT.Gui.UserControls
{
    /// <summary>
    /// Interaction logic for OrdersControl.xaml
    /// </summary>
    public partial class OrdersControl: UserControl
    {
        private readonly OrderViewModel viewModel;
        private bool isLoaded;

        public OrdersControl()
        {
            InitializeComponent();

            viewModel = DataContext as OrderViewModel;
        }

        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                if(!isLoaded)
                {
                    isLoaded = !isLoaded;
                     
                    await viewModel.InitializeAsync();
                }
            }
            catch(Exception ex)
            {
               await Logger.LogAsync(ex);
            }
        }
    } 
}
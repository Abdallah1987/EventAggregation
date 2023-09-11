using System.Windows;
using Autofac;
using EventAggregatorExample.ViewModel;

namespace EventAggregatorExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitializeViewModelLocator();
            RunApplication();
        }

        private void InitializeViewModelLocator()
        {
            ViewModelLocator viewModelLocator = new ViewModelLocator();
            Resources.Add("ViewModelLocator", viewModelLocator);
        }

        private void RunApplication()
        {
            // Create and show your main window
            var mainWindow = new MainView();
            mainWindow.Show();
        }
    }
}

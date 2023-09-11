using Autofac;
using EventAggregatorExample.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregatorExample
{
    public class ViewModelLocator
    {
        private IContainer _container;

        public ViewModelLocator()
        {
            ConfigureContainer();
        }

        private void ConfigureContainer()
        {
            // Set up your container (Autofac, in this example)
            var builder = new ContainerBuilder();
            builder.RegisterType<UpdateViewModel>().AsSelf();
            builder.RegisterType<ListDisplayViewModel>().AsSelf();
            builder.RegisterType<ListDisplay2ViewModel>().AsSelf();
            builder.RegisterType<ListDisplay3ViewModel>().AsSelf();

            builder.RegisterType<EventAggregator>().SingleInstance().AsSelf();
            // Register other view models and services as needed
            _container = builder.Build();
        }

        public UpdateViewModel UpdateViewModelInstance => _container.Resolve<UpdateViewModel>();
        public ListDisplayViewModel ListDisplayViewModelInstance => _container.Resolve<ListDisplayViewModel>();
        public ListDisplay2ViewModel ListDisplay2ViewModelInstance => _container.Resolve<ListDisplay2ViewModel>();
        public ListDisplay3ViewModel ListDisplay3ViewModelInstance => _container.Resolve<ListDisplay3ViewModel>();
        
        // Add other view model properties as needed
    }
}

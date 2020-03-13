using System;
using System.ComponentModel;
using Prism.Mvvm;
using Prism.Navigation;

namespace PlacesApp.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware, IDestructible, INotifyPropertyChanged
    {
        protected INavigationService NavigationService { get; private set; }


        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }


        internal void OnNavigatedTo()
        {
            throw new NotImplementedException();
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatingTo(INavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {

        }
    }
}

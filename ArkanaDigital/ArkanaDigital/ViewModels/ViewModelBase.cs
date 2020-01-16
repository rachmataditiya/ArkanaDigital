using ArkanaDigital.ApiModels;
using ArkanaDigital.Routes;
using ArkanaDigital.WebRequests;
using Prism.Navigation;
using Prism.Services;
using ReactiveUI;
using System;
using Xamarin.Essentials;


namespace ArkanaDigital.ViewModels
{
    public class ViewModelBase : ReactiveObject, INavigationAware, IConfirmNavigation, IInitialize, IDestructible
    {
        public IPageDialogService DialogService { get; set; }
        public INavigationService NavigationService;
        public ViewModelBase()
        {
            
        }
        public virtual void Initialize(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }
        public bool CanNavigate(INavigationParameters parameters)
        {
            return true;
        }
        public virtual void Destroy()
        {

        }
        private string errorMessage;
        public string ErrorMessage
        {
            get { return errorMessage; }
            set { this.RaiseAndSetIfChanged(ref errorMessage, value); }
        }
        private string _title;
        public string Title
        {
            get { return _title; }
            set { this.RaiseAndSetIfChanged(ref _title, value); }
        }
        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set { this.RaiseAndSetIfChanged(ref _isBusy, value); }
        }
        public bool IsNotBusy
        {
            get { return !IsBusy; }
        }
        protected void BindBusy(IReactiveCommand command)
        {
            command.IsExecuting.Subscribe(
                x => this.IsBusy = x,
                _ => this.IsBusy = false,
                () => this.IsBusy = false
                );
            ;
        }
    }
}

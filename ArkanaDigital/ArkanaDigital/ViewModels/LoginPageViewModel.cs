using ArkanaDigital.Views;
using ArkanaDigital.Routes;
using ArkanaDigital.ApiModels;
using ArkanaDigital.WebRequests;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using ReactiveUI;
using System.Threading.Tasks;
using Xamarin.Essentials;
using System;
using System.Reactive;

namespace ArkanaDigital.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        public ReactiveCommand<Unit, Unit> LoginCommand { get; }
        public LoginPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
        {
            NavigationService = navigationService;
            DialogService = pageDialogService;
        }
    }
}

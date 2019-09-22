using Goose.Models;
using Goose.Service;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Goose.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private ObservableCollection<Item> items;
        public ObservableCollection<Item> Items
        {
            get { return items; }
            set { SetProperty(ref items, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Qiita 最新投稿一覧";
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            Device.BeginInvokeOnMainThread(async () => {
                this.Items = new ObservableCollection<Item>(await QiitaService.GetItemsAsync());
            });
        }
    }
}

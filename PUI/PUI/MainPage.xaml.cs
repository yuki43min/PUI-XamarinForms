using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PUI.ViewModel;
using Xamarin.Forms;

namespace PUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var group = new ObservableCollection<ObservableCollection<MainPageViewModel>>()
            {
                new ObservableCollection<MainPageViewModel> () {
                new MainPageViewModel() { Title = "コピー", SubTitle = "", ImageSource = null },
                new MainPageViewModel() { Title = "スキャナー(メール送信)", SubTitle = "", ImageSource = null },
                new MainPageViewModel() { Title = "スキャナー(ボックス保存)", SubTitle = "", ImageSource = null },
                new MainPageViewModel() { Title = "ファクス", SubTitle = "", ImageSource = null },
                new MainPageViewModel() { Title = "お気に入り一覧", SubTitle = "", ImageSource = null }

                }
            };
            this.GroupedView.ItemsSource = group;
        }

        /// <summary>
        /// [NavigateToNextPage]ボタン押下時に呼ばれる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnTransitNextPage(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new CopyPage() { Title = "コピー画面" });
        }
    }
}

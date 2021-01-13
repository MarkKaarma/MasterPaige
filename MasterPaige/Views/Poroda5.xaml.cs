using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterPaige.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Poroda5 : ContentPage
    {
        public Poroda5()
        {
            InitializeComponent();
        }

        private async void btn_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://lapkins.ru/dog/frantsuzskiy-buldog/");
            await Browser.OpenAsync(uri);
        }
    }
}
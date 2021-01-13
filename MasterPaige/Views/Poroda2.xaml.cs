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
    public partial class Poroda2 : ContentPage
    {
        public Poroda2()
        {
            InitializeComponent();
        }

        private async void btn_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.koer.ee/ru/%D0%90%D0%BD%D0%B3%D0%BB%D0%B8%D0%B9%D1%81%D0%BA%D0%B8%D0%B9_%D0%B1%D1%83%D0%BB%D1%8C%D0%B4%D0%BE%D0%B3.html");
            await Browser.OpenAsync(uri);
        }
    }
}
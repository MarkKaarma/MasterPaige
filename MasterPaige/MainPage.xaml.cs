using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterPaige
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            profileImage.Source = ImageSource.FromFile("doggymain.jpg");
            aboutList.ItemsSource = GetMenuList();
            var homePage = typeof(Views.Poroda1);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
        }
        public List<MasterMenuItems> GetMenuList()
        {
            var list = new List<MasterMenuItems>();
            list.Add(new MasterMenuItems()
            {
                Text = "Бостон-терьер",
                Detail = "Топ 10 собакэнов",
                ImagePath = "doggymain.jpg",
                TargetPage = typeof(Views.Poroda1)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Бостон-терьер",
                Detail = "Топ 9 собакэнов",
                ImagePath = "doggymain.jpg",
                TargetPage = typeof(Views.Poroda2)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Бостон-терьер",
                Detail = "Топ 8 собакэнов",
                ImagePath = "doggymain.jpg",
                TargetPage = typeof(Views.Poroda3)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Бостон-терьер",
                Detail = "Топ 7 собакэнов",
                ImagePath = "doggymain.jpg",
                TargetPage = typeof(Views.Poroda4)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Бостон-терьер",
                Detail = "Топ 6 собакэнов",
                ImagePath = "doggymain.jpg",
                TargetPage = typeof(Views.Poroda5)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Бостон-терьер",
                Detail = "Топ 5 собакэнов",
                ImagePath = "doggymain.jpg",
                TargetPage = typeof(Views.Poroda6)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Бостон-терьер",
                Detail = "Топ 4 собакэнов",
                ImagePath = "doggymain.jpg",
                TargetPage = typeof(Views.Poroda7)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Бостон-терьер",
                Detail = "Топ 3 собакэнов",
                ImagePath = "doggymain.jpg",
                TargetPage = typeof(Views.Poroda8)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Бостон-терьер",
                Detail = "Топ 2 собакэнов",
                ImagePath = "doggymain.jpg",
                TargetPage = typeof(Views.Poroda9)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Бостон-терьер",
                Detail = "Топ 1 собакэнов",
                ImagePath = "doggymain.jpg",
                TargetPage = typeof(Views.Poroda10)
            });
            return list;
        }


        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MasterMenuItems)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        }
    }
}

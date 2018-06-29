using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetail_2
{
    public partial class MainPage : MasterDetailPage
    {
        string[] menuItems = { "Page1", "Page2", "Page3" };
        //private List<MenuItem> _menuItems;

        public MainPage()
        {
            InitializeComponent();

            masterListView.ItemsSource = menuItems;

            /*_menuItems = new List<MenuItem> {
                new MenuItem {Name="Page1"},
                new MenuItem {Name="Page2"},
                new MenuItem {Name="Page3"}
            };

            // each MenuItem in _menuItems is the Binding Context
            // for its corresponding item in ItemsSource
            masterListView.ItemsSource = _menuItems; */


            // first thing shown is a Detail Page.  Set this page here
            Detail = new NavigationPage(new Page1());
            IsPresented = false;  // present master page?
        }

        private void masterListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menuChoice = (string)e.SelectedItem;

            if (menuChoice == menuItems[0])
                Detail = new NavigationPage(new Page1());
            else if (menuChoice == menuItems[1])
                Detail = new NavigationPage(new Page2());
            else if (menuChoice == menuItems[2])
                Detail = new NavigationPage(new Page3()); 

            /*var menuChoice = e.SelectedItem as MenuItem;

            DisplayAlert("menuChoice", menuChoice.ToString(), "Ok");

            string str = menuChoice.Name;

            if (str == _menuItems[0].Name)
                Detail = new NavigationPage(new Page1());
            else if (str == _menuItems[1].Name)
                Detail = new NavigationPage(new Page2());
            else if (str == _menuItems[2].Name)
                Detail = new NavigationPage(new Page3()); */

            IsPresented = false;  // present master page?

            // To deselect the item (otherwise it's highlighted when clicked on)
            masterListView.SelectedItem = null;
        }
    }
}


using Menu = Expresso.Models.Menu;
//using SubMenu = Expresso.Models.SubMenu;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using Expresso.Models;

namespace Expresso.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubMenuPage : ContentPage
    {
        public ObservableCollection<SubMenu> SubMenus;
        public static bool First = true;
        public SubMenuPage(Menu menu)
        {
            InitializeComponent();
            SubMenus = new ObservableCollection<SubMenu>();
            foreach (var submenu in menu.SubMenus)
            {
                SubMenus.Add(submenu);
            }
            LvSubMenu.ItemsSource = SubMenus;
        }

    }
}
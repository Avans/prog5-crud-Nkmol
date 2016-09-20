using System.Windows;
using GalaSoft.MvvmLight.Threading;

namespace CRUD_Inventory
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            // Set default errror messages to english
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            DispatcherHelper.Initialize();

            // Open secundair window
            Inventory window2 = new Inventory();
            window2.Show();
        }
    }
}

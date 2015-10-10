using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RestaurantManager
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrderPage : Page
    {
        public OrderPage()
        {
            this.InitializeComponent();
        }

        private void appBarButton_Home_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //RestaurantManager.Models.DataManager obj = new RestaurantManager.Models.DataManager();
            //string s = lstMenuItems.Items[lstMenuItems.SelectedIndex].ToString();
            //
            //List<string> pp;
            //pp = lstCurrentlySelectedMenuItems.ItemsSource; // = obj.CurrentlySelectedMenuItems;
            //lstCurrentlySelectedMenuItems.Items.Add(s);

            //for (int i = 0; i < lstCurrentlySelectedMenuItems.Items.Count; i++)
            //{
            //    obj.CurrentlySelectedMenuItems.Add(lstCurrentlySelectedMenuItems.Items[i].ToString());
            //}
            //obj.CurrentlySelectedMenuItems.Add(s);
            //lstCurrentlySelectedMenuItems.ItemsSource = obj.CurrentlySelectedMenuItems;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

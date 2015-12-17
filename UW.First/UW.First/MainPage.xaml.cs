using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
using UW.First.Examples;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UW.First
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //Prism.Windows.Mvvm.ViewModelBase
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void Example1_Click(object sender, RoutedEventArgs e)
        {
            this.MySplitView.Content = new GridLayoutNet();
            SetButtons(((Button)sender).Tag.ToString());
        }

        private void Example2_Click(object sender, RoutedEventArgs e)
        {
            this.MySplitView.Content = new GridLayoutRectangles();
            SetButtons(((Button)sender).Tag.ToString());
        }

        private async void Example3_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("Wait for example");
            await dialog.ShowAsync();
            //SetButtons(((Button)sender).Tag.ToString());
        }

        private void SetButtons(string tag)
        {
            Example1.IsTapEnabled = !Example1.Tag.ToString().Equals(tag);
            Example2.IsTapEnabled = !Example2.Tag.ToString().Equals(tag);
            Example3.IsTapEnabled = !Example3.Tag.ToString().Equals(tag);
        }
    }
}

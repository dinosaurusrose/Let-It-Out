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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
   
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void HomepageBtnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
        private void Self_Referrall_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HelpPage));
        }

    
              
        private void HowToBtnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HelpPage));
        }
        private void SelfHelpBtnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(selfHelp));
        }

        private void AboutBtnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AboutPage));
        }

        private void InstructionBtnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HelpPage));
        }

        private void InfoBtnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ImportantInfoPage));
        }
    }
}

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

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace UWP31Test
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ContentFrame.Navigate(typeof(DonutPage));
        }

        private void TopButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (button.Name == "DonutButton")
                {
                    ContentFrame.Navigate(typeof(DonutPage));
                }
                else if (button.Name == "CoffeeButton")
                {
                    ContentFrame.Navigate(typeof(CoffeePage));
                }
                else if (button.Name == "ScheduleButton")
                {
                    ContentFrame.Navigate(typeof(SchedulePage));
                }
                else if (button.Name == "CompleteButton")
                {
                    ContentFrame.Navigate(typeof(CompletePage));
                }
            }
            
        }

    }
}

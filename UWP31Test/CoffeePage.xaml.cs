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

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace UWP31Test
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        public CoffeePage()
        {
            this.InitializeComponent();
        }

        private string roastText = "";

        private string sweetenerText = "";

        private string creamText = "";

        private void RoastMenuSelected(object sender, RoutedEventArgs e)
        {
            MenuFlyoutItem item = sender as MenuFlyoutItem;

            if (item != null)
            {
                if (item.Tag.ToString() == "None")
                {
                    roastText = "";
                    sweetenerText = "";
                    creamText = "";
                    OrderedMsg.Text = "";
                }
                else
                {
                    roastText = item.Text;
                }
                OrderedMsg.Text = roastText + ((creamText == "") ? "" : " + " + creamText) + ((sweetenerText == "") ? "" : " + " + sweetenerText);

            }

        }

        private void SweetenerMenuSelected(object sender, RoutedEventArgs e)
        {
            MenuFlyoutItem item = sender as MenuFlyoutItem;
            if (item != null)
            {
                if (roastText != "")
                {
                    if (item.Tag.ToString() == "None")
                    {
                        sweetenerText = "";
                    }
                    else
                    {
                        sweetenerText = item.Text;
                    }
                    OrderedMsg.Text = roastText + ((creamText == "") ? "" : " + " + creamText) + ((sweetenerText == "") ? "" : " + " + sweetenerText);
                }
            }
        }

        private void CreamMenuSelected(object sender, RoutedEventArgs e)
        {
            MenuFlyoutItem item = sender as MenuFlyoutItem;
            if (item != null)
            {
                if (roastText != "")
                {
                    if (item.Tag.ToString() == "None")
                    {
                        creamText = "";
                    }
                    else
                    {
                        creamText = item.Text;
                    }
                    OrderedMsg.Text = roastText + ((creamText == "") ? "" : " + " + creamText) + ((sweetenerText == "") ? "" : " + " + sweetenerText);
                }
            }
        }
    }
}

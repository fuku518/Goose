using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Goose.Controls
{
    public class ColoredNavigationPage : NavigationPage
    {
        public ColoredNavigationPage() : base()
        {
            BarBackgroundColor = Color.FromHex("#55C500");
            BarTextColor = Color.White;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using Goose.Controls;
using Goose.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(NavigationPageGradientHeader), typeof(NavigationPageGradientHeaderRenderer))]
namespace Goose.iOS.Renderers
{
    public class NavigationPageGradientHeaderRenderer : NavigationRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            var gradientLayer = new CAGradientLayer();
            var barHeight = (double)UIApplication.SharedApplication.StatusBarFrame.Height;
            gradientLayer.Bounds = new CGRect(0, 0, NavigationBar.Bounds.Width, NavigationBar.Bounds.Height + barHeight);
            gradientLayer.Colors = new CGColor[] { Color.FromHex("#55C500").ToCGColor(), Color.FromHex("3B8400").ToCGColor() };
            gradientLayer.StartPoint = new CGPoint(0.0, 0.5);
            gradientLayer.EndPoint = new CGPoint(1.0, 0.5);

            UIGraphics.BeginImageContext(View.Frame.Size);
            gradientLayer.RenderInContext(UIGraphics.GetCurrentContext());
            UIImage image = UIGraphics.GetImageFromCurrentImageContext();
            UIGraphics.EndImageContext();
            NavigationBar.SetBackgroundImage(image, UIBarMetrics.Default);
        }
    }
}
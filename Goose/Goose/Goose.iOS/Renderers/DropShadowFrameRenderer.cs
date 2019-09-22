using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreGraphics;
using Foundation;
using Goose.Controls;
using Goose.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(DropShadowFrame), typeof(DropShadowFrameRenderer))]
namespace Goose.iOS.Renderers
{
    public class DropShadowFrameRenderer : FrameRenderer
    {
        public override void Draw(CGRect rect)
        {
            base.Draw(rect);

            Layer.ShadowRadius = 4.0f;
            Layer.ShadowColor = Color.Gray.ToCGColor();
            Layer.ShadowOffset = new CGSize(2, 2);
            Layer.ShadowOpacity = 0.4f;
            Layer.ShadowPath = UIBezierPath.FromRect(Layer.Bounds).CGPath;
            Layer.MasksToBounds = false;
        }
    }
}
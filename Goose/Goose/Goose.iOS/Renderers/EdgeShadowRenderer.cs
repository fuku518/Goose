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

[assembly: ExportRenderer(typeof(EdgeShadow), typeof(EdgeShadowRenderer))]
namespace Goose.iOS.Renderers
{
    public class EdgeShadowRenderer : BoxRenderer
    {
        private CAGradientLayer _shadowLayer { get; set; }

        public override void Draw(CGRect rect)
        {
            base.Draw(rect);

            if (_shadowLayer != null)
            {
                _shadowLayer.RemoveFromSuperLayer();
                _shadowLayer = null;
            }
            _shadowLayer = new CAGradientLayer()
            {
                StartPoint = new CGPoint(0, 0),
                EndPoint = new CGPoint(0, 1)
            };
            _shadowLayer.Frame = rect;
            _shadowLayer.Colors = new CGColor[] {
                Color.FromHex("#60000000").ToCGColor(),
                Color.FromHex("#00000000").ToCGColor(),
            };
            Layer.InsertSublayer(_shadowLayer, 0);
        }

        protected override void Dispose(bool disposing)
        {
            if (_shadowLayer != null)
            {
                _shadowLayer.RemoveFromSuperLayer();
                _shadowLayer = null;
            }
            base.Dispose(disposing);
        }
    }
}
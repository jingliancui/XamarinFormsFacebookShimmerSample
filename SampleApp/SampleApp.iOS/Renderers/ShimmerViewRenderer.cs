using System;
using SampleApp.Controls;
using SampleApp.iOS.Renderers;
using Shimmer;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ShimmerView), typeof(ShimmerViewRenderer))]
namespace SampleApp.iOS.Renderers
{
    public class ShimmerViewRenderer:ViewRenderer<ShimmerView, FBShimmeringView>
    {
        private FBShimmeringView fbShimmeringView;

        protected override void OnElementChanged(ElementChangedEventArgs<ShimmerView> e)
        {
            if (fbShimmeringView==null)
            {
                fbShimmeringView = new FBShimmeringView();
            }

            var text = new UILabel();
            text.TextColor = UIColor.White;
            text.Text = "Xamarin Library";
            fbShimmeringView.ContentView = text;

            fbShimmeringView.Shimmering = true;

            SetNativeControl(fbShimmeringView);
        }
    }
}

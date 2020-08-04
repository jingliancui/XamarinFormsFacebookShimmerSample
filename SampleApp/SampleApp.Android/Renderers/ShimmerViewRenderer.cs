using System;
using Android.Content;
using Android.Widget;
using Com.Facebook.Shimmer;
using SampleApp.Controls;
using SampleApp.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ShimmerView), typeof(ShimmerViewRenderer))]
namespace SampleApp.Droid.Renderers
{
    public class ShimmerViewRenderer : ViewRenderer<ShimmerView, ShimmerFrameLayout>
    {
        public ShimmerViewRenderer(Context context) : base(context)
        {
        }

        private ShimmerFrameLayout shimmer;

        protected override void OnElementChanged(ElementChangedEventArgs<ShimmerView> e)
        {
            if (shimmer == null)
            {
                shimmer = new ShimmerFrameLayout(Context);
            }

            var text = new TextView(Context) { Text = "Xamarin Library" };

            text.SetTextColor(Android.Graphics.Color.White);

            text.SetTextSize(Android.Util.ComplexUnitType.Px, 100);

            var builder = new Shimmer.AlphaHighlightBuilder();
            builder.SetDuration(2500);
            builder.SetBaseAlpha(0.1f);
            builder.SetDropoff(0.1f);
            builder.SetTilt(0f);

            shimmer.SetShimmer(builder.Build());
            shimmer.AddView(text);
            shimmer.StartShimmer();

            SetNativeControl(shimmer);
        }
    }
}

using Android.Graphics;
using CustomFontAndStyles;
using CustomFontAndStyles.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(LabelWithCustomFont), typeof(LabelWithCustomFontRenderer))]
namespace CustomFontAndStyles.Droid
{
    public class LabelWithCustomFontRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            var labelWithCustomFont = e.NewElement;
            if (labelWithCustomFont != null)
            {
                var fontPath = labelWithCustomFont.FontFamily;
                var label = Control;
                var font = Typeface.CreateFromAsset(Forms.Context.Assets, fontPath);
                label.Typeface = font;
            }
        }
    }
}
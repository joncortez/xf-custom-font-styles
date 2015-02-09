Xamarin.Forms-CustomFontAndStyles
==========================
Sample Xamarin.Forms app to demonstrate using a custom font file that works across all platforms. It uses Styles in Xamarin.Forms 1.3 and a custom renderer for Android to support custom fonts.

##Overview
Using a custom font in Xamarin.Forms is covered in http://developer.xamarin.com/guides/cross-platform/xamarin-forms/working-with/fonts/#Using_a_Custom_Font

Xamarin.Forms for Android does not currently expose the ability to set the font to a custom font file and so it requires creating a custom renderer.

The LabelWithCustomFontRenderer class is a custom renderer that allows you to use in place of a Label control and specify a FontFamily string which is a path to the font file inside the Assets folder of your Android project.

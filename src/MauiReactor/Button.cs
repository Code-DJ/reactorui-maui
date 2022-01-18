using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using MauiReactor.Animations;
//using MauiReactor.Shapes;
using MauiReactor.Internals;

namespace MauiReactor
{
    public partial interface IButton : IView
    {
        PropertyValue<Microsoft.Maui.Controls.Button.ButtonContentLayout>? ContentLayout { get; set; }
        PropertyValue<string>? Text { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? TextColor { get; set; }
        PropertyValue<double>? CharacterSpacing { get; set; }
        PropertyValue<string>? FontFamily { get; set; }
        PropertyValue<double>? FontSize { get; set; }
        PropertyValue<Microsoft.Maui.TextTransform>? TextTransform { get; set; }
        PropertyValue<Microsoft.Maui.Controls.FontAttributes>? FontAttributes { get; set; }
        PropertyValue<bool>? FontAutoScalingEnabled { get; set; }
        PropertyValue<double>? BorderWidth { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? BorderColor { get; set; }
        PropertyValue<int>? CornerRadius { get; set; }
        PropertyValue<Microsoft.Maui.Controls.ImageSource>? ImageSource { get; set; }
        PropertyValue<Microsoft.Maui.Thickness>? Padding { get; set; }
        PropertyValue<Microsoft.Maui.LineBreakMode>? LineBreakMode { get; set; }

        Action? ClickedAction { get; set; }
        Action<object?, EventArgs>? ClickedActionWithArgs { get; set; }
        Action? PressedAction { get; set; }
        Action<object?, EventArgs>? PressedActionWithArgs { get; set; }
        Action? ReleasedAction { get; set; }
        Action<object?, EventArgs>? ReleasedActionWithArgs { get; set; }

    }
    public partial class Button<T> : View<T>, IButton where T : Microsoft.Maui.Controls.Button, new()
    {
        public Button()
        {

        }

        public Button(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<Microsoft.Maui.Controls.Button.ButtonContentLayout>? IButton.ContentLayout { get; set; }
        PropertyValue<string>? IButton.Text { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? IButton.TextColor { get; set; }
        PropertyValue<double>? IButton.CharacterSpacing { get; set; }
        PropertyValue<string>? IButton.FontFamily { get; set; }
        PropertyValue<double>? IButton.FontSize { get; set; }
        PropertyValue<Microsoft.Maui.TextTransform>? IButton.TextTransform { get; set; }
        PropertyValue<Microsoft.Maui.Controls.FontAttributes>? IButton.FontAttributes { get; set; }
        PropertyValue<bool>? IButton.FontAutoScalingEnabled { get; set; }
        PropertyValue<double>? IButton.BorderWidth { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? IButton.BorderColor { get; set; }
        PropertyValue<int>? IButton.CornerRadius { get; set; }
        PropertyValue<Microsoft.Maui.Controls.ImageSource>? IButton.ImageSource { get; set; }
        PropertyValue<Microsoft.Maui.Thickness>? IButton.Padding { get; set; }
        PropertyValue<Microsoft.Maui.LineBreakMode>? IButton.LineBreakMode { get; set; }

        Action? IButton.ClickedAction { get; set; }
        Action<object?, EventArgs>? IButton.ClickedActionWithArgs { get; set; }
        Action? IButton.PressedAction { get; set; }
        Action<object?, EventArgs>? IButton.PressedActionWithArgs { get; set; }
        Action? IButton.ReleasedAction { get; set; }
        Action<object?, EventArgs>? IButton.ReleasedActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsIButton = (IButton)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Button.ContentLayoutProperty, thisAsIButton.ContentLayout);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Button.TextProperty, thisAsIButton.Text);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Button.TextColorProperty, thisAsIButton.TextColor);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Button.CharacterSpacingProperty, thisAsIButton.CharacterSpacing);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Button.FontFamilyProperty, thisAsIButton.FontFamily);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Button.FontSizeProperty, thisAsIButton.FontSize);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Button.TextTransformProperty, thisAsIButton.TextTransform);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Button.FontAttributesProperty, thisAsIButton.FontAttributes);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Button.FontAutoScalingEnabledProperty, thisAsIButton.FontAutoScalingEnabled);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Button.BorderWidthProperty, thisAsIButton.BorderWidth);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Button.BorderColorProperty, thisAsIButton.BorderColor);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Button.CornerRadiusProperty, thisAsIButton.CornerRadius);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Button.ImageSourceProperty, thisAsIButton.ImageSource);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Button.PaddingProperty, thisAsIButton.Padding);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Button.LineBreakModeProperty, thisAsIButton.LineBreakMode);


            base.OnUpdate();

            OnEndUpdate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();

        protected override void OnAttachNativeEvents()
        {
            Validate.EnsureNotNull(NativeControl);

            var thisAsIButton = (IButton)this;
            if (thisAsIButton.ClickedAction != null || thisAsIButton.ClickedActionWithArgs != null)
            {
                NativeControl.Clicked += NativeControl_Clicked;
            }
            if (thisAsIButton.PressedAction != null || thisAsIButton.PressedActionWithArgs != null)
            {
                NativeControl.Pressed += NativeControl_Pressed;
            }
            if (thisAsIButton.ReleasedAction != null || thisAsIButton.ReleasedActionWithArgs != null)
            {
                NativeControl.Released += NativeControl_Released;
            }

            base.OnAttachNativeEvents();
        }

        private void NativeControl_Clicked(object? sender, EventArgs e)
        {
            var thisAsIButton = (IButton)this;
            thisAsIButton.ClickedAction?.Invoke();
            thisAsIButton.ClickedActionWithArgs?.Invoke(sender, e);
        }
        private void NativeControl_Pressed(object? sender, EventArgs e)
        {
            var thisAsIButton = (IButton)this;
            thisAsIButton.PressedAction?.Invoke();
            thisAsIButton.PressedActionWithArgs?.Invoke(sender, e);
        }
        private void NativeControl_Released(object? sender, EventArgs e)
        {
            var thisAsIButton = (IButton)this;
            thisAsIButton.ReleasedAction?.Invoke();
            thisAsIButton.ReleasedActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.Clicked -= NativeControl_Clicked;
                NativeControl.Pressed -= NativeControl_Pressed;
                NativeControl.Released -= NativeControl_Released;
            }

            base.OnDetachNativeEvents();
        }

    }

    public partial class Button : Button<Microsoft.Maui.Controls.Button>
    {
        public Button()
        {

        }

        public Button(Action<Microsoft.Maui.Controls.Button?> componentRefAction)
            : base(componentRefAction)
        {

        }
    }

    public static partial class ButtonExtensions
    {
        public static T ContentLayout<T>(this T button, Microsoft.Maui.Controls.Button.ButtonContentLayout contentLayout) where T : IButton
        {
            button.ContentLayout = new PropertyValue<Microsoft.Maui.Controls.Button.ButtonContentLayout>(contentLayout);
            return button;
        }
        public static T ContentLayout<T>(this T button, Func<Microsoft.Maui.Controls.Button.ButtonContentLayout> contentLayoutFunc) where T : IButton
        {
            button.ContentLayout = new PropertyValue<Microsoft.Maui.Controls.Button.ButtonContentLayout>(contentLayoutFunc);
            return button;
        }



        public static T Text<T>(this T button, string text) where T : IButton
        {
            button.Text = new PropertyValue<string>(text);
            return button;
        }
        public static T Text<T>(this T button, Func<string> textFunc) where T : IButton
        {
            button.Text = new PropertyValue<string>(textFunc);
            return button;
        }



        public static T TextColor<T>(this T button, Microsoft.Maui.Graphics.Color textColor) where T : IButton
        {
            button.TextColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(textColor);
            return button;
        }
        public static T TextColor<T>(this T button, Func<Microsoft.Maui.Graphics.Color> textColorFunc) where T : IButton
        {
            button.TextColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(textColorFunc);
            return button;
        }



        public static T CharacterSpacing<T>(this T button, double characterSpacing) where T : IButton
        {
            button.CharacterSpacing = new PropertyValue<double>(characterSpacing);
            return button;
        }
        public static T CharacterSpacing<T>(this T button, Func<double> characterSpacingFunc) where T : IButton
        {
            button.CharacterSpacing = new PropertyValue<double>(characterSpacingFunc);
            return button;
        }



        public static T FontFamily<T>(this T button, string fontFamily) where T : IButton
        {
            button.FontFamily = new PropertyValue<string>(fontFamily);
            return button;
        }
        public static T FontFamily<T>(this T button, Func<string> fontFamilyFunc) where T : IButton
        {
            button.FontFamily = new PropertyValue<string>(fontFamilyFunc);
            return button;
        }



        public static T FontSize<T>(this T button, double fontSize) where T : IButton
        {
            button.FontSize = new PropertyValue<double>(fontSize);
            return button;
        }
        public static T FontSize<T>(this T button, Func<double> fontSizeFunc) where T : IButton
        {
            button.FontSize = new PropertyValue<double>(fontSizeFunc);
            return button;
        }


        public static T FontSize<T>(this T button, NamedSize size) where T : IButton
        {
            button.FontSize = new PropertyValue<double>(Device.GetNamedSize(size, typeof(Button)));
            return button;
        }

        public static T TextTransform<T>(this T button, Microsoft.Maui.TextTransform textTransform) where T : IButton
        {
            button.TextTransform = new PropertyValue<Microsoft.Maui.TextTransform>(textTransform);
            return button;
        }
        public static T TextTransform<T>(this T button, Func<Microsoft.Maui.TextTransform> textTransformFunc) where T : IButton
        {
            button.TextTransform = new PropertyValue<Microsoft.Maui.TextTransform>(textTransformFunc);
            return button;
        }



        public static T FontAttributes<T>(this T button, Microsoft.Maui.Controls.FontAttributes fontAttributes) where T : IButton
        {
            button.FontAttributes = new PropertyValue<Microsoft.Maui.Controls.FontAttributes>(fontAttributes);
            return button;
        }
        public static T FontAttributes<T>(this T button, Func<Microsoft.Maui.Controls.FontAttributes> fontAttributesFunc) where T : IButton
        {
            button.FontAttributes = new PropertyValue<Microsoft.Maui.Controls.FontAttributes>(fontAttributesFunc);
            return button;
        }



        public static T FontAutoScalingEnabled<T>(this T button, bool fontAutoScalingEnabled) where T : IButton
        {
            button.FontAutoScalingEnabled = new PropertyValue<bool>(fontAutoScalingEnabled);
            return button;
        }
        public static T FontAutoScalingEnabled<T>(this T button, Func<bool> fontAutoScalingEnabledFunc) where T : IButton
        {
            button.FontAutoScalingEnabled = new PropertyValue<bool>(fontAutoScalingEnabledFunc);
            return button;
        }



        public static T BorderWidth<T>(this T button, double borderWidth) where T : IButton
        {
            button.BorderWidth = new PropertyValue<double>(borderWidth);
            return button;
        }
        public static T BorderWidth<T>(this T button, Func<double> borderWidthFunc) where T : IButton
        {
            button.BorderWidth = new PropertyValue<double>(borderWidthFunc);
            return button;
        }



        public static T BorderColor<T>(this T button, Microsoft.Maui.Graphics.Color borderColor) where T : IButton
        {
            button.BorderColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(borderColor);
            return button;
        }
        public static T BorderColor<T>(this T button, Func<Microsoft.Maui.Graphics.Color> borderColorFunc) where T : IButton
        {
            button.BorderColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(borderColorFunc);
            return button;
        }



        public static T CornerRadius<T>(this T button, int cornerRadius) where T : IButton
        {
            button.CornerRadius = new PropertyValue<int>(cornerRadius);
            return button;
        }
        public static T CornerRadius<T>(this T button, Func<int> cornerRadiusFunc) where T : IButton
        {
            button.CornerRadius = new PropertyValue<int>(cornerRadiusFunc);
            return button;
        }



        public static T ImageSource<T>(this T button, Microsoft.Maui.Controls.ImageSource imageSource) where T : IButton
        {
            button.ImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(imageSource);
            return button;
        }
        public static T ImageSource<T>(this T button, Func<Microsoft.Maui.Controls.ImageSource> imageSourceFunc) where T : IButton
        {
            button.ImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(imageSourceFunc);
            return button;
        }


        public static T Image<T>(this T button, string file) where T : IButton
        {
            button.ImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromFile(file));
            return button;
        }
        public static T Image<T>(this T button, string fileAndroid, string fileiOS) where T : IButton
        {
            button.ImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Device.RuntimePlatform == Device.Android ? Microsoft.Maui.Controls.ImageSource.FromFile(fileAndroid) : Microsoft.Maui.Controls.ImageSource.FromFile(fileiOS));
            return button;
        }
        public static T Image<T>(this T button, string resourceName, Assembly sourceAssembly) where T : IButton
        {
            button.ImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromResource(resourceName, sourceAssembly));
            return button;
        }
        public static T Image<T>(this T button, Uri imageUri) where T : IButton
        {
            button.ImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromUri(imageUri));
            return button;
        }
        public static T Image<T>(this T button, Uri imageUri, bool cachingEnabled, TimeSpan cacheValidity) where T : IButton
        {
            button.ImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(new UriImageSource
            {
                Uri = imageUri,
                CachingEnabled = cachingEnabled,
                CacheValidity = cacheValidity
            });
            return button;
        }
        public static T Image<T>(this T button, Func<Stream> imageStream) where T : IButton
        {
            button.ImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromStream(imageStream));
            return button;
        }

        public static T Padding<T>(this T button, Microsoft.Maui.Thickness padding) where T : IButton
        {
            button.Padding = new PropertyValue<Microsoft.Maui.Thickness>(padding);
            return button;
        }
        public static T Padding<T>(this T button, Func<Microsoft.Maui.Thickness> paddingFunc) where T : IButton
        {
            button.Padding = new PropertyValue<Microsoft.Maui.Thickness>(paddingFunc);
            return button;
        }
        public static T Padding<T>(this T button, double leftRight, double topBottom) where T : IButton
        {
            button.Padding = new PropertyValue<Microsoft.Maui.Thickness>(new Thickness(leftRight, topBottom));
            return button;
        }
        public static T Padding<T>(this T button, double uniformSize) where T : IButton
        {
            button.Padding = new PropertyValue<Microsoft.Maui.Thickness>(new Thickness(uniformSize));
            return button;
        }



        public static T LineBreakMode<T>(this T button, Microsoft.Maui.LineBreakMode lineBreakMode) where T : IButton
        {
            button.LineBreakMode = new PropertyValue<Microsoft.Maui.LineBreakMode>(lineBreakMode);
            return button;
        }
        public static T LineBreakMode<T>(this T button, Func<Microsoft.Maui.LineBreakMode> lineBreakModeFunc) where T : IButton
        {
            button.LineBreakMode = new PropertyValue<Microsoft.Maui.LineBreakMode>(lineBreakModeFunc);
            return button;
        }




        public static T OnClicked<T>(this T button, Action clickedAction) where T : IButton
        {
            button.ClickedAction = clickedAction;
            return button;
        }

        public static T OnClicked<T>(this T button, Action<object?, EventArgs> clickedActionWithArgs) where T : IButton
        {
            button.ClickedActionWithArgs = clickedActionWithArgs;
            return button;
        }
        public static T OnPressed<T>(this T button, Action pressedAction) where T : IButton
        {
            button.PressedAction = pressedAction;
            return button;
        }

        public static T OnPressed<T>(this T button, Action<object?, EventArgs> pressedActionWithArgs) where T : IButton
        {
            button.PressedActionWithArgs = pressedActionWithArgs;
            return button;
        }
        public static T OnReleased<T>(this T button, Action releasedAction) where T : IButton
        {
            button.ReleasedAction = releasedAction;
            return button;
        }

        public static T OnReleased<T>(this T button, Action<object?, EventArgs> releasedActionWithArgs) where T : IButton
        {
            button.ReleasedActionWithArgs = releasedActionWithArgs;
            return button;
        }
    }
}

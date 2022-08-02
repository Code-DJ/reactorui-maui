// <auto-generated />
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using MauiReactor.Animations;
using MauiReactor.Shapes;
using MauiReactor.Internals;

#nullable enable

namespace MauiReactor
{
    public partial interface IImageButton : IView
    {
        PropertyValue<int>? CornerRadius { get; set; }
        PropertyValue<double>? BorderWidth { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? BorderColor { get; set; }
        PropertyValue<Microsoft.Maui.Controls.ImageSource>? Source { get; set; }
        PropertyValue<Microsoft.Maui.Aspect>? Aspect { get; set; }
        PropertyValue<bool>? IsOpaque { get; set; }
        PropertyValue<Microsoft.Maui.Thickness>? Padding { get; set; }

        Action? ClickedAction { get; set; }
        Action<object?, EventArgs>? ClickedActionWithArgs { get; set; }
        Action? PressedAction { get; set; }
        Action<object?, EventArgs>? PressedActionWithArgs { get; set; }
        Action? ReleasedAction { get; set; }
        Action<object?, EventArgs>? ReleasedActionWithArgs { get; set; }

    }

    public partial class ImageButton<T> : View<T>, IImageButton where T : Microsoft.Maui.Controls.ImageButton, new()
    {
        public ImageButton()
        {

        }

        public ImageButton(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<int>? IImageButton.CornerRadius { get; set; }
        PropertyValue<double>? IImageButton.BorderWidth { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? IImageButton.BorderColor { get; set; }
        PropertyValue<Microsoft.Maui.Controls.ImageSource>? IImageButton.Source { get; set; }
        PropertyValue<Microsoft.Maui.Aspect>? IImageButton.Aspect { get; set; }
        PropertyValue<bool>? IImageButton.IsOpaque { get; set; }
        PropertyValue<Microsoft.Maui.Thickness>? IImageButton.Padding { get; set; }

        Action? IImageButton.ClickedAction { get; set; }
        Action<object?, EventArgs>? IImageButton.ClickedActionWithArgs { get; set; }
        Action? IImageButton.PressedAction { get; set; }
        Action<object?, EventArgs>? IImageButton.PressedActionWithArgs { get; set; }
        Action? IImageButton.ReleasedAction { get; set; }
        Action<object?, EventArgs>? IImageButton.ReleasedActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsIImageButton = (IImageButton)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ImageButton.CornerRadiusProperty, thisAsIImageButton.CornerRadius);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ImageButton.BorderWidthProperty, thisAsIImageButton.BorderWidth);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ImageButton.BorderColorProperty, thisAsIImageButton.BorderColor);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ImageButton.SourceProperty, thisAsIImageButton.Source);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ImageButton.AspectProperty, thisAsIImageButton.Aspect);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ImageButton.IsOpaqueProperty, thisAsIImageButton.IsOpaque);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ImageButton.PaddingProperty, thisAsIImageButton.Padding);


            base.OnUpdate();

            OnEndUpdate();
        }

        protected override void OnAnimate()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsIImageButton = (IImageButton)this;

            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ImageButton.BorderWidthProperty, thisAsIImageButton.BorderWidth);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ImageButton.PaddingProperty, thisAsIImageButton.Padding);

            base.OnAnimate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();

        protected override void OnAttachNativeEvents()
        {
            Validate.EnsureNotNull(NativeControl);

            var thisAsIImageButton = (IImageButton)this;
            if (thisAsIImageButton.ClickedAction != null || thisAsIImageButton.ClickedActionWithArgs != null)
            {
                NativeControl.Clicked += NativeControl_Clicked;
            }
            if (thisAsIImageButton.PressedAction != null || thisAsIImageButton.PressedActionWithArgs != null)
            {
                NativeControl.Pressed += NativeControl_Pressed;
            }
            if (thisAsIImageButton.ReleasedAction != null || thisAsIImageButton.ReleasedActionWithArgs != null)
            {
                NativeControl.Released += NativeControl_Released;
            }

            base.OnAttachNativeEvents();
        }

        private void NativeControl_Clicked(object? sender, EventArgs e)
        {
            var thisAsIImageButton = (IImageButton)this;
            thisAsIImageButton.ClickedAction?.Invoke();
            thisAsIImageButton.ClickedActionWithArgs?.Invoke(sender, e);
        }
        private void NativeControl_Pressed(object? sender, EventArgs e)
        {
            var thisAsIImageButton = (IImageButton)this;
            thisAsIImageButton.PressedAction?.Invoke();
            thisAsIImageButton.PressedActionWithArgs?.Invoke(sender, e);
        }
        private void NativeControl_Released(object? sender, EventArgs e)
        {
            var thisAsIImageButton = (IImageButton)this;
            thisAsIImageButton.ReleasedAction?.Invoke();
            thisAsIImageButton.ReleasedActionWithArgs?.Invoke(sender, e);
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

    public partial class ImageButton : ImageButton<Microsoft.Maui.Controls.ImageButton>
    {
        public ImageButton()
        {

        }

        public ImageButton(Action<Microsoft.Maui.Controls.ImageButton?> componentRefAction)
            : base(componentRefAction)
        {

        }
    }

    public static partial class ImageButtonExtensions
    {
        public static T CornerRadius<T>(this T imageButton, int cornerRadius) where T : IImageButton
        {
            imageButton.CornerRadius = new PropertyValue<int>(cornerRadius);
            return imageButton;
        }

        public static T CornerRadius<T>(this T imageButton, Func<int> cornerRadiusFunc) where T : IImageButton
        {
            imageButton.CornerRadius = new PropertyValue<int>(cornerRadiusFunc);
            return imageButton;
        }



        public static T BorderWidth<T>(this T imageButton, double borderWidth, RxDoubleAnimation? customAnimation = null) where T : IImageButton
        {
            imageButton.BorderWidth = new PropertyValue<double>(borderWidth);
            imageButton.AppendAnimatable(Microsoft.Maui.Controls.ImageButton.BorderWidthProperty, customAnimation ?? new RxDoubleAnimation(borderWidth), v => imageButton.BorderWidth = new PropertyValue<double>(v.CurrentValue()));
            return imageButton;
        }

        public static T BorderWidth<T>(this T imageButton, Func<double> borderWidthFunc) where T : IImageButton
        {
            imageButton.BorderWidth = new PropertyValue<double>(borderWidthFunc);
            return imageButton;
        }



        public static T BorderColor<T>(this T imageButton, Microsoft.Maui.Graphics.Color borderColor) where T : IImageButton
        {
            imageButton.BorderColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(borderColor);
            return imageButton;
        }

        public static T BorderColor<T>(this T imageButton, Func<Microsoft.Maui.Graphics.Color> borderColorFunc) where T : IImageButton
        {
            imageButton.BorderColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(borderColorFunc);
            return imageButton;
        }



        public static T Source<T>(this T imageButton, Microsoft.Maui.Controls.ImageSource source) where T : IImageButton
        {
            imageButton.Source = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(source);
            return imageButton;
        }

        public static T Source<T>(this T imageButton, Func<Microsoft.Maui.Controls.ImageSource> sourceFunc) where T : IImageButton
        {
            imageButton.Source = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(sourceFunc);
            return imageButton;
        }


        public static T Source<T>(this T imageButton, string file) where T : IImageButton
        {
            imageButton.Source = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromFile(file));
            return imageButton;
        }
        public static T Source<T>(this T imageButton, string resourceName, Assembly sourceAssembly) where T : IImageButton
        {
            imageButton.Source = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromResource(resourceName, sourceAssembly));
            return imageButton;
        }
        public static T Source<T>(this T imageButton, Uri imageUri) where T : IImageButton
        {
            imageButton.Source = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromUri(imageUri));
            return imageButton;
        }
        public static T Source<T>(this T imageButton, Uri imageUri, bool cachingEnabled, TimeSpan cacheValidity) where T : IImageButton
        {
            imageButton.Source = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(new UriImageSource
            {
                Uri = imageUri,
                CachingEnabled = cachingEnabled,
                CacheValidity = cacheValidity
            });
            return imageButton;
        }
        public static T Source<T>(this T imageButton, Func<Stream> imageStream) where T : IImageButton
        {
            imageButton.Source = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromStream(imageStream));
            return imageButton;
        }

        public static T Aspect<T>(this T imageButton, Microsoft.Maui.Aspect aspect) where T : IImageButton
        {
            imageButton.Aspect = new PropertyValue<Microsoft.Maui.Aspect>(aspect);
            return imageButton;
        }

        public static T Aspect<T>(this T imageButton, Func<Microsoft.Maui.Aspect> aspectFunc) where T : IImageButton
        {
            imageButton.Aspect = new PropertyValue<Microsoft.Maui.Aspect>(aspectFunc);
            return imageButton;
        }



        public static T IsOpaque<T>(this T imageButton, bool isOpaque) where T : IImageButton
        {
            imageButton.IsOpaque = new PropertyValue<bool>(isOpaque);
            return imageButton;
        }

        public static T IsOpaque<T>(this T imageButton, Func<bool> isOpaqueFunc) where T : IImageButton
        {
            imageButton.IsOpaque = new PropertyValue<bool>(isOpaqueFunc);
            return imageButton;
        }



        public static T Padding<T>(this T imageButton, Microsoft.Maui.Thickness padding, RxThicknessAnimation? customAnimation = null) where T : IImageButton
        {
            imageButton.Padding = new PropertyValue<Microsoft.Maui.Thickness>(padding);
            imageButton.AppendAnimatable(Microsoft.Maui.Controls.ImageButton.PaddingProperty, customAnimation ?? new RxSimpleThicknessAnimation(padding), v => imageButton.Padding = new PropertyValue<Microsoft.Maui.Thickness>(v.CurrentValue()));
            return imageButton;
        }

        public static T Padding<T>(this T imageButton, Func<Microsoft.Maui.Thickness> paddingFunc) where T : IImageButton
        {
            imageButton.Padding = new PropertyValue<Microsoft.Maui.Thickness>(paddingFunc);
            return imageButton;
        }
        public static T Padding<T>(this T imageButton, double leftRight, double topBottom) where T : IImageButton
        {
            imageButton.Padding = new PropertyValue<Microsoft.Maui.Thickness>(new Thickness(leftRight, topBottom));
            return imageButton;
        }
        public static T Padding<T>(this T imageButton, double uniformSize) where T : IImageButton
        {
            imageButton.Padding = new PropertyValue<Microsoft.Maui.Thickness>(new Thickness(uniformSize));
            return imageButton;
        }
        public static T Padding<T>(this T imageButton, double left, double top, double right, double bottom) where T : IImageButton
        {
            imageButton.Padding = new PropertyValue<Microsoft.Maui.Thickness>(new Thickness(left, top, right, bottom));
            return imageButton;
        }




        public static T OnClicked<T>(this T imageButton, Action? clickedAction) where T : IImageButton
        {
            imageButton.ClickedAction = clickedAction;
            return imageButton;
        }

        public static T OnClicked<T>(this T imageButton, Action<object?, EventArgs>? clickedActionWithArgs) where T : IImageButton
        {
            imageButton.ClickedActionWithArgs = clickedActionWithArgs;
            return imageButton;
        }
        public static T OnPressed<T>(this T imageButton, Action? pressedAction) where T : IImageButton
        {
            imageButton.PressedAction = pressedAction;
            return imageButton;
        }

        public static T OnPressed<T>(this T imageButton, Action<object?, EventArgs>? pressedActionWithArgs) where T : IImageButton
        {
            imageButton.PressedActionWithArgs = pressedActionWithArgs;
            return imageButton;
        }
        public static T OnReleased<T>(this T imageButton, Action? releasedAction) where T : IImageButton
        {
            imageButton.ReleasedAction = releasedAction;
            return imageButton;
        }

        public static T OnReleased<T>(this T imageButton, Action<object?, EventArgs>? releasedActionWithArgs) where T : IImageButton
        {
            imageButton.ReleasedActionWithArgs = releasedActionWithArgs;
            return imageButton;
        }
    }
}

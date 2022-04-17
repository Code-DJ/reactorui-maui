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
    public partial interface IEntry : IInputView
    {
        PropertyValue<Microsoft.Maui.ReturnType>? ReturnType { get; set; }
        PropertyValue<bool>? IsPassword { get; set; }
        PropertyValue<Microsoft.Maui.TextAlignment>? HorizontalTextAlignment { get; set; }
        PropertyValue<Microsoft.Maui.TextAlignment>? VerticalTextAlignment { get; set; }
        PropertyValue<string>? FontFamily { get; set; }
        PropertyValue<double>? FontSize { get; set; }
        PropertyValue<Microsoft.Maui.Controls.FontAttributes>? FontAttributes { get; set; }
        PropertyValue<bool>? FontAutoScalingEnabled { get; set; }
        PropertyValue<bool>? IsTextPredictionEnabled { get; set; }
        PropertyValue<int>? CursorPosition { get; set; }
        PropertyValue<int>? SelectionLength { get; set; }
        PropertyValue<Microsoft.Maui.ClearButtonVisibility>? ClearButtonVisibility { get; set; }

        Action? CompletedAction { get; set; }
        Action<object?, EventArgs>? CompletedActionWithArgs { get; set; }

    }

    public partial class Entry<T> : InputView<T>, IEntry where T : Microsoft.Maui.Controls.Entry, new()
    {
        public Entry()
        {

        }

        public Entry(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<Microsoft.Maui.ReturnType>? IEntry.ReturnType { get; set; }
        PropertyValue<bool>? IEntry.IsPassword { get; set; }
        PropertyValue<Microsoft.Maui.TextAlignment>? IEntry.HorizontalTextAlignment { get; set; }
        PropertyValue<Microsoft.Maui.TextAlignment>? IEntry.VerticalTextAlignment { get; set; }
        PropertyValue<string>? IEntry.FontFamily { get; set; }
        PropertyValue<double>? IEntry.FontSize { get; set; }
        PropertyValue<Microsoft.Maui.Controls.FontAttributes>? IEntry.FontAttributes { get; set; }
        PropertyValue<bool>? IEntry.FontAutoScalingEnabled { get; set; }
        PropertyValue<bool>? IEntry.IsTextPredictionEnabled { get; set; }
        PropertyValue<int>? IEntry.CursorPosition { get; set; }
        PropertyValue<int>? IEntry.SelectionLength { get; set; }
        PropertyValue<Microsoft.Maui.ClearButtonVisibility>? IEntry.ClearButtonVisibility { get; set; }

        Action? IEntry.CompletedAction { get; set; }
        Action<object?, EventArgs>? IEntry.CompletedActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsIEntry = (IEntry)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Entry.ReturnTypeProperty, thisAsIEntry.ReturnType);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Entry.IsPasswordProperty, thisAsIEntry.IsPassword);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Entry.HorizontalTextAlignmentProperty, thisAsIEntry.HorizontalTextAlignment);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Entry.VerticalTextAlignmentProperty, thisAsIEntry.VerticalTextAlignment);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Entry.FontFamilyProperty, thisAsIEntry.FontFamily);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Entry.FontSizeProperty, thisAsIEntry.FontSize);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Entry.FontAttributesProperty, thisAsIEntry.FontAttributes);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Entry.FontAutoScalingEnabledProperty, thisAsIEntry.FontAutoScalingEnabled);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Entry.IsTextPredictionEnabledProperty, thisAsIEntry.IsTextPredictionEnabled);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Entry.CursorPositionProperty, thisAsIEntry.CursorPosition);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Entry.SelectionLengthProperty, thisAsIEntry.SelectionLength);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Entry.ClearButtonVisibilityProperty, thisAsIEntry.ClearButtonVisibility);


            base.OnUpdate();

            OnEndUpdate();
        }

        protected override void OnAnimate()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsIEntry = (IEntry)this;

            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Entry.FontSizeProperty, thisAsIEntry.FontSize);

            base.OnAnimate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();

        protected override void OnAttachNativeEvents()
        {
            Validate.EnsureNotNull(NativeControl);

            var thisAsIEntry = (IEntry)this;
            if (thisAsIEntry.CompletedAction != null || thisAsIEntry.CompletedActionWithArgs != null)
            {
                NativeControl.Completed += NativeControl_Completed;
            }

            base.OnAttachNativeEvents();
        }

        private void NativeControl_Completed(object? sender, EventArgs e)
        {
            var thisAsIEntry = (IEntry)this;
            thisAsIEntry.CompletedAction?.Invoke();
            thisAsIEntry.CompletedActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.Completed -= NativeControl_Completed;
            }

            base.OnDetachNativeEvents();
        }

    }

    public partial class Entry : Entry<Microsoft.Maui.Controls.Entry>
    {
        public Entry()
        {

        }

        public Entry(Action<Microsoft.Maui.Controls.Entry?> componentRefAction)
            : base(componentRefAction)
        {

        }
    }

    public static partial class EntryExtensions
    {
        public static T ReturnType<T>(this T entry, Microsoft.Maui.ReturnType returnType) where T : IEntry
        {
            entry.ReturnType = new PropertyValue<Microsoft.Maui.ReturnType>(returnType);
            return entry;
        }

        public static T ReturnType<T>(this T entry, Func<Microsoft.Maui.ReturnType> returnTypeFunc) where T : IEntry
        {
            entry.ReturnType = new PropertyValue<Microsoft.Maui.ReturnType>(returnTypeFunc);
            return entry;
        }



        public static T IsPassword<T>(this T entry, bool isPassword) where T : IEntry
        {
            entry.IsPassword = new PropertyValue<bool>(isPassword);
            return entry;
        }

        public static T IsPassword<T>(this T entry, Func<bool> isPasswordFunc) where T : IEntry
        {
            entry.IsPassword = new PropertyValue<bool>(isPasswordFunc);
            return entry;
        }



        public static T HorizontalTextAlignment<T>(this T entry, Microsoft.Maui.TextAlignment horizontalTextAlignment) where T : IEntry
        {
            entry.HorizontalTextAlignment = new PropertyValue<Microsoft.Maui.TextAlignment>(horizontalTextAlignment);
            return entry;
        }

        public static T HorizontalTextAlignment<T>(this T entry, Func<Microsoft.Maui.TextAlignment> horizontalTextAlignmentFunc) where T : IEntry
        {
            entry.HorizontalTextAlignment = new PropertyValue<Microsoft.Maui.TextAlignment>(horizontalTextAlignmentFunc);
            return entry;
        }



        public static T VerticalTextAlignment<T>(this T entry, Microsoft.Maui.TextAlignment verticalTextAlignment) where T : IEntry
        {
            entry.VerticalTextAlignment = new PropertyValue<Microsoft.Maui.TextAlignment>(verticalTextAlignment);
            return entry;
        }

        public static T VerticalTextAlignment<T>(this T entry, Func<Microsoft.Maui.TextAlignment> verticalTextAlignmentFunc) where T : IEntry
        {
            entry.VerticalTextAlignment = new PropertyValue<Microsoft.Maui.TextAlignment>(verticalTextAlignmentFunc);
            return entry;
        }



        public static T FontFamily<T>(this T entry, string fontFamily) where T : IEntry
        {
            entry.FontFamily = new PropertyValue<string>(fontFamily);
            return entry;
        }

        public static T FontFamily<T>(this T entry, Func<string> fontFamilyFunc) where T : IEntry
        {
            entry.FontFamily = new PropertyValue<string>(fontFamilyFunc);
            return entry;
        }



        public static T FontSize<T>(this T entry, double fontSize, RxDoubleAnimation? customAnimation = null) where T : IEntry
        {
            entry.FontSize = new PropertyValue<double>(fontSize);
            entry.AppendAnimatable(Microsoft.Maui.Controls.Entry.FontSizeProperty, customAnimation ?? new RxDoubleAnimation(fontSize), v => entry.FontSize = new PropertyValue<double>(v.CurrentValue()));
            return entry;
        }

        public static T FontSize<T>(this T entry, Func<double> fontSizeFunc) where T : IEntry
        {
            entry.FontSize = new PropertyValue<double>(fontSizeFunc);
            return entry;
        }



        public static T FontAttributes<T>(this T entry, Microsoft.Maui.Controls.FontAttributes fontAttributes) where T : IEntry
        {
            entry.FontAttributes = new PropertyValue<Microsoft.Maui.Controls.FontAttributes>(fontAttributes);
            return entry;
        }

        public static T FontAttributes<T>(this T entry, Func<Microsoft.Maui.Controls.FontAttributes> fontAttributesFunc) where T : IEntry
        {
            entry.FontAttributes = new PropertyValue<Microsoft.Maui.Controls.FontAttributes>(fontAttributesFunc);
            return entry;
        }



        public static T FontAutoScalingEnabled<T>(this T entry, bool fontAutoScalingEnabled) where T : IEntry
        {
            entry.FontAutoScalingEnabled = new PropertyValue<bool>(fontAutoScalingEnabled);
            return entry;
        }

        public static T FontAutoScalingEnabled<T>(this T entry, Func<bool> fontAutoScalingEnabledFunc) where T : IEntry
        {
            entry.FontAutoScalingEnabled = new PropertyValue<bool>(fontAutoScalingEnabledFunc);
            return entry;
        }



        public static T IsTextPredictionEnabled<T>(this T entry, bool isTextPredictionEnabled) where T : IEntry
        {
            entry.IsTextPredictionEnabled = new PropertyValue<bool>(isTextPredictionEnabled);
            return entry;
        }

        public static T IsTextPredictionEnabled<T>(this T entry, Func<bool> isTextPredictionEnabledFunc) where T : IEntry
        {
            entry.IsTextPredictionEnabled = new PropertyValue<bool>(isTextPredictionEnabledFunc);
            return entry;
        }



        public static T CursorPosition<T>(this T entry, int cursorPosition) where T : IEntry
        {
            entry.CursorPosition = new PropertyValue<int>(cursorPosition);
            return entry;
        }

        public static T CursorPosition<T>(this T entry, Func<int> cursorPositionFunc) where T : IEntry
        {
            entry.CursorPosition = new PropertyValue<int>(cursorPositionFunc);
            return entry;
        }



        public static T SelectionLength<T>(this T entry, int selectionLength) where T : IEntry
        {
            entry.SelectionLength = new PropertyValue<int>(selectionLength);
            return entry;
        }

        public static T SelectionLength<T>(this T entry, Func<int> selectionLengthFunc) where T : IEntry
        {
            entry.SelectionLength = new PropertyValue<int>(selectionLengthFunc);
            return entry;
        }



        public static T ClearButtonVisibility<T>(this T entry, Microsoft.Maui.ClearButtonVisibility clearButtonVisibility) where T : IEntry
        {
            entry.ClearButtonVisibility = new PropertyValue<Microsoft.Maui.ClearButtonVisibility>(clearButtonVisibility);
            return entry;
        }

        public static T ClearButtonVisibility<T>(this T entry, Func<Microsoft.Maui.ClearButtonVisibility> clearButtonVisibilityFunc) where T : IEntry
        {
            entry.ClearButtonVisibility = new PropertyValue<Microsoft.Maui.ClearButtonVisibility>(clearButtonVisibilityFunc);
            return entry;
        }




        public static T OnCompleted<T>(this T entry, Action completedAction) where T : IEntry
        {
            entry.CompletedAction = completedAction;
            return entry;
        }

        public static T OnCompleted<T>(this T entry, Action<object?, EventArgs> completedActionWithArgs) where T : IEntry
        {
            entry.CompletedActionWithArgs = completedActionWithArgs;
            return entry;
        }
    }
}

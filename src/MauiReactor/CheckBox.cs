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
    public partial interface ICheckBox : IView
    {
        PropertyValue<bool>? IsChecked { get; set; }

        PropertyValue<Microsoft.Maui.Graphics.Color>? Color { get; set; }

        Action? CheckedChangedAction { get; set; }

        Action<object?, CheckedChangedEventArgs>? CheckedChangedActionWithArgs { get; set; }
    }

    public partial class CheckBox<T> : View<T>, ICheckBox where T : Microsoft.Maui.Controls.CheckBox, new()
    {
        public CheckBox()
        {
        }

        public CheckBox(Action<T?> componentRefAction) : base(componentRefAction)
        {
        }

        PropertyValue<bool>? ICheckBox.IsChecked { get; set; }

        PropertyValue<Microsoft.Maui.Graphics.Color>? ICheckBox.Color { get; set; }

        Action? ICheckBox.CheckedChangedAction { get; set; }

        Action<object?, CheckedChangedEventArgs>? ICheckBox.CheckedChangedActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();
            Validate.EnsureNotNull(NativeControl);
            var thisAsICheckBox = (ICheckBox)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.CheckBox.IsCheckedProperty, thisAsICheckBox.IsChecked);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.CheckBox.ColorProperty, thisAsICheckBox.Color);
            base.OnUpdate();
            OnEndUpdate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();
        partial void OnBeginAnimate();
        partial void OnEndAnimate();
        partial void OnAttachingNativeEvents();
        partial void OnDetachingNativeEvents();
        protected override void OnAttachNativeEvents()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsICheckBox = (ICheckBox)this;
            if (thisAsICheckBox.CheckedChangedAction != null || thisAsICheckBox.CheckedChangedActionWithArgs != null)
            {
                NativeControl.CheckedChanged += NativeControl_CheckedChanged;
            }

            OnAttachingNativeEvents();
            base.OnAttachNativeEvents();
        }

        private void NativeControl_CheckedChanged(object? sender, CheckedChangedEventArgs e)
        {
            var thisAsICheckBox = (ICheckBox)this;
            thisAsICheckBox.CheckedChangedAction?.Invoke();
            thisAsICheckBox.CheckedChangedActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.CheckedChanged -= NativeControl_CheckedChanged;
            }

            OnDetachingNativeEvents();
            base.OnDetachNativeEvents();
        }
    }

    public partial class CheckBox : CheckBox<Microsoft.Maui.Controls.CheckBox>
    {
        public CheckBox()
        {
        }

        public CheckBox(Action<Microsoft.Maui.Controls.CheckBox?> componentRefAction) : base(componentRefAction)
        {
        }
    }

    public static partial class CheckBoxExtensions
    {
        public static T IsChecked<T>(this T checkBox, bool isChecked)
            where T : ICheckBox
        {
            checkBox.IsChecked = new PropertyValue<bool>(isChecked);
            return checkBox;
        }

        public static T IsChecked<T>(this T checkBox, Func<bool> isCheckedFunc)
            where T : ICheckBox
        {
            checkBox.IsChecked = new PropertyValue<bool>(isCheckedFunc);
            return checkBox;
        }

        public static T Color<T>(this T checkBox, Microsoft.Maui.Graphics.Color color)
            where T : ICheckBox
        {
            checkBox.Color = new PropertyValue<Microsoft.Maui.Graphics.Color>(color);
            return checkBox;
        }

        public static T Color<T>(this T checkBox, Func<Microsoft.Maui.Graphics.Color> colorFunc)
            where T : ICheckBox
        {
            checkBox.Color = new PropertyValue<Microsoft.Maui.Graphics.Color>(colorFunc);
            return checkBox;
        }

        public static T OnCheckedChanged<T>(this T checkBox, Action? checkedChangedAction)
            where T : ICheckBox
        {
            checkBox.CheckedChangedAction = checkedChangedAction;
            return checkBox;
        }

        public static T OnCheckedChanged<T>(this T checkBox, Action<object?, CheckedChangedEventArgs>? checkedChangedActionWithArgs)
            where T : ICheckBox
        {
            checkBox.CheckedChangedActionWithArgs = checkedChangedActionWithArgs;
            return checkBox;
        }
    }
}
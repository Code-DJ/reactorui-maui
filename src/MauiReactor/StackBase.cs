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
    public partial interface IStackBase : ILayout
    {
        PropertyValue<double>? Spacing { get; set; }
    }

    public abstract partial class StackBase<T> : Layout<T>, IStackBase where T : Microsoft.Maui.Controls.StackBase, new()
    {
        protected StackBase()
        {
        }

        protected StackBase(Action<T?> componentRefAction) : base(componentRefAction)
        {
        }

        PropertyValue<double>? IStackBase.Spacing { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();
            Validate.EnsureNotNull(NativeControl);
            var thisAsIStackBase = (IStackBase)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.StackBase.SpacingProperty, thisAsIStackBase.Spacing);
            base.OnUpdate();
            OnEndUpdate();
        }

        protected override void OnAnimate()
        {
            OnBeginAnimate();
            Validate.EnsureNotNull(NativeControl);
            var thisAsIStackBase = (IStackBase)this;
            AnimateProperty(Microsoft.Maui.Controls.StackBase.SpacingProperty, thisAsIStackBase.Spacing);
            base.OnAnimate();
            OnEndAnimate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();
        partial void OnBeginAnimate();
        partial void OnEndAnimate();
    }

    public static partial class StackBaseExtensions
    {
        public static T Spacing<T>(this T stackBase, double spacing, RxDoubleAnimation? customAnimation = null)
            where T : IStackBase
        {
            stackBase.Spacing = new PropertyValue<double>(spacing);
            stackBase.AppendAnimatable(Microsoft.Maui.Controls.StackBase.SpacingProperty, customAnimation ?? new RxDoubleAnimation(spacing), v => stackBase.Spacing = new PropertyValue<double>(v.CurrentValue()));
            return stackBase;
        }

        public static T Spacing<T>(this T stackBase, Func<double> spacingFunc)
            where T : IStackBase
        {
            stackBase.Spacing = new PropertyValue<double>(spacingFunc);
            return stackBase;
        }
    }
}
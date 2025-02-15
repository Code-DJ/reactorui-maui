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
    public partial interface IPinchGestureRecognizer : IGestureRecognizer
    {
        Action? PinchUpdatedAction { get; set; }

        Action<object?, PinchGestureUpdatedEventArgs>? PinchUpdatedActionWithArgs { get; set; }
    }

    public sealed partial class PinchGestureRecognizer : GestureRecognizer<Microsoft.Maui.Controls.PinchGestureRecognizer>, IPinchGestureRecognizer
    {
        public PinchGestureRecognizer()
        {
        }

        public PinchGestureRecognizer(Action<Microsoft.Maui.Controls.PinchGestureRecognizer?> componentRefAction) : base(componentRefAction)
        {
        }

        Action? IPinchGestureRecognizer.PinchUpdatedAction { get; set; }

        Action<object?, PinchGestureUpdatedEventArgs>? IPinchGestureRecognizer.PinchUpdatedActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();
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
            var thisAsIPinchGestureRecognizer = (IPinchGestureRecognizer)this;
            if (thisAsIPinchGestureRecognizer.PinchUpdatedAction != null || thisAsIPinchGestureRecognizer.PinchUpdatedActionWithArgs != null)
            {
                NativeControl.PinchUpdated += NativeControl_PinchUpdated;
            }

            OnAttachingNativeEvents();
            base.OnAttachNativeEvents();
        }

        private void NativeControl_PinchUpdated(object? sender, PinchGestureUpdatedEventArgs e)
        {
            var thisAsIPinchGestureRecognizer = (IPinchGestureRecognizer)this;
            thisAsIPinchGestureRecognizer.PinchUpdatedAction?.Invoke();
            thisAsIPinchGestureRecognizer.PinchUpdatedActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.PinchUpdated -= NativeControl_PinchUpdated;
            }

            OnDetachingNativeEvents();
            base.OnDetachNativeEvents();
        }
    }

    public static partial class PinchGestureRecognizerExtensions
    {
        public static T OnPinchUpdated<T>(this T pinchGestureRecognizer, Action? pinchUpdatedAction)
            where T : IPinchGestureRecognizer
        {
            pinchGestureRecognizer.PinchUpdatedAction = pinchUpdatedAction;
            return pinchGestureRecognizer;
        }

        public static T OnPinchUpdated<T>(this T pinchGestureRecognizer, Action<object?, PinchGestureUpdatedEventArgs>? pinchUpdatedActionWithArgs)
            where T : IPinchGestureRecognizer
        {
            pinchGestureRecognizer.PinchUpdatedActionWithArgs = pinchUpdatedActionWithArgs;
            return pinchGestureRecognizer;
        }
    }
}
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

namespace MauiReactor.Shapes
{
    public partial interface IGeometryGroup : Shapes.IGeometry
    {
        PropertyValue<Microsoft.Maui.Controls.Shapes.GeometryCollection>? Children { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Shapes.FillRule>? FillRule { get; set; }

        Action? InvalidateGeometryRequestedAction { get; set; }
        Action<object?, EventArgs>? InvalidateGeometryRequestedActionWithArgs { get; set; }

    }

    public partial class GeometryGroup<T> : Shapes.Geometry<T>, IGeometryGroup where T : Microsoft.Maui.Controls.Shapes.GeometryGroup, new()
    {
        public GeometryGroup()
        {

        }

        public GeometryGroup(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<Microsoft.Maui.Controls.Shapes.GeometryCollection>? IGeometryGroup.Children { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Shapes.FillRule>? IGeometryGroup.FillRule { get; set; }

        Action? IGeometryGroup.InvalidateGeometryRequestedAction { get; set; }
        Action<object?, EventArgs>? IGeometryGroup.InvalidateGeometryRequestedActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsIGeometryGroup = (IGeometryGroup)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.GeometryGroup.ChildrenProperty, thisAsIGeometryGroup.Children);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.GeometryGroup.FillRuleProperty, thisAsIGeometryGroup.FillRule);


            base.OnUpdate();

            OnEndUpdate();
        }


        partial void OnBeginUpdate();
        partial void OnEndUpdate();

        protected override void OnAttachNativeEvents()
        {
            Validate.EnsureNotNull(NativeControl);

            var thisAsIGeometryGroup = (IGeometryGroup)this;
            if (thisAsIGeometryGroup.InvalidateGeometryRequestedAction != null || thisAsIGeometryGroup.InvalidateGeometryRequestedActionWithArgs != null)
            {
                NativeControl.InvalidateGeometryRequested += NativeControl_InvalidateGeometryRequested;
            }

            base.OnAttachNativeEvents();
        }

        private void NativeControl_InvalidateGeometryRequested(object? sender, EventArgs e)
        {
            var thisAsIGeometryGroup = (IGeometryGroup)this;
            thisAsIGeometryGroup.InvalidateGeometryRequestedAction?.Invoke();
            thisAsIGeometryGroup.InvalidateGeometryRequestedActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.InvalidateGeometryRequested -= NativeControl_InvalidateGeometryRequested;
            }

            base.OnDetachNativeEvents();
        }

    }

    public partial class GeometryGroup : GeometryGroup<Microsoft.Maui.Controls.Shapes.GeometryGroup>
    {
        public GeometryGroup()
        {

        }

        public GeometryGroup(Action<Microsoft.Maui.Controls.Shapes.GeometryGroup?> componentRefAction)
            : base(componentRefAction)
        {

        }
    }

    public static partial class GeometryGroupExtensions
    {
        public static T Children<T>(this T geometryGroup, Microsoft.Maui.Controls.Shapes.GeometryCollection children) where T : IGeometryGroup
        {
            geometryGroup.Children = new PropertyValue<Microsoft.Maui.Controls.Shapes.GeometryCollection>(children);
            return geometryGroup;
        }

        public static T Children<T>(this T geometryGroup, Func<Microsoft.Maui.Controls.Shapes.GeometryCollection> childrenFunc) where T : IGeometryGroup
        {
            geometryGroup.Children = new PropertyValue<Microsoft.Maui.Controls.Shapes.GeometryCollection>(childrenFunc);
            return geometryGroup;
        }



        public static T FillRule<T>(this T geometryGroup, Microsoft.Maui.Controls.Shapes.FillRule fillRule) where T : IGeometryGroup
        {
            geometryGroup.FillRule = new PropertyValue<Microsoft.Maui.Controls.Shapes.FillRule>(fillRule);
            return geometryGroup;
        }

        public static T FillRule<T>(this T geometryGroup, Func<Microsoft.Maui.Controls.Shapes.FillRule> fillRuleFunc) where T : IGeometryGroup
        {
            geometryGroup.FillRule = new PropertyValue<Microsoft.Maui.Controls.Shapes.FillRule>(fillRuleFunc);
            return geometryGroup;
        }




        public static T OnInvalidateGeometryRequested<T>(this T geometryGroup, Action? invalidateGeometryRequestedAction) where T : IGeometryGroup
        {
            geometryGroup.InvalidateGeometryRequestedAction = invalidateGeometryRequestedAction;
            return geometryGroup;
        }

        public static T OnInvalidateGeometryRequested<T>(this T geometryGroup, Action<object?, EventArgs>? invalidateGeometryRequestedActionWithArgs) where T : IGeometryGroup
        {
            geometryGroup.InvalidateGeometryRequestedActionWithArgs = invalidateGeometryRequestedActionWithArgs;
            return geometryGroup;
        }
    }
}

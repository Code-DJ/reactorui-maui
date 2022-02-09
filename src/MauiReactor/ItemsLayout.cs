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
    public partial interface IItemsLayout : IVisualNode
    {
        PropertyValue<Microsoft.Maui.Controls.SnapPointsAlignment>? SnapPointsAlignment { get; set; }
        PropertyValue<Microsoft.Maui.Controls.SnapPointsType>? SnapPointsType { get; set; }


    }
    public abstract partial class ItemsLayout<T> : VisualNode<T>, IItemsLayout where T : Microsoft.Maui.Controls.ItemsLayout, new()
    {
        protected ItemsLayout()
        {

        }

        protected ItemsLayout(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<Microsoft.Maui.Controls.SnapPointsAlignment>? IItemsLayout.SnapPointsAlignment { get; set; }
        PropertyValue<Microsoft.Maui.Controls.SnapPointsType>? IItemsLayout.SnapPointsType { get; set; }


        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsIItemsLayout = (IItemsLayout)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ItemsLayout.SnapPointsAlignmentProperty, thisAsIItemsLayout.SnapPointsAlignment);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ItemsLayout.SnapPointsTypeProperty, thisAsIItemsLayout.SnapPointsType);


            base.OnUpdate();

            OnEndUpdate();
        }


        partial void OnBeginUpdate();
        partial void OnEndUpdate();


    }


    public static partial class ItemsLayoutExtensions
    {
        public static T SnapPointsAlignment<T>(this T itemsLayout, Microsoft.Maui.Controls.SnapPointsAlignment snapPointsAlignment) where T : IItemsLayout
        {
            itemsLayout.SnapPointsAlignment = new PropertyValue<Microsoft.Maui.Controls.SnapPointsAlignment>(snapPointsAlignment);
            return itemsLayout;
        }

        public static T SnapPointsAlignment<T>(this T itemsLayout, Func<Microsoft.Maui.Controls.SnapPointsAlignment> snapPointsAlignmentFunc) where T : IItemsLayout
        {
            itemsLayout.SnapPointsAlignment = new PropertyValue<Microsoft.Maui.Controls.SnapPointsAlignment>(snapPointsAlignmentFunc);
            return itemsLayout;
        }



        public static T SnapPointsType<T>(this T itemsLayout, Microsoft.Maui.Controls.SnapPointsType snapPointsType) where T : IItemsLayout
        {
            itemsLayout.SnapPointsType = new PropertyValue<Microsoft.Maui.Controls.SnapPointsType>(snapPointsType);
            return itemsLayout;
        }

        public static T SnapPointsType<T>(this T itemsLayout, Func<Microsoft.Maui.Controls.SnapPointsType> snapPointsTypeFunc) where T : IItemsLayout
        {
            itemsLayout.SnapPointsType = new PropertyValue<Microsoft.Maui.Controls.SnapPointsType>(snapPointsTypeFunc);
            return itemsLayout;
        }




    }
}

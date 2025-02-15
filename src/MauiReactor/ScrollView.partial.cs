﻿using MauiReactor.Internals;

namespace MauiReactor
{
    public partial class ScrollView<T>
    {
        public ScrollView(VisualNode content)
        {
            _internalChildren.Add(content);
        }

        protected override void OnAddChild(VisualNode widget, BindableObject childControl)
        {
            Validate.EnsureNotNull(NativeControl);

            if (childControl is View view)
                NativeControl.Content = view;

            base.OnAddChild(widget, childControl);
        }

        protected override void OnRemoveChild(VisualNode widget, BindableObject childControl)
        {
            Validate.EnsureNotNull(NativeControl);

            if (childControl is View)
                NativeControl.Content = null;

            base.OnRemoveChild(widget, childControl);
        }

    }

    public class HorizontalScrollView : ScrollView
    {
        public HorizontalScrollView() => this.Orientation(ScrollOrientation.Horizontal);
    }

    public class VerticalScrollView : ScrollView
    {
        public VerticalScrollView() => this.Orientation(ScrollOrientation.Vertical);
    }
}

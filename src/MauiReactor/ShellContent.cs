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
    public partial interface IShellContent : IBaseShellItem
    {
    }

    public partial class ShellContent<T> : BaseShellItem<T>, IShellContent where T : Microsoft.Maui.Controls.ShellContent, new()
    {
        public ShellContent()
        {
        }

        public ShellContent(Action<T?> componentRefAction) : base(componentRefAction)
        {
        }

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
    }

    public partial class ShellContent : ShellContent<Microsoft.Maui.Controls.ShellContent>
    {
        public ShellContent()
        {
        }

        public ShellContent(Action<Microsoft.Maui.Controls.ShellContent?> componentRefAction) : base(componentRefAction)
        {
        }
    }

    public static partial class ShellContentExtensions
    {
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiReactor.TestApp.Pages
{
    class CollectionViewPage : Component
    {
        static CollectionViewPage()
        {
            ItemsSource = Enumerable.Range(1, 200)
                .Select(_ => new Tuple<string, string>($"Item{_}", $"Details{_}"))
                .ToArray();
        }
        
        static Tuple<string, string>[] ItemsSource { get; }

        public override VisualNode Render()
        {
            return new ContentPage("CollectionView")
            {
                new CollectionView()
                    .ItemsSource(ItemsSource, RenderItem)
            };
        }

        private VisualNode RenderItem(Tuple<string, string> item) 
            => new VStack(spacing: 5)
            {
                new Label(item.Item1),
                new Label(item.Item2)
            };
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using MauiReactor.Internals;
using Microsoft.Maui.Controls;
using Microsoft.Maui;
using Microsoft.Maui.Graphics;

namespace MauiReactor.Canvas.Internals
{
    public class Row : NodeContainer
    {
        private static readonly GridLengthTypeConverter _gridLengthTypeConverter = new GridLengthTypeConverter();

        public static readonly BindableProperty ColumnsProperty = BindableProperty.Create(nameof(Columns), typeof(string), typeof(Row), "*",
            coerceValue: (bindableObject, value) => string.IsNullOrWhiteSpace((string)value) ? "*" : value);

        public string Columns
        {
            get => (string)GetValue(ColumnsProperty);
            set => SetValue(ColumnsProperty, value);
        }

        private static IEnumerable<ColumnDefinition> ParseColumns(string columns)
        {
            foreach (var columnDefinition in columns.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(_ => (GridLength)Validate.EnsureNotNull(_gridLengthTypeConverter.ConvertFromInvariantString(_)))
                .Select(_ => new ColumnDefinition() { Width = _ }))
            {
                yield return columnDefinition;
            }
        }

        private IEnumerable<float> GetColumnWidths(double width)
        {
            var columns = ParseColumns(Columns).ToList();

            while (columns.Count < Children.Count)
            {
                columns.Add(new ColumnDefinition() { Width = columns[columns.Count-1].Width });
            }

            var widthForStarColumns = Math.Max(0.0, width - columns.Where(_ => _.Width.IsAbsolute).Sum(_ => _.Width.Value));
            var starSum = columns.Where(_ => _.Width.IsStar).Sum(_ => _.Width.Value);
            var starWidth = starSum > 0 ? widthForStarColumns / starSum : 0.0;

            foreach (var column in columns)
            {
                if (column.Width.IsAbsolute)
                {
                    yield return (float)column.Width.Value;
                }
                else if (column.Width.IsStar)
                {
                    yield return (float)(column.Width.Value * starWidth);
                }
                else
                {
                    throw new NotSupportedException("Auto sizing is not supported");
                }
            }
        }

        protected override void OnDraw(DrawingContext context)
        {
            var columnWidths = GetColumnWidths(context.DirtyRect.Width).ToArray();
            var x = context.DirtyRect.X;
            for (int i = 0; i < Children.Count; i++)
            {
                Children[i].Draw(context with
                {
                    DirtyRect = new RectF(
                        x,
                        context.DirtyRect.Top,
                        columnWidths[i],
                        context.DirtyRect.Height
                        )
                });

                x += columnWidths[i];
            }

            base.OnDraw(context);
        }
    }

}
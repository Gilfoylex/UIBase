using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Avalonia.Data.Converters;
namespace UIBase.Converters;

public class IndexToVisibleConverter : IMultiValueConverter
{
    private static readonly Lazy<IndexToVisibleConverter> _lazy = new (() => new IndexToVisibleConverter());
    public static IndexToVisibleConverter Instance => _lazy.Value;
    
    public object? Convert(IList<object?> values, Type targetType, object? parameter, CultureInfo culture)
    {
        if (values.Count < 2)
            return false;

        if (values[0] is not IEnumerable items)
            return false;

        var item = values[1];
        if (item == null)
            return false;

        if (items is IList list)
            return list.IndexOf(item) > 0;

        var index = 0;
        foreach (var i in items)
        {
            if (Equals(i, item))
                return index > 0;

            index++;
        }

        return false;
    }
}
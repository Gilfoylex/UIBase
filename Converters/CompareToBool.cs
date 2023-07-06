using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Avalonia.Data.Converters;
namespace UIBase.Converters;

public class CompareToBool: IMultiValueConverter
{
    private static readonly Lazy<CompareToBool> _lazy = new (() => new CompareToBool());
    public static CompareToBool Instance => _lazy.Value;
    
    public object? Convert(IList<object?> values, Type targetType, object? parameter, CultureInfo culture)
    {
        if (values.Count < 2)
            return false;

        if (values[0] is not IComparable i1)
            return false;

        if (values[1] is not IComparable i2)
            return false;
            
        return i1.CompareTo(i2) == 0;
    }
}
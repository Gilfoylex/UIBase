using System;
using System.Globalization;
using Avalonia.Data;
using Avalonia.Data.Converters;
namespace UIBase.Converters;

public class EnumToBoolConverter : IValueConverter
{
    private static readonly Lazy<EnumToBoolConverter> _lazy = new (() => new EnumToBoolConverter());
    public static EnumToBoolConverter Instance => _lazy.Value;
    
    public object Convert(
        object? value,
        Type targetType,
        object? parameter,
        CultureInfo culture)
    {
        if (value == null &&
            parameter == null)
        {
            return true;
        }
        else if (value == null ||
                 parameter == null)
        {
            return false;
        }
        else
        {
            return value!.Equals(parameter);
        }
    }
        
    public object? ConvertBack(
        object? value,
        Type targetType,
        object? parameter,
        CultureInfo culture)
    {
        return value is bool and true ? parameter : BindingOperations.DoNothing;
    }
}
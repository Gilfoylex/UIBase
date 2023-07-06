using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace UIBase.CustomControls;

public class LeftIconRadio : RadioButton
{
    public static readonly StyledProperty<Thickness> TextMarginProperty =
        AvaloniaProperty.Register<LeftIconRadio, Thickness>(nameof(TextMargin));

    public Thickness TextMargin
    {
        get => GetValue(TextMarginProperty);
        set => SetValue(TextMarginProperty, value);
    }
    
    public static readonly StyledProperty<CornerRadius> BorderRadiusProperty =
        AvaloniaProperty.Register<LeftIconRadio, CornerRadius>(nameof(BorderRadius));

    public CornerRadius BorderRadius
    {
        get => GetValue(BorderRadiusProperty);
        set => SetValue(BorderRadiusProperty, value);
    }
    
    public static readonly StyledProperty<IBrush?> HoverForegroundProperty =
        AvaloniaProperty.Register<LeftIconRadio, IBrush?>(nameof(HoverForeground));

    public IBrush? HoverForeground
    {
        get => GetValue(HoverForegroundProperty);
        set => SetValue(HoverForegroundProperty, value);
    }
    
    public static readonly StyledProperty<IBrush?> PushForegroundProperty =
        AvaloniaProperty.Register<LeftIconRadio, IBrush?>(nameof(PushForeground));

    public IBrush? PushForeground
    {
        get => GetValue(PushForegroundProperty);
        set => SetValue(PushForegroundProperty, value);
    }
    
    public static readonly StyledProperty<IImage?> IconProperty = 
        AvaloniaProperty.Register<LeftIconRadio, IImage?>(nameof(Icon));

    public IImage? Icon
    {
        get => GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }
    
    public static readonly StyledProperty<IImage?> HoverIconProperty = 
        AvaloniaProperty.Register<LeftIconRadio, IImage?>(nameof(HoverIcon));

    public IImage? HoverIcon
    {
        get => GetValue(HoverIconProperty);
        set => SetValue(HoverIconProperty, value);
    }
    
    public static readonly StyledProperty<IImage?> PushIconProperty = 
        AvaloniaProperty.Register<LeftIconRadio, IImage?>(nameof(PushIcon));

    public IImage? PushIcon
    {
        get => GetValue(PushIconProperty);
        set => SetValue(PushIconProperty, value);
    }

    public static readonly StyledProperty<double> IconWidthProperty =
        AvaloniaProperty.Register<LeftIconRadio, double>(nameof(IconWidth));

    public double IconWidth
    {
        get => GetValue(IconWidthProperty);
        set => SetValue(IconWidthProperty, value);
    }
    
    public static readonly StyledProperty<double> IconHeightProperty =
        AvaloniaProperty.Register<LeftIconRadio, double>(nameof(IconHeight));

    public double IconHeight
    {
        get => GetValue(IconHeightProperty);
        set => SetValue(IconHeightProperty, value);
    }
    
    public static readonly StyledProperty<IBrush?> PushBackgroundProperty =
        AvaloniaProperty.Register<LeftIconRadio, IBrush?>(nameof(PushBackground));

    public IBrush? PushBackground
    {
        get => GetValue(PushBackgroundProperty);
        set => SetValue(PushBackgroundProperty, value);
    }
    
    public static readonly StyledProperty<Thickness> IconMarginProperty =
        AvaloniaProperty.Register<LeftIconRadio, Thickness>(nameof(IconMargin));

    public Thickness IconMargin
    {
        get => GetValue(IconMarginProperty);
        set => SetValue(IconMarginProperty, value);
    }
}
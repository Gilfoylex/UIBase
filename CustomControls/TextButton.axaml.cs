using System.Globalization;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace UIBase.CustomControls;

public class TextButton : Button
{
    public static readonly StyledProperty<IBrush?> HoverForegroundProperty =
        AvaloniaProperty.Register<TextButton, IBrush?>(nameof(HoverForeground));

    public IBrush? HoverForeground
    {
        get => GetValue(HoverForegroundProperty);
        set => SetValue(HoverForegroundProperty, value);
    }
    
    public static readonly StyledProperty<IBrush?> PushForegroundProperty =
        AvaloniaProperty.Register<TextButton, IBrush?>(nameof(PushForeground));

    public IBrush? PushForeground
    {
        get => GetValue(PushForegroundProperty);
        set => SetValue(PushForegroundProperty, value);
    }

    public static readonly StyledProperty<CornerRadius> BorderRadiusProperty =
        AvaloniaProperty.Register<TextButton, CornerRadius>(nameof(BorderRadius));

    public CornerRadius BorderRadius
    {
        get => GetValue(BorderRadiusProperty);
        set => SetValue(BorderRadiusProperty, value);
    }
    
    public static readonly StyledProperty<IBrush?> HoverBackgroundProperty =
        AvaloniaProperty.Register<TextButton, IBrush?>(nameof(HoverBackground));

    public IBrush? HoverBackground
    {
        get => GetValue(HoverForegroundProperty);
        set => SetValue(HoverForegroundProperty, value);
    }
    
    public static readonly StyledProperty<IBrush?> PushBackgroundProperty =
        AvaloniaProperty.Register<TextButton, IBrush?>(nameof(PushBackground));

    public IBrush? PushBackground
    {
        get => GetValue(HoverForegroundProperty);
        set => SetValue(HoverForegroundProperty, value);
    }

    public static readonly StyledProperty<TextTrimming> BtnTextTrimmingProperty =
        AvaloniaProperty.Register<TextButton, TextTrimming>(nameof(BtnTextTrimming));
    
    public TextTrimming BtnTextTrimming
    {
        get => GetValue(BtnTextTrimmingProperty);
        set => SetValue(BtnTextTrimmingProperty, value);
    }

    public static readonly StyledProperty<Thickness> BtnTextMarginProperty =
        AvaloniaProperty.Register<TextButton, Thickness>(nameof(BtnTextMargin));

    public Thickness BtnTextMargin
    {
        get => GetValue(BtnTextMarginProperty);
        set => SetValue(BtnTextMarginProperty, value);
    }
}
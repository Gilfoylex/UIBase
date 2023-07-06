using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace UIBase.CustomControls;

public class TextRadio : RadioButton
{
    public static readonly StyledProperty<Thickness> TextMarginProperty =
        AvaloniaProperty.Register<TextRadio, Thickness>(nameof(TextMargin));

    public Thickness TextMargin
    {
        get => GetValue(TextMarginProperty);
        set => SetValue(TextMarginProperty, value);
    }
    
    public static readonly StyledProperty<CornerRadius> BorderRadiusProperty =
        AvaloniaProperty.Register<TextRadio, CornerRadius>(nameof(BorderRadius));

    public CornerRadius BorderRadius
    {
        get => GetValue(BorderRadiusProperty);
        set => SetValue(BorderRadiusProperty, value);
    }
    
    public static readonly StyledProperty<IBrush?> HoverForegroundProperty =
        AvaloniaProperty.Register<TextRadio, IBrush?>(nameof(HoverForeground));

    public IBrush? HoverForeground
    {
        get => GetValue(HoverForegroundProperty);
        set => SetValue(HoverForegroundProperty, value);
    }
    
    public static readonly StyledProperty<IBrush?> PushForegroundProperty =
        AvaloniaProperty.Register<TextRadio, IBrush?>(nameof(PushForeground));

    public IBrush? PushForeground
    {
        get => GetValue(PushForegroundProperty);
        set => SetValue(PushForegroundProperty, value);
    }
    
    public static readonly StyledProperty<IBrush?> PushBackgroundProperty =
        AvaloniaProperty.Register<TextRadio, IBrush?>(nameof(PushBackground));

    public IBrush? PushBackground
    {
        get => GetValue(PushBackgroundProperty);
        set => SetValue(PushBackgroundProperty, value);
    }
    
    public static readonly StyledProperty<IBrush?> HoverBackgroundProperty =
        AvaloniaProperty.Register<TextRadio, IBrush?>(nameof(HoverBackground));

    public IBrush? HoverBackground
    {
        get => GetValue(HoverBackgroundProperty);
        set => SetValue(HoverBackgroundProperty, value);
    }
}
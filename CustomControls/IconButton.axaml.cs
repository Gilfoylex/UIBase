using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace UIBase.CustomControls;

public class IconButton : Button //, IStyleable
{
    //Type IStyleable.StyleKey => typeof(Button);

    public static readonly StyledProperty<IImage?> IconProperty = AvaloniaProperty.Register<IconButton, IImage?>(nameof(Icon));

    public IImage? Icon
    {
        get => GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }
    
    public static readonly StyledProperty<IImage?> HoverIconProperty = AvaloniaProperty.Register<IconButton, IImage?>(nameof(HoverIcon));

    public IImage? HoverIcon
    {
        get => GetValue(HoverIconProperty);
        set => SetValue(HoverIconProperty, value);
    }
    
    public static readonly StyledProperty<IImage?> PushIconProperty = AvaloniaProperty.Register<IconButton, IImage?>(nameof(PushIcon));

    public IImage? PushIcon
    {
        get => GetValue(PushIconProperty);
        set => SetValue(PushIconProperty, value);
    }
    
    public static readonly StyledProperty<CornerRadius> BorderRadiusProperty =
        AvaloniaProperty.Register<TextRadio, CornerRadius>(nameof(BorderRadius));

    public CornerRadius BorderRadius
    {
        get => GetValue(BorderRadiusProperty);
        set => SetValue(BorderRadiusProperty, value);
    }
}
using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml.Styling;

namespace UIBase.Skin;

public class SkinChanger : IDisposable
{
    private IResourceProvider? _darkTheme;
    private IResourceProvider? _lightTheme;
    private readonly IDisposable _subscribe;
    private readonly ISkinView _skinView;

    public SkinChanger(ISkinView skinView)
    {
        _skinView = skinView;
        _subscribe = Main.Instance.SkinSourceChanged.Subscribe(OnSkinSourceChanged);
    }

    private IResourceProvider GetLightTheme()
    {
        return new ResourceInclude((Uri?)null)
        {
            Source = new Uri(_skinView.LightAsset)
        };
    }

    private IResourceProvider GetDarkTheme()
    {
        return new ResourceInclude((Uri?)null)
        {
            Source = new Uri(_skinView.DarkAsset)
        };
    }

    private void OnSkinSourceChanged(SkinSource skinSource)
    {
        switch (skinSource)
        {
            case SkinSource.Dark:
                _darkTheme ??= GetDarkTheme();
                Main.Instance.UpdateAppSkinSource(_darkTheme);
                break;
            case SkinSource.Light:
                _lightTheme ??= GetLightTheme();
                Main.Instance.UpdateAppSkinSource(_lightTheme);
                break;
            case SkinSource.None:
                break;
            
            default:
                throw new ArgumentOutOfRangeException(nameof(skinSource), skinSource, null);
        }
    }

    public void Dispose()
    {
        _subscribe.Dispose();
    }
}
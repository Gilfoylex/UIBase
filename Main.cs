using System;
using System.Diagnostics;
using System.Reactive.Subjects;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;
using UIBase.Skin;

namespace UIBase;

public class Main
{
    private static readonly Lazy<Main> lazy = new Lazy<Main>(() => new Main());
    
    public static readonly Main Instance = lazy.Value;

    #region 皮肤管理

    // 使用ReplaySubject缓存一条消息，防止有些模块在改变触发之后订阅收不到消息
    private readonly ReplaySubject<SkinSource> _skinSourceChanged = new (1);

    internal IObservable<SkinSource> SkinSourceChanged => _skinSourceChanged;
    
    internal SkinSource CurrentSkinSource { get; private set; } = SkinSource.None;

    public bool IsDark()
    {
        return CurrentSkinSource == SkinSource.Dark;
    }
    
    private void ChangeSkinSource(SkinSource skinSource)
    {
        if (CurrentSkinSource == skinSource)
            return;
        
        CurrentSkinSource = skinSource;
        // avalonia 0.10.18版本
        // if (Application.Current != null)
        // {
        //     if (Application.Current.Styles.Count > 0 &&
        //         Application.Current.Styles[0] is FluentTheme fluentTheme)
        //     {
        //         fluentTheme.Mode = skinMode == SkinMode.Dark ? FluentThemeMode.Dark : FluentThemeMode.Light;
        //     }
        // }

        _skinSourceChanged.OnNext(skinSource);
    }
    
    public void OnApplicationActualThemeVariantChanged()
    {
        var lightOrDark = Application.Current!.ActualThemeVariant;
        if (lightOrDark == ThemeVariant.Light)
        {
            ChangeSkinSource(SkinSource.Light);
        }
        else if (lightOrDark == ThemeVariant.Dark)
        {
            ChangeSkinSource(SkinSource.Dark);
        }
    }


    // 必须在UI线程
    public void SetSkinMode(SkinMode skinMode)
    {
        if (skinMode == SkinMode.Default)
        {
            Application.Current!.RequestedThemeVariant = ThemeVariant.Default;
        }
        else if (skinMode == SkinMode.Light)
        {
            Application.Current!.RequestedThemeVariant = ThemeVariant.Light;
        }
        else if (skinMode == SkinMode.Dark)
        {
            Application.Current!.RequestedThemeVariant = ThemeVariant.Dark;
        }
        
        var lightOrDark = Application.Current!.ActualThemeVariant;
        if (lightOrDark == ThemeVariant.Light)
        {
            ChangeSkinSource(SkinSource.Light);
        }
        else if (lightOrDark == ThemeVariant.Dark)
        {
            ChangeSkinSource(SkinSource.Dark);
        }
    }

    public void UpdateAppSkinSource(IResourceProvider resourceDictionary)
    {
        if (Application.Current == null)
            return;

        try
        {
            var m = Application.Current.Resources.MergedDictionaries;
            if (m.Contains(resourceDictionary))
                m.Remove(resourceDictionary);
        
            m.Add(resourceDictionary);
        }
        catch (Exception e)
        {
            Trace.WriteLine(e);
        }
    }

    #endregion
}
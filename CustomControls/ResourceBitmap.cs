using System;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace UIBase.CustomControls;

public class ResourceBitmap : Bitmap
{
    public ResourceBitmap(Uri uri) 
        : base(AssetLoader.Open(uri))
    {
        
    }
}
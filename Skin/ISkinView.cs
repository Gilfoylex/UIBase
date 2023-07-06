namespace UIBase.Skin;

public interface ISkinView
{
    SkinChanger SkinChange { get; set; }
    string DarkAsset { get; }
    string LightAsset { get; }
}
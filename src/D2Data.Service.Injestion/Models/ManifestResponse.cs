namespace D2Data.Service.Injestion.Models;

public class ManifestResponse
{
    public string Version { get; set; } = string.Empty;
    public string MobileAssetContentPath { get; set; } = string.Empty;
    public MobileGearAssetDataBasesItem[] MobileGearAssetDataBases { get; set; } = [];
    public MobileWorldContentPaths MobileWorldContentPaths { get; set; } = new MobileWorldContentPaths();
    public JsonWorldContentPaths JsonWorldContentPaths { get; set; } = new JsonWorldContentPaths();
    public JsonWorldComponentContentPaths JsonWorldComponentContentPaths { get; set; } = new JsonWorldComponentContentPaths();
    public string MobileClanBannerDatabasePath { get; set; } = string.Empty;
    public MobileGearCDN MobileGearCDN { get; set; } = new MobileGearCDN();
    public string[] IconImagePyramidInfo { get; set; } = [];
}
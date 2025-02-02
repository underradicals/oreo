namespace D2Data.Service.Injestion.Models;

public class Manifest
{
    public ManifestResponse Response { get; set; } = null!;
    public int ErrorCode { get; set; } = 0;
    public int ThrottleSeconds { get; set; } = 0;
    public string ErrorStatus { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public object MessageData { get; set; } = string.Empty;

    public string GetMobileWorldContentPath(string lang) => lang.ToLower() switch
    {
        "en" => Response.MobileWorldContentPaths.En,
        "fr" => Response.MobileWorldContentPaths.Fr,
        "es" => Response.MobileWorldContentPaths.Es,
        "es-mx" => Response.MobileWorldContentPaths.EsMx,
        "esmx" => Response.MobileWorldContentPaths.EsMx,
        "de" => Response.MobileWorldContentPaths.De,
        "ja" => Response.MobileWorldContentPaths.Ja,
        "pt-br" => Response.MobileWorldContentPaths.PtBr,
        "ptbr" => Response.MobileWorldContentPaths.PtBr,
        "ru" => Response.MobileWorldContentPaths.Ru,
        "pl" => Response.MobileWorldContentPaths.Pl,
        "ko" => Response.MobileWorldContentPaths.Ko,
        "zh-cht" => Response.MobileWorldContentPaths.ZhCht,
        "zhcht" => Response.MobileWorldContentPaths.ZhCht,
        "zh-chs" => Response.MobileWorldContentPaths.ZhChs,
        "zhchs" => Response.MobileWorldContentPaths.ZhChs,
        _ => "Error occured"
    };
    
    public string GetJsonWorldContentPath(string lang) => lang.ToLower() switch
    {
        "en" => Response.JsonWorldContentPaths.En,
        "fr" => Response.JsonWorldContentPaths.Fr,
        "es" => Response.JsonWorldContentPaths.Es,
        "es-mx" => Response.JsonWorldContentPaths.EsMx,
        "esmx" => Response.JsonWorldContentPaths.EsMx,
        "de" => Response.JsonWorldContentPaths.De,
        "ja" => Response.JsonWorldContentPaths.Ja,
        "pt-br" => Response.JsonWorldContentPaths.PtBr,
        "ptbr" => Response.JsonWorldContentPaths.PtBr,
        "ru" => Response.JsonWorldContentPaths.Ru,
        "pl" => Response.JsonWorldContentPaths.Pl,
        "ko" => Response.JsonWorldContentPaths.Ko,
        "zh-cht" => Response.JsonWorldContentPaths.ZhCht,
        "zhcht" => Response.JsonWorldContentPaths.ZhCht,
        "zh-chs" => Response.JsonWorldContentPaths.ZhChs,
        "zhchs" => Response.JsonWorldContentPaths.ZhChs,
        _ => "Error occured"
    };
    
    public JsonWorldComponents GetJsonWorldComponentsContentPath(string lang) => lang.ToLower() switch
    {
        "en" => Response.JsonWorldComponentContentPaths.En,
        "fr" => Response.JsonWorldComponentContentPaths.Fr,
        "es" => Response.JsonWorldComponentContentPaths.Es,
        "es-mx" => Response.JsonWorldComponentContentPaths.EsMx,
        "esmx" => Response.JsonWorldComponentContentPaths.EsMx,
        "de" => Response.JsonWorldComponentContentPaths.De,
        "ja" => Response.JsonWorldComponentContentPaths.Ja,
        "pt-br" => Response.JsonWorldComponentContentPaths.PtBr,
        "ptbr" => Response.JsonWorldComponentContentPaths.PtBr,
        "ru" => Response.JsonWorldComponentContentPaths.Ru,
        "pl" => Response.JsonWorldComponentContentPaths.Pl,
        "ko" => Response.JsonWorldComponentContentPaths.Ko,
        "zh-cht" => Response.JsonWorldComponentContentPaths.ZhCht,
        "zhcht" => Response.JsonWorldComponentContentPaths.ZhCht,
        "zh-chs" => Response.JsonWorldComponentContentPaths.ZhChs,
        "zhchs" => Response.JsonWorldComponentContentPaths.ZhChs,
        _ => throw new Exception("Error occured")
    };
}
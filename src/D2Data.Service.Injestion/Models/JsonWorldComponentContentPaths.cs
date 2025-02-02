using System.Text.Json.Serialization;

namespace D2Data.Service.Injestion.Models;

public class JsonWorldComponentContentPaths
{
    public JsonWorldComponents En { get; set; } = new JsonWorldComponents();
    public JsonWorldComponents Fr { get; set; } = new JsonWorldComponents();
    public JsonWorldComponents Es { get; set; } = new JsonWorldComponents();
    [JsonPropertyName("es-mx")] public JsonWorldComponents EsMx { get; set; } = new JsonWorldComponents();
    public JsonWorldComponents De { get; set; } = new JsonWorldComponents();
    public JsonWorldComponents It { get; set; } = new JsonWorldComponents();
    public JsonWorldComponents Ja { get; set; } = new JsonWorldComponents();
    [JsonPropertyName("pt-br")] public JsonWorldComponents PtBr { get; set; } = new JsonWorldComponents();
    public JsonWorldComponents Ru { get; set; } = new JsonWorldComponents();
    public JsonWorldComponents Pl { get; set; } = new JsonWorldComponents();
    public JsonWorldComponents Ko { get; set; } = new JsonWorldComponents();
    [JsonPropertyName("zh-cht")] public JsonWorldComponents ZhCht { get; set; } = new JsonWorldComponents();
    [JsonPropertyName("zh-chs")] public JsonWorldComponents ZhChs { get; set; } = new JsonWorldComponents();
}

public class JsonWorldComponents
{
    public string DestinyArtDyeChannelDefinition{get; set;} = string.Empty;
    public string DestinyArtDyeReferenceDefinition{get; set;} = string.Empty;
    public string DestinyPlaceDefinition{get; set;} = string.Empty;
    public string DestinyActivityDefinition{get; set;} = string.Empty;
    public string DestinyActivityTypeDefinition{get; set;} = string.Empty;
    public string DestinyClassDefinition{get; set;} = string.Empty;
    public string DestinyGenderDefinition{get; set;} = string.Empty;
    public string DestinyInventoryBucketDefinition{get; set;} = string.Empty;
    public string DestinyRaceDefinition{get; set;} = string.Empty;
    public string DestinyUnlockDefinition{get; set;} = string.Empty;
    public string DestinyStatGroupDefinition{get; set;} = string.Empty;
    public string DestinyProgressionMappingDefinition{get; set;} = string.Empty;
    public string DestinyFactionDefinition{get; set;} = string.Empty;
    public string DestinyVendorGroupDefinition{get; set;} = string.Empty;
    public string DestinyRewardSourceDefinition{get; set;} = string.Empty;
    public string DestinyUnlockValueDefinition{get; set;} = string.Empty;
    public string DestinyRewardMappingDefinition{get; set;} = string.Empty;
    public string DestinyRewardSheetDefinition{get; set;} = string.Empty;
    public string DestinyItemCategoryDefinition{get; set;} = string.Empty;
    public string DestinyDamageTypeDefinition{get; set;} = string.Empty;
    public string DestinyActivityModeDefinition{get; set;} = string.Empty;
    public string DestinyMedalTierDefinition{get; set;} = string.Empty;
    public string DestinyAchievementDefinition{get; set;} = string.Empty;
    public string DestinyActivityGraphDefinition{get; set;} = string.Empty;
    public string DestinyActivityInteractableDefinition{get; set;} = string.Empty;
    public string DestinyBondDefinition{get; set;} = string.Empty;
    public string DestinyCharacterCustomizationCategoryDefinition{get; set;} = string.Empty;
    public string DestinyCharacterCustomizationOptionDefinition{get; set;} = string.Empty;
    public string DestinyCollectibleDefinition{get; set;} = string.Empty;
    public string DestinyDestinationDefinition{get; set;} = string.Empty;
    public string DestinyEntitlementOfferDefinition{get; set;} = string.Empty;
    public string DestinyEquipmentSlotDefinition{get; set;} = string.Empty;
    public string DestinyEventCardDefinition{get; set;} = string.Empty;
    public string DestinyFireteamFinderActivityGraphDefinition{get; set;} = string.Empty;
    public string DestinyFireteamFinderActivitySetDefinition{get; set;} = string.Empty;
    public string DestinyFireteamFinderLabelDefinition{get; set;} = string.Empty;
    public string DestinyFireteamFinderLabelGroupDefinition{get; set;} = string.Empty;
    public string DestinyFireteamFinderOptionDefinition{get; set;} = string.Empty;
    public string DestinyFireteamFinderOptionGroupDefinition{get; set;} = string.Empty;
    public string DestinyStatDefinition{get; set;} = string.Empty;
    public string DestinyInventoryItemDefinition{get; set;} = string.Empty;
    public string DestinyInventoryItemLiteDefinition{get; set;} = string.Empty;
    public string DestinyItemTierTypeDefinition{get; set;} = string.Empty;
    public string DestinyLoadoutColorDefinition{get; set;} = string.Empty;
    public string DestinyLoadoutIconDefinition{get; set;} = string.Empty;
    public string DestinyLoadoutNameDefinition{get; set;} = string.Empty;
    public string DestinyLocationDefinition{get; set;} = string.Empty;
    public string DestinyLoreDefinition{get; set;} = string.Empty;
    public string DestinyMaterialRequirementSetDefinition{get; set;} = string.Empty;
    public string DestinyMetricDefinition{get; set;} = string.Empty;
    public string DestinyObjectiveDefinition{get; set;} = string.Empty;
    public string DestinySandboxPerkDefinition{get; set;} = string.Empty;
    public string DestinyPlatformBucketMappingDefinition{get; set;} = string.Empty;
    public string DestinyPlugSetDefinition{get; set;} = string.Empty;
    public string DestinyPowerCapDefinition{get; set;} = string.Empty;
    public string DestinyPresentationNodeDefinition{get; set;} = string.Empty;
    public string DestinyProgressionDefinition{get; set;} = string.Empty;
    public string DestinyProgressionLevelRequirementDefinition{get; set;} = string.Empty;
    public string DestinyRecordDefinition{get; set;} = string.Empty;
    public string DestinyRewardAdjusterPointerDefinition{get; set;} = string.Empty;
    public string DestinyRewardAdjusterProgressionMapDefinition{get; set;} = string.Empty;
    public string DestinyRewardItemListDefinition{get; set;} = string.Empty;
    public string DestinySackRewardItemListDefinition{get; set;} = string.Empty;
    public string DestinySandboxPatternDefinition{get; set;} = string.Empty;
    public string DestinySeasonDefinition{get; set;} = string.Empty;
    public string DestinySeasonPassDefinition{get; set;} = string.Empty;
    public string DestinySocialCommendationDefinition{get; set;} = string.Empty;
    public string DestinySocketCategoryDefinition{get; set;} = string.Empty;
    public string DestinySocketTypeDefinition{get; set;} = string.Empty;
    public string DestinyTraitDefinition{get; set;} = string.Empty;
    public string DestinyUnlockCountMappingDefinition{get; set;} = string.Empty;
    public string DestinyUnlockEventDefinition{get; set;} = string.Empty;
    public string DestinyUnlockExpressionMappingDefinition{get; set;} = string.Empty;
    public string DestinyVendorDefinition{get; set;} = string.Empty;
    public string DestinyMilestoneDefinition{get; set;} = string.Empty;
    public string DestinyActivityModifierDefinition{get; set;} = string.Empty;
    public string DestinyReportReasonCategoryDefinition{get; set;} = string.Empty;
    public string DestinyArtifactDefinition{get; set;} = string.Empty;
    public string DestinyBreakerTypeDefinition{get; set;} = string.Empty;
    public string DestinyChecklistDefinition{get; set;} = string.Empty;
    public string DestinyEnergyTypeDefinition{get; set;} = string.Empty;
    public string DestinySocialCommendationNodeDefinition{get; set;} = string.Empty;
    public string DestinyGuardianRankDefinition{get; set;} = string.Empty;
    public string DestinyGuardianRankConstantsDefinition{get; set;} = string.Empty;
    public string DestinyLoadoutConstantsDefinition{get; set;} = string.Empty;
    public string DestinyFireteamFinderConstantsDefinition{get; set;} = string.Empty;
    public string DestinyGlobalConstantsDefinition{get; set;} = string.Empty;

    public Dictionary<string, string> ToDictionary()
    {
        Dictionary<string, string?> dictionary = new Dictionary<string, string?>();
        var type = this.GetType();
        var properties = type.GetProperties();
        foreach (var property in properties)
        {
            dictionary.Add(property.Name, property.GetValue(this)?.ToString());
        }
        
        return dictionary!;
    }
}
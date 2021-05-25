public class TMP_FontAssetUtilities // TypeDefIndex: 5794
{
	// Fields
	private static readonly TMP_FontAssetUtilities s_Instance; // 0x0
	private static HashSet<int> k_SearchedAssets; // 0x8
	private static bool k_IsFontEngineInitialized; // 0x10

	// Properties
	public static TMP_FontAssetUtilities instance { get; }

	// Methods

	// RVA: 0x155D4C0 Offset: 0x155D5C1 VA: 0x155D4C0
	private static void .cctor() { }

	// RVA: 0x155D540 Offset: 0x155D641 VA: 0x155D540
	public static TMP_FontAssetUtilities get_instance() { }

	// RVA: 0x155D5B0 Offset: 0x155D6B1 VA: 0x155D5B0
	public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x155D730 Offset: 0x155D831 VA: 0x155D730
	private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x155DB00 Offset: 0x155DC01 VA: 0x155DB00
	public static TMP_Character GetCharacterFromFontAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x155DDA0 Offset: 0x155DEA1 VA: 0x155DDA0
	public static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x155E0A0 Offset: 0x155E1A1 VA: 0x155E0A0
	private static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x155D530 Offset: 0x155D631 VA: 0x155D530
	public void .ctor() { }
}


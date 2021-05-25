[ExcludeFromPresetAttribute] // RVA: 0x13ED80 Offset: 0x13EE81 VA: 0x13ED80
[Serializable]
public class TMP_Settings : ScriptableObject // TypeDefIndex: 5838
{
	// Fields
	private static TMP_Settings s_Instance; // 0x0
	[SerializeField] // RVA: 0x13FA80 Offset: 0x13FB81 VA: 0x13FA80
	private bool m_enableWordWrapping; // 0x18
	[SerializeField] // RVA: 0x13FA90 Offset: 0x13FB91 VA: 0x13FA90
	private bool m_enableKerning; // 0x19
	[SerializeField] // RVA: 0x13FAA0 Offset: 0x13FBA1 VA: 0x13FAA0
	private bool m_enableExtraPadding; // 0x1A
	[SerializeField] // RVA: 0x13FAB0 Offset: 0x13FBB1 VA: 0x13FAB0
	private bool m_enableTintAllSprites; // 0x1B
	[SerializeField] // RVA: 0x13FAC0 Offset: 0x13FBC1 VA: 0x13FAC0
	private bool m_enableParseEscapeCharacters; // 0x1C
	[SerializeField] // RVA: 0x13FAD0 Offset: 0x13FBD1 VA: 0x13FAD0
	private bool m_EnableRaycastTarget; // 0x1D
	[SerializeField] // RVA: 0x13FAE0 Offset: 0x13FBE1 VA: 0x13FAE0
	private bool m_GetFontFeaturesAtRuntime; // 0x1E
	[SerializeField] // RVA: 0x13FAF0 Offset: 0x13FBF1 VA: 0x13FAF0
	private int m_missingGlyphCharacter; // 0x20
	[SerializeField] // RVA: 0x13FB00 Offset: 0x13FC01 VA: 0x13FB00
	private bool m_warningsDisabled; // 0x24
	[SerializeField] // RVA: 0x13FB10 Offset: 0x13FC11 VA: 0x13FB10
	private TMP_FontAsset m_defaultFontAsset; // 0x28
	[SerializeField] // RVA: 0x13FB20 Offset: 0x13FC21 VA: 0x13FB20
	private string m_defaultFontAssetPath; // 0x30
	[SerializeField] // RVA: 0x13FB30 Offset: 0x13FC31 VA: 0x13FB30
	private float m_defaultFontSize; // 0x38
	[SerializeField] // RVA: 0x13FB40 Offset: 0x13FC41 VA: 0x13FB40
	private float m_defaultAutoSizeMinRatio; // 0x3C
	[SerializeField] // RVA: 0x13FB50 Offset: 0x13FC51 VA: 0x13FB50
	private float m_defaultAutoSizeMaxRatio; // 0x40
	[SerializeField] // RVA: 0x13FB60 Offset: 0x13FC61 VA: 0x13FB60
	private Vector2 m_defaultTextMeshProTextContainerSize; // 0x44
	[SerializeField] // RVA: 0x13FB70 Offset: 0x13FC71 VA: 0x13FB70
	private Vector2 m_defaultTextMeshProUITextContainerSize; // 0x4C
	[SerializeField] // RVA: 0x13FB80 Offset: 0x13FC81 VA: 0x13FB80
	private bool m_autoSizeTextContainer; // 0x54
	[SerializeField] // RVA: 0x13FB90 Offset: 0x13FC91 VA: 0x13FB90
	private bool m_IsTextObjectScaleStatic; // 0x55
	[SerializeField] // RVA: 0x13FBA0 Offset: 0x13FCA1 VA: 0x13FBA0
	private List<TMP_FontAsset> m_fallbackFontAssets; // 0x58
	[SerializeField] // RVA: 0x13FBB0 Offset: 0x13FCB1 VA: 0x13FBB0
	private bool m_matchMaterialPreset; // 0x60
	[SerializeField] // RVA: 0x13FBC0 Offset: 0x13FCC1 VA: 0x13FBC0
	private TMP_SpriteAsset m_defaultSpriteAsset; // 0x68
	[SerializeField] // RVA: 0x13FBD0 Offset: 0x13FCD1 VA: 0x13FBD0
	private string m_defaultSpriteAssetPath; // 0x70
	[SerializeField] // RVA: 0x13FBE0 Offset: 0x13FCE1 VA: 0x13FBE0
	private bool m_enableEmojiSupport; // 0x78
	[SerializeField] // RVA: 0x13FBF0 Offset: 0x13FCF1 VA: 0x13FBF0
	private uint m_MissingCharacterSpriteUnicode; // 0x7C
	[SerializeField] // RVA: 0x13FC00 Offset: 0x13FD01 VA: 0x13FC00
	private string m_defaultColorGradientPresetsPath; // 0x80
	[SerializeField] // RVA: 0x13FC10 Offset: 0x13FD11 VA: 0x13FC10
	private TMP_StyleSheet m_defaultStyleSheet; // 0x88
	[SerializeField] // RVA: 0x13FC20 Offset: 0x13FD21 VA: 0x13FC20
	private string m_StyleSheetsResourcePath; // 0x90
	[SerializeField] // RVA: 0x13FC30 Offset: 0x13FD31 VA: 0x13FC30
	private TextAsset m_leadingCharacters; // 0x98
	[SerializeField] // RVA: 0x13FC40 Offset: 0x13FD41 VA: 0x13FC40
	private TextAsset m_followingCharacters; // 0xA0
	[SerializeField] // RVA: 0x13FC50 Offset: 0x13FD51 VA: 0x13FC50
	private TMP_Settings.LineBreakingTable m_linebreakingRules; // 0xA8
	[SerializeField] // RVA: 0x13FC60 Offset: 0x13FD61 VA: 0x13FC60
	private bool m_UseModernHangulLineBreakingRules; // 0xB0

	// Properties
	public static string version { get; }
	public static bool enableWordWrapping { get; }
	public static bool enableKerning { get; }
	public static bool enableExtraPadding { get; }
	public static bool enableTintAllSprites { get; }
	public static bool enableParseEscapeCharacters { get; }
	public static bool enableRaycastTarget { get; }
	public static bool getFontFeaturesAtRuntime { get; }
	public static int missingGlyphCharacter { get; set; }
	public static bool warningsDisabled { get; }
	public static TMP_FontAsset defaultFontAsset { get; }
	public static string defaultFontAssetPath { get; }
	public static float defaultFontSize { get; }
	public static float defaultTextAutoSizingMinRatio { get; }
	public static float defaultTextAutoSizingMaxRatio { get; }
	public static Vector2 defaultTextMeshProTextContainerSize { get; }
	public static Vector2 defaultTextMeshProUITextContainerSize { get; }
	public static bool autoSizeTextContainer { get; }
	public static bool isTextObjectScaleStatic { get; set; }
	public static List<TMP_FontAsset> fallbackFontAssets { get; }
	public static bool matchMaterialPreset { get; }
	public static TMP_SpriteAsset defaultSpriteAsset { get; }
	public static string defaultSpriteAssetPath { get; }
	public static bool enableEmojiSupport { get; set; }
	public static uint missingCharacterSpriteUnicode { get; set; }
	public static string defaultColorGradientPresetsPath { get; }
	public static TMP_StyleSheet defaultStyleSheet { get; }
	public static string styleSheetsResourcePath { get; }
	public static TextAsset leadingCharacters { get; }
	public static TextAsset followingCharacters { get; }
	public static TMP_Settings.LineBreakingTable linebreakingRules { get; }
	public static bool useModernHangulLineBreakingRules { get; set; }
	public static TMP_Settings instance { get; }

	// Methods

	// RVA: 0x14C6400 Offset: 0x14C6501 VA: 0x14C6400
	public static string get_version() { }

	// RVA: 0x14C6450 Offset: 0x14C6551 VA: 0x14C6450
	public static bool get_enableWordWrapping() { }

	// RVA: 0x14C6530 Offset: 0x14C6631 VA: 0x14C6530
	public static bool get_enableKerning() { }

	// RVA: 0x14C6550 Offset: 0x14C6651 VA: 0x14C6550
	public static bool get_enableExtraPadding() { }

	// RVA: 0x14C6570 Offset: 0x14C6671 VA: 0x14C6570
	public static bool get_enableTintAllSprites() { }

	// RVA: 0x14C6590 Offset: 0x14C6691 VA: 0x14C6590
	public static bool get_enableParseEscapeCharacters() { }

	// RVA: 0x14C65B0 Offset: 0x14C66B1 VA: 0x14C65B0
	public static bool get_enableRaycastTarget() { }

	// RVA: 0x14C65D0 Offset: 0x14C66D1 VA: 0x14C65D0
	public static bool get_getFontFeaturesAtRuntime() { }

	// RVA: 0x14C65F0 Offset: 0x14C66F1 VA: 0x14C65F0
	public static int get_missingGlyphCharacter() { }

	// RVA: 0x14C6610 Offset: 0x14C6711 VA: 0x14C6610
	public static void set_missingGlyphCharacter(int value) { }

	// RVA: 0x14C6640 Offset: 0x14C6741 VA: 0x14C6640
	public static bool get_warningsDisabled() { }

	// RVA: 0x14C6660 Offset: 0x14C6761 VA: 0x14C6660
	public static TMP_FontAsset get_defaultFontAsset() { }

	// RVA: 0x14C6680 Offset: 0x14C6781 VA: 0x14C6680
	public static string get_defaultFontAssetPath() { }

	// RVA: 0x14C66A0 Offset: 0x14C67A1 VA: 0x14C66A0
	public static float get_defaultFontSize() { }

	// RVA: 0x14C66C0 Offset: 0x14C67C1 VA: 0x14C66C0
	public static float get_defaultTextAutoSizingMinRatio() { }

	// RVA: 0x14C66E0 Offset: 0x14C67E1 VA: 0x14C66E0
	public static float get_defaultTextAutoSizingMaxRatio() { }

	// RVA: 0x14C6700 Offset: 0x14C6801 VA: 0x14C6700
	public static Vector2 get_defaultTextMeshProTextContainerSize() { }

	// RVA: 0x14C6720 Offset: 0x14C6821 VA: 0x14C6720
	public static Vector2 get_defaultTextMeshProUITextContainerSize() { }

	// RVA: 0x14C6740 Offset: 0x14C6841 VA: 0x14C6740
	public static bool get_autoSizeTextContainer() { }

	// RVA: 0x14C6760 Offset: 0x14C6861 VA: 0x14C6760
	public static bool get_isTextObjectScaleStatic() { }

	// RVA: 0x14C6780 Offset: 0x14C6881 VA: 0x14C6780
	public static void set_isTextObjectScaleStatic(bool value) { }

	// RVA: 0x14C67B0 Offset: 0x14C68B1 VA: 0x14C67B0
	public static List<TMP_FontAsset> get_fallbackFontAssets() { }

	// RVA: 0x14C67D0 Offset: 0x14C68D1 VA: 0x14C67D0
	public static bool get_matchMaterialPreset() { }

	// RVA: 0x14C67F0 Offset: 0x14C68F1 VA: 0x14C67F0
	public static TMP_SpriteAsset get_defaultSpriteAsset() { }

	// RVA: 0x14C6810 Offset: 0x14C6911 VA: 0x14C6810
	public static string get_defaultSpriteAssetPath() { }

	// RVA: 0x14C6830 Offset: 0x14C6931 VA: 0x14C6830
	public static bool get_enableEmojiSupport() { }

	// RVA: 0x14C6850 Offset: 0x14C6951 VA: 0x14C6850
	public static void set_enableEmojiSupport(bool value) { }

	// RVA: 0x14C6880 Offset: 0x14C6981 VA: 0x14C6880
	public static uint get_missingCharacterSpriteUnicode() { }

	// RVA: 0x14C68A0 Offset: 0x14C69A1 VA: 0x14C68A0
	public static void set_missingCharacterSpriteUnicode(uint value) { }

	// RVA: 0x14C68D0 Offset: 0x14C69D1 VA: 0x14C68D0
	public static string get_defaultColorGradientPresetsPath() { }

	// RVA: 0x14C68F0 Offset: 0x14C69F1 VA: 0x14C68F0
	public static TMP_StyleSheet get_defaultStyleSheet() { }

	// RVA: 0x14C6910 Offset: 0x14C6A11 VA: 0x14C6910
	public static string get_styleSheetsResourcePath() { }

	// RVA: 0x14C6930 Offset: 0x14C6A31 VA: 0x14C6930
	public static TextAsset get_leadingCharacters() { }

	// RVA: 0x14C6950 Offset: 0x14C6A51 VA: 0x14C6950
	public static TextAsset get_followingCharacters() { }

	// RVA: 0x14C6970 Offset: 0x14C6A71 VA: 0x14C6970
	public static TMP_Settings.LineBreakingTable get_linebreakingRules() { }

	// RVA: 0x14C6AF0 Offset: 0x14C6BF1 VA: 0x14C6AF0
	public static bool get_useModernHangulLineBreakingRules() { }

	// RVA: 0x14C6B10 Offset: 0x14C6C11 VA: 0x14C6B10
	public static void set_useModernHangulLineBreakingRules(bool value) { }

	// RVA: 0x14C6470 Offset: 0x14C6571 VA: 0x14C6470
	public static TMP_Settings get_instance() { }

	// RVA: 0x14C6B40 Offset: 0x14C6C41 VA: 0x14C6B40
	public static TMP_Settings LoadDefaultSettings() { }

	// RVA: 0x14C6C40 Offset: 0x14C6D41 VA: 0x14C6C40
	public static TMP_Settings GetSettings() { }

	// RVA: 0x14C6CD0 Offset: 0x14C6DD1 VA: 0x14C6CD0
	public static TMP_FontAsset GetFontAsset() { }

	// RVA: 0x14C6D60 Offset: 0x14C6E61 VA: 0x14C6D60
	public static TMP_SpriteAsset GetSpriteAsset() { }

	// RVA: 0x14C6DF0 Offset: 0x14C6EF1 VA: 0x14C6DF0
	public static TMP_StyleSheet GetStyleSheet() { }

	// RVA: 0x14C69B0 Offset: 0x14C6AB1 VA: 0x14C69B0
	public static void LoadLinebreakingRules() { }

	// RVA: 0x14C6E90 Offset: 0x14C6F91 VA: 0x14C6E90
	private static Dictionary<int, char> GetCharacters(TextAsset file) { }

	// RVA: 0x14C6FB0 Offset: 0x14C70B1 VA: 0x14C6FB0
	public void .ctor() { }
}


internal static class StyleSheetCache // TypeDefIndex: 4246
{
	// Fields
	private static StyleSheetCache.SheetHandleKeyComparer s_Comparer; // 0x0
	private static Dictionary<StyleSheetCache.SheetHandleKey, int> s_EnumToIntCache; // 0x8
	private static Dictionary<StyleSheetCache.SheetHandleKey, StylePropertyID[]> s_RulePropertyIDsCache; // 0x10
	private static Dictionary<string, StylePropertyID> s_NameToIDCache; // 0x18
	private static StyleValue[] s_InitialStyleValues; // 0x20
	private static Dictionary<string, string> s_DeprecatedNames; // 0x28

	// Methods

	// RVA: 0x15CA210 Offset: 0x15CA311 VA: 0x15CA210
	private static void .cctor() { }

	// RVA: 0x15C9B70 Offset: 0x15C9C71 VA: 0x15C9B70
	internal static StyleValue GetInitialValue(StylePropertyID propertyId) { }
}


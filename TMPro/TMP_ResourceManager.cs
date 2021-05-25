public class TMP_ResourceManager // TypeDefIndex: 5831
{
	// Fields
	private static readonly TMP_ResourceManager s_instance; // 0x0
	private static TMP_Settings s_TextSettings; // 0x8
	private static readonly List<TMP_FontAsset> s_FontAssetReferences; // 0x10
	private static readonly Dictionary<int, TMP_FontAsset> s_FontAssetReferenceLookup; // 0x18

	// Methods

	// RVA: 0x14C5C90 Offset: 0x14C5D91 VA: 0x14C5C90
	private static void .cctor() { }

	// RVA: 0x14C5D80 Offset: 0x14C5E81 VA: 0x14C5D80
	internal static TMP_Settings GetTextSettings() { }

	// RVA: 0x14C5E90 Offset: 0x14C5F91 VA: 0x14C5E90
	public static void AddFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0x14C5FA0 Offset: 0x14C60A1 VA: 0x14C5FA0
	public static bool TryGetFontAsset(int hashcode, out TMP_FontAsset fontAsset) { }

	// RVA: 0x14C6050 Offset: 0x14C6151 VA: 0x14C6050
	internal static void RebuildFontAssetCache(int instanceID) { }

	// RVA: 0x14C5D70 Offset: 0x14C5E71 VA: 0x14C5D70
	public void .ctor() { }
}


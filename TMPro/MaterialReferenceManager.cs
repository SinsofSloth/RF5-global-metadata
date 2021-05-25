public class MaterialReferenceManager // TypeDefIndex: 5748
{
	// Fields
	private static MaterialReferenceManager s_Instance; // 0x0
	private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
	private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup; // 0x18
	private Dictionary<int, TMP_SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
	private Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup; // 0x28

	// Properties
	public static MaterialReferenceManager instance { get; }

	// Methods

	// RVA: 0x154BDA0 Offset: 0x154BEA1 VA: 0x154BDA0
	public static MaterialReferenceManager get_instance() { }

	// RVA: 0x154BF60 Offset: 0x154C061 VA: 0x154BF60
	public static void AddFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0x154C000 Offset: 0x154C101 VA: 0x154C000
	private void AddFontAssetInternal(TMP_FontAsset fontAsset) { }

	// RVA: 0x154C0C0 Offset: 0x154C1C1 VA: 0x154C0C0
	public static void AddSpriteAsset(TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x154C160 Offset: 0x154C261 VA: 0x154C160
	private void AddSpriteAssetInternal(TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x154C220 Offset: 0x154C321 VA: 0x154C220
	public static void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x154C2D0 Offset: 0x154C3D1 VA: 0x154C2D0
	private void AddSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x154C3B0 Offset: 0x154C4B1 VA: 0x154C3B0
	public static void AddFontMaterial(int hashCode, Material material) { }

	// RVA: 0x154C490 Offset: 0x154C591 VA: 0x154C490
	private void AddFontMaterialInternal(int hashCode, Material material) { }

	// RVA: 0x154C500 Offset: 0x154C601 VA: 0x154C500
	public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset) { }

	// RVA: 0x154C610 Offset: 0x154C711 VA: 0x154C610
	private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset) { }

	// RVA: 0x154C6B0 Offset: 0x154C7B1 VA: 0x154C6B0
	public bool Contains(TMP_FontAsset font) { }

	// RVA: 0x154C720 Offset: 0x154C821 VA: 0x154C720
	public bool Contains(TMP_SpriteAsset sprite) { }

	// RVA: 0x154C790 Offset: 0x154C891 VA: 0x154C790
	public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset) { }

	// RVA: 0x154C880 Offset: 0x154C981 VA: 0x154C880
	private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset) { }

	// RVA: 0x154C900 Offset: 0x154CA01 VA: 0x154C900
	public static bool TryGetSpriteAsset(int hashCode, out TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x154C9F0 Offset: 0x154CAF1 VA: 0x154C9F0
	private bool TryGetSpriteAssetInternal(int hashCode, out TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x154CA70 Offset: 0x154CB71 VA: 0x154CA70
	public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset) { }

	// RVA: 0x154CB60 Offset: 0x154CC61 VA: 0x154CB60
	private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset) { }

	// RVA: 0x154CBE0 Offset: 0x154CCE1 VA: 0x154CBE0
	public static bool TryGetMaterial(int hashCode, out Material material) { }

	// RVA: 0x154CCD0 Offset: 0x154CDD1 VA: 0x154CCD0
	private bool TryGetMaterialInternal(int hashCode, out Material material) { }

	// RVA: 0x154BE40 Offset: 0x154BF41 VA: 0x154BE40
	public void .ctor() { }
}


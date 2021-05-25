public struct MaterialReference // TypeDefIndex: 5750
{
	// Fields
	public int index; // 0x0
	public TMP_FontAsset fontAsset; // 0x8
	public TMP_SpriteAsset spriteAsset; // 0x10
	public Material material; // 0x18
	public bool isDefaultMaterial; // 0x20
	public bool isFallbackMaterial; // 0x21
	public Material fallbackMaterial; // 0x28
	public float padding; // 0x30
	public int referenceCount; // 0x34

	// Methods

	// RVA: 0x2850 Offset: 0x2951 VA: 0x2850
	public void .ctor(int index, TMP_FontAsset fontAsset, TMP_SpriteAsset spriteAsset, Material material, float padding) { }

	// RVA: 0x154B910 Offset: 0x154BA11 VA: 0x154B910
	public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset) { }

	// RVA: 0x154BA20 Offset: 0x154BB21 VA: 0x154BA20
	public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }

	// RVA: 0x154BBF0 Offset: 0x154BCF1 VA: 0x154BBF0
	public static int AddMaterialReference(Material material, TMP_SpriteAsset spriteAsset, MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }
}


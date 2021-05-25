[Serializable]
public struct FontAssetCreationSettings // TypeDefIndex: 5783
{
	// Fields
	public string sourceFontFileName; // 0x0
	public string sourceFontFileGUID; // 0x8
	public int pointSizeSamplingMode; // 0x10
	public int pointSize; // 0x14
	public int padding; // 0x18
	public int packingMode; // 0x1C
	public int atlasWidth; // 0x20
	public int atlasHeight; // 0x24
	public int characterSetSelectionMode; // 0x28
	public string characterSequence; // 0x30
	public string referencedFontAssetGUID; // 0x38
	public string referencedTextAssetGUID; // 0x40
	public int fontStyle; // 0x48
	public float fontStyleModifier; // 0x4C
	public int renderMode; // 0x50
	public bool includeFontFeatures; // 0x54

	// Methods

	// RVA: 0x2530 Offset: 0x2631 VA: 0x2530
	internal void .ctor(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode) { }
}


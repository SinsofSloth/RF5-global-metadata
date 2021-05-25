[ExcludeFromPresetAttribute] // RVA: 0x13EDA0 Offset: 0x13EEA1 VA: 0x13EDA0
public class TMP_SpriteAsset : TMP_Asset // TypeDefIndex: 5844
{
	// Fields
	internal Dictionary<int, int> m_NameLookup; // 0x30
	internal Dictionary<uint, int> m_GlyphIndexLookup; // 0x38
	[SerializeField] // RVA: 0x13FC70 Offset: 0x13FD71 VA: 0x13FC70
	private string m_Version; // 0x40
	[SerializeField] // RVA: 0x13FC80 Offset: 0x13FD81 VA: 0x13FC80
	internal FaceInfo m_FaceInfo; // 0x48
	public Texture spriteSheet; // 0xA0
	[SerializeField] // RVA: 0x13FC90 Offset: 0x13FD91 VA: 0x13FC90
	private List<TMP_SpriteCharacter> m_SpriteCharacterTable; // 0xA8
	internal Dictionary<uint, TMP_SpriteCharacter> m_SpriteCharacterLookup; // 0xB0
	[SerializeField] // RVA: 0x13FCA0 Offset: 0x13FDA1 VA: 0x13FCA0
	private List<TMP_SpriteGlyph> m_SpriteGlyphTable; // 0xB8
	internal Dictionary<uint, TMP_SpriteGlyph> m_SpriteGlyphLookup; // 0xC0
	public List<TMP_Sprite> spriteInfoList; // 0xC8
	[SerializeField] // RVA: 0x13FCB0 Offset: 0x13FDB1 VA: 0x13FCB0
	public List<TMP_SpriteAsset> fallbackSpriteAssets; // 0xD0
	internal bool m_IsSpriteAssetLookupTablesDirty; // 0xD8
	private static HashSet<int> k_searchedSpriteAssets; // 0x0

	// Properties
	public string version { get; set; }
	public FaceInfo faceInfo { get; set; }
	public List<TMP_SpriteCharacter> spriteCharacterTable { get; set; }
	public Dictionary<uint, TMP_SpriteCharacter> spriteCharacterLookupTable { get; set; }
	public List<TMP_SpriteGlyph> spriteGlyphTable { get; set; }

	// Methods

	// RVA: 0x14C7D90 Offset: 0x14C7E91 VA: 0x14C7D90
	public string get_version() { }

	// RVA: 0x14C7DA0 Offset: 0x14C7EA1 VA: 0x14C7DA0
	internal void set_version(string value) { }

	// RVA: 0x14C7DB0 Offset: 0x14C7EB1 VA: 0x14C7DB0
	public FaceInfo get_faceInfo() { }

	// RVA: 0x14C7DF0 Offset: 0x14C7EF1 VA: 0x14C7DF0
	internal void set_faceInfo(FaceInfo value) { }

	// RVA: 0x14C7CD0 Offset: 0x14C7DD1 VA: 0x14C7CD0
	public List<TMP_SpriteCharacter> get_spriteCharacterTable() { }

	// RVA: 0x14C82B0 Offset: 0x14C83B1 VA: 0x14C82B0
	internal void set_spriteCharacterTable(List<TMP_SpriteCharacter> value) { }

	// RVA: 0x14C82C0 Offset: 0x14C83C1 VA: 0x14C82C0
	public Dictionary<uint, TMP_SpriteCharacter> get_spriteCharacterLookupTable() { }

	// RVA: 0x14C8300 Offset: 0x14C8401 VA: 0x14C8300
	internal void set_spriteCharacterLookupTable(Dictionary<uint, TMP_SpriteCharacter> value) { }

	// RVA: 0x14C8310 Offset: 0x14C8411 VA: 0x14C8310
	public List<TMP_SpriteGlyph> get_spriteGlyphTable() { }

	// RVA: 0x14C8320 Offset: 0x14C8421 VA: 0x14C8320
	internal void set_spriteGlyphTable(List<TMP_SpriteGlyph> value) { }

	// RVA: 0x14C8330 Offset: 0x14C8431 VA: 0x14C8330
	private void Awake() { }

	// RVA: 0x14C88B0 Offset: 0x14C89B1 VA: 0x14C88B0
	private Material GetDefaultSpriteMaterial() { }

	// RVA: 0x14C7E20 Offset: 0x14C7F21 VA: 0x14C7E20
	public void UpdateLookupTables() { }

	// RVA: 0x14C8990 Offset: 0x14C8A91 VA: 0x14C8990
	public int GetSpriteIndexFromHashcode(int hashCode) { }

	// RVA: 0x14C8A20 Offset: 0x14C8B21 VA: 0x14C8A20
	public int GetSpriteIndexFromUnicode(uint unicode) { }

	// RVA: 0x14C8AD0 Offset: 0x14C8BD1 VA: 0x14C8AD0
	public int GetSpriteIndexFromName(string name) { }

	// RVA: 0x14C8BD0 Offset: 0x14C8CD1 VA: 0x14C8BD0
	public static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x14C8E20 Offset: 0x14C8F21 VA: 0x14C8E20
	private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x14C8FA0 Offset: 0x14C90A1 VA: 0x14C8FA0
	private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x14C90D0 Offset: 0x14C91D1 VA: 0x14C90D0
	public static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x14C94A0 Offset: 0x14C95A1 VA: 0x14C94A0
	private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	// RVA: 0x14C9620 Offset: 0x14C9721 VA: 0x14C9620
	private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	// RVA: 0x14C9740 Offset: 0x14C9841 VA: 0x14C9740
	public void SortGlyphTable() { }

	// RVA: 0x14C9890 Offset: 0x14C9991 VA: 0x14C9890
	internal void SortCharacterTable() { }

	// RVA: 0x14C99F0 Offset: 0x14C9AF1 VA: 0x14C99F0
	internal void SortGlyphAndCharacterTables() { }

	// RVA: 0x14C83D0 Offset: 0x14C84D1 VA: 0x14C83D0
	private void UpgradeSpriteAsset() { }

	// RVA: 0x14C9B10 Offset: 0x14C9C11 VA: 0x14C9B10
	public void .ctor() { }
}


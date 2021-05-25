[ExcludeFromPresetAttribute] // RVA: 0x13ED20 Offset: 0x13EE21 VA: 0x13ED20
[Serializable]
public class TMP_FontAsset : TMP_Asset // TypeDefIndex: 5779
{
	// Fields
	[SerializeField] // RVA: 0x13F3B0 Offset: 0x13F4B1 VA: 0x13F3B0
	private string m_Version; // 0x30
	[SerializeField] // RVA: 0x13F3C0 Offset: 0x13F4C1 VA: 0x13F3C0
	internal string m_SourceFontFileGUID; // 0x38
	[SerializeField] // RVA: 0x13F3D0 Offset: 0x13F4D1 VA: 0x13F3D0
	private Font m_SourceFontFile; // 0x40
	[SerializeField] // RVA: 0x13F3E0 Offset: 0x13F4E1 VA: 0x13F3E0
	private AtlasPopulationMode m_AtlasPopulationMode; // 0x48
	[SerializeField] // RVA: 0x13F3F0 Offset: 0x13F4F1 VA: 0x13F3F0
	internal FaceInfo m_FaceInfo; // 0x50
	[SerializeField] // RVA: 0x13F400 Offset: 0x13F501 VA: 0x13F400
	internal List<Glyph> m_GlyphTable; // 0xA8
	internal Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0xB0
	[SerializeField] // RVA: 0x13F410 Offset: 0x13F511 VA: 0x13F410
	internal List<TMP_Character> m_CharacterTable; // 0xB8
	internal Dictionary<uint, TMP_Character> m_CharacterLookupDictionary; // 0xC0
	internal Texture2D m_AtlasTexture; // 0xC8
	[SerializeField] // RVA: 0x13F420 Offset: 0x13F521 VA: 0x13F420
	internal Texture2D[] m_AtlasTextures; // 0xD0
	[SerializeField] // RVA: 0x13F430 Offset: 0x13F531 VA: 0x13F430
	internal int m_AtlasTextureIndex; // 0xD8
	[SerializeField] // RVA: 0x13F440 Offset: 0x13F541 VA: 0x13F440
	private bool m_IsMultiAtlasTexturesEnabled; // 0xDC
	[SerializeField] // RVA: 0x13F450 Offset: 0x13F551 VA: 0x13F450
	private List<GlyphRect> m_UsedGlyphRects; // 0xE0
	[SerializeField] // RVA: 0x13F460 Offset: 0x13F561 VA: 0x13F460
	private List<GlyphRect> m_FreeGlyphRects; // 0xE8
	[SerializeField] // RVA: 0x13F470 Offset: 0x13F571 VA: 0x13F470
	private FaceInfo_Legacy m_fontInfo; // 0xF0
	[SerializeField] // RVA: 0x13F480 Offset: 0x13F581 VA: 0x13F480
	public Texture2D atlas; // 0xF8
	[SerializeField] // RVA: 0x13F490 Offset: 0x13F591 VA: 0x13F490
	internal int m_AtlasWidth; // 0x100
	[SerializeField] // RVA: 0x13F4A0 Offset: 0x13F5A1 VA: 0x13F4A0
	internal int m_AtlasHeight; // 0x104
	[SerializeField] // RVA: 0x13F4B0 Offset: 0x13F5B1 VA: 0x13F4B0
	internal int m_AtlasPadding; // 0x108
	[SerializeField] // RVA: 0x13F4C0 Offset: 0x13F5C1 VA: 0x13F4C0
	internal GlyphRenderMode m_AtlasRenderMode; // 0x10C
	[SerializeField] // RVA: 0x13F4D0 Offset: 0x13F5D1 VA: 0x13F4D0
	internal List<TMP_Glyph> m_glyphInfoList; // 0x110
	[SerializeField] // RVA: 0x13F4E0 Offset: 0x13F5E1 VA: 0x13F4E0
	[FormerlySerializedAsAttribute] // RVA: 0x13F4E0 Offset: 0x13F5E1 VA: 0x13F4E0
	internal KerningTable m_KerningTable; // 0x118
	[SerializeField] // RVA: 0x13F530 Offset: 0x13F631 VA: 0x13F530
	internal TMP_FontFeatureTable m_FontFeatureTable; // 0x120
	[SerializeField] // RVA: 0x13F540 Offset: 0x13F641 VA: 0x13F540
	private List<TMP_FontAsset> fallbackFontAssets; // 0x128
	[SerializeField] // RVA: 0x13F550 Offset: 0x13F651 VA: 0x13F550
	internal List<TMP_FontAsset> m_FallbackFontAssetTable; // 0x130
	[SerializeField] // RVA: 0x13F560 Offset: 0x13F661 VA: 0x13F560
	internal FontAssetCreationSettings m_CreationSettings; // 0x138
	[SerializeField] // RVA: 0x13F570 Offset: 0x13F671 VA: 0x13F570
	private TMP_FontWeightPair[] m_FontWeightTable; // 0x190
	[SerializeField] // RVA: 0x13F580 Offset: 0x13F681 VA: 0x13F580
	private TMP_FontWeightPair[] fontWeights; // 0x198
	public float normalStyle; // 0x1A0
	public float normalSpacingOffset; // 0x1A4
	public float boldStyle; // 0x1A8
	public float boldSpacing; // 0x1AC
	public byte italicStyle; // 0x1B0
	public byte tabSize; // 0x1B1
	internal bool IsFontAssetLookupTablesDirty; // 0x1B2
	private static string s_DefaultMaterialSuffix; // 0x0
	internal HashSet<int> FallbackSearchQueryLookup; // 0x1B8
	private static HashSet<int> k_SearchedFontAssetLookup; // 0x8
	private static List<TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue; // 0x10
	private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x18
	private static List<TMP_FontAsset> k_FontAssets_AtlasTexturesUpdateQueue; // 0x20
	private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x28
	private List<Glyph> m_GlyphsToRender; // 0x1C0
	private List<Glyph> m_GlyphsRendered; // 0x1C8
	private List<uint> m_GlyphIndexList; // 0x1D0
	private List<uint> m_GlyphIndexListNewlyAdded; // 0x1D8
	internal List<uint> m_GlyphsToAdd; // 0x1E0
	internal HashSet<uint> m_GlyphsToAddLookup; // 0x1E8
	internal List<TMP_Character> m_CharactersToAdd; // 0x1F0
	internal HashSet<uint> m_CharactersToAddLookup; // 0x1F8
	internal List<uint> s_MissingCharacterList; // 0x200
	internal HashSet<uint> m_MissingUnicodesFromFontFile; // 0x208
	internal static uint[] k_GlyphIndexArray; // 0x30

	// Properties
	public string version { get; set; }
	public Font sourceFontFile { get; set; }
	public AtlasPopulationMode atlasPopulationMode { get; set; }
	public FaceInfo faceInfo { get; set; }
	public List<Glyph> glyphTable { get; set; }
	public Dictionary<uint, Glyph> glyphLookupTable { get; }
	public List<TMP_Character> characterTable { get; set; }
	public Dictionary<uint, TMP_Character> characterLookupTable { get; }
	public Texture2D atlasTexture { get; }
	public Texture2D[] atlasTextures { get; set; }
	public int atlasTextureCount { get; }
	public bool isMultiAtlasTexturesEnabled { get; set; }
	internal List<GlyphRect> usedGlyphRects { get; set; }
	internal List<GlyphRect> freeGlyphRects { get; set; }
	[ObsoleteAttribute] // RVA: 0x140B60 Offset: 0x140C61 VA: 0x140B60
	public FaceInfo_Legacy fontInfo { get; }
	public int atlasWidth { get; set; }
	public int atlasHeight { get; set; }
	public int atlasPadding { get; set; }
	public GlyphRenderMode atlasRenderMode { get; set; }
	public TMP_FontFeatureTable fontFeatureTable { get; set; }
	public List<TMP_FontAsset> fallbackFontAssetTable { get; set; }
	public FontAssetCreationSettings creationSettings { get; set; }
	public TMP_FontWeightPair[] fontWeightTable { get; set; }

	// Methods

	// RVA: 0x1555C70 Offset: 0x1555D71 VA: 0x1555C70
	public string get_version() { }

	// RVA: 0x1555C80 Offset: 0x1555D81 VA: 0x1555C80
	internal void set_version(string value) { }

	// RVA: 0x1555C90 Offset: 0x1555D91 VA: 0x1555C90
	public Font get_sourceFontFile() { }

	// RVA: 0x1555CA0 Offset: 0x1555DA1 VA: 0x1555CA0
	internal void set_sourceFontFile(Font value) { }

	// RVA: 0x1555CB0 Offset: 0x1555DB1 VA: 0x1555CB0
	public AtlasPopulationMode get_atlasPopulationMode() { }

	// RVA: 0x1555CC0 Offset: 0x1555DC1 VA: 0x1555CC0
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	// RVA: 0x1555CD0 Offset: 0x1555DD1 VA: 0x1555CD0
	public FaceInfo get_faceInfo() { }

	// RVA: 0x1555D10 Offset: 0x1555E11 VA: 0x1555D10
	public void set_faceInfo(FaceInfo value) { }

	// RVA: 0x1555D40 Offset: 0x1555E41 VA: 0x1555D40
	public List<Glyph> get_glyphTable() { }

	// RVA: 0x1555D50 Offset: 0x1555E51 VA: 0x1555D50
	internal void set_glyphTable(List<Glyph> value) { }

	// RVA: 0x1555D60 Offset: 0x1555E61 VA: 0x1555D60
	public Dictionary<uint, Glyph> get_glyphLookupTable() { }

	// RVA: 0x1555FE0 Offset: 0x15560E1 VA: 0x1555FE0
	public List<TMP_Character> get_characterTable() { }

	// RVA: 0x1555FF0 Offset: 0x15560F1 VA: 0x1555FF0
	internal void set_characterTable(List<TMP_Character> value) { }

	// RVA: 0x1556000 Offset: 0x1556101 VA: 0x1556000
	public Dictionary<uint, TMP_Character> get_characterLookupTable() { }

	// RVA: 0x1556040 Offset: 0x1556141 VA: 0x1556040
	public Texture2D get_atlasTexture() { }

	// RVA: 0x1556100 Offset: 0x1556201 VA: 0x1556100
	public Texture2D[] get_atlasTextures() { }

	// RVA: 0x1556110 Offset: 0x1556211 VA: 0x1556110
	public void set_atlasTextures(Texture2D[] value) { }

	// RVA: 0x1556120 Offset: 0x1556221 VA: 0x1556120
	public int get_atlasTextureCount() { }

	// RVA: 0x1556130 Offset: 0x1556231 VA: 0x1556130
	public bool get_isMultiAtlasTexturesEnabled() { }

	// RVA: 0x1556140 Offset: 0x1556241 VA: 0x1556140
	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	// RVA: 0x1556150 Offset: 0x1556251 VA: 0x1556150
	internal List<GlyphRect> get_usedGlyphRects() { }

	// RVA: 0x1556160 Offset: 0x1556261 VA: 0x1556160
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x1556170 Offset: 0x1556271 VA: 0x1556170
	internal List<GlyphRect> get_freeGlyphRects() { }

	// RVA: 0x1556180 Offset: 0x1556281 VA: 0x1556180
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x1556190 Offset: 0x1556291 VA: 0x1556190
	public FaceInfo_Legacy get_fontInfo() { }

	// RVA: 0x15561A0 Offset: 0x15562A1 VA: 0x15561A0
	public int get_atlasWidth() { }

	// RVA: 0x15561B0 Offset: 0x15562B1 VA: 0x15561B0
	internal void set_atlasWidth(int value) { }

	// RVA: 0x15561C0 Offset: 0x15562C1 VA: 0x15561C0
	public int get_atlasHeight() { }

	// RVA: 0x15561D0 Offset: 0x15562D1 VA: 0x15561D0
	internal void set_atlasHeight(int value) { }

	// RVA: 0x15561E0 Offset: 0x15562E1 VA: 0x15561E0
	public int get_atlasPadding() { }

	// RVA: 0x15561F0 Offset: 0x15562F1 VA: 0x15561F0
	internal void set_atlasPadding(int value) { }

	// RVA: 0x1556200 Offset: 0x1556301 VA: 0x1556200
	public GlyphRenderMode get_atlasRenderMode() { }

	// RVA: 0x1556210 Offset: 0x1556311 VA: 0x1556210
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	// RVA: 0x1556220 Offset: 0x1556321 VA: 0x1556220
	public TMP_FontFeatureTable get_fontFeatureTable() { }

	// RVA: 0x1556230 Offset: 0x1556331 VA: 0x1556230
	internal void set_fontFeatureTable(TMP_FontFeatureTable value) { }

	// RVA: 0x1556240 Offset: 0x1556341 VA: 0x1556240
	public List<TMP_FontAsset> get_fallbackFontAssetTable() { }

	// RVA: 0x1556250 Offset: 0x1556351 VA: 0x1556250
	public void set_fallbackFontAssetTable(List<TMP_FontAsset> value) { }

	// RVA: 0x1556260 Offset: 0x1556361 VA: 0x1556260
	public FontAssetCreationSettings get_creationSettings() { }

	// RVA: 0x15562A0 Offset: 0x15563A1 VA: 0x15562A0
	public void set_creationSettings(FontAssetCreationSettings value) { }

	// RVA: 0x15562D0 Offset: 0x15563D1 VA: 0x15562D0
	public TMP_FontWeightPair[] get_fontWeightTable() { }

	// RVA: 0x15562E0 Offset: 0x15563E1 VA: 0x15562E0
	internal void set_fontWeightTable(TMP_FontWeightPair[] value) { }

	// RVA: 0x15562F0 Offset: 0x15563F1 VA: 0x15562F0
	public static TMP_FontAsset CreateFontAsset(Font font) { }

	// RVA: 0x1556380 Offset: 0x1556481 VA: 0x1556380
	public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x1556860 Offset: 0x1556961 VA: 0x1556860
	private void Awake() { }

	// RVA: 0x1555DA0 Offset: 0x1555EA1 VA: 0x1555DA0
	public void ReadFontAssetDefinition() { }

	// RVA: 0x15573A0 Offset: 0x15574A1 VA: 0x15573A0
	internal void InitializeDictionaryLookupTables() { }

	// RVA: 0x15576A0 Offset: 0x15577A1 VA: 0x15576A0
	internal void InitializeGlyphLookupDictionary() { }

	// RVA: 0x15578D0 Offset: 0x15579D1 VA: 0x15578D0
	internal void InitializeCharacterLookupDictionary() { }

	// RVA: 0x1557AC0 Offset: 0x1557BC1 VA: 0x1557AC0
	internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x15573D0 Offset: 0x15574D1 VA: 0x15573D0
	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	// RVA: 0x1557F80 Offset: 0x1558081 VA: 0x1557F80
	private void AddSynthesizedCharacter(uint unicode, bool addImmediately = False) { }

	// RVA: 0x1558240 Offset: 0x1558341 VA: 0x1558240
	internal void AddCharacterToLookupCache(uint unicode, TMP_Character character) { }

	// RVA: 0x1558300 Offset: 0x1558401 VA: 0x1558300
	internal void SortCharacterTable() { }

	// RVA: 0x1558460 Offset: 0x1558561 VA: 0x1558460
	internal void SortGlyphTable() { }

	// RVA: 0x15585C0 Offset: 0x15586C1 VA: 0x15585C0
	internal void SortFontFeatureTable() { }

	// RVA: 0x15585E0 Offset: 0x15586E1 VA: 0x15585E0
	internal void SortAllTables() { }

	// RVA: 0x1558620 Offset: 0x1558721 VA: 0x1558620
	public bool HasCharacter(int character) { }

	// RVA: 0x15586A0 Offset: 0x15587A1 VA: 0x15586A0
	public bool HasCharacter(char character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x1559400 Offset: 0x1559501 VA: 0x1559400
	private bool HasCharacter_Internal(uint character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x1559610 Offset: 0x1559711 VA: 0x1559610
	public bool HasCharacters(string text, out List<char> missingCharacters) { }

	// RVA: 0x1559770 Offset: 0x1559871 VA: 0x1559770
	public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x1559D40 Offset: 0x1559E41 VA: 0x1559D40
	public bool HasCharacters(string text) { }

	// RVA: 0x1559E00 Offset: 0x1559F01 VA: 0x1559E00
	public static string GetCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0x1559EE0 Offset: 0x1559FE1 VA: 0x1559EE0
	public static int[] GetCharactersArray(TMP_FontAsset fontAsset) { }

	// RVA: 0x1559FE0 Offset: 0x155A0E1 VA: 0x1559FE0
	internal uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x155A100 Offset: 0x155A201 VA: 0x155A100
	internal static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset) { }

	// RVA: 0x155A200 Offset: 0x155A301 VA: 0x155A200
	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	// RVA: 0x155A690 Offset: 0x155A791 VA: 0x155A690
	internal static void RegisterFontAssetForAtlasTextureUpdate(TMP_FontAsset fontAsset) { }

	// RVA: 0x155A790 Offset: 0x155A891 VA: 0x155A790
	internal static void UpdateAtlasTexturesForFontAssetsInQueue() { }

	// RVA: 0x155A900 Offset: 0x155AA01 VA: 0x155A900
	public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = False) { }

	// RVA: 0x155A930 Offset: 0x155AA31 VA: 0x155A930
	public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = False) { }

	// RVA: 0x155B590 Offset: 0x155B691 VA: 0x155B590
	public bool TryAddCharacters(string characters, bool includeFontFeatures = False) { }

	// RVA: 0x155B5C0 Offset: 0x155B6C1 VA: 0x155B5C0
	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = False) { }

	// RVA: 0x1558BB0 Offset: 0x1558CB1 VA: 0x1558BB0
	internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character) { }

	// RVA: 0x155C100 Offset: 0x155C201 VA: 0x155C100
	internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character) { }

	// RVA: 0x155A8F0 Offset: 0x155A9F1 VA: 0x155A8F0
	internal void TryAddGlyphsToAtlasTextures() { }

	// RVA: 0x155B2A0 Offset: 0x155B3A1 VA: 0x155B2A0
	private bool TryAddGlyphsToNewAtlasTexture() { }

	// RVA: 0x155BF10 Offset: 0x155C011 VA: 0x155BF10
	private void SetupNewAtlasTexture() { }

	// RVA: 0x155C580 Offset: 0x155C681 VA: 0x155C580
	internal void UpdateAtlasTexture() { }

	// RVA: 0x155A360 Offset: 0x155A461 VA: 0x155A360
	internal void UpdateGlyphAdjustmentRecords() { }

	// RVA: 0x155C710 Offset: 0x155C811 VA: 0x155C710
	internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes) { }

	// RVA: 0x155C9F0 Offset: 0x155CAF1 VA: 0x155C9F0
	internal void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes) { }

	// RVA: 0x155CA00 Offset: 0x155CB01 VA: 0x155CA00
	internal void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes) { }

	// RVA: -1 Offset: -1
	private void CopyListDataToArray<T>(List<T> srcList, ref T[] dstArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E1950 Offset: 0x23E1A51 VA: 0x23E1950
	|-TMP_FontAsset.CopyListDataToArray<object>
	|
	|-RVA: 0x23E1A80 Offset: 0x23E1B81 VA: 0x23E1A80
	|-TMP_FontAsset.CopyListDataToArray<uint>
	*/

	// RVA: 0x155CA10 Offset: 0x155CB11 VA: 0x155CA10
	public void ClearFontAssetData(bool setAtlasSizeToZero = False) { }

	// RVA: 0x155CE10 Offset: 0x155CF11 VA: 0x155CE10
	internal void UpdateFontAssetData() { }

	// RVA: 0x155CA50 Offset: 0x155CB51 VA: 0x155CA50
	internal void ClearFontAssetTables() { }

	// RVA: 0x155CBB0 Offset: 0x155CCB1 VA: 0x155CBB0
	internal void ClearAtlasTextures(bool setAtlasSizeToZero = False) { }

	// RVA: 0x1556900 Offset: 0x1556A01 VA: 0x1556900
	internal void UpgradeFontAsset() { }

	// RVA: 0x1557C50 Offset: 0x1557D51 VA: 0x1557C50
	private void UpgradeGlyphAdjustmentTableToFontFeatureTable() { }

	// RVA: 0x155CF50 Offset: 0x155D051 VA: 0x155CF50
	public void .ctor() { }

	// RVA: 0x155D2D0 Offset: 0x155D3D1 VA: 0x155D2D0
	private static void .cctor() { }
}


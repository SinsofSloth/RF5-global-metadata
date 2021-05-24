[UsedByNativeCodeAttribute] // RVA: 0xFD770 Offset: 0xFD871 VA: 0xFD770
[NativeHeaderAttribute] // RVA: 0xFD770 Offset: 0xFD871 VA: 0xFD770
[NativeHeaderAttribute] // RVA: 0xFD770 Offset: 0xFD871 VA: 0xFD770
public sealed class TerrainData : Object // TypeDefIndex: 3661
{
	// Fields
	private const string k_ScriptingInterfaceName = "TerrainDataScriptingInterface";
	private const string k_ScriptingInterfacePrefix = "TerrainDataScriptingInterface::";
	private const string k_HeightmapPrefix = "GetHeightmap().";
	private const string k_DetailDatabasePrefix = "GetDetailDatabase().";
	private const string k_TreeDatabasePrefix = "GetTreeDatabase().";
	private const string k_SplatDatabasePrefix = "GetSplatDatabase().";
	internal static readonly int k_MaximumResolution; // 0x0
	internal static readonly int k_MinimumDetailResolutionPerPatch; // 0x4
	internal static readonly int k_MaximumDetailResolutionPerPatch; // 0x8
	internal static readonly int k_MaximumDetailPatchCount; // 0xC
	internal static readonly int k_MaximumDetailsPerRes; // 0x10
	internal static readonly int k_MinimumAlphamapResolution; // 0x14
	internal static readonly int k_MaximumAlphamapResolution; // 0x18
	internal static readonly int k_MinimumBaseMapResolution; // 0x1C
	internal static readonly int k_MaximumBaseMapResolution; // 0x20

	// Properties
	[ObsoleteAttribute] // RVA: 0xFF860 Offset: 0xFF961 VA: 0xFF860
	public int heightmapWidth { get; }
	[ObsoleteAttribute] // RVA: 0xFF8A0 Offset: 0xFF9A1 VA: 0xFF8A0
	public int heightmapHeight { get; }
	public RenderTexture heightmapTexture { get; }
	public int heightmapResolution { get; set; }
	private int internalHeightmapResolution { get; set; }
	public Vector3 heightmapScale { get; }
	public Texture holesTexture { get; }
	public bool enableHolesTextureCompression { get; set; }
	internal RenderTexture holesRenderTexture { get; }
	public int holesResolution { get; }
	public Vector3 size { get; set; }
	public Bounds bounds { get; }
	[ObsoleteAttribute] // RVA: 0xFF8E0 Offset: 0xFF9E1 VA: 0xFF8E0
	public float thickness { get; set; }
	public float wavingGrassStrength { get; set; }
	public float wavingGrassAmount { get; set; }
	public float wavingGrassSpeed { get; set; }
	public Color wavingGrassTint { get; set; }
	public int detailWidth { get; }
	public int detailHeight { get; }
	internal static int maxDetailsPerRes { get; }
	public int detailPatchCount { get; }
	public int detailResolution { get; }
	public int detailResolutionPerPatch { get; }
	public DetailPrototype[] detailPrototypes { get; set; }
	public TreeInstance[] treeInstances { get; set; }
	public int treeInstanceCount { get; }
	public TreePrototype[] treePrototypes { get; set; }
	public int alphamapLayers { get; }
	public int alphamapResolution { get; set; }
	private int Internal_alphamapResolution { get; set; }
	public int alphamapWidth { get; }
	public int alphamapHeight { get; }
	public int baseMapResolution { get; set; }
	private int Internal_baseMapResolution { get; set; }
	public int alphamapTextureCount { get; }
	public Texture2D[] alphamapTextures { get; }
	[ObsoleteAttribute] // RVA: 0xFF920 Offset: 0xFFA21 VA: 0xFF920
	public SplatPrototype[] splatPrototypes { get; set; }
	public TerrainLayer[] terrainLayers { get; set; }
	internal Terrain[] users { get; }
	private static bool SupportsCopyTextureBetweenRTAndTexture { get; }
	public static string AlphamapTextureName { get; }
	public static string HolesTextureName { get; }

	// Methods

	[StaticAccessorAttribute] // RVA: 0xFDB10 Offset: 0xFDC11 VA: 0xFDB10
	[ThreadSafeAttribute] // RVA: 0xFDB10 Offset: 0xFDC11 VA: 0xFDB10
	// RVA: 0x1B4B630 Offset: 0x1B4B731 VA: 0x1B4B630
	private static int GetBoundaryValue(TerrainData.BoundaryValueType type) { }

	// RVA: 0x1B4B680 Offset: 0x1B4B781 VA: 0x1B4B680
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0xFDB60 Offset: 0xFDC61 VA: 0xFDB60
	// RVA: 0x1B4B750 Offset: 0x1B4B851 VA: 0x1B4B750
	private static void Internal_Create(TerrainData terrainData) { }

	[ObsoleteAttribute] // RVA: 0xFDBA0 Offset: 0xFDCA1 VA: 0xFDBA0
	// RVA: 0x1B4B7A0 Offset: 0x1B4B8A1 VA: 0x1B4B7A0
	public void UpdateDirtyRegion(int x, int y, int width, int height, bool syncHeightmapTextureImmediately) { }

	// RVA: 0x1B4BA40 Offset: 0x1B4BB41 VA: 0x1B4BA40
	public int get_heightmapWidth() { }

	// RVA: 0x1B4BAE0 Offset: 0x1B4BBE1 VA: 0x1B4BAE0
	public int get_heightmapHeight() { }

	[NativeNameAttribute] // RVA: 0xFDBE0 Offset: 0xFDCE1 VA: 0xFDBE0
	// RVA: 0x1B4BB30 Offset: 0x1B4BC31 VA: 0x1B4BB30
	public RenderTexture get_heightmapTexture() { }

	// RVA: 0x1B4BA90 Offset: 0x1B4BB91 VA: 0x1B4BA90
	public int get_heightmapResolution() { }

	// RVA: 0x1B4BBD0 Offset: 0x1B4BCD1 VA: 0x1B4BBD0
	public void set_heightmapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0xFDC20 Offset: 0xFDD21 VA: 0xFDC20
	// RVA: 0x1B4BB80 Offset: 0x1B4BC81 VA: 0x1B4BB80
	private int get_internalHeightmapResolution() { }

	[NativeNameAttribute] // RVA: 0xFDC60 Offset: 0xFDD61 VA: 0xFDC60
	// RVA: 0x1B4BD80 Offset: 0x1B4BE81 VA: 0x1B4BD80
	private void set_internalHeightmapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0xFDCA0 Offset: 0xFDDA1 VA: 0xFDCA0
	// RVA: 0x1B4BDD0 Offset: 0x1B4BED1 VA: 0x1B4BDD0
	public Vector3 get_heightmapScale() { }

	// RVA: 0x1B4BE80 Offset: 0x1B4BF81 VA: 0x1B4BE80
	public Texture get_holesTexture() { }

	[NativeNameAttribute] // RVA: 0xFDCE0 Offset: 0xFDDE1 VA: 0xFDCE0
	// RVA: 0x1B4C010 Offset: 0x1B4C111 VA: 0x1B4C010
	public bool get_enableHolesTextureCompression() { }

	[NativeNameAttribute] // RVA: 0xFDD20 Offset: 0xFDE21 VA: 0xFDD20
	// RVA: 0x1B4C060 Offset: 0x1B4C161 VA: 0x1B4C060
	public void set_enableHolesTextureCompression(bool value) { }

	// RVA: 0x1B4C0B0 Offset: 0x1B4C1B1 VA: 0x1B4C0B0
	internal RenderTexture get_holesRenderTexture() { }

	[NativeNameAttribute] // RVA: 0xFDD60 Offset: 0xFDE61 VA: 0xFDD60
	// RVA: 0x1B4BF20 Offset: 0x1B4C021 VA: 0x1B4BF20
	internal bool IsHolesTextureCompressed() { }

	[NativeNameAttribute] // RVA: 0xFDDA0 Offset: 0xFDEA1 VA: 0xFDDA0
	// RVA: 0x1B4BFC0 Offset: 0x1B4C0C1 VA: 0x1B4BFC0
	internal RenderTexture GetHolesTexture() { }

	[NativeNameAttribute] // RVA: 0xFDDE0 Offset: 0xFDEE1 VA: 0xFDDE0
	// RVA: 0x1B4BF70 Offset: 0x1B4C071 VA: 0x1B4BF70
	internal Texture2D GetCompressedHolesTexture() { }

	// RVA: 0x1B4C100 Offset: 0x1B4C201 VA: 0x1B4C100
	public int get_holesResolution() { }

	[NativeNameAttribute] // RVA: 0xFDE20 Offset: 0xFDF21 VA: 0xFDE20
	// RVA: 0x1B47EF0 Offset: 0x1B47FF1 VA: 0x1B47EF0
	public Vector3 get_size() { }

	[NativeNameAttribute] // RVA: 0xFDE60 Offset: 0xFDF61 VA: 0xFDE60
	// RVA: 0x1B4C1A0 Offset: 0x1B4C2A1 VA: 0x1B4C1A0
	public void set_size(Vector3 value) { }

	[NativeNameAttribute] // RVA: 0xFDEA0 Offset: 0xFDFA1 VA: 0xFDEA0
	// RVA: 0x1B4C250 Offset: 0x1B4C351 VA: 0x1B4C250
	public Bounds get_bounds() { }

	// RVA: 0x1B4C310 Offset: 0x1B4C411 VA: 0x1B4C310
	public float get_thickness() { }

	// RVA: 0x1B4C320 Offset: 0x1B4C421 VA: 0x1B4C320
	public void set_thickness(float value) { }

	[NativeNameAttribute] // RVA: 0xFDEE0 Offset: 0xFDFE1 VA: 0xFDEE0
	// RVA: 0x1B4C330 Offset: 0x1B4C431 VA: 0x1B4C330
	public float GetHeight(int x, int y) { }

	[NativeNameAttribute] // RVA: 0xFDF20 Offset: 0xFE021 VA: 0xFDF20
	// RVA: 0x1B4C390 Offset: 0x1B4C491 VA: 0x1B4C390
	public float GetInterpolatedHeight(float x, float y) { }

	// RVA: 0x1B4C3F0 Offset: 0x1B4C4F1 VA: 0x1B4C3F0
	public float[,] GetInterpolatedHeights(float xBase, float yBase, int xCount, int yCount, float xInterval, float yInterval) { }

	// RVA: 0x1B4C610 Offset: 0x1B4C711 VA: 0x1B4C610
	public void GetInterpolatedHeights(float[,] results, int resultXOffset, int resultYOffset, float xBase, float yBase, int xCount, int yCount, float xInterval, float yInterval) { }

	[FreeFunctionAttribute] // RVA: 0xFDF60 Offset: 0xFE061 VA: 0xFDF60
	// RVA: 0x1B4C550 Offset: 0x1B4C651 VA: 0x1B4C550
	private void Internal_GetInterpolatedHeights(float[,] results, int resultXDimension, int resultXOffset, int resultYOffset, float xBase, float yBase, int xCount, int yCount, float xInterval, float yInterval) { }

	// RVA: 0x1B4C810 Offset: 0x1B4C911 VA: 0x1B4C810
	public float[,] GetHeights(int xBase, int yBase, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0xFDFB0 Offset: 0xFE0B1 VA: 0xFDFB0
	// RVA: 0x1B4C960 Offset: 0x1B4CA61 VA: 0x1B4C960
	private float[,] Internal_GetHeights(int xBase, int yBase, int width, int height) { }

	// RVA: 0x1B4C9D0 Offset: 0x1B4CAD1 VA: 0x1B4C9D0
	public void SetHeights(int xBase, int yBase, float[,] heights) { }

	[FreeFunctionAttribute] // RVA: 0xFE000 Offset: 0xFE101 VA: 0xFE000
	// RVA: 0x1B4CCF0 Offset: 0x1B4CDF1 VA: 0x1B4CCF0
	private void Internal_SetHeights(int xBase, int yBase, int width, int height, float[,] heights) { }

	[FreeFunctionAttribute] // RVA: 0xFE050 Offset: 0xFE151 VA: 0xFE050
	// RVA: 0x1B4CD70 Offset: 0x1B4CE71 VA: 0x1B4CD70
	public PatchExtents[] GetPatchMinMaxHeights() { }

	[FreeFunctionAttribute] // RVA: 0xFE0A0 Offset: 0xFE1A1 VA: 0xFE0A0
	// RVA: 0x1B4CDC0 Offset: 0x1B4CEC1 VA: 0x1B4CDC0
	public void OverrideMinMaxPatchHeights(PatchExtents[] minMaxHeights) { }

	[FreeFunctionAttribute] // RVA: 0xFE0F0 Offset: 0xFE1F1 VA: 0xFE0F0
	// RVA: 0x1B4CE10 Offset: 0x1B4CF11 VA: 0x1B4CE10
	public float[] GetMaximumHeightError() { }

	[FreeFunctionAttribute] // RVA: 0xFE140 Offset: 0xFE241 VA: 0xFE140
	// RVA: 0x1B4CE60 Offset: 0x1B4CF61 VA: 0x1B4CE60
	public void OverrideMaximumHeightError(float[] maxError) { }

	// RVA: 0x1B4CEB0 Offset: 0x1B4CFB1 VA: 0x1B4CEB0
	public void SetHeightsDelayLOD(int xBase, int yBase, float[,] heights) { }

	[FreeFunctionAttribute] // RVA: 0xFE190 Offset: 0xFE291 VA: 0xFE190
	// RVA: 0x1B4D240 Offset: 0x1B4D341 VA: 0x1B4D240
	private void Internal_SetHeightsDelayLOD(int xBase, int yBase, int width, int height, float[,] heights) { }

	// RVA: 0x1B4D2C0 Offset: 0x1B4D3C1 VA: 0x1B4D2C0
	public bool IsHole(int x, int y) { }

	// RVA: 0x1B4D450 Offset: 0x1B4D551 VA: 0x1B4D450
	public bool[,] GetHoles(int xBase, int yBase, int width, int height) { }

	// RVA: 0x1B4D620 Offset: 0x1B4D721 VA: 0x1B4D620
	public void SetHoles(int xBase, int yBase, bool[,] holes) { }

	// RVA: 0x1B4DA60 Offset: 0x1B4DB61 VA: 0x1B4DA60
	public void SetHolesDelayLOD(int xBase, int yBase, bool[,] holes) { }

	[FreeFunctionAttribute] // RVA: 0xFE1E0 Offset: 0xFE2E1 VA: 0xFE1E0
	// RVA: 0x1B4D9E0 Offset: 0x1B4DAE1 VA: 0x1B4D9E0
	private void Internal_SetHoles(int xBase, int yBase, int width, int height, bool[,] holes) { }

	[FreeFunctionAttribute] // RVA: 0xFE230 Offset: 0xFE331 VA: 0xFE230
	// RVA: 0x1B4D5B0 Offset: 0x1B4D6B1 VA: 0x1B4D5B0
	private bool[,] Internal_GetHoles(int xBase, int yBase, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0xFE280 Offset: 0xFE381 VA: 0xFE280
	// RVA: 0x1B4D3F0 Offset: 0x1B4D4F1 VA: 0x1B4D3F0
	private bool Internal_IsHole(int x, int y) { }

	[FreeFunctionAttribute] // RVA: 0xFE2D0 Offset: 0xFE3D1 VA: 0xFE2D0
	// RVA: 0x1B4DE00 Offset: 0x1B4DF01 VA: 0x1B4DE00
	private void Internal_SetHolesDelayLOD(int xBase, int yBase, int width, int height, bool[,] holes) { }

	[NativeNameAttribute] // RVA: 0xFE320 Offset: 0xFE421 VA: 0xFE320
	// RVA: 0x1B4DE80 Offset: 0x1B4DF81 VA: 0x1B4DE80
	public float GetSteepness(float x, float y) { }

	[NativeNameAttribute] // RVA: 0xFE360 Offset: 0xFE461 VA: 0xFE360
	// RVA: 0x1B4DEE0 Offset: 0x1B4DFE1 VA: 0x1B4DEE0
	public Vector3 GetInterpolatedNormal(float x, float y) { }

	[NativeNameAttribute] // RVA: 0xFE3A0 Offset: 0xFE4A1 VA: 0xFE3A0
	// RVA: 0x1B4DFD0 Offset: 0x1B4E0D1 VA: 0x1B4DFD0
	internal int GetAdjustedSize(int size) { }

	[NativeNameAttribute] // RVA: 0xFE3E0 Offset: 0xFE4E1 VA: 0xFE3E0
	// RVA: 0x1B4E020 Offset: 0x1B4E121 VA: 0x1B4E020
	public float get_wavingGrassStrength() { }

	[FreeFunctionAttribute] // RVA: 0xFE420 Offset: 0xFE521 VA: 0xFE420
	// RVA: 0x1B4E070 Offset: 0x1B4E171 VA: 0x1B4E070
	public void set_wavingGrassStrength(float value) { }

	[NativeNameAttribute] // RVA: 0xFE470 Offset: 0xFE571 VA: 0xFE470
	// RVA: 0x1B4E0C0 Offset: 0x1B4E1C1 VA: 0x1B4E0C0
	public float get_wavingGrassAmount() { }

	[FreeFunctionAttribute] // RVA: 0xFE4B0 Offset: 0xFE5B1 VA: 0xFE4B0
	// RVA: 0x1B4E110 Offset: 0x1B4E211 VA: 0x1B4E110
	public void set_wavingGrassAmount(float value) { }

	[NativeNameAttribute] // RVA: 0xFE500 Offset: 0xFE601 VA: 0xFE500
	// RVA: 0x1B4E160 Offset: 0x1B4E261 VA: 0x1B4E160
	public float get_wavingGrassSpeed() { }

	[FreeFunctionAttribute] // RVA: 0xFE540 Offset: 0xFE641 VA: 0xFE540
	// RVA: 0x1B4E1B0 Offset: 0x1B4E2B1 VA: 0x1B4E1B0
	public void set_wavingGrassSpeed(float value) { }

	[NativeNameAttribute] // RVA: 0xFE590 Offset: 0xFE691 VA: 0xFE590
	// RVA: 0x1B4E200 Offset: 0x1B4E301 VA: 0x1B4E200
	public Color get_wavingGrassTint() { }

	[FreeFunctionAttribute] // RVA: 0xFE5D0 Offset: 0xFE6D1 VA: 0xFE5D0
	// RVA: 0x1B4E2B0 Offset: 0x1B4E3B1 VA: 0x1B4E2B0
	public void set_wavingGrassTint(Color value) { }

	[NativeNameAttribute] // RVA: 0xFE620 Offset: 0xFE721 VA: 0xFE620
	// RVA: 0x1B4E360 Offset: 0x1B4E461 VA: 0x1B4E360
	public int get_detailWidth() { }

	[NativeNameAttribute] // RVA: 0xFE660 Offset: 0xFE761 VA: 0xFE660
	// RVA: 0x1B4E3B0 Offset: 0x1B4E4B1 VA: 0x1B4E3B0
	public int get_detailHeight() { }

	// RVA: 0x1B4E400 Offset: 0x1B4E501 VA: 0x1B4E400
	internal static int get_maxDetailsPerRes() { }

	// RVA: 0x1B4E470 Offset: 0x1B4E571 VA: 0x1B4E470
	public void SetDetailResolution(int detailResolution, int resolutionPerPatch) { }

	[NativeNameAttribute] // RVA: 0xFE6A0 Offset: 0xFE7A1 VA: 0xFE6A0
	// RVA: 0x1B4E960 Offset: 0x1B4EA61 VA: 0x1B4E960
	private void Internal_SetDetailResolution(int patchCount, int resolutionPerPatch) { }

	[NativeNameAttribute] // RVA: 0xFE6E0 Offset: 0xFE7E1 VA: 0xFE6E0
	// RVA: 0x1B4E9C0 Offset: 0x1B4EAC1 VA: 0x1B4E9C0
	public int get_detailPatchCount() { }

	[NativeNameAttribute] // RVA: 0xFE720 Offset: 0xFE821 VA: 0xFE720
	// RVA: 0x1B4EA10 Offset: 0x1B4EB11 VA: 0x1B4EA10
	public int get_detailResolution() { }

	[NativeNameAttribute] // RVA: 0xFE760 Offset: 0xFE861 VA: 0xFE760
	// RVA: 0x1B4EA60 Offset: 0x1B4EB61 VA: 0x1B4EA60
	public int get_detailResolutionPerPatch() { }

	[NativeNameAttribute] // RVA: 0xFE7A0 Offset: 0xFE8A1 VA: 0xFE7A0
	// RVA: 0x1B4EAB0 Offset: 0x1B4EBB1 VA: 0x1B4EAB0
	internal void ResetDirtyDetails() { }

	[FreeFunctionAttribute] // RVA: 0xFE7E0 Offset: 0xFE8E1 VA: 0xFE7E0
	// RVA: 0x1B4EB00 Offset: 0x1B4EC01 VA: 0x1B4EB00
	public void RefreshPrototypes() { }

	[FreeFunctionAttribute] // RVA: 0xFE830 Offset: 0xFE931 VA: 0xFE830
	// RVA: 0x1B4EB50 Offset: 0x1B4EC51 VA: 0x1B4EB50
	public DetailPrototype[] get_detailPrototypes() { }

	[FreeFunctionAttribute] // RVA: 0xFE880 Offset: 0xFE981 VA: 0xFE880
	// RVA: 0x1B4EBA0 Offset: 0x1B4ECA1 VA: 0x1B4EBA0
	public void set_detailPrototypes(DetailPrototype[] value) { }

	[FreeFunctionAttribute] // RVA: 0xFE8D0 Offset: 0xFE9D1 VA: 0xFE8D0
	// RVA: 0x1B4EBF0 Offset: 0x1B4ECF1 VA: 0x1B4EBF0
	public int[] GetSupportedLayers(int xBase, int yBase, int totalWidth, int totalHeight) { }

	[FreeFunctionAttribute] // RVA: 0xFE920 Offset: 0xFEA21 VA: 0xFE920
	// RVA: 0x1B4EC60 Offset: 0x1B4ED61 VA: 0x1B4EC60
	public int[,] GetDetailLayer(int xBase, int yBase, int width, int height, int layer) { }

	// RVA: 0x1B4ECE0 Offset: 0x1B4EDE1 VA: 0x1B4ECE0
	public void SetDetailLayer(int xBase, int yBase, int layer, int[,] details) { }

	[FreeFunctionAttribute] // RVA: 0xFE970 Offset: 0xFEA71 VA: 0xFE970
	// RVA: 0x1B4ED90 Offset: 0x1B4EE91 VA: 0x1B4ED90
	private void Internal_SetDetailLayer(int xBase, int yBase, int totalWidth, int totalHeight, int detailIndex, int[,] data) { }

	// RVA: 0x1B4EE20 Offset: 0x1B4EF21 VA: 0x1B4EE20
	public TreeInstance[] get_treeInstances() { }

	// RVA: 0x1B4EEC0 Offset: 0x1B4EFC1 VA: 0x1B4EEC0
	public void set_treeInstances(TreeInstance[] value) { }

	[NativeNameAttribute] // RVA: 0xFE9C0 Offset: 0xFEAC1 VA: 0xFE9C0
	// RVA: 0x1B4EE70 Offset: 0x1B4EF71 VA: 0x1B4EE70
	private TreeInstance[] Internal_GetTreeInstances() { }

	[FreeFunctionAttribute] // RVA: 0xFEA00 Offset: 0xFEB01 VA: 0xFEA00
	// RVA: 0x1B4EF20 Offset: 0x1B4F021 VA: 0x1B4EF20
	public void SetTreeInstances(TreeInstance[] instances, bool snapToHeightmap) { }

	// RVA: 0x1B4EF80 Offset: 0x1B4F081 VA: 0x1B4EF80
	public TreeInstance GetTreeInstance(int index) { }

	[FreeFunctionAttribute] // RVA: 0xFEA50 Offset: 0xFEB51 VA: 0xFEA50
	// RVA: 0x1B4F110 Offset: 0x1B4F211 VA: 0x1B4F110
	private TreeInstance Internal_GetTreeInstance(int index) { }

	[FreeFunctionAttribute] // RVA: 0xFEAA0 Offset: 0xFEBA1 VA: 0xFEAA0
	[NativeThrowsAttribute] // RVA: 0xFEAA0 Offset: 0xFEBA1 VA: 0xFEAA0
	// RVA: 0x1B4F200 Offset: 0x1B4F301 VA: 0x1B4F200
	public void SetTreeInstance(int index, TreeInstance instance) { }

	[NativeNameAttribute] // RVA: 0xFEB00 Offset: 0xFEC01 VA: 0xFEB00
	// RVA: 0x1B4F0C0 Offset: 0x1B4F1C1 VA: 0x1B4F0C0
	public int get_treeInstanceCount() { }

	[FreeFunctionAttribute] // RVA: 0xFEB40 Offset: 0xFEC41 VA: 0xFEB40
	// RVA: 0x1B4F2C0 Offset: 0x1B4F3C1 VA: 0x1B4F2C0
	public TreePrototype[] get_treePrototypes() { }

	[FreeFunctionAttribute] // RVA: 0xFEB90 Offset: 0xFEC91 VA: 0xFEB90
	// RVA: 0x1B4F310 Offset: 0x1B4F411 VA: 0x1B4F310
	public void set_treePrototypes(TreePrototype[] value) { }

	[NativeNameAttribute] // RVA: 0xFEBE0 Offset: 0xFECE1 VA: 0xFEBE0
	// RVA: 0x1B4F360 Offset: 0x1B4F461 VA: 0x1B4F360
	internal void RemoveTreePrototype(int index) { }

	[NativeNameAttribute] // RVA: 0xFEC20 Offset: 0xFED21 VA: 0xFEC20
	// RVA: 0x1B4F3B0 Offset: 0x1B4F4B1 VA: 0x1B4F3B0
	internal void RemoveDetailPrototype(int index) { }

	[NativeNameAttribute] // RVA: 0xFEC60 Offset: 0xFED61 VA: 0xFEC60
	// RVA: 0x1B4F400 Offset: 0x1B4F501 VA: 0x1B4F400
	internal bool NeedUpgradeScaledTreePrototypes() { }

	[FreeFunctionAttribute] // RVA: 0xFECA0 Offset: 0xFEDA1 VA: 0xFECA0
	// RVA: 0x1B4F450 Offset: 0x1B4F551 VA: 0x1B4F450
	internal void UpgradeScaledTreePrototype() { }

	[NativeNameAttribute] // RVA: 0xFECF0 Offset: 0xFEDF1 VA: 0xFECF0
	// RVA: 0x1B4F4A0 Offset: 0x1B4F5A1 VA: 0x1B4F4A0
	public int get_alphamapLayers() { }

	// RVA: 0x1B4F4F0 Offset: 0x1B4F5F1 VA: 0x1B4F4F0
	public float[,,] GetAlphamaps(int x, int y, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0xFED30 Offset: 0xFEE31 VA: 0xFED30
	// RVA: 0x1B4F5D0 Offset: 0x1B4F6D1 VA: 0x1B4F5D0
	private float[,,] Internal_GetAlphamaps(int x, int y, int width, int height) { }

	// RVA: 0x1B4F640 Offset: 0x1B4F741 VA: 0x1B4F640
	public int get_alphamapResolution() { }

	// RVA: 0x1B4F6E0 Offset: 0x1B4F7E1 VA: 0x1B4F6E0
	public void set_alphamapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0xFED80 Offset: 0xFEE81 VA: 0xFED80
	[RequiredByNativeCodeAttribute] // RVA: 0xFED80 Offset: 0xFEE81 VA: 0xFED80
	// RVA: 0x1B4FAC0 Offset: 0x1B4FBC1 VA: 0x1B4FAC0
	internal float GetAlphamapResolutionInternal() { }

	[NativeNameAttribute] // RVA: 0xFEDD0 Offset: 0xFEED1 VA: 0xFEDD0
	// RVA: 0x1B4F690 Offset: 0x1B4F791 VA: 0x1B4F690
	private int get_Internal_alphamapResolution() { }

	[NativeNameAttribute] // RVA: 0xFEE10 Offset: 0xFEF11 VA: 0xFEE10
	// RVA: 0x1B4FA70 Offset: 0x1B4FB71 VA: 0x1B4FA70
	private void set_Internal_alphamapResolution(int value) { }

	// RVA: 0x1B4FB10 Offset: 0x1B4FC11 VA: 0x1B4FB10
	public int get_alphamapWidth() { }

	// RVA: 0x1B4FB60 Offset: 0x1B4FC61 VA: 0x1B4FB60
	public int get_alphamapHeight() { }

	// RVA: 0x1B4FBB0 Offset: 0x1B4FCB1 VA: 0x1B4FBB0
	public int get_baseMapResolution() { }

	// RVA: 0x1B4FC50 Offset: 0x1B4FD51 VA: 0x1B4FC50
	public void set_baseMapResolution(int value) { }

	[NativeNameAttribute] // RVA: 0xFEE50 Offset: 0xFEF51 VA: 0xFEE50
	// RVA: 0x1B4FC00 Offset: 0x1B4FD01 VA: 0x1B4FC00
	private int get_Internal_baseMapResolution() { }

	[NativeNameAttribute] // RVA: 0xFEE90 Offset: 0xFEF91 VA: 0xFEE90
	// RVA: 0x1B4FFE0 Offset: 0x1B500E1 VA: 0x1B4FFE0
	private void set_Internal_baseMapResolution(int value) { }

	// RVA: 0x1B50030 Offset: 0x1B50131 VA: 0x1B50030
	public void SetAlphamaps(int x, int y, float[,,] map) { }

	[FreeFunctionAttribute] // RVA: 0xFEED0 Offset: 0xFEFD1 VA: 0xFEED0
	// RVA: 0x1B501F0 Offset: 0x1B502F1 VA: 0x1B501F0
	private void Internal_SetAlphamaps(int x, int y, int width, int height, float[,,] map) { }

	[NativeNameAttribute] // RVA: 0xFEF20 Offset: 0xFF021 VA: 0xFEF20
	// RVA: 0x1B50270 Offset: 0x1B50371 VA: 0x1B50270
	public void SetBaseMapDirty() { }

	[NativeNameAttribute] // RVA: 0xFEF60 Offset: 0xFF061 VA: 0xFEF60
	// RVA: 0x1B502C0 Offset: 0x1B503C1 VA: 0x1B502C0
	public Texture2D GetAlphamapTexture(int index) { }

	[NativeNameAttribute] // RVA: 0xFEFA0 Offset: 0xFF0A1 VA: 0xFEFA0
	// RVA: 0x1B50310 Offset: 0x1B50411 VA: 0x1B50310
	public int get_alphamapTextureCount() { }

	// RVA: 0x1B50360 Offset: 0x1B50461 VA: 0x1B50360
	public Texture2D[] get_alphamapTextures() { }

	[FreeFunctionAttribute] // RVA: 0xFEFE0 Offset: 0xFF0E1 VA: 0xFEFE0
	// RVA: 0x1B504B0 Offset: 0x1B505B1 VA: 0x1B504B0
	public SplatPrototype[] get_splatPrototypes() { }

	[FreeFunctionAttribute] // RVA: 0xFF030 Offset: 0xFF131 VA: 0xFF030
	// RVA: 0x1B50500 Offset: 0x1B50601 VA: 0x1B50500
	public void set_splatPrototypes(SplatPrototype[] value) { }

	[FreeFunctionAttribute] // RVA: 0xFF080 Offset: 0xFF181 VA: 0xFF080
	// RVA: 0x1B50550 Offset: 0x1B50651 VA: 0x1B50550
	public TerrainLayer[] get_terrainLayers() { }

	[FreeFunctionAttribute] // RVA: 0xFF0D0 Offset: 0xFF1D1 VA: 0xFF0D0
	// RVA: 0x1B505A0 Offset: 0x1B506A1 VA: 0x1B505A0
	public void set_terrainLayers(TerrainLayer[] value) { }

	[NativeNameAttribute] // RVA: 0xFF120 Offset: 0xFF221 VA: 0xFF120
	// RVA: 0x1B505F0 Offset: 0x1B506F1 VA: 0x1B505F0
	internal void AddTree(ref TreeInstance tree) { }

	[NativeNameAttribute] // RVA: 0xFF160 Offset: 0xFF261 VA: 0xFF160
	// RVA: 0x1B50640 Offset: 0x1B50741 VA: 0x1B50640
	internal int RemoveTrees(Vector2 position, float radius, int prototypeIndex) { }

	[NativeNameAttribute] // RVA: 0xFF1A0 Offset: 0xFF2A1 VA: 0xFF1A0
	// RVA: 0x1B50730 Offset: 0x1B50831 VA: 0x1B50730
	private void Internal_CopyActiveRenderTextureToHeightmap(RectInt rect, int destX, int destY, TerrainHeightmapSyncControl syncControl) { }

	[NativeNameAttribute] // RVA: 0xFF1E0 Offset: 0xFF2E1 VA: 0xFF1E0
	// RVA: 0x1B50820 Offset: 0x1B50921 VA: 0x1B50820
	private void Internal_DirtyHeightmapRegion(int x, int y, int width, int height, TerrainHeightmapSyncControl syncControl) { }

	[NativeNameAttribute] // RVA: 0xFF220 Offset: 0xFF321 VA: 0xFF220
	// RVA: 0x1B4B5D0 Offset: 0x1B4B6D1 VA: 0x1B4B5D0
	public void SyncHeightmap() { }

	[NativeNameAttribute] // RVA: 0xFF260 Offset: 0xFF361 VA: 0xFF260
	// RVA: 0x1B508A0 Offset: 0x1B509A1 VA: 0x1B508A0
	private void Internal_CopyActiveRenderTextureToHoles(RectInt rect, int destX, int destY, bool allowDelayedCPUSync) { }

	[NativeNameAttribute] // RVA: 0xFF2A0 Offset: 0xFF3A1 VA: 0xFF2A0
	// RVA: 0x1B50990 Offset: 0x1B50A91 VA: 0x1B50990
	private void Internal_DirtyHolesRegion(int x, int y, int width, int height, bool allowDelayedCPUSync) { }

	[NativeNameAttribute] // RVA: 0xFF2E0 Offset: 0xFF3E1 VA: 0xFF2E0
	// RVA: 0x1B50A10 Offset: 0x1B50B11 VA: 0x1B50A10
	private void Internal_SyncHoles() { }

	[NativeNameAttribute] // RVA: 0xFF320 Offset: 0xFF421 VA: 0xFF320
	// RVA: 0x1B50A60 Offset: 0x1B50B61 VA: 0x1B50A60
	private void Internal_MarkAlphamapDirtyRegion(int alphamapIndex, int x, int y, int width, int height) { }

	[NativeNameAttribute] // RVA: 0xFF360 Offset: 0xFF461 VA: 0xFF360
	// RVA: 0x1B50AE0 Offset: 0x1B50BE1 VA: 0x1B50AE0
	private void Internal_ClearAlphamapDirtyRegion(int alphamapIndex) { }

	[NativeNameAttribute] // RVA: 0xFF3A0 Offset: 0xFF4A1 VA: 0xFF3A0
	// RVA: 0x1B50B30 Offset: 0x1B50C31 VA: 0x1B50B30
	private void Internal_SyncAlphamaps() { }

	// RVA: 0x1B460E0 Offset: 0x1B461E1 VA: 0x1B460E0
	internal Terrain[] get_users() { }

	// RVA: 0x1B50B80 Offset: 0x1B50C81 VA: 0x1B50B80
	private static bool get_SupportsCopyTextureBetweenRTAndTexture() { }

	// RVA: 0x1B50BB0 Offset: 0x1B50CB1 VA: 0x1B50BB0
	public void CopyActiveRenderTextureToHeightmap(RectInt sourceRect, Vector2Int dest, TerrainHeightmapSyncControl syncControl) { }

	// RVA: 0x1B4B7F0 Offset: 0x1B4B8F1 VA: 0x1B4B7F0
	public void DirtyHeightmapRegion(RectInt region, TerrainHeightmapSyncControl syncControl) { }

	// RVA: 0x1B50F00 Offset: 0x1B51001 VA: 0x1B50F00
	public static string get_AlphamapTextureName() { }

	// RVA: 0x1B50F50 Offset: 0x1B51051 VA: 0x1B50F50
	public static string get_HolesTextureName() { }

	// RVA: 0x1B50FA0 Offset: 0x1B510A1 VA: 0x1B50FA0
	public void CopyActiveRenderTextureToTexture(string textureName, int textureIndex, RectInt sourceRect, Vector2Int dest, bool allowDelayedCPUSync) { }

	// RVA: 0x1B51B10 Offset: 0x1B51C11 VA: 0x1B51B10
	public void DirtyTextureRegion(string textureName, RectInt region, bool allowDelayedCPUSync) { }

	// RVA: 0x1B51FC0 Offset: 0x1B520C1 VA: 0x1B51FC0
	public void SyncTexture(string textureName) { }

	// RVA: 0x1B52220 Offset: 0x1B52321 VA: 0x1B52220
	private static void .cctor() { }

	// RVA: 0x1B4BE30 Offset: 0x1B4BF31 VA: 0x1B4BE30
	private void get_heightmapScale_Injected(out Vector3 ret) { }

	// RVA: 0x1B4C150 Offset: 0x1B4C251 VA: 0x1B4C150
	private void get_size_Injected(out Vector3 ret) { }

	// RVA: 0x1B4C200 Offset: 0x1B4C301 VA: 0x1B4C200
	private void set_size_Injected(ref Vector3 value) { }

	// RVA: 0x1B4C2C0 Offset: 0x1B4C3C1 VA: 0x1B4C2C0
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x1B4DF60 Offset: 0x1B4E061 VA: 0x1B4DF60
	private void GetInterpolatedNormal_Injected(float x, float y, out Vector3 ret) { }

	// RVA: 0x1B4E260 Offset: 0x1B4E361 VA: 0x1B4E260
	private void get_wavingGrassTint_Injected(out Color ret) { }

	// RVA: 0x1B4E310 Offset: 0x1B4E411 VA: 0x1B4E310
	private void set_wavingGrassTint_Injected(ref Color value) { }

	// RVA: 0x1B4F1A0 Offset: 0x1B4F2A1 VA: 0x1B4F1A0
	private void Internal_GetTreeInstance_Injected(int index, out TreeInstance ret) { }

	// RVA: 0x1B4F260 Offset: 0x1B4F361 VA: 0x1B4F260
	private void SetTreeInstance_Injected(int index, ref TreeInstance instance) { }

	// RVA: 0x1B506C0 Offset: 0x1B507C1 VA: 0x1B506C0
	private int RemoveTrees_Injected(ref Vector2 position, float radius, int prototypeIndex) { }

	// RVA: 0x1B507B0 Offset: 0x1B508B1 VA: 0x1B507B0
	private void Internal_CopyActiveRenderTextureToHeightmap_Injected(ref RectInt rect, int destX, int destY, TerrainHeightmapSyncControl syncControl) { }

	// RVA: 0x1B50920 Offset: 0x1B50A21 VA: 0x1B50920
	private void Internal_CopyActiveRenderTextureToHoles_Injected(ref RectInt rect, int destX, int destY, bool allowDelayedCPUSync) { }
}


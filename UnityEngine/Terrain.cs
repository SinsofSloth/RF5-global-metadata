[NativeHeaderAttribute] // RVA: 0xFD620 Offset: 0xFD721 VA: 0xFD620
[StaticAccessorAttribute] // RVA: 0xFD620 Offset: 0xFD721 VA: 0xFD620
[UsedByNativeCodeAttribute] // RVA: 0xFD620 Offset: 0xFD721 VA: 0xFD620
[NativeHeaderAttribute] // RVA: 0xFD620 Offset: 0xFD721 VA: 0xFD620
[NativeHeaderAttribute] // RVA: 0xFD620 Offset: 0xFD721 VA: 0xFD620
public sealed class Terrain : Behaviour // TypeDefIndex: 3653
{
	// Properties
	public TerrainData terrainData { get; set; }
	public float treeDistance { get; set; }
	public float treeBillboardDistance { get; set; }
	public float treeCrossFadeLength { get; set; }
	public int treeMaximumFullLODCount { get; set; }
	public float detailObjectDistance { get; set; }
	public float detailObjectDensity { get; set; }
	public float heightmapPixelError { get; set; }
	public int heightmapMaximumLOD { get; set; }
	public float basemapDistance { get; set; }
	[NativePropertyAttribute] // RVA: 0xFF480 Offset: 0xFF581 VA: 0xFF480
	public int lightmapIndex { get; set; }
	[NativePropertyAttribute] // RVA: 0xFF4C0 Offset: 0xFF5C1 VA: 0xFF4C0
	public int realtimeLightmapIndex { get; set; }
	[NativePropertyAttribute] // RVA: 0xFF500 Offset: 0xFF601 VA: 0xFF500
	public Vector4 lightmapScaleOffset { get; set; }
	[NativePropertyAttribute] // RVA: 0xFF540 Offset: 0xFF641 VA: 0xFF540
	public Vector4 realtimeLightmapScaleOffset { get; set; }
	[NativePropertyAttribute] // RVA: 0xFF580 Offset: 0xFF681 VA: 0xFF580
	public bool freeUnusedRenderingResources { get; set; }
	public ShadowCastingMode shadowCastingMode { get; set; }
	public ReflectionProbeUsage reflectionProbeUsage { get; set; }
	public Material materialTemplate { get; set; }
	public bool drawHeightmap { get; set; }
	public bool allowAutoConnect { get; set; }
	public int groupingID { get; set; }
	public bool drawInstanced { get; set; }
	public RenderTexture normalmapTexture { get; }
	public bool drawTreesAndFoliage { get; set; }
	public Vector3 patchBoundsMultiplier { get; set; }
	public float treeLODBiasMultiplier { get; set; }
	public bool collectDetailPatches { get; set; }
	public TerrainRenderFlags editorRenderFlags { get; set; }
	public bool preserveTreePrototypeLayers { get; set; }
	[StaticAccessorAttribute] // RVA: 0xFF5C0 Offset: 0xFF6C1 VA: 0xFF5C0
	public static GraphicsFormat heightmapFormat { get; }
	public static TextureFormat heightmapTextureFormat { get; }
	public static RenderTextureFormat heightmapRenderTextureFormat { get; }
	[StaticAccessorAttribute] // RVA: 0xFF600 Offset: 0xFF701 VA: 0xFF600
	public static GraphicsFormat normalmapFormat { get; }
	public static TextureFormat normalmapTextureFormat { get; }
	public static RenderTextureFormat normalmapRenderTextureFormat { get; }
	[StaticAccessorAttribute] // RVA: 0xFF640 Offset: 0xFF741 VA: 0xFF640
	public static GraphicsFormat holesFormat { get; }
	public static RenderTextureFormat holesRenderTextureFormat { get; }
	[StaticAccessorAttribute] // RVA: 0xFF680 Offset: 0xFF781 VA: 0xFF680
	public static GraphicsFormat compressedHolesFormat { get; }
	public static TextureFormat compressedHolesTextureFormat { get; }
	public static Terrain activeTerrain { get; }
	[NativePropertyAttribute] // RVA: 0xFF6C0 Offset: 0xFF7C1 VA: 0xFF6C0
	public static Terrain[] activeTerrains { get; }
	public Terrain leftNeighbor { get; }
	public Terrain rightNeighbor { get; }
	public Terrain topNeighbor { get; }
	public Terrain bottomNeighbor { get; }
	public uint renderingLayerMask { get; set; }
	[EditorBrowsableAttribute] // RVA: 0xFF700 Offset: 0xFF801 VA: 0xFF700
	[ObsoleteAttribute] // RVA: 0xFF700 Offset: 0xFF801 VA: 0xFF700
	public float splatmapDistance { get; set; }
	[ObsoleteAttribute] // RVA: 0xFF760 Offset: 0xFF861 VA: 0xFF760
	public bool castShadows { get; set; }
	[ObsoleteAttribute] // RVA: 0xFF7A0 Offset: 0xFF8A1 VA: 0xFF7A0
	public Terrain.MaterialType materialType { get; set; }
	[ObsoleteAttribute] // RVA: 0xFF7E0 Offset: 0xFF8E1 VA: 0xFF7E0
	public Color legacySpecular { get; set; }
	[ObsoleteAttribute] // RVA: 0xFF820 Offset: 0xFF921 VA: 0xFF820
	public float legacyShininess { get; set; }

	// Methods

	// RVA: 0x1B47EA0 Offset: 0x1B47FA1 VA: 0x1B47EA0
	public TerrainData get_terrainData() { }

	// RVA: 0x1B49640 Offset: 0x1B49741 VA: 0x1B49640
	public void set_terrainData(TerrainData value) { }

	// RVA: 0x1B49690 Offset: 0x1B49791 VA: 0x1B49690
	public float get_treeDistance() { }

	// RVA: 0x1B496E0 Offset: 0x1B497E1 VA: 0x1B496E0
	public void set_treeDistance(float value) { }

	// RVA: 0x1B49730 Offset: 0x1B49831 VA: 0x1B49730
	public float get_treeBillboardDistance() { }

	// RVA: 0x1B49780 Offset: 0x1B49881 VA: 0x1B49780
	public void set_treeBillboardDistance(float value) { }

	// RVA: 0x1B497D0 Offset: 0x1B498D1 VA: 0x1B497D0
	public float get_treeCrossFadeLength() { }

	// RVA: 0x1B49820 Offset: 0x1B49921 VA: 0x1B49820
	public void set_treeCrossFadeLength(float value) { }

	// RVA: 0x1B49870 Offset: 0x1B49971 VA: 0x1B49870
	public int get_treeMaximumFullLODCount() { }

	// RVA: 0x1B498C0 Offset: 0x1B499C1 VA: 0x1B498C0
	public void set_treeMaximumFullLODCount(int value) { }

	// RVA: 0x1B49910 Offset: 0x1B49A11 VA: 0x1B49910
	public float get_detailObjectDistance() { }

	// RVA: 0x1B49960 Offset: 0x1B49A61 VA: 0x1B49960
	public void set_detailObjectDistance(float value) { }

	// RVA: 0x1B499B0 Offset: 0x1B49AB1 VA: 0x1B499B0
	public float get_detailObjectDensity() { }

	// RVA: 0x1B49A00 Offset: 0x1B49B01 VA: 0x1B49A00
	public void set_detailObjectDensity(float value) { }

	// RVA: 0x1B49A50 Offset: 0x1B49B51 VA: 0x1B49A50
	public float get_heightmapPixelError() { }

	// RVA: 0x1B49AA0 Offset: 0x1B49BA1 VA: 0x1B49AA0
	public void set_heightmapPixelError(float value) { }

	// RVA: 0x1B49AF0 Offset: 0x1B49BF1 VA: 0x1B49AF0
	public int get_heightmapMaximumLOD() { }

	// RVA: 0x1B49B40 Offset: 0x1B49C41 VA: 0x1B49B40
	public void set_heightmapMaximumLOD(int value) { }

	// RVA: 0x1B49B90 Offset: 0x1B49C91 VA: 0x1B49B90
	public float get_basemapDistance() { }

	// RVA: 0x1B49BE0 Offset: 0x1B49CE1 VA: 0x1B49BE0
	public void set_basemapDistance(float value) { }

	// RVA: 0x1B49C30 Offset: 0x1B49D31 VA: 0x1B49C30
	public int get_lightmapIndex() { }

	// RVA: 0x1B49C80 Offset: 0x1B49D81 VA: 0x1B49C80
	public void set_lightmapIndex(int value) { }

	// RVA: 0x1B49CD0 Offset: 0x1B49DD1 VA: 0x1B49CD0
	public int get_realtimeLightmapIndex() { }

	// RVA: 0x1B49D20 Offset: 0x1B49E21 VA: 0x1B49D20
	public void set_realtimeLightmapIndex(int value) { }

	// RVA: 0x1B49D70 Offset: 0x1B49E71 VA: 0x1B49D70
	public Vector4 get_lightmapScaleOffset() { }

	// RVA: 0x1B49E20 Offset: 0x1B49F21 VA: 0x1B49E20
	public void set_lightmapScaleOffset(Vector4 value) { }

	// RVA: 0x1B49ED0 Offset: 0x1B49FD1 VA: 0x1B49ED0
	public Vector4 get_realtimeLightmapScaleOffset() { }

	// RVA: 0x1B49F80 Offset: 0x1B4A081 VA: 0x1B49F80
	public void set_realtimeLightmapScaleOffset(Vector4 value) { }

	// RVA: 0x1B4A030 Offset: 0x1B4A131 VA: 0x1B4A030
	public bool get_freeUnusedRenderingResources() { }

	// RVA: 0x1B4A080 Offset: 0x1B4A181 VA: 0x1B4A080
	public void set_freeUnusedRenderingResources(bool value) { }

	// RVA: 0x1B4A0D0 Offset: 0x1B4A1D1 VA: 0x1B4A0D0
	public ShadowCastingMode get_shadowCastingMode() { }

	// RVA: 0x1B4A120 Offset: 0x1B4A221 VA: 0x1B4A120
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x1B4A170 Offset: 0x1B4A271 VA: 0x1B4A170
	public ReflectionProbeUsage get_reflectionProbeUsage() { }

	// RVA: 0x1B4A1C0 Offset: 0x1B4A2C1 VA: 0x1B4A1C0
	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	// RVA: 0x1B4A210 Offset: 0x1B4A311 VA: 0x1B4A210
	public void GetClosestReflectionProbes(List<ReflectionProbeBlendInfo> result) { }

	// RVA: 0x1B4A260 Offset: 0x1B4A361 VA: 0x1B4A260
	public Material get_materialTemplate() { }

	// RVA: 0x1B4A2B0 Offset: 0x1B4A3B1 VA: 0x1B4A2B0
	public void set_materialTemplate(Material value) { }

	// RVA: 0x1B4A300 Offset: 0x1B4A401 VA: 0x1B4A300
	public bool get_drawHeightmap() { }

	// RVA: 0x1B4A350 Offset: 0x1B4A451 VA: 0x1B4A350
	public void set_drawHeightmap(bool value) { }

	// RVA: 0x1B473A0 Offset: 0x1B474A1 VA: 0x1B473A0
	public bool get_allowAutoConnect() { }

	// RVA: 0x1B4A3A0 Offset: 0x1B4A4A1 VA: 0x1B4A3A0
	public void set_allowAutoConnect(bool value) { }

	// RVA: 0x1B473F0 Offset: 0x1B474F1 VA: 0x1B473F0
	public int get_groupingID() { }

	// RVA: 0x1B4A3F0 Offset: 0x1B4A4F1 VA: 0x1B4A3F0
	public void set_groupingID(int value) { }

	// RVA: 0x1B4A440 Offset: 0x1B4A541 VA: 0x1B4A440
	public bool get_drawInstanced() { }

	// RVA: 0x1B4A490 Offset: 0x1B4A591 VA: 0x1B4A490
	public void set_drawInstanced(bool value) { }

	[NativeMethodAttribute] // RVA: 0xFDA00 Offset: 0xFDB01 VA: 0xFDA00
	// RVA: 0x1B4A4E0 Offset: 0x1B4A5E1 VA: 0x1B4A4E0
	public RenderTexture get_normalmapTexture() { }

	// RVA: 0x1B4A530 Offset: 0x1B4A631 VA: 0x1B4A530
	public bool get_drawTreesAndFoliage() { }

	// RVA: 0x1B4A580 Offset: 0x1B4A681 VA: 0x1B4A580
	public void set_drawTreesAndFoliage(bool value) { }

	// RVA: 0x1B4A5D0 Offset: 0x1B4A6D1 VA: 0x1B4A5D0
	public Vector3 get_patchBoundsMultiplier() { }

	// RVA: 0x1B4A680 Offset: 0x1B4A781 VA: 0x1B4A680
	public void set_patchBoundsMultiplier(Vector3 value) { }

	// RVA: 0x1B4A730 Offset: 0x1B4A831 VA: 0x1B4A730
	public float SampleHeight(Vector3 worldPosition) { }

	// RVA: 0x1B4A7E0 Offset: 0x1B4A8E1 VA: 0x1B4A7E0
	public void AddTreeInstance(TreeInstance instance) { }

	// RVA: 0x1B46F20 Offset: 0x1B47021 VA: 0x1B46F20
	public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom) { }

	// RVA: 0x1B4A880 Offset: 0x1B4A981 VA: 0x1B4A880
	public float get_treeLODBiasMultiplier() { }

	// RVA: 0x1B4A8D0 Offset: 0x1B4A9D1 VA: 0x1B4A8D0
	public void set_treeLODBiasMultiplier(float value) { }

	// RVA: 0x1B4A920 Offset: 0x1B4AA21 VA: 0x1B4A920
	public bool get_collectDetailPatches() { }

	// RVA: 0x1B4A970 Offset: 0x1B4AA71 VA: 0x1B4A970
	public void set_collectDetailPatches(bool value) { }

	// RVA: 0x1B4A9C0 Offset: 0x1B4AAC1 VA: 0x1B4A9C0
	public TerrainRenderFlags get_editorRenderFlags() { }

	// RVA: 0x1B4AA10 Offset: 0x1B4AB11 VA: 0x1B4AA10
	public void set_editorRenderFlags(TerrainRenderFlags value) { }

	// RVA: 0x1B4AA60 Offset: 0x1B4AB61 VA: 0x1B4AA60
	public Vector3 GetPosition() { }

	// RVA: 0x1B4AB10 Offset: 0x1B4AC11 VA: 0x1B4AB10
	public void Flush() { }

	// RVA: 0x1B4AB60 Offset: 0x1B4AC61 VA: 0x1B4AB60
	internal void RemoveTrees(Vector2 position, float radius, int prototypeIndex) { }

	[NativeMethodAttribute] // RVA: 0xFDA40 Offset: 0xFDB41 VA: 0xFDA40
	// RVA: 0x1B4AC50 Offset: 0x1B4AD51 VA: 0x1B4AC50
	public void SetSplatMaterialPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x1B4ACA0 Offset: 0x1B4ADA1 VA: 0x1B4ACA0
	public void GetSplatMaterialPropertyBlock(MaterialPropertyBlock dest) { }

	[NativeMethodAttribute] // RVA: 0xFDA80 Offset: 0xFDB81 VA: 0xFDA80
	// RVA: 0x1B4AD60 Offset: 0x1B4AE61 VA: 0x1B4AD60
	private void Internal_GetSplatMaterialPropertyBlock(MaterialPropertyBlock dest) { }

	// RVA: 0x1B4ADB0 Offset: 0x1B4AEB1 VA: 0x1B4ADB0
	public bool get_preserveTreePrototypeLayers() { }

	// RVA: 0x1B4AE00 Offset: 0x1B4AF01 VA: 0x1B4AE00
	public void set_preserveTreePrototypeLayers(bool value) { }

	// RVA: 0x1B4AE50 Offset: 0x1B4AF51 VA: 0x1B4AE50
	public static GraphicsFormat get_heightmapFormat() { }

	// RVA: 0x1B4AE90 Offset: 0x1B4AF91 VA: 0x1B4AE90
	public static TextureFormat get_heightmapTextureFormat() { }

	// RVA: 0x1B4AED0 Offset: 0x1B4AFD1 VA: 0x1B4AED0
	public static RenderTextureFormat get_heightmapRenderTextureFormat() { }

	// RVA: 0x1B4AF10 Offset: 0x1B4B011 VA: 0x1B4AF10
	public static GraphicsFormat get_normalmapFormat() { }

	// RVA: 0x1B4AF50 Offset: 0x1B4B051 VA: 0x1B4AF50
	public static TextureFormat get_normalmapTextureFormat() { }

	// RVA: 0x1B4AF90 Offset: 0x1B4B091 VA: 0x1B4AF90
	public static RenderTextureFormat get_normalmapRenderTextureFormat() { }

	// RVA: 0x1B4AFD0 Offset: 0x1B4B0D1 VA: 0x1B4AFD0
	public static GraphicsFormat get_holesFormat() { }

	// RVA: 0x1B4B010 Offset: 0x1B4B111 VA: 0x1B4B010
	public static RenderTextureFormat get_holesRenderTextureFormat() { }

	// RVA: 0x1B4B050 Offset: 0x1B4B151 VA: 0x1B4B050
	public static GraphicsFormat get_compressedHolesFormat() { }

	// RVA: 0x1B4B090 Offset: 0x1B4B191 VA: 0x1B4B090
	public static TextureFormat get_compressedHolesTextureFormat() { }

	// RVA: 0x1B4B0D0 Offset: 0x1B4B1D1 VA: 0x1B4B0D0
	public static Terrain get_activeTerrain() { }

	// RVA: 0x1B4B110 Offset: 0x1B4B211 VA: 0x1B4B110
	public static void SetConnectivityDirty() { }

	// RVA: 0x1B46E00 Offset: 0x1B46F01 VA: 0x1B46E00
	public static Terrain[] get_activeTerrains() { }

	[UsedByNativeCodeAttribute] // RVA: 0xFDAC0 Offset: 0xFDBC1 VA: 0xFDAC0
	// RVA: 0x1B4B150 Offset: 0x1B4B251 VA: 0x1B4B150
	public static GameObject CreateTerrainGameObject(TerrainData assignTerrain) { }

	// RVA: 0x1B4B1A0 Offset: 0x1B4B2A1 VA: 0x1B4B1A0
	public Terrain get_leftNeighbor() { }

	// RVA: 0x1B4B1F0 Offset: 0x1B4B2F1 VA: 0x1B4B1F0
	public Terrain get_rightNeighbor() { }

	// RVA: 0x1B4B240 Offset: 0x1B4B341 VA: 0x1B4B240
	public Terrain get_topNeighbor() { }

	// RVA: 0x1B4B290 Offset: 0x1B4B391 VA: 0x1B4B290
	public Terrain get_bottomNeighbor() { }

	// RVA: 0x1B4B2E0 Offset: 0x1B4B3E1 VA: 0x1B4B2E0
	public uint get_renderingLayerMask() { }

	// RVA: 0x1B4B330 Offset: 0x1B4B431 VA: 0x1B4B330
	public void set_renderingLayerMask(uint value) { }

	// RVA: 0x1B4B380 Offset: 0x1B4B481 VA: 0x1B4B380
	public float get_splatmapDistance() { }

	// RVA: 0x1B4B3D0 Offset: 0x1B4B4D1 VA: 0x1B4B3D0
	public void set_splatmapDistance(float value) { }

	// RVA: 0x1B4B420 Offset: 0x1B4B521 VA: 0x1B4B420
	public bool get_castShadows() { }

	// RVA: 0x1B4B470 Offset: 0x1B4B571 VA: 0x1B4B470
	public void set_castShadows(bool value) { }

	// RVA: 0x1B4B4D0 Offset: 0x1B4B5D1 VA: 0x1B4B4D0
	public Terrain.MaterialType get_materialType() { }

	// RVA: 0x1B4B4E0 Offset: 0x1B4B5E1 VA: 0x1B4B4E0
	public void set_materialType(Terrain.MaterialType value) { }

	// RVA: 0x1B4B4F0 Offset: 0x1B4B5F1 VA: 0x1B4B4F0
	public Color get_legacySpecular() { }

	// RVA: 0x1B4B500 Offset: 0x1B4B601 VA: 0x1B4B500
	public void set_legacySpecular(Color value) { }

	// RVA: 0x1B4B510 Offset: 0x1B4B611 VA: 0x1B4B510
	public float get_legacyShininess() { }

	// RVA: 0x1B4B520 Offset: 0x1B4B621 VA: 0x1B4B520
	public void set_legacyShininess(float value) { }

	[ObsoleteAttribute] // RVA: 0xFDAD0 Offset: 0xFDBD1 VA: 0xFDAD0
	// RVA: 0x1B4B530 Offset: 0x1B4B631 VA: 0x1B4B530
	public void ApplyDelayedHeightmapModification() { }

	// RVA: 0x1B4B620 Offset: 0x1B4B721 VA: 0x1B4B620
	public void .ctor() { }

	// RVA: 0x1B49DD0 Offset: 0x1B49ED1 VA: 0x1B49DD0
	private void get_lightmapScaleOffset_Injected(out Vector4 ret) { }

	// RVA: 0x1B49E80 Offset: 0x1B49F81 VA: 0x1B49E80
	private void set_lightmapScaleOffset_Injected(ref Vector4 value) { }

	// RVA: 0x1B49F30 Offset: 0x1B4A031 VA: 0x1B49F30
	private void get_realtimeLightmapScaleOffset_Injected(out Vector4 ret) { }

	// RVA: 0x1B49FE0 Offset: 0x1B4A0E1 VA: 0x1B49FE0
	private void set_realtimeLightmapScaleOffset_Injected(ref Vector4 value) { }

	// RVA: 0x1B4A630 Offset: 0x1B4A731 VA: 0x1B4A630
	private void get_patchBoundsMultiplier_Injected(out Vector3 ret) { }

	// RVA: 0x1B4A6E0 Offset: 0x1B4A7E1 VA: 0x1B4A6E0
	private void set_patchBoundsMultiplier_Injected(ref Vector3 value) { }

	// RVA: 0x1B4A790 Offset: 0x1B4A891 VA: 0x1B4A790
	private float SampleHeight_Injected(ref Vector3 worldPosition) { }

	// RVA: 0x1B4A830 Offset: 0x1B4A931 VA: 0x1B4A830
	private void AddTreeInstance_Injected(ref TreeInstance instance) { }

	// RVA: 0x1B4AAC0 Offset: 0x1B4ABC1 VA: 0x1B4AAC0
	private void GetPosition_Injected(out Vector3 ret) { }

	// RVA: 0x1B4ABE0 Offset: 0x1B4ACE1 VA: 0x1B4ABE0
	private void RemoveTrees_Injected(ref Vector2 position, float radius, int prototypeIndex) { }
}


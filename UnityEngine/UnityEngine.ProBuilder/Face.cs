[DefaultMemberAttribute] // RVA: 0x141440 Offset: 0x141541 VA: 0x141440
[Serializable]
public sealed class Face // TypeDefIndex: 5951
{
	// Fields
	[SerializeField] // RVA: 0x141A30 Offset: 0x141B31 VA: 0x141A30
	[FormerlySerializedAsAttribute] // RVA: 0x141A30 Offset: 0x141B31 VA: 0x141A30
	private int[] m_Indexes; // 0x10
	[SerializeField] // RVA: 0x141A80 Offset: 0x141B81 VA: 0x141A80
	[FormerlySerializedAsAttribute] // RVA: 0x141A80 Offset: 0x141B81 VA: 0x141A80
	private int m_SmoothingGroup; // 0x18
	[SerializeField] // RVA: 0x141AD0 Offset: 0x141BD1 VA: 0x141AD0
	[FormerlySerializedAsAttribute] // RVA: 0x141AD0 Offset: 0x141BD1 VA: 0x141AD0
	private AutoUnwrapSettings m_Uv; // 0x1C
	[FormerlySerializedAsAttribute] // RVA: 0x141B20 Offset: 0x141C21 VA: 0x141B20
	[SerializeField] // RVA: 0x141B20 Offset: 0x141C21 VA: 0x141B20
	private Material m_Material; // 0x40
	[SerializeField] // RVA: 0x141B70 Offset: 0x141C71 VA: 0x141B70
	private int m_SubmeshIndex; // 0x48
	[SerializeField] // RVA: 0x141B80 Offset: 0x141C81 VA: 0x141B80
	[FormerlySerializedAsAttribute] // RVA: 0x141B80 Offset: 0x141C81 VA: 0x141B80
	private bool m_ManualUV; // 0x4C
	[SerializeField] // RVA: 0x141BD0 Offset: 0x141CD1 VA: 0x141BD0
	internal int elementGroup; // 0x50
	[SerializeField] // RVA: 0x141BE0 Offset: 0x141CE1 VA: 0x141BE0
	private int m_TextureGroup; // 0x54
	private int[] m_DistinctIndexes; // 0x58
	private Edge[] m_Edges; // 0x60

	// Properties
	public bool manualUV { get; set; }
	public int textureGroup { get; set; }
	internal int[] indexesInternal { get; }
	internal int[] distinctIndexesInternal { get; }
	public ReadOnlyCollection<int> distinctIndexes { get; }
	internal Edge[] edgesInternal { get; }
	public ReadOnlyCollection<Edge> edges { get; }
	public int smoothingGroup { get; }
	[ObsoleteAttribute] // RVA: 0x142670 Offset: 0x142771 VA: 0x142670
	public Material material { get; set; }
	public int submeshIndex { get; set; }
	public AutoUnwrapSettings uv { get; set; }

	// Methods

	// RVA: 0x1A91D20 Offset: 0x1A91E21 VA: 0x1A91D20
	public bool get_manualUV() { }

	// RVA: 0x1A91D30 Offset: 0x1A91E31 VA: 0x1A91D30
	public void set_manualUV(bool value) { }

	// RVA: 0x1A91D40 Offset: 0x1A91E41 VA: 0x1A91D40
	public int get_textureGroup() { }

	// RVA: 0x1A91D50 Offset: 0x1A91E51 VA: 0x1A91D50
	public void set_textureGroup(int value) { }

	// RVA: 0x1A91D60 Offset: 0x1A91E61 VA: 0x1A91D60
	internal int[] get_indexesInternal() { }

	// RVA: 0x1A91D70 Offset: 0x1A91E71 VA: 0x1A91D70
	public void SetIndexes(IEnumerable<int> indices) { }

	// RVA: 0x1A91EE0 Offset: 0x1A91FE1 VA: 0x1A91EE0
	internal int[] get_distinctIndexesInternal() { }

	// RVA: 0x1A92020 Offset: 0x1A92121 VA: 0x1A92020
	public ReadOnlyCollection<int> get_distinctIndexes() { }

	// RVA: 0x1A92120 Offset: 0x1A92221 VA: 0x1A92120
	internal Edge[] get_edgesInternal() { }

	// RVA: 0x1A92360 Offset: 0x1A92461 VA: 0x1A92360
	public ReadOnlyCollection<Edge> get_edges() { }

	// RVA: 0x1A923E0 Offset: 0x1A924E1 VA: 0x1A923E0
	public int get_smoothingGroup() { }

	// RVA: 0x1A923F0 Offset: 0x1A924F1 VA: 0x1A923F0
	public Material get_material() { }

	// RVA: 0x1A92400 Offset: 0x1A92501 VA: 0x1A92400
	public void set_material(Material value) { }

	// RVA: 0x1A92410 Offset: 0x1A92511 VA: 0x1A92410
	public int get_submeshIndex() { }

	// RVA: 0x1A92420 Offset: 0x1A92521 VA: 0x1A92420
	public void set_submeshIndex(int value) { }

	// RVA: 0x1A92430 Offset: 0x1A92531 VA: 0x1A92430
	public AutoUnwrapSettings get_uv() { }

	// RVA: 0x1A92450 Offset: 0x1A92551 VA: 0x1A92450
	public void set_uv(AutoUnwrapSettings value) { }

	// RVA: 0x1A92470 Offset: 0x1A92571 VA: 0x1A92470
	public void .ctor() { }

	// RVA: 0x1A924A0 Offset: 0x1A925A1 VA: 0x1A924A0
	internal void .ctor(IEnumerable<int> triangles, int submeshIndex, AutoUnwrapSettings u, int smoothing, int texture, int element, bool manualUVs) { }

	// RVA: 0x1A92580 Offset: 0x1A92681 VA: 0x1A92580
	public void .ctor(Face other) { }

	// RVA: 0x1A925B0 Offset: 0x1A926B1 VA: 0x1A925B0
	public void CopyFrom(Face other) { }

	// RVA: 0x1A91EA0 Offset: 0x1A91FA1 VA: 0x1A91EA0
	internal void InvalidateCache() { }

	// RVA: 0x1A92140 Offset: 0x1A92241 VA: 0x1A92140
	private Edge[] CacheEdges() { }

	// RVA: 0x1A91F90 Offset: 0x1A92091 VA: 0x1A91F90
	private int[] CacheDistinctIndexes() { }

	// RVA: 0x1A92740 Offset: 0x1A92841 VA: 0x1A92740
	public bool IsQuad() { }

	// RVA: 0x1A927A0 Offset: 0x1A928A1 VA: 0x1A927A0
	public int[] ToQuad() { }

	// RVA: 0x1A92B50 Offset: 0x1A92C51 VA: 0x1A92B50 Slot: 3
	public override string ToString() { }
}


[RequiredByNativeCodeAttribute] // RVA: 0xC5800 Offset: 0xC5901 VA: 0xC5800
[NativeHeaderAttribute] // RVA: 0xC5800 Offset: 0xC5901 VA: 0xC5800
public sealed class Mesh : Object // TypeDefIndex: 2938
{
	// Properties
	public IndexFormat indexFormat { get; set; }
	public int vertexBufferCount { get; }
	public int blendShapeCount { get; }
	[NativeNameAttribute] // RVA: 0xDEBD0 Offset: 0xDECD1 VA: 0xDEBD0
	public Matrix4x4[] bindposes { get; set; }
	public bool isReadable { get; }
	internal bool canAccess { get; }
	public int vertexCount { get; }
	public int subMeshCount { get; set; }
	public Bounds bounds { get; set; }
	public Vector3[] vertices { get; set; }
	public Vector3[] normals { get; set; }
	public Vector4[] tangents { get; set; }
	public Vector2[] uv { get; set; }
	public Vector2[] uv2 { get; set; }
	public Vector2[] uv3 { get; set; }
	public Vector2[] uv4 { get; set; }
	public Vector2[] uv5 { get; set; }
	public Vector2[] uv6 { get; set; }
	public Vector2[] uv7 { get; set; }
	public Vector2[] uv8 { get; set; }
	public Color[] colors { get; set; }
	public Color32[] colors32 { get; set; }
	public int vertexAttributeCount { get; }
	public int[] triangles { get; set; }
	public BoneWeight[] boneWeights { get; set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xD1AE0 Offset: 0xD1BE1 VA: 0xD1AE0
	// RVA: 0x1A3B300 Offset: 0x1A3B401 VA: 0x1A3B300
	private static void Internal_Create(Mesh mono) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD1B20 Offset: 0xD1C21 VA: 0xD1B20
	// RVA: 0x1A3B350 Offset: 0x1A3B451 VA: 0x1A3B350
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0xD1B30 Offset: 0xD1C31 VA: 0xD1B30
	// RVA: 0x1A3B3F0 Offset: 0x1A3B4F1 VA: 0x1A3B3F0
	internal static Mesh FromInstanceID(int id) { }

	// RVA: 0x1A3B440 Offset: 0x1A3B541 VA: 0x1A3B440
	public IndexFormat get_indexFormat() { }

	// RVA: 0x1A3B490 Offset: 0x1A3B591 VA: 0x1A3B490
	public void set_indexFormat(IndexFormat value) { }

	[FreeFunctionAttribute] // RVA: 0xD1B70 Offset: 0xD1C71 VA: 0xD1B70
	// RVA: 0x1A3B4E0 Offset: 0x1A3B5E1 VA: 0x1A3B4E0
	public void SetIndexBufferParams(int indexCount, IndexFormat format) { }

	[FreeFunctionAttribute] // RVA: 0xD1BC0 Offset: 0xD1CC1 VA: 0xD1BC0
	// RVA: 0x1A3B540 Offset: 0x1A3B641 VA: 0x1A3B540
	private void InternalSetIndexBufferData(IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0xD1C10 Offset: 0xD1D11 VA: 0xD1C10
	// RVA: 0x1A3B5D0 Offset: 0x1A3B6D1 VA: 0x1A3B5D0
	private void InternalSetIndexBufferDataFromArray(Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0xD1C60 Offset: 0xD1D61 VA: 0xD1C60
	// RVA: 0x1A3B660 Offset: 0x1A3B761 VA: 0x1A3B660
	public void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	[FreeFunctionAttribute] // RVA: 0xD1CB0 Offset: 0xD1DB1 VA: 0xD1CB0
	// RVA: 0x1A3B6C0 Offset: 0x1A3B7C1 VA: 0x1A3B6C0
	private void InternalSetVertexBufferData(int stream, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0xD1D00 Offset: 0xD1E01 VA: 0xD1D00
	// RVA: 0x1A3B760 Offset: 0x1A3B861 VA: 0x1A3B760
	private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0xD1D50 Offset: 0xD1E51 VA: 0xD1D50
	// RVA: 0x1A3B800 Offset: 0x1A3B901 VA: 0x1A3B800
	private Array GetVertexAttributesAlloc() { }

	[FreeFunctionAttribute] // RVA: 0xD1DA0 Offset: 0xD1EA1 VA: 0xD1DA0
	// RVA: 0x1A3B850 Offset: 0x1A3B951 VA: 0x1A3B850
	private int GetVertexAttributesArray(VertexAttributeDescriptor[] attributes) { }

	[FreeFunctionAttribute] // RVA: 0xD1DF0 Offset: 0xD1EF1 VA: 0xD1DF0
	// RVA: 0x1A3B8A0 Offset: 0x1A3B9A1 VA: 0x1A3B8A0
	private int GetVertexAttributesList(List<VertexAttributeDescriptor> attributes) { }

	[FreeFunctionAttribute] // RVA: 0xD1E40 Offset: 0xD1F41 VA: 0xD1E40
	// RVA: 0x1A3B8F0 Offset: 0x1A3B9F1 VA: 0x1A3B8F0
	private int GetVertexAttributeCountImpl() { }

	[FreeFunctionAttribute] // RVA: 0xD1E90 Offset: 0xD1F91 VA: 0xD1E90
	// RVA: 0x1A3B940 Offset: 0x1A3BA41 VA: 0x1A3B940
	public VertexAttributeDescriptor GetVertexAttribute(int index) { }

	[FreeFunctionAttribute] // RVA: 0xD1EE0 Offset: 0xD1FE1 VA: 0xD1EE0
	// RVA: 0x1A3BA10 Offset: 0x1A3BB11 VA: 0x1A3BA10
	private uint GetIndexStartImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0xD1F30 Offset: 0xD2031 VA: 0xD1F30
	// RVA: 0x1A3BA60 Offset: 0x1A3BB61 VA: 0x1A3BA60
	private uint GetIndexCountImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0xD1F80 Offset: 0xD2081 VA: 0xD1F80
	// RVA: 0x1A3BAB0 Offset: 0x1A3BBB1 VA: 0x1A3BAB0
	private uint GetTrianglesCountImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0xD1FD0 Offset: 0xD20D1 VA: 0xD1FD0
	// RVA: 0x1A3BB00 Offset: 0x1A3BC01 VA: 0x1A3BB00
	private uint GetBaseVertexImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0xD2020 Offset: 0xD2121 VA: 0xD2020
	// RVA: 0x1A3BB50 Offset: 0x1A3BC51 VA: 0x1A3BB50
	private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0xD2070 Offset: 0xD2171 VA: 0xD2070
	// RVA: 0x1A3BBB0 Offset: 0x1A3BCB1 VA: 0x1A3BBB0
	private int[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0xD20C0 Offset: 0xD21C1 VA: 0xD20C0
	// RVA: 0x1A3BC10 Offset: 0x1A3BD11 VA: 0x1A3BC10
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunctionAttribute] // RVA: 0xD2110 Offset: 0xD2211 VA: 0xD2110
	// RVA: 0x1A3BCB0 Offset: 0x1A3BDB1 VA: 0x1A3BCB0
	private void SetIndicesNativeArrayImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, IntPtr indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunctionAttribute] // RVA: 0xD2160 Offset: 0xD2261 VA: 0xD2160
	// RVA: 0x1A3BD50 Offset: 0x1A3BE51 VA: 0x1A3BD50
	private void GetTrianglesNonAllocImpl([Out] int[] values, int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0xD21B0 Offset: 0xD22B1 VA: 0xD21B0
	// RVA: 0x1A3BDC0 Offset: 0x1A3BEC1 VA: 0x1A3BDC0
	private void GetTrianglesNonAllocImpl16([Out] ushort[] values, int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0xD2200 Offset: 0xD2301 VA: 0xD2200
	// RVA: 0x1A3BE30 Offset: 0x1A3BF31 VA: 0x1A3BE30
	private void GetIndicesNonAllocImpl([Out] int[] values, int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0xD2250 Offset: 0xD2351 VA: 0xD2250
	// RVA: 0x1A3BEA0 Offset: 0x1A3BFA1 VA: 0x1A3BEA0
	private void GetIndicesNonAllocImpl16([Out] ushort[] values, int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0xD22A0 Offset: 0xD23A1 VA: 0xD22A0
	// RVA: 0x1A3BF10 Offset: 0x1A3C011 VA: 0x1A3BF10
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	[FreeFunctionAttribute] // RVA: 0xD22F0 Offset: 0xD23F1 VA: 0xD22F0
	// RVA: 0x1A3BF60 Offset: 0x1A3C061 VA: 0x1A3BF60
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[FreeFunctionAttribute] // RVA: 0xD2340 Offset: 0xD2441 VA: 0xD2340
	// RVA: 0x1A3BFB0 Offset: 0x1A3C0B1 VA: 0x1A3BFB0
	public int GetVertexAttributeDimension(VertexAttribute attr) { }

	[FreeFunctionAttribute] // RVA: 0xD2390 Offset: 0xD2491 VA: 0xD2390
	// RVA: 0x1A3C000 Offset: 0x1A3C101 VA: 0x1A3C000
	public VertexAttributeFormat GetVertexAttributeFormat(VertexAttribute attr) { }

	[FreeFunctionAttribute] // RVA: 0xD23E0 Offset: 0xD24E1 VA: 0xD23E0
	// RVA: 0x1A3C050 Offset: 0x1A3C151 VA: 0x1A3C050
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount) { }

	[FreeFunctionAttribute] // RVA: 0xD2430 Offset: 0xD2531 VA: 0xD2430
	// RVA: 0x1A3C0F0 Offset: 0x1A3C1F1 VA: 0x1A3C0F0
	private void SetNativeArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, IntPtr values, int arraySize, int valuesStart, int valuesCount) { }

	[FreeFunctionAttribute] // RVA: 0xD2480 Offset: 0xD2581 VA: 0xD2480
	// RVA: 0x1A3C190 Offset: 0x1A3C291 VA: 0x1A3C190
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[FreeFunctionAttribute] // RVA: 0xD24D0 Offset: 0xD25D1 VA: 0xD24D0
	// RVA: 0x1A3C200 Offset: 0x1A3C301 VA: 0x1A3C200
	private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	[FreeFunctionAttribute] // RVA: 0xD2520 Offset: 0xD2621 VA: 0xD2520
	// RVA: 0x1A3C270 Offset: 0x1A3C371 VA: 0x1A3C270
	public int get_vertexBufferCount() { }

	[FreeFunctionAttribute] // RVA: 0xD2570 Offset: 0xD2671 VA: 0xD2570
	[NativeThrowsAttribute] // RVA: 0xD2570 Offset: 0xD2671 VA: 0xD2570
	// RVA: 0x1A3C2C0 Offset: 0x1A3C3C1 VA: 0x1A3C2C0
	public IntPtr GetNativeVertexBufferPtr(int index) { }

	[FreeFunctionAttribute] // RVA: 0xD25D0 Offset: 0xD26D1 VA: 0xD25D0
	// RVA: 0x1A3C310 Offset: 0x1A3C411 VA: 0x1A3C310
	public IntPtr GetNativeIndexBufferPtr() { }

	[NativeMethodAttribute] // RVA: 0xD2620 Offset: 0xD2721 VA: 0xD2620
	// RVA: 0x1A3C360 Offset: 0x1A3C461 VA: 0x1A3C360
	public int get_blendShapeCount() { }

	[FreeFunctionAttribute] // RVA: 0xD2670 Offset: 0xD2771 VA: 0xD2670
	// RVA: 0x1A3C3B0 Offset: 0x1A3C4B1 VA: 0x1A3C3B0
	public void ClearBlendShapes() { }

	[FreeFunctionAttribute] // RVA: 0xD26C0 Offset: 0xD27C1 VA: 0xD26C0
	// RVA: 0x1A3C400 Offset: 0x1A3C501 VA: 0x1A3C400
	public string GetBlendShapeName(int shapeIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD2710 Offset: 0xD2811 VA: 0xD2710
	// RVA: 0x1A3C450 Offset: 0x1A3C551 VA: 0x1A3C450
	public int GetBlendShapeIndex(string blendShapeName) { }

	[FreeFunctionAttribute] // RVA: 0xD2760 Offset: 0xD2861 VA: 0xD2760
	// RVA: 0x1A3C4A0 Offset: 0x1A3C5A1 VA: 0x1A3C4A0
	public int GetBlendShapeFrameCount(int shapeIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD27B0 Offset: 0xD28B1 VA: 0xD27B0
	// RVA: 0x1A3C4F0 Offset: 0x1A3C5F1 VA: 0x1A3C4F0
	public float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD2800 Offset: 0xD2901 VA: 0xD2800
	// RVA: 0x1A3C550 Offset: 0x1A3C651 VA: 0x1A3C550
	public void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents) { }

	[FreeFunctionAttribute] // RVA: 0xD2850 Offset: 0xD2951 VA: 0xD2850
	// RVA: 0x1A3C5D0 Offset: 0x1A3C6D1 VA: 0x1A3C5D0
	public void AddBlendShapeFrame(string shapeName, float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents) { }

	[NativeMethodAttribute] // RVA: 0xD28A0 Offset: 0xD29A1 VA: 0xD28A0
	// RVA: 0x1A3C650 Offset: 0x1A3C751 VA: 0x1A3C650
	private bool HasBoneWeights() { }

	[FreeFunctionAttribute] // RVA: 0xD28E0 Offset: 0xD29E1 VA: 0xD28E0
	// RVA: 0x1A3C6A0 Offset: 0x1A3C7A1 VA: 0x1A3C6A0
	private BoneWeight[] GetBoneWeightsImpl() { }

	[FreeFunctionAttribute] // RVA: 0xD2930 Offset: 0xD2A31 VA: 0xD2930
	// RVA: 0x1A3C6F0 Offset: 0x1A3C7F1 VA: 0x1A3C6F0
	private void SetBoneWeightsImpl(BoneWeight[] weights) { }

	// RVA: 0x1A3C740 Offset: 0x1A3C841 VA: 0x1A3C740
	public void SetBoneWeights(NativeArray<byte> bonesPerVertex, NativeArray<BoneWeight1> weights) { }

	[FreeFunctionAttribute] // RVA: 0xD2980 Offset: 0xD2A81 VA: 0xD2980
	// RVA: 0x1A3C820 Offset: 0x1A3C921 VA: 0x1A3C820
	private void InternalSetBoneWeights(IntPtr bonesPerVertex, int bonesPerVertexSize, IntPtr weights, int weightsSize) { }

	// RVA: 0x1A3C890 Offset: 0x1A3C991 VA: 0x1A3C890
	public NativeArray<BoneWeight1> GetAllBoneWeights() { }

	// RVA: 0x1A3C9F0 Offset: 0x1A3CAF1 VA: 0x1A3C9F0
	public NativeArray<byte> GetBonesPerVertex() { }

	[FreeFunctionAttribute] // RVA: 0xD29D0 Offset: 0xD2AD1 VA: 0xD29D0
	// RVA: 0x1A3C9A0 Offset: 0x1A3CAA1 VA: 0x1A3C9A0
	private int GetAllBoneWeightsArraySize() { }

	[FreeFunctionAttribute] // RVA: 0xD2A20 Offset: 0xD2B21 VA: 0xD2A20
	// RVA: 0x1A3C950 Offset: 0x1A3CA51 VA: 0x1A3C950
	private IntPtr GetAllBoneWeightsArray() { }

	[FreeFunctionAttribute] // RVA: 0xD2A70 Offset: 0xD2B71 VA: 0xD2A70
	// RVA: 0x1A3CB50 Offset: 0x1A3CC51 VA: 0x1A3CB50
	private IntPtr GetBonesPerVertexArray() { }

	// RVA: 0x1A3CBA0 Offset: 0x1A3CCA1 VA: 0x1A3CBA0
	private int GetBindposeCount() { }

	// RVA: 0x1A3CBF0 Offset: 0x1A3CCF1 VA: 0x1A3CBF0
	public Matrix4x4[] get_bindposes() { }

	// RVA: 0x1A3CC40 Offset: 0x1A3CD41 VA: 0x1A3CC40
	public void set_bindposes(Matrix4x4[] value) { }

	[FreeFunctionAttribute] // RVA: 0xD2AC0 Offset: 0xD2BC1 VA: 0xD2AC0
	// RVA: 0x1A3CC90 Offset: 0x1A3CD91 VA: 0x1A3CC90
	private void GetBoneWeightsNonAllocImpl([Out] BoneWeight[] values) { }

	[FreeFunctionAttribute] // RVA: 0xD2B10 Offset: 0xD2C11 VA: 0xD2B10
	// RVA: 0x1A3CCE0 Offset: 0x1A3CDE1 VA: 0x1A3CCE0
	private void GetBindposesNonAllocImpl([Out] Matrix4x4[] values) { }

	[NativeMethodAttribute] // RVA: 0xD2B60 Offset: 0xD2C61 VA: 0xD2B60
	// RVA: 0x1A3CD30 Offset: 0x1A3CE31 VA: 0x1A3CD30
	public bool get_isReadable() { }

	[NativeMethodAttribute] // RVA: 0xD2BA0 Offset: 0xD2CA1 VA: 0xD2BA0
	// RVA: 0x1A3CD80 Offset: 0x1A3CE81 VA: 0x1A3CD80
	internal bool get_canAccess() { }

	[NativeMethodAttribute] // RVA: 0xD2BE0 Offset: 0xD2CE1 VA: 0xD2BE0
	// RVA: 0x1A3CB00 Offset: 0x1A3CC01 VA: 0x1A3CB00
	public int get_vertexCount() { }

	[NativeMethodAttribute] // RVA: 0xD2C20 Offset: 0xD2D21 VA: 0xD2C20
	// RVA: 0x1A2AF80 Offset: 0x1A2B081 VA: 0x1A2AF80
	public int get_subMeshCount() { }

	[FreeFunctionAttribute] // RVA: 0xD2C70 Offset: 0xD2D71 VA: 0xD2C70
	// RVA: 0x1A3CDD0 Offset: 0x1A3CED1 VA: 0x1A3CDD0
	public void set_subMeshCount(int value) { }

	[FreeFunctionAttribute] // RVA: 0xD2CC0 Offset: 0xD2DC1 VA: 0xD2CC0
	// RVA: 0x1A3CE20 Offset: 0x1A3CF21 VA: 0x1A3CE20
	public void SetSubMesh(int index, SubMeshDescriptor desc, MeshUpdateFlags flags = 0) { }

	[FreeFunctionAttribute] // RVA: 0xD2D10 Offset: 0xD2E11 VA: 0xD2D10
	// RVA: 0x1A3CF00 Offset: 0x1A3D001 VA: 0x1A3CF00
	public SubMeshDescriptor GetSubMesh(int index) { }

	// RVA: 0x1A3CFF0 Offset: 0x1A3D0F1 VA: 0x1A3CFF0
	public Bounds get_bounds() { }

	// RVA: 0x1A3D0B0 Offset: 0x1A3D1B1 VA: 0x1A3D0B0
	public void set_bounds(Bounds value) { }

	[NativeMethodAttribute] // RVA: 0xD2D60 Offset: 0xD2E61 VA: 0xD2D60
	// RVA: 0x1A3D150 Offset: 0x1A3D251 VA: 0x1A3D150
	private void ClearImpl(bool keepVertexLayout) { }

	[NativeMethodAttribute] // RVA: 0xD2DA0 Offset: 0xD2EA1 VA: 0xD2DA0
	// RVA: 0x1A3D1A0 Offset: 0x1A3D2A1 VA: 0x1A3D1A0
	private void RecalculateBoundsImpl() { }

	[NativeMethodAttribute] // RVA: 0xD2DE0 Offset: 0xD2EE1 VA: 0xD2DE0
	// RVA: 0x1A3D1F0 Offset: 0x1A3D2F1 VA: 0x1A3D1F0
	private void RecalculateNormalsImpl() { }

	[NativeMethodAttribute] // RVA: 0xD2E20 Offset: 0xD2F21 VA: 0xD2E20
	// RVA: 0x1A3D240 Offset: 0x1A3D341 VA: 0x1A3D240
	private void RecalculateTangentsImpl() { }

	[NativeMethodAttribute] // RVA: 0xD2E60 Offset: 0xD2F61 VA: 0xD2E60
	// RVA: 0x1A3D290 Offset: 0x1A3D391 VA: 0x1A3D290
	private void MarkDynamicImpl() { }

	[NativeMethodAttribute] // RVA: 0xD2EA0 Offset: 0xD2FA1 VA: 0xD2EA0
	// RVA: 0x1A3D2E0 Offset: 0x1A3D3E1 VA: 0x1A3D2E0
	public void MarkModified() { }

	[NativeMethodAttribute] // RVA: 0xD2EE0 Offset: 0xD2FE1 VA: 0xD2EE0
	// RVA: 0x1A3D330 Offset: 0x1A3D431 VA: 0x1A3D330
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0xD2F20 Offset: 0xD3021 VA: 0xD2F20
	// RVA: 0x1A3D380 Offset: 0x1A3D481 VA: 0x1A3D380
	private MeshTopology GetTopologyImpl(int submesh) { }

	[NativeMethodAttribute] // RVA: 0xD2F70 Offset: 0xD3071 VA: 0xD2F70
	// RVA: 0x1A3D3D0 Offset: 0x1A3D4D1 VA: 0x1A3D3D0
	public float GetUVDistributionMetric(int uvSetIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD2FB0 Offset: 0xD30B1 VA: 0xD2FB0
	// RVA: 0x1A3D420 Offset: 0x1A3D521 VA: 0x1A3D420
	private void CombineMeshesImpl(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) { }

	[NativeMethodAttribute] // RVA: 0xD3000 Offset: 0xD3101 VA: 0xD3000
	// RVA: 0x1A3D490 Offset: 0x1A3D591 VA: 0x1A3D490
	private void OptimizeImpl() { }

	[NativeMethodAttribute] // RVA: 0xD3040 Offset: 0xD3141 VA: 0xD3040
	// RVA: 0x1A3D4E0 Offset: 0x1A3D5E1 VA: 0x1A3D4E0
	private void OptimizeIndexBuffersImpl() { }

	[NativeMethodAttribute] // RVA: 0xD3080 Offset: 0xD3181 VA: 0xD3080
	// RVA: 0x1A3D530 Offset: 0x1A3D631 VA: 0x1A3D530
	private void OptimizeReorderVertexBufferImpl() { }

	// RVA: 0x1A3D580 Offset: 0x1A3D681 VA: 0x1A3D580
	internal VertexAttribute GetUVChannel(int uvIndex) { }

	// RVA: 0x1A3D620 Offset: 0x1A3D721 VA: 0x1A3D620
	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	// RVA: -1 Offset: -1
	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F69B0 Offset: 0x34F6AB1 VA: 0x34F69B0
	|-Mesh.GetAllocArrayFromChannel<object>
	|
	|-RVA: 0x34F6AB0 Offset: 0x34F6BB1 VA: 0x34F6AB0
	|-Mesh.GetAllocArrayFromChannel<Color32>
	|
	|-RVA: 0x34F6C10 Offset: 0x34F6D11 VA: 0x34F6C10
	|-Mesh.GetAllocArrayFromChannel<Color>
	|
	|-RVA: 0x34F6D70 Offset: 0x34F6E71 VA: 0x34F6D70
	|-Mesh.GetAllocArrayFromChannel<Vector2>
	|
	|-RVA: 0x34F6ED0 Offset: 0x34F6FD1 VA: 0x34F6ED0
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|
	|-RVA: 0x34F7030 Offset: 0x34F7131 VA: 0x34F7030
	|-Mesh.GetAllocArrayFromChannel<Vector4>
	*/

	// RVA: -1 Offset: -1
	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F6950 Offset: 0x34F6A51 VA: 0x34F6950
	|-Mesh.GetAllocArrayFromChannel<object>
	|
	|-RVA: 0x34F6BB0 Offset: 0x34F6CB1 VA: 0x34F6BB0
	|-Mesh.GetAllocArrayFromChannel<Color>
	|
	|-RVA: 0x34F6D10 Offset: 0x34F6E11 VA: 0x34F6D10
	|-Mesh.GetAllocArrayFromChannel<Vector2>
	|
	|-RVA: 0x34F6E70 Offset: 0x34F6F71 VA: 0x34F6E70
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|
	|-RVA: 0x34F6FD0 Offset: 0x34F70D1 VA: 0x34F6FD0
	|-Mesh.GetAllocArrayFromChannel<Vector4>
	*/

	// RVA: 0x1A3D6F0 Offset: 0x1A3D7F1 VA: 0x1A3D6F0
	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount) { }

	// RVA: 0x1A3D990 Offset: 0x1A3DA91 VA: 0x1A3D990
	private void SetSizedNativeArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, IntPtr values, int valuesArrayLength, int valuesStart, int valuesCount) { }

	// RVA: -1 Offset: -1
	private void SetArrayForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E5C00 Offset: 0x23E5D01 VA: 0x23E5C00
	|-Mesh.SetArrayForChannel<object>
	|
	|-RVA: 0x23E5C80 Offset: 0x23E5D81 VA: 0x23E5C80
	|-Mesh.SetArrayForChannel<Color32>
	*/

	// RVA: -1 Offset: -1
	private void SetArrayForChannel<T>(VertexAttribute channel, T[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E5B80 Offset: 0x23E5C81 VA: 0x23E5B80
	|-Mesh.SetArrayForChannel<object>
	|
	|-RVA: 0x23E5D00 Offset: 0x23E5E01 VA: 0x23E5D00
	|-Mesh.SetArrayForChannel<Color>
	|
	|-RVA: 0x23E5D80 Offset: 0x23E5E81 VA: 0x23E5D80
	|-Mesh.SetArrayForChannel<Vector2>
	|
	|-RVA: 0x23E5E00 Offset: 0x23E5F01 VA: 0x23E5E00
	|-Mesh.SetArrayForChannel<Vector3>
	|
	|-RVA: 0x23E5E80 Offset: 0x23E5F81 VA: 0x23E5E80
	|-Mesh.SetArrayForChannel<Vector4>
	*/

	// RVA: -1 Offset: -1
	private void SetListForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E5FC0 Offset: 0x23E60C1 VA: 0x23E5FC0
	|-Mesh.SetListForChannel<object>
	|
	|-RVA: 0x23E6080 Offset: 0x23E6181 VA: 0x23E6080
	|-Mesh.SetListForChannel<Color32>
	|
	|-RVA: 0x23E6200 Offset: 0x23E6301 VA: 0x23E6200
	|-Mesh.SetListForChannel<Vector2>
	|
	|-RVA: 0x23E6380 Offset: 0x23E6481 VA: 0x23E6380
	|-Mesh.SetListForChannel<Vector3>
	|
	|-RVA: 0x23E6500 Offset: 0x23E6601 VA: 0x23E6500
	|-Mesh.SetListForChannel<Vector4>
	*/

	// RVA: -1 Offset: -1
	private void SetListForChannel<T>(VertexAttribute channel, List<T> values, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E5F00 Offset: 0x23E6001 VA: 0x23E5F00
	|-Mesh.SetListForChannel<object>
	|
	|-RVA: 0x23E6140 Offset: 0x23E6241 VA: 0x23E6140
	|-Mesh.SetListForChannel<Color>
	|
	|-RVA: 0x23E62C0 Offset: 0x23E63C1 VA: 0x23E62C0
	|-Mesh.SetListForChannel<Vector3>
	|
	|-RVA: 0x23E6440 Offset: 0x23E6541 VA: 0x23E6440
	|-Mesh.SetListForChannel<Vector4>
	*/

	// RVA: -1 Offset: -1
	private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E4F70 Offset: 0x23E5071 VA: 0x23E4F70
	|-Mesh.GetListForChannel<object>
	|
	|-RVA: 0x23E51C0 Offset: 0x23E52C1 VA: 0x23E51C0
	|-Mesh.GetListForChannel<Color>
	|
	|-RVA: 0x23E5300 Offset: 0x23E5401 VA: 0x23E5300
	|-Mesh.GetListForChannel<Vector2>
	|
	|-RVA: 0x23E5440 Offset: 0x23E5541 VA: 0x23E5440
	|-Mesh.GetListForChannel<Vector3>
	|
	|-RVA: 0x23E5580 Offset: 0x23E5681 VA: 0x23E5580
	|-Mesh.GetListForChannel<Vector4>
	*/

	// RVA: -1 Offset: -1
	private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E4FA0 Offset: 0x23E50A1 VA: 0x23E4FA0
	|-Mesh.GetListForChannel<object>
	|
	|-RVA: 0x23E50B0 Offset: 0x23E51B1 VA: 0x23E50B0
	|-Mesh.GetListForChannel<Color32>
	|
	|-RVA: 0x23E51F0 Offset: 0x23E52F1 VA: 0x23E51F0
	|-Mesh.GetListForChannel<Color>
	|
	|-RVA: 0x23E5330 Offset: 0x23E5431 VA: 0x23E5330
	|-Mesh.GetListForChannel<Vector2>
	|
	|-RVA: 0x23E5470 Offset: 0x23E5571 VA: 0x23E5470
	|-Mesh.GetListForChannel<Vector3>
	|
	|-RVA: 0x23E55B0 Offset: 0x23E56B1 VA: 0x23E55B0
	|-Mesh.GetListForChannel<Vector4>
	*/

	// RVA: 0x1A3DC30 Offset: 0x1A3DD31 VA: 0x1A3DC30
	public Vector3[] get_vertices() { }

	// RVA: 0x1A3DC90 Offset: 0x1A3DD91 VA: 0x1A3DC90
	public void set_vertices(Vector3[] value) { }

	// RVA: 0x1A3DD00 Offset: 0x1A3DE01 VA: 0x1A3DD00
	public Vector3[] get_normals() { }

	// RVA: 0x1A3DD60 Offset: 0x1A3DE61 VA: 0x1A3DD60
	public void set_normals(Vector3[] value) { }

	// RVA: 0x1A3DDD0 Offset: 0x1A3DED1 VA: 0x1A3DDD0
	public Vector4[] get_tangents() { }

	// RVA: 0x1A3DE30 Offset: 0x1A3DF31 VA: 0x1A3DE30
	public void set_tangents(Vector4[] value) { }

	// RVA: 0x1A3DEA0 Offset: 0x1A3DFA1 VA: 0x1A3DEA0
	public Vector2[] get_uv() { }

	// RVA: 0x1A3DF00 Offset: 0x1A3E001 VA: 0x1A3DF00
	public void set_uv(Vector2[] value) { }

	// RVA: 0x1A3DF70 Offset: 0x1A3E071 VA: 0x1A3DF70
	public Vector2[] get_uv2() { }

	// RVA: 0x1A3DFD0 Offset: 0x1A3E0D1 VA: 0x1A3DFD0
	public void set_uv2(Vector2[] value) { }

	// RVA: 0x1A3E040 Offset: 0x1A3E141 VA: 0x1A3E040
	public Vector2[] get_uv3() { }

	// RVA: 0x1A3E0A0 Offset: 0x1A3E1A1 VA: 0x1A3E0A0
	public void set_uv3(Vector2[] value) { }

	// RVA: 0x1A3E110 Offset: 0x1A3E211 VA: 0x1A3E110
	public Vector2[] get_uv4() { }

	// RVA: 0x1A3E170 Offset: 0x1A3E271 VA: 0x1A3E170
	public void set_uv4(Vector2[] value) { }

	// RVA: 0x1A3E1E0 Offset: 0x1A3E2E1 VA: 0x1A3E1E0
	public Vector2[] get_uv5() { }

	// RVA: 0x1A3E240 Offset: 0x1A3E341 VA: 0x1A3E240
	public void set_uv5(Vector2[] value) { }

	// RVA: 0x1A3E2B0 Offset: 0x1A3E3B1 VA: 0x1A3E2B0
	public Vector2[] get_uv6() { }

	// RVA: 0x1A3E310 Offset: 0x1A3E411 VA: 0x1A3E310
	public void set_uv6(Vector2[] value) { }

	// RVA: 0x1A3E380 Offset: 0x1A3E481 VA: 0x1A3E380
	public Vector2[] get_uv7() { }

	// RVA: 0x1A3E3E0 Offset: 0x1A3E4E1 VA: 0x1A3E3E0
	public void set_uv7(Vector2[] value) { }

	// RVA: 0x1A3E450 Offset: 0x1A3E551 VA: 0x1A3E450
	public Vector2[] get_uv8() { }

	// RVA: 0x1A3E4B0 Offset: 0x1A3E5B1 VA: 0x1A3E4B0
	public void set_uv8(Vector2[] value) { }

	// RVA: 0x1A3E520 Offset: 0x1A3E621 VA: 0x1A3E520
	public Color[] get_colors() { }

	// RVA: 0x1A3E580 Offset: 0x1A3E681 VA: 0x1A3E580
	public void set_colors(Color[] value) { }

	// RVA: 0x1A3E5F0 Offset: 0x1A3E6F1 VA: 0x1A3E5F0
	public Color32[] get_colors32() { }

	// RVA: 0x1A3E650 Offset: 0x1A3E751 VA: 0x1A3E650
	public void set_colors32(Color32[] value) { }

	// RVA: 0x1A3E6C0 Offset: 0x1A3E7C1 VA: 0x1A3E6C0
	public void GetVertices(List<Vector3> vertices) { }

	// RVA: 0x1A3E7D0 Offset: 0x1A3E8D1 VA: 0x1A3E7D0
	public void SetVertices(List<Vector3> inVertices) { }

	// RVA: 0x1A3E880 Offset: 0x1A3E981 VA: 0x1A3E880
	public void SetVertices(List<Vector3> inVertices, int start, int length) { }

	// RVA: 0x1A3E900 Offset: 0x1A3EA01 VA: 0x1A3E900
	public void SetVertices(Vector3[] inVertices) { }

	// RVA: 0x1A3E9A0 Offset: 0x1A3EAA1 VA: 0x1A3E9A0
	public void SetVertices(Vector3[] inVertices, int start, int length) { }

	// RVA: -1 Offset: -1
	public void SetVertices<T>(NativeArray<T> inVertices) { }

	// RVA: -1 Offset: -1
	public void SetVertices<T>(NativeArray<T> inVertices, int start, int length) { }

	// RVA: 0x1A3EA40 Offset: 0x1A3EB41 VA: 0x1A3EA40
	public void GetNormals(List<Vector3> normals) { }

	// RVA: 0x1A3EB50 Offset: 0x1A3EC51 VA: 0x1A3EB50
	public void SetNormals(List<Vector3> inNormals) { }

	// RVA: 0x1A3EC00 Offset: 0x1A3ED01 VA: 0x1A3EC00
	public void SetNormals(List<Vector3> inNormals, int start, int length) { }

	// RVA: 0x1A3EC80 Offset: 0x1A3ED81 VA: 0x1A3EC80
	public void SetNormals(Vector3[] inNormals) { }

	// RVA: 0x1A3ED20 Offset: 0x1A3EE21 VA: 0x1A3ED20
	public void SetNormals(Vector3[] inNormals, int start, int length) { }

	// RVA: -1 Offset: -1
	public void SetNormals<T>(NativeArray<T> inNormals) { }

	// RVA: -1 Offset: -1
	public void SetNormals<T>(NativeArray<T> inNormals, int start, int length) { }

	// RVA: 0x1A3EDC0 Offset: 0x1A3EEC1 VA: 0x1A3EDC0
	public void GetTangents(List<Vector4> tangents) { }

	// RVA: 0x1A3EED0 Offset: 0x1A3EFD1 VA: 0x1A3EED0
	public void SetTangents(List<Vector4> inTangents) { }

	// RVA: 0x1A3EF80 Offset: 0x1A3F081 VA: 0x1A3EF80
	public void SetTangents(List<Vector4> inTangents, int start, int length) { }

	// RVA: 0x1A3F000 Offset: 0x1A3F101 VA: 0x1A3F000
	public void SetTangents(Vector4[] inTangents) { }

	// RVA: 0x1A3F0A0 Offset: 0x1A3F1A1 VA: 0x1A3F0A0
	public void SetTangents(Vector4[] inTangents, int start, int length) { }

	// RVA: -1 Offset: -1
	public void SetTangents<T>(NativeArray<T> inTangents) { }

	// RVA: -1 Offset: -1
	public void SetTangents<T>(NativeArray<T> inTangents, int start, int length) { }

	// RVA: 0x1A3F140 Offset: 0x1A3F241 VA: 0x1A3F140
	public void GetColors(List<Color> colors) { }

	// RVA: 0x1A3F250 Offset: 0x1A3F351 VA: 0x1A3F250
	public void SetColors(List<Color> inColors) { }

	// RVA: 0x1A3F300 Offset: 0x1A3F401 VA: 0x1A3F300
	public void SetColors(List<Color> inColors, int start, int length) { }

	// RVA: 0x1A3F380 Offset: 0x1A3F481 VA: 0x1A3F380
	public void SetColors(Color[] inColors) { }

	// RVA: 0x1A3F420 Offset: 0x1A3F521 VA: 0x1A3F420
	public void SetColors(Color[] inColors, int start, int length) { }

	// RVA: 0x1A3F4C0 Offset: 0x1A3F5C1 VA: 0x1A3F4C0
	public void GetColors(List<Color32> colors) { }

	// RVA: 0x1A3F5B0 Offset: 0x1A3F6B1 VA: 0x1A3F5B0
	public void SetColors(List<Color32> inColors) { }

	// RVA: 0x1A3F660 Offset: 0x1A3F761 VA: 0x1A3F660
	public void SetColors(List<Color32> inColors, int start, int length) { }

	// RVA: 0x1A3F6F0 Offset: 0x1A3F7F1 VA: 0x1A3F6F0
	public void SetColors(Color32[] inColors) { }

	// RVA: 0x1A3F760 Offset: 0x1A3F861 VA: 0x1A3F760
	public void SetColors(Color32[] inColors, int start, int length) { }

	// RVA: -1 Offset: -1
	public void SetColors<T>(NativeArray<T> inColors) { }

	// RVA: -1 Offset: -1
	public void SetColors<T>(NativeArray<T> inColors, int start, int length) { }

	// RVA: -1 Offset: -1
	private void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E65C0 Offset: 0x23E66C1 VA: 0x23E65C0
	|-Mesh.SetUvsImpl<object>
	|
	|-RVA: 0x23E66C0 Offset: 0x23E67C1 VA: 0x23E66C0
	|-Mesh.SetUvsImpl<Vector2>
	|
	|-RVA: 0x23E67C0 Offset: 0x23E68C1 VA: 0x23E67C0
	|-Mesh.SetUvsImpl<Vector3>
	|
	|-RVA: 0x23E68C0 Offset: 0x23E69C1 VA: 0x23E68C0
	|-Mesh.SetUvsImpl<Vector4>
	*/

	// RVA: 0x1A3F7D0 Offset: 0x1A3F8D1 VA: 0x1A3F7D0
	public void SetUVs(int channel, List<Vector2> uvs) { }

	// RVA: 0x1A3F920 Offset: 0x1A3FA21 VA: 0x1A3F920
	public void SetUVs(int channel, List<Vector3> uvs) { }

	// RVA: 0x1A3FA70 Offset: 0x1A3FB71 VA: 0x1A3FA70
	public void SetUVs(int channel, List<Vector4> uvs) { }

	// RVA: 0x1A3F890 Offset: 0x1A3F991 VA: 0x1A3F890
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length) { }

	// RVA: 0x1A3F9E0 Offset: 0x1A3FAE1 VA: 0x1A3F9E0
	public void SetUVs(int channel, List<Vector3> uvs, int start, int length) { }

	// RVA: 0x1A3FB30 Offset: 0x1A3FC31 VA: 0x1A3FB30
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length) { }

	// RVA: 0x1A3FBC0 Offset: 0x1A3FCC1 VA: 0x1A3FBC0
	private void SetUvsImpl(int uvIndex, int dim, Array uvs, int arrayStart, int arraySize) { }

	// RVA: 0x1A3FD00 Offset: 0x1A3FE01 VA: 0x1A3FD00
	public void SetUVs(int channel, Vector2[] uvs) { }

	// RVA: 0x1A3FD70 Offset: 0x1A3FE71 VA: 0x1A3FD70
	public void SetUVs(int channel, Vector3[] uvs) { }

	// RVA: 0x1A3FDE0 Offset: 0x1A3FEE1 VA: 0x1A3FDE0
	public void SetUVs(int channel, Vector4[] uvs) { }

	// RVA: 0x1A3FD50 Offset: 0x1A3FE51 VA: 0x1A3FD50
	public void SetUVs(int channel, Vector2[] uvs, int start, int length) { }

	// RVA: 0x1A3FDC0 Offset: 0x1A3FEC1 VA: 0x1A3FDC0
	public void SetUVs(int channel, Vector3[] uvs, int start, int length) { }

	// RVA: 0x1A3FE30 Offset: 0x1A3FF31 VA: 0x1A3FE30
	public void SetUVs(int channel, Vector4[] uvs, int start, int length) { }

	// RVA: -1 Offset: -1
	public void SetUVs<T>(int channel, NativeArray<T> uvs) { }

	// RVA: -1 Offset: -1
	public void SetUVs<T>(int channel, NativeArray<T> uvs, int start, int length) { }

	// RVA: -1 Offset: -1
	private void GetUVsImpl<T>(int uvIndex, List<T> uvs, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E56C0 Offset: 0x23E57C1 VA: 0x23E56C0
	|-Mesh.GetUVsImpl<object>
	|
	|-RVA: 0x23E57F0 Offset: 0x23E58F1 VA: 0x23E57F0
	|-Mesh.GetUVsImpl<Vector2>
	|
	|-RVA: 0x23E5920 Offset: 0x23E5A21 VA: 0x23E5920
	|-Mesh.GetUVsImpl<Vector3>
	|
	|-RVA: 0x23E5A50 Offset: 0x23E5B51 VA: 0x23E5A50
	|-Mesh.GetUVsImpl<Vector4>
	*/

	// RVA: 0x1A3FE50 Offset: 0x1A3FF51 VA: 0x1A3FE50
	public void GetUVs(int channel, List<Vector2> uvs) { }

	// RVA: 0x1A3FEC0 Offset: 0x1A3FFC1 VA: 0x1A3FEC0
	public void GetUVs(int channel, List<Vector3> uvs) { }

	// RVA: 0x1A3FF30 Offset: 0x1A40031 VA: 0x1A3FF30
	public void GetUVs(int channel, List<Vector4> uvs) { }

	// RVA: 0x1A3FFA0 Offset: 0x1A400A1 VA: 0x1A3FFA0
	public int get_vertexAttributeCount() { }

	// RVA: 0x1A3FFF0 Offset: 0x1A400F1 VA: 0x1A3FFF0
	public VertexAttributeDescriptor[] GetVertexAttributes() { }

	// RVA: 0x1A400A0 Offset: 0x1A401A1 VA: 0x1A400A0
	public int GetVertexAttributes(VertexAttributeDescriptor[] attributes) { }

	// RVA: 0x1A400F0 Offset: 0x1A401F1 VA: 0x1A400F0
	public int GetVertexAttributes(List<VertexAttributeDescriptor> attributes) { }

	// RVA: -1 Offset: -1
	public void SetVertexBufferData<T>(NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }

	// RVA: -1 Offset: -1
	public void SetVertexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }

	// RVA: -1 Offset: -1
	public void SetVertexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }

	// RVA: 0x1A40140 Offset: 0x1A40241 VA: 0x1A40140
	private void PrintErrorCantAccessIndices() { }

	// RVA: 0x1A401D0 Offset: 0x1A402D1 VA: 0x1A401D0
	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	// RVA: 0x1A403A0 Offset: 0x1A404A1 VA: 0x1A403A0
	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	// RVA: 0x1A403B0 Offset: 0x1A404B1 VA: 0x1A403B0
	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	// RVA: 0x1A403C0 Offset: 0x1A404C1 VA: 0x1A403C0
	public int[] get_triangles() { }

	// RVA: 0x1A40510 Offset: 0x1A40611 VA: 0x1A40510
	public void set_triangles(int[] value) { }

	// RVA: 0x1A40730 Offset: 0x1A40831 VA: 0x1A40730
	public int[] GetTriangles(int submesh) { }

	// RVA: 0x1A407E0 Offset: 0x1A408E1 VA: 0x1A407E0
	public int[] GetTriangles(int submesh, bool applyBaseVertex) { }

	// RVA: 0x1A40890 Offset: 0x1A40991 VA: 0x1A40890
	public void GetTriangles(List<int> triangles, int submesh) { }

	// RVA: 0x1A408A0 Offset: 0x1A409A1 VA: 0x1A408A0
	public void GetTriangles(List<int> triangles, int submesh, bool applyBaseVertex) { }

	// RVA: 0x1A40A40 Offset: 0x1A40B41 VA: 0x1A40A40
	public void GetTriangles(List<ushort> triangles, int submesh, bool applyBaseVertex = True) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD30C0 Offset: 0xD31C1 VA: 0xD30C0
	// RVA: 0x1A40BE0 Offset: 0x1A40CE1 VA: 0x1A40BE0
	public int[] GetIndices(int submesh) { }

	// RVA: 0x1A40C90 Offset: 0x1A40D91 VA: 0x1A40C90
	public int[] GetIndices(int submesh, bool applyBaseVertex) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD30D0 Offset: 0xD31D1 VA: 0xD30D0
	// RVA: 0x1A40D40 Offset: 0x1A40E41 VA: 0x1A40D40
	public void GetIndices(List<int> indices, int submesh) { }

	// RVA: 0x1A40D50 Offset: 0x1A40E51 VA: 0x1A40D50
	public void GetIndices(List<int> indices, int submesh, bool applyBaseVertex) { }

	// RVA: 0x1A40FC0 Offset: 0x1A410C1 VA: 0x1A40FC0
	public void GetIndices(List<ushort> indices, int submesh, bool applyBaseVertex = True) { }

	// RVA: -1 Offset: -1
	public void SetIndexBufferData<T>(NativeArray<T> data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }

	// RVA: -1 Offset: -1
	public void SetIndexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }

	// RVA: -1 Offset: -1
	public void SetIndexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }

	// RVA: 0x1A41140 Offset: 0x1A41241 VA: 0x1A41140
	public uint GetIndexStart(int submesh) { }

	// RVA: 0x1A40ED0 Offset: 0x1A40FD1 VA: 0x1A40ED0
	public uint GetIndexCount(int submesh) { }

	// RVA: 0x1A41230 Offset: 0x1A41331 VA: 0x1A41230
	public uint GetBaseVertex(int submesh) { }

	// RVA: 0x1A41320 Offset: 0x1A41421 VA: 0x1A41320
	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	// RVA: 0x1A40680 Offset: 0x1A40781 VA: 0x1A40680
	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD30E0 Offset: 0xD31E1 VA: 0xD30E0
	// RVA: 0x1A414D0 Offset: 0x1A415D1 VA: 0x1A414D0
	public void SetTriangles(int[] triangles, int submesh) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD30F0 Offset: 0xD31F1 VA: 0xD30F0
	// RVA: 0x1A41680 Offset: 0x1A41781 VA: 0x1A41680
	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds) { }

	// RVA: 0x1A415A0 Offset: 0x1A416A1 VA: 0x1A415A0
	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x1A41750 Offset: 0x1A41851 VA: 0x1A41750
	public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x1A41820 Offset: 0x1A41921 VA: 0x1A41820
	public void SetTriangles(ushort[] triangles, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x1A41900 Offset: 0x1A41A01 VA: 0x1A41900
	public void SetTriangles(ushort[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD3100 Offset: 0xD3201 VA: 0xD3100
	// RVA: 0x1A419D0 Offset: 0x1A41AD1 VA: 0x1A419D0
	public void SetTriangles(List<int> triangles, int submesh) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD3110 Offset: 0xD3211 VA: 0xD3110
	// RVA: 0x1A41AE0 Offset: 0x1A41BE1 VA: 0x1A41AE0
	public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds) { }

	// RVA: 0x1A41A50 Offset: 0x1A41B51 VA: 0x1A41A50
	public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x1A41B70 Offset: 0x1A41C71 VA: 0x1A41B70
	public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x1A41C80 Offset: 0x1A41D81 VA: 0x1A41C80
	public void SetTriangles(List<ushort> triangles, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x1A41D10 Offset: 0x1A41E11 VA: 0x1A41D10
	public void SetTriangles(List<ushort> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD3120 Offset: 0xD3221 VA: 0xD3120
	// RVA: 0x1A41E20 Offset: 0x1A41F21 VA: 0x1A41E20
	public void SetIndices(int[] indices, MeshTopology topology, int submesh) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD3130 Offset: 0xD3231 VA: 0xD3130
	// RVA: 0x1A41FD0 Offset: 0x1A420D1 VA: 0x1A41FD0
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	// RVA: 0x1A41EF0 Offset: 0x1A41FF1 VA: 0x1A41EF0
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x1A420B0 Offset: 0x1A421B1 VA: 0x1A420B0
	public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x1A421A0 Offset: 0x1A422A1 VA: 0x1A421A0
	public void SetIndices(ushort[] indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x1A42280 Offset: 0x1A42381 VA: 0x1A42280
	public void SetIndices(ushort[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: -1 Offset: -1
	public void SetIndices<T>(NativeArray<T> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: -1 Offset: -1
	public void SetIndices<T>(NativeArray<T> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x1A42370 Offset: 0x1A42471 VA: 0x1A42370
	public void SetIndices(List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x1A42420 Offset: 0x1A42521 VA: 0x1A42420
	public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x1A42550 Offset: 0x1A42651 VA: 0x1A42550
	public void SetIndices(List<ushort> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x1A42600 Offset: 0x1A42701 VA: 0x1A42600
	public void SetIndices(List<ushort> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x1A42730 Offset: 0x1A42831 VA: 0x1A42730
	public void GetBindposes(List<Matrix4x4> bindposes) { }

	// RVA: 0x1A42850 Offset: 0x1A42951 VA: 0x1A42850
	public void GetBoneWeights(List<BoneWeight> boneWeights) { }

	// RVA: 0x1A429B0 Offset: 0x1A42AB1 VA: 0x1A429B0
	public BoneWeight[] get_boneWeights() { }

	// RVA: 0x1A42A00 Offset: 0x1A42B01 VA: 0x1A42A00
	public void set_boneWeights(BoneWeight[] value) { }

	// RVA: 0x1A42A50 Offset: 0x1A42B51 VA: 0x1A42A50
	public void Clear(bool keepVertexLayout) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD3140 Offset: 0xD3241 VA: 0xD3140
	// RVA: 0x1A42AA0 Offset: 0x1A42BA1 VA: 0x1A42AA0
	public void Clear() { }

	// RVA: 0x1A42AF0 Offset: 0x1A42BF1 VA: 0x1A42AF0
	public void RecalculateBounds() { }

	// RVA: 0x1A42C10 Offset: 0x1A42D11 VA: 0x1A42C10
	public void RecalculateNormals() { }

	// RVA: 0x1A42D30 Offset: 0x1A42E31 VA: 0x1A42D30
	public void RecalculateTangents() { }

	// RVA: 0x1A42E50 Offset: 0x1A42F51 VA: 0x1A42E50
	public void MarkDynamic() { }

	// RVA: 0x1A42EF0 Offset: 0x1A42FF1 VA: 0x1A42EF0
	public void UploadMeshData(bool markNoLongerReadable) { }

	// RVA: 0x1A42F90 Offset: 0x1A43091 VA: 0x1A42F90
	public void Optimize() { }

	// RVA: 0x1A430B0 Offset: 0x1A431B1 VA: 0x1A430B0
	public void OptimizeIndexBuffers() { }

	// RVA: 0x1A431D0 Offset: 0x1A432D1 VA: 0x1A431D0
	public void OptimizeReorderVertexBuffer() { }

	// RVA: 0x1A432F0 Offset: 0x1A433F1 VA: 0x1A432F0
	public MeshTopology GetTopology(int submesh) { }

	// RVA: 0x1A43420 Offset: 0x1A43521 VA: 0x1A43420
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD3150 Offset: 0xD3251 VA: 0xD3150
	// RVA: 0x1A43490 Offset: 0x1A43591 VA: 0x1A43490
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD3160 Offset: 0xD3261 VA: 0xD3160
	// RVA: 0x1A43500 Offset: 0x1A43601 VA: 0x1A43500
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD3170 Offset: 0xD3271 VA: 0xD3170
	// RVA: 0x1A43560 Offset: 0x1A43661 VA: 0x1A43560
	public void CombineMeshes(CombineInstance[] combine) { }

	// RVA: 0x1A3B9B0 Offset: 0x1A3BAB1 VA: 0x1A3B9B0
	private void GetVertexAttribute_Injected(int index, out VertexAttributeDescriptor ret) { }

	// RVA: 0x1A3CE90 Offset: 0x1A3CF91 VA: 0x1A3CE90
	private void SetSubMesh_Injected(int index, ref SubMeshDescriptor desc, MeshUpdateFlags flags = 0) { }

	// RVA: 0x1A3CF90 Offset: 0x1A3D091 VA: 0x1A3CF90
	private void GetSubMesh_Injected(int index, out SubMeshDescriptor ret) { }

	// RVA: 0x1A3D060 Offset: 0x1A3D161 VA: 0x1A3D060
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x1A3D100 Offset: 0x1A3D201 VA: 0x1A3D100
	private void set_bounds_Injected(ref Bounds value) { }
}


[RequireComponent] // RVA: 0x141550 Offset: 0x141651 VA: 0x141550
[AddComponentMenu] // RVA: 0x141550 Offset: 0x141651 VA: 0x141550
[DisallowMultipleComponent] // RVA: 0x141550 Offset: 0x141651 VA: 0x141550
[ExcludeFromPresetAttribute] // RVA: 0x141550 Offset: 0x141651 VA: 0x141550
[ExcludeFromObjectFactoryAttribute] // RVA: 0x141550 Offset: 0x141651 VA: 0x141550
[ExecuteInEditMode] // RVA: 0x141550 Offset: 0x141651 VA: 0x141550
public sealed class ProBuilderMesh : MonoBehaviour // TypeDefIndex: 5966
{
	// Fields
	internal const HideFlags k_MeshFilterHideFlags = 10;
	private const int k_UVChannelCount = 4;
	private const int k_MeshFormatVersion = 1;
	private const int k_MeshFormatVersionSubmeshMaterialRefactor = 1;
	public const uint maxVertexCount = 65535;
	[SerializeField] // RVA: 0x141D40 Offset: 0x141E41 VA: 0x141D40
	private int m_MeshFormatVersion; // 0x18
	[SerializeField] // RVA: 0x141D50 Offset: 0x141E51 VA: 0x141D50
	[FormerlySerializedAsAttribute] // RVA: 0x141D50 Offset: 0x141E51 VA: 0x141D50
	private Face[] m_Faces; // 0x20
	[SerializeField] // RVA: 0x141DA0 Offset: 0x141EA1 VA: 0x141DA0
	[FormerlySerializedAsAttribute] // RVA: 0x141DA0 Offset: 0x141EA1 VA: 0x141DA0
	[FormerlySerializedAsAttribute] // RVA: 0x141DA0 Offset: 0x141EA1 VA: 0x141DA0
	private SharedVertex[] m_SharedVertices; // 0x28
	private ProBuilderMesh.CacheValidState m_CacheValid; // 0x30
	private Dictionary<int, int> m_SharedVertexLookup; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0x141E10 Offset: 0x141F11 VA: 0x141E10
	[SerializeField] // RVA: 0x141E10 Offset: 0x141F11 VA: 0x141E10
	private SharedVertex[] m_SharedTextures; // 0x40
	private Dictionary<int, int> m_SharedTextureLookup; // 0x48
	[SerializeField] // RVA: 0x141E60 Offset: 0x141F61 VA: 0x141E60
	[FormerlySerializedAsAttribute] // RVA: 0x141E60 Offset: 0x141F61 VA: 0x141E60
	private Vector3[] m_Positions; // 0x50
	[SerializeField] // RVA: 0x141EB0 Offset: 0x141FB1 VA: 0x141EB0
	[FormerlySerializedAsAttribute] // RVA: 0x141EB0 Offset: 0x141FB1 VA: 0x141EB0
	private Vector2[] m_Textures0; // 0x58
	[FormerlySerializedAsAttribute] // RVA: 0x141F00 Offset: 0x142001 VA: 0x141F00
	[SerializeField] // RVA: 0x141F00 Offset: 0x142001 VA: 0x141F00
	private List<Vector4> m_Textures2; // 0x60
	[FormerlySerializedAsAttribute] // RVA: 0x141F50 Offset: 0x142051 VA: 0x141F50
	[SerializeField] // RVA: 0x141F50 Offset: 0x142051 VA: 0x141F50
	private List<Vector4> m_Textures3; // 0x68
	[FormerlySerializedAsAttribute] // RVA: 0x141FA0 Offset: 0x1420A1 VA: 0x141FA0
	[SerializeField] // RVA: 0x141FA0 Offset: 0x1420A1 VA: 0x141FA0
	private Vector4[] m_Tangents; // 0x70
	private Vector3[] m_Normals; // 0x78
	[FormerlySerializedAsAttribute] // RVA: 0x141FF0 Offset: 0x1420F1 VA: 0x141FF0
	[SerializeField] // RVA: 0x141FF0 Offset: 0x1420F1 VA: 0x141FF0
	private Color[] m_Colors; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x142040 Offset: 0x142141 VA: 0x142040
	private bool <userCollisions>k__BackingField; // 0x88
	[SerializeField] // RVA: 0x142050 Offset: 0x142151 VA: 0x142050
	[FormerlySerializedAsAttribute] // RVA: 0x142050 Offset: 0x142151 VA: 0x142050
	private UnwrapParameters m_UnwrapParameters; // 0x90
	[SerializeField] // RVA: 0x1420A0 Offset: 0x1421A1 VA: 0x1420A0
	[FormerlySerializedAsAttribute] // RVA: 0x1420A0 Offset: 0x1421A1 VA: 0x1420A0
	private bool m_PreserveMeshAssetOnDestroy; // 0x98
	[SerializeField] // RVA: 0x1420F0 Offset: 0x1421F1 VA: 0x1420F0
	internal string assetGuid; // 0xA0
	[SerializeField] // RVA: 0x142100 Offset: 0x142201 VA: 0x142100
	private Mesh m_Mesh; // 0xA8
	private MeshRenderer m_MeshRenderer; // 0xB0
	private MeshFilter m_MeshFilter; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x142110 Offset: 0x142211 VA: 0x142110
	private static Action<ProBuilderMesh> meshWillBeDestroyed; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x142120 Offset: 0x142221 VA: 0x142120
	private static Action<ProBuilderMesh> componentWillBeDestroyed; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x142130 Offset: 0x142231 VA: 0x142130
	private static Action<ProBuilderMesh> componentHasBeenReset; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x142140 Offset: 0x142241 VA: 0x142140
	private static Action<ProBuilderMesh> elementSelectionChanged; // 0x18
	private static HashSet<int> s_CachedHashSet; // 0x20
	[SerializeField] // RVA: 0x142150 Offset: 0x142251 VA: 0x142150
	private bool m_IsSelectable; // 0xC0
	[SerializeField] // RVA: 0x142160 Offset: 0x142261 VA: 0x142160
	private int[] m_SelectedFaces; // 0xC8
	[SerializeField] // RVA: 0x142170 Offset: 0x142271 VA: 0x142170
	private Edge[] m_SelectedEdges; // 0xD0
	[SerializeField] // RVA: 0x142180 Offset: 0x142281 VA: 0x142180
	private int[] m_SelectedVertices; // 0xD8
	private bool m_SelectedCacheDirty; // 0xE0
	private int m_SelectedSharedVerticesCount; // 0xE4
	private int m_SelectedCoincidentVertexCount; // 0xE8
	private HashSet<int> m_SelectedSharedVertices; // 0xF0
	private List<int> m_SelectedCoincidentVertices; // 0xF8

	// Properties
	public bool userCollisions { get; set; }
	public UnwrapParameters unwrapParameters { get; set; }
	internal MeshRenderer renderer { get; }
	internal MeshFilter filter { get; }
	public bool preserveMeshAssetOnDestroy { get; set; }
	internal Face[] facesInternal { get; set; }
	public IList<Face> faces { get; set; }
	internal SharedVertex[] sharedVerticesInternal { get; set; }
	public IList<SharedVertex> sharedVertices { get; set; }
	internal Dictionary<int, int> sharedVertexLookup { get; }
	internal SharedVertex[] sharedTextures { get; set; }
	internal Dictionary<int, int> sharedTextureLookup { get; }
	internal Vector3[] positionsInternal { get; set; }
	public IList<Vector3> positions { get; set; }
	public IList<Vector3> normals { get; }
	internal Vector3[] normalsInternal { get; set; }
	internal Color[] colorsInternal { get; set; }
	public IList<Color> colors { get; set; }
	public IList<Vector4> tangents { get; set; }
	internal Vector4[] tangentsInternal { get; set; }
	internal Vector2[] texturesInternal { get; set; }
	public IList<Vector2> textures { get; set; }
	public int faceCount { get; }
	public int vertexCount { get; }
	public int edgeCount { get; }
	public int indexCount { get; }
	public int triangleCount { get; }
	internal Mesh mesh { get; set; }
	internal int id { get; }
	public MeshSyncState meshSyncState { get; }
	public bool selectable { get; set; }
	public int selectedFaceCount { get; }
	public int selectedVertexCount { get; }
	public int selectedEdgeCount { get; }
	internal int selectedSharedVerticesCount { get; }
	internal int selectedCoincidentVertexCount { get; }
	internal IEnumerable<int> selectedSharedVertices { get; }
	internal IEnumerable<int> selectedCoincidentVertices { get; }
	public ReadOnlyCollection<int> selectedFaceIndexes { get; }
	public ReadOnlyCollection<int> selectedVertices { get; }
	public ReadOnlyCollection<Edge> selectedEdges { get; }
	internal Face[] selectedFacesInternal { get; set; }
	internal int[] selectedFaceIndicesInternal { get; set; }
	internal Edge[] selectedEdgesInternal { get; set; }
	internal int[] selectedIndexesInternal { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x142590 Offset: 0x142691 VA: 0x142590
	// RVA: 0x1A97580 Offset: 0x1A97681 VA: 0x1A97580
	public bool get_userCollisions() { }

	[CompilerGeneratedAttribute] // RVA: 0x1425A0 Offset: 0x1426A1 VA: 0x1425A0
	// RVA: 0x1A97590 Offset: 0x1A97691 VA: 0x1A97590
	public void set_userCollisions(bool value) { }

	// RVA: 0x1A975A0 Offset: 0x1A976A1 VA: 0x1A975A0
	public UnwrapParameters get_unwrapParameters() { }

	// RVA: 0x1A975B0 Offset: 0x1A976B1 VA: 0x1A975B0
	public void set_unwrapParameters(UnwrapParameters value) { }

	// RVA: 0x1A975C0 Offset: 0x1A976C1 VA: 0x1A975C0
	internal MeshRenderer get_renderer() { }

	// RVA: 0x1A97650 Offset: 0x1A97751 VA: 0x1A97650
	internal MeshFilter get_filter() { }

	// RVA: 0x1A97720 Offset: 0x1A97821 VA: 0x1A97720
	public bool get_preserveMeshAssetOnDestroy() { }

	// RVA: 0x1A97730 Offset: 0x1A97831 VA: 0x1A97730
	public void set_preserveMeshAssetOnDestroy(bool value) { }

	// RVA: 0x1A96170 Offset: 0x1A96271 VA: 0x1A96170
	public bool HasArrays(MeshArrays channels) { }

	// RVA: 0x1A97830 Offset: 0x1A97931 VA: 0x1A97830
	internal Face[] get_facesInternal() { }

	// RVA: 0x1A97840 Offset: 0x1A97941 VA: 0x1A97840
	internal void set_facesInternal(Face[] value) { }

	// RVA: 0x1A97850 Offset: 0x1A97951 VA: 0x1A97850
	public IList<Face> get_faces() { }

	// RVA: 0x1A978C0 Offset: 0x1A979C1 VA: 0x1A978C0
	public void set_faces(IList<Face> value) { }

	// RVA: 0x1A97970 Offset: 0x1A97A71 VA: 0x1A97970
	internal void InvalidateSharedVertexLookup() { }

	// RVA: 0x1A97A20 Offset: 0x1A97B21 VA: 0x1A97A20
	internal void InvalidateSharedTextureLookup() { }

	// RVA: 0x1A97AD0 Offset: 0x1A97BD1 VA: 0x1A97AD0
	internal void InvalidateFaces() { }

	// RVA: 0x1A97DF0 Offset: 0x1A97EF1 VA: 0x1A97DF0
	internal void InvalidateCaches() { }

	// RVA: 0x1A97E30 Offset: 0x1A97F31 VA: 0x1A97E30
	internal SharedVertex[] get_sharedVerticesInternal() { }

	// RVA: 0x1A97E40 Offset: 0x1A97F41 VA: 0x1A97E40
	internal void set_sharedVerticesInternal(SharedVertex[] value) { }

	// RVA: 0x1A97E70 Offset: 0x1A97F71 VA: 0x1A97E70
	public IList<SharedVertex> get_sharedVertices() { }

	// RVA: 0x1A97EE0 Offset: 0x1A97FE1 VA: 0x1A97EE0
	public void set_sharedVertices(IList<SharedVertex> value) { }

	// RVA: 0x1A98200 Offset: 0x1A98301 VA: 0x1A98200
	internal Dictionary<int, int> get_sharedVertexLookup() { }

	// RVA: 0x1A986F0 Offset: 0x1A987F1 VA: 0x1A986F0
	internal void SetSharedVertices(IEnumerable<KeyValuePair<int, int>> indexes) { }

	// RVA: 0x1A98C80 Offset: 0x1A98D81 VA: 0x1A98C80
	internal SharedVertex[] get_sharedTextures() { }

	// RVA: 0x1A98C90 Offset: 0x1A98D91 VA: 0x1A98C90
	internal void set_sharedTextures(SharedVertex[] value) { }

	// RVA: 0x1A98CC0 Offset: 0x1A98DC1 VA: 0x1A98CC0
	internal Dictionary<int, int> get_sharedTextureLookup() { }

	// RVA: 0x1A98D70 Offset: 0x1A98E71 VA: 0x1A98D70
	internal void SetSharedTextures(IEnumerable<KeyValuePair<int, int>> indexes) { }

	// RVA: 0x1A98E20 Offset: 0x1A98F21 VA: 0x1A98E20
	internal Vector3[] get_positionsInternal() { }

	// RVA: 0x1A98E30 Offset: 0x1A98F31 VA: 0x1A98E30
	internal void set_positionsInternal(Vector3[] value) { }

	// RVA: 0x1A98E40 Offset: 0x1A98F41 VA: 0x1A98E40
	public IList<Vector3> get_positions() { }

	// RVA: 0x1A98EB0 Offset: 0x1A98FB1 VA: 0x1A98EB0
	public void set_positions(IList<Vector3> value) { }

	// RVA: 0x1A98F60 Offset: 0x1A99061 VA: 0x1A98F60
	public Vertex[] GetVertices(IList<int> indexes) { }

	// RVA: 0x1A99C50 Offset: 0x1A99D51 VA: 0x1A99C50
	public void SetVertices(IList<Vertex> vertices, bool applyMesh = False) { }

	// RVA: 0x1A9A070 Offset: 0x1A9A171 VA: 0x1A9A070
	public IList<Vector3> get_normals() { }

	// RVA: 0x1A9A100 Offset: 0x1A9A201 VA: 0x1A9A100
	internal Vector3[] get_normalsInternal() { }

	// RVA: 0x1A9A110 Offset: 0x1A9A211 VA: 0x1A9A110
	internal void set_normalsInternal(Vector3[] value) { }

	// RVA: 0x1A963B0 Offset: 0x1A964B1 VA: 0x1A963B0
	public Vector3[] GetNormals() { }

	// RVA: 0x1A9A120 Offset: 0x1A9A221 VA: 0x1A9A120
	internal Color[] get_colorsInternal() { }

	// RVA: 0x1A9A130 Offset: 0x1A9A231 VA: 0x1A9A130
	internal void set_colorsInternal(Color[] value) { }

	// RVA: 0x1A9A140 Offset: 0x1A9A241 VA: 0x1A9A140
	public IList<Color> get_colors() { }

	// RVA: 0x1A9A1D0 Offset: 0x1A9A2D1 VA: 0x1A9A1D0
	public void set_colors(IList<Color> value) { }

	// RVA: 0x1A9A2D0 Offset: 0x1A9A3D1 VA: 0x1A9A2D0
	public Color[] GetColors() { }

	// RVA: 0x1A9A420 Offset: 0x1A9A521 VA: 0x1A9A420
	public IList<Vector4> get_tangents() { }

	// RVA: 0x1A9A4E0 Offset: 0x1A9A5E1 VA: 0x1A9A4E0
	public void set_tangents(IList<Vector4> value) { }

	// RVA: 0x1A9A5E0 Offset: 0x1A9A6E1 VA: 0x1A9A5E0
	internal Vector4[] get_tangentsInternal() { }

	// RVA: 0x1A9A5F0 Offset: 0x1A9A6F1 VA: 0x1A9A5F0
	internal void set_tangentsInternal(Vector4[] value) { }

	// RVA: 0x1A99680 Offset: 0x1A99781 VA: 0x1A99680
	public Vector4[] GetTangents() { }

	// RVA: 0x1A9A600 Offset: 0x1A9A701 VA: 0x1A9A600
	internal Vector2[] get_texturesInternal() { }

	// RVA: 0x1A9A610 Offset: 0x1A9A711 VA: 0x1A9A610
	internal void set_texturesInternal(Vector2[] value) { }

	// RVA: 0x1A9A620 Offset: 0x1A9A721 VA: 0x1A9A620
	public IList<Vector2> get_textures() { }

	// RVA: 0x1A9A6B0 Offset: 0x1A9A7B1 VA: 0x1A9A6B0
	public void set_textures(IList<Vector2> value) { }

	// RVA: 0x1A997E0 Offset: 0x1A998E1 VA: 0x1A997E0
	public void GetUVs(int channel, List<Vector4> uvs) { }

	// RVA: 0x1A9A7A0 Offset: 0x1A9A8A1 VA: 0x1A9A7A0
	internal ReadOnlyCollection<Vector2> GetUVs(int channel) { }

	// RVA: 0x1A9A8A0 Offset: 0x1A9A9A1 VA: 0x1A9A8A0
	public void SetUVs(int channel, List<Vector4> uvs) { }

	// RVA: 0x1A971A0 Offset: 0x1A972A1 VA: 0x1A971A0
	public int get_faceCount() { }

	// RVA: 0x1A96150 Offset: 0x1A96251 VA: 0x1A96150
	public int get_vertexCount() { }

	// RVA: 0x1A9ABB0 Offset: 0x1A9ACB1 VA: 0x1A9ABB0
	public int get_edgeCount() { }

	// RVA: 0x1A9AC50 Offset: 0x1A9AD51 VA: 0x1A9AC50
	public int get_indexCount() { }

	// RVA: 0x1A9AD70 Offset: 0x1A9AE71 VA: 0x1A9AD70
	public int get_triangleCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x1425B0 Offset: 0x1426B1 VA: 0x1425B0
	// RVA: 0x1A9AEB0 Offset: 0x1A9AFB1 VA: 0x1A9AEB0
	public static void add_meshWillBeDestroyed(Action<ProBuilderMesh> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1425C0 Offset: 0x1426C1 VA: 0x1425C0
	// RVA: 0x1A9AFA0 Offset: 0x1A9B0A1 VA: 0x1A9AFA0
	public static void remove_meshWillBeDestroyed(Action<ProBuilderMesh> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1425D0 Offset: 0x1426D1 VA: 0x1425D0
	// RVA: 0x1A9B090 Offset: 0x1A9B191 VA: 0x1A9B090
	internal static void add_componentWillBeDestroyed(Action<ProBuilderMesh> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1425E0 Offset: 0x1426E1 VA: 0x1425E0
	// RVA: 0x1A9B180 Offset: 0x1A9B281 VA: 0x1A9B180
	internal static void remove_componentWillBeDestroyed(Action<ProBuilderMesh> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1425F0 Offset: 0x1426F1 VA: 0x1425F0
	// RVA: 0x1A9B270 Offset: 0x1A9B371 VA: 0x1A9B270
	internal static void add_componentHasBeenReset(Action<ProBuilderMesh> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x142600 Offset: 0x142701 VA: 0x142600
	// RVA: 0x1A9B360 Offset: 0x1A9B461 VA: 0x1A9B360
	internal static void remove_componentHasBeenReset(Action<ProBuilderMesh> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x142610 Offset: 0x142711 VA: 0x142610
	// RVA: 0x1A9B450 Offset: 0x1A9B551 VA: 0x1A9B450
	public static void add_elementSelectionChanged(Action<ProBuilderMesh> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x142620 Offset: 0x142721 VA: 0x142620
	// RVA: 0x1A9B540 Offset: 0x1A9B641 VA: 0x1A9B540
	public static void remove_elementSelectionChanged(Action<ProBuilderMesh> value) { }

	// RVA: 0x1A97740 Offset: 0x1A97841 VA: 0x1A97740
	internal Mesh get_mesh() { }

	// RVA: 0x1A9B630 Offset: 0x1A9B731 VA: 0x1A9B630
	internal void set_mesh(Mesh value) { }

	// RVA: 0x1A9B640 Offset: 0x1A9B741 VA: 0x1A9B640
	internal int get_id() { }

	// RVA: 0x1A9B670 Offset: 0x1A9B771 VA: 0x1A9B670
	public MeshSyncState get_meshSyncState() { }

	// RVA: 0x1A9B7B0 Offset: 0x1A9B8B1 VA: 0x1A9B7B0
	private void Awake() { }

	// RVA: 0x1A9BAF0 Offset: 0x1A9BBF1 VA: 0x1A9BAF0
	private void Reset() { }

	// RVA: 0x1A9BBF0 Offset: 0x1A9BCF1 VA: 0x1A9BBF0
	private void OnDestroy() { }

	// RVA: 0x1A99F00 Offset: 0x1A9A001 VA: 0x1A99F00
	public void Clear() { }

	// RVA: 0x1A9B830 Offset: 0x1A9B931 VA: 0x1A9B830
	internal void EnsureMeshFilterIsAssigned() { }

	// RVA: 0x1A9BEE0 Offset: 0x1A9BFE1 VA: 0x1A9BEE0
	internal static ProBuilderMesh CreateInstanceWithPoints(Vector3[] positions) { }

	// RVA: 0x1A9C430 Offset: 0x1A9C531 VA: 0x1A9C430
	public static ProBuilderMesh Create() { }

	// RVA: 0x1A9C4C0 Offset: 0x1A9C5C1 VA: 0x1A9C4C0
	public static ProBuilderMesh Create(IEnumerable<Vector3> positions, IEnumerable<Face> faces) { }

	// RVA: 0x1A9C6A0 Offset: 0x1A9C7A1 VA: 0x1A9C6A0
	public static ProBuilderMesh Create(IList<Vertex> vertices, IList<Face> faces, IList<SharedVertex> sharedVertices, IList<SharedVertex> sharedTextures, IList<Material> materials) { }

	// RVA: 0x1A9C060 Offset: 0x1A9C161 VA: 0x1A9C060
	private void GeometryWithPoints(Vector3[] points) { }

	// RVA: 0x1A9C580 Offset: 0x1A9C681 VA: 0x1A9C580
	public void RebuildWithPositionsAndFaces(IEnumerable<Vector3> vertices, IEnumerable<Face> faces) { }

	// RVA: 0x1A9BAC0 Offset: 0x1A9BBC1 VA: 0x1A9BAC0
	internal void Rebuild() { }

	// RVA: 0x1A9C900 Offset: 0x1A9CA01 VA: 0x1A9C900
	public void ToMesh(MeshTopology preferredTopology = 0) { }

	// RVA: 0x1A9DEA0 Offset: 0x1A9DFA1 VA: 0x1A9DEA0
	internal void MakeUnique() { }

	// RVA: 0x1A9DF20 Offset: 0x1A9E021 VA: 0x1A9DF20
	public void CopyFrom(ProBuilderMesh other) { }

	// RVA: 0x1A9CC60 Offset: 0x1A9CD61 VA: 0x1A9CC60
	public void Refresh(RefreshMask mask = 31) { }

	// RVA: 0x1A9B9C0 Offset: 0x1A9BAC1 VA: 0x1A9B9C0
	internal void EnsureMeshColliderIsAssigned() { }

	// RVA: 0x1A9EC80 Offset: 0x1A9ED81 VA: 0x1A9EC80
	internal int GetUnusedTextureGroup(int i = 1) { }

	// RVA: 0x1A9ED80 Offset: 0x1A9EE81 VA: 0x1A9ED80
	private static bool IsValidTextureGroup(int group) { }

	// RVA: 0x1A9ED90 Offset: 0x1A9EE91 VA: 0x1A9ED90
	internal int UnusedElementGroup(int i = 1) { }

	// RVA: 0x1A9E4C0 Offset: 0x1A9E5C1 VA: 0x1A9E4C0
	public void RefreshUV(IEnumerable<Face> facesToRefresh) { }

	// RVA: 0x1A9F300 Offset: 0x1A9F401 VA: 0x1A9F300
	internal void SetGroupUV(AutoUnwrapSettings settings, int group) { }

	// RVA: 0x1A9EB40 Offset: 0x1A9EC41 VA: 0x1A9EB40
	private void RefreshColors() { }

	// RVA: 0x1A9F400 Offset: 0x1A9F501 VA: 0x1A9F400
	public void SetFaceColor(Face face, Color color) { }

	// RVA: 0x1A9F740 Offset: 0x1A9F841 VA: 0x1A9F740
	public void SetMaterial(IEnumerable<Face> faces, Material material) { }

	// RVA: 0x1A9EB80 Offset: 0x1A9EC81 VA: 0x1A9EB80
	private void RefreshNormals() { }

	// RVA: 0x1A9EC00 Offset: 0x1A9ED01 VA: 0x1A9EC00
	private void RefreshTangents() { }

	// RVA: 0x1A9FD20 Offset: 0x1A9FE21 VA: 0x1A9FD20
	internal int GetSharedVertexHandle(int vertex) { }

	// RVA: 0x1A9FE60 Offset: 0x1A9FF61 VA: 0x1A9FE60
	internal HashSet<int> GetSharedVertexHandles(IEnumerable<int> vertices) { }

	// RVA: 0x1AA0250 Offset: 0x1AA0351 VA: 0x1AA0250
	public List<int> GetCoincidentVertices(IEnumerable<int> vertices) { }

	// RVA: 0x1AA07F0 Offset: 0x1AA08F1 VA: 0x1AA07F0
	public void GetCoincidentVertices(IEnumerable<Face> faces, List<int> coincident) { }

	// RVA: 0x1AA0E00 Offset: 0x1AA0F01 VA: 0x1AA0E00
	public void GetCoincidentVertices(IEnumerable<Edge> edges, List<int> coincident) { }

	// RVA: 0x1AA0320 Offset: 0x1AA0421 VA: 0x1AA0320
	public void GetCoincidentVertices(IEnumerable<int> vertices, List<int> coincident) { }

	// RVA: 0x1AA1480 Offset: 0x1AA1581 VA: 0x1AA1480
	public void GetCoincidentVertices(int vertex, List<int> coincident) { }

	// RVA: 0x1AA1600 Offset: 0x1AA1701 VA: 0x1AA1600
	public void SetVerticesCoincident(IEnumerable<int> vertices) { }

	// RVA: 0x1AA1970 Offset: 0x1AA1A71 VA: 0x1AA1970
	internal void SetTexturesCoincident(IEnumerable<int> vertices) { }

	// RVA: 0x1AA19C0 Offset: 0x1AA1AC1 VA: 0x1AA19C0
	internal void AddToSharedVertex(int sharedVertexHandle, int vertex) { }

	// RVA: 0x1AA1B50 Offset: 0x1AA1C51 VA: 0x1AA1B50
	internal void AddSharedVertex(SharedVertex vertex) { }

	// RVA: 0x1AA1C10 Offset: 0x1AA1D11 VA: 0x1AA1C10
	public bool get_selectable() { }

	// RVA: 0x1AA1C20 Offset: 0x1AA1D21 VA: 0x1AA1C20
	public void set_selectable(bool value) { }

	// RVA: 0x1AA1C30 Offset: 0x1AA1D31 VA: 0x1AA1C30
	public int get_selectedFaceCount() { }

	// RVA: 0x1AA1C50 Offset: 0x1AA1D51 VA: 0x1AA1C50
	public int get_selectedVertexCount() { }

	// RVA: 0x1AA1C70 Offset: 0x1AA1D71 VA: 0x1AA1C70
	public int get_selectedEdgeCount() { }

	// RVA: 0x1AA1C90 Offset: 0x1AA1D91 VA: 0x1AA1C90
	internal int get_selectedSharedVerticesCount() { }

	// RVA: 0x1AA2230 Offset: 0x1AA2331 VA: 0x1AA2230
	internal int get_selectedCoincidentVertexCount() { }

	// RVA: 0x1AA2260 Offset: 0x1AA2361 VA: 0x1AA2260
	internal IEnumerable<int> get_selectedSharedVertices() { }

	// RVA: 0x1AA2290 Offset: 0x1AA2391 VA: 0x1AA2290
	internal IEnumerable<int> get_selectedCoincidentVertices() { }

	// RVA: 0x1AA1CC0 Offset: 0x1AA1DC1 VA: 0x1AA1CC0
	private void CacheSelection() { }

	// RVA: 0x1AA2370 Offset: 0x1AA2471 VA: 0x1AA2370
	public Face[] GetSelectedFaces() { }

	// RVA: 0x1AA24D0 Offset: 0x1AA25D1 VA: 0x1AA24D0
	public ReadOnlyCollection<int> get_selectedFaceIndexes() { }

	// RVA: 0x1AA2540 Offset: 0x1AA2641 VA: 0x1AA2540
	public ReadOnlyCollection<int> get_selectedVertices() { }

	// RVA: 0x1AA25B0 Offset: 0x1AA26B1 VA: 0x1AA25B0
	public ReadOnlyCollection<Edge> get_selectedEdges() { }

	// RVA: 0x1AA2620 Offset: 0x1AA2721 VA: 0x1AA2620
	internal Face[] get_selectedFacesInternal() { }

	// RVA: 0x1AA2630 Offset: 0x1AA2731 VA: 0x1AA2630
	internal void set_selectedFacesInternal(Face[] value) { }

	// RVA: 0x1AA26F0 Offset: 0x1AA27F1 VA: 0x1AA26F0
	internal int[] get_selectedFaceIndicesInternal() { }

	// RVA: 0x1AA2700 Offset: 0x1AA2801 VA: 0x1AA2700
	internal void set_selectedFaceIndicesInternal(int[] value) { }

	// RVA: 0x1AA2710 Offset: 0x1AA2811 VA: 0x1AA2710
	internal Edge[] get_selectedEdgesInternal() { }

	// RVA: 0x1AA2720 Offset: 0x1AA2821 VA: 0x1AA2720
	internal void set_selectedEdgesInternal(Edge[] value) { }

	// RVA: 0x1AA2730 Offset: 0x1AA2831 VA: 0x1AA2730
	internal int[] get_selectedIndexesInternal() { }

	// RVA: 0x1AA2740 Offset: 0x1AA2841 VA: 0x1AA2740
	internal void set_selectedIndexesInternal(int[] value) { }

	// RVA: 0x1AA2750 Offset: 0x1AA2851 VA: 0x1AA2750
	internal Face GetActiveFace() { }

	// RVA: 0x1AA27C0 Offset: 0x1AA28C1 VA: 0x1AA27C0
	internal Edge GetActiveEdge() { }

	// RVA: 0x1AA2860 Offset: 0x1AA2961 VA: 0x1AA2860
	internal int GetActiveVertex() { }

	// RVA: 0x1AA28A0 Offset: 0x1AA29A1 VA: 0x1AA28A0
	internal void AddToFaceSelection(int index) { }

	// RVA: 0x1AA2B20 Offset: 0x1AA2C21 VA: 0x1AA2B20
	public void SetSelectedFaces(IEnumerable<Face> selected) { }

	// RVA: 0x1AA2920 Offset: 0x1AA2A21 VA: 0x1AA2920
	internal void SetSelectedFaces(IEnumerable<int> selected) { }

	// RVA: 0x1AA2BE0 Offset: 0x1AA2CE1 VA: 0x1AA2BE0
	public void SetSelectedEdges(IEnumerable<Edge> edges) { }

	// RVA: 0x1AA2D30 Offset: 0x1AA2E31 VA: 0x1AA2D30
	public void SetSelectedVertices(IEnumerable<int> vertices) { }

	// RVA: 0x1AA2EB0 Offset: 0x1AA2FB1 VA: 0x1AA2EB0
	internal void RemoveFromFaceSelectionAtIndex(int index) { }

	// RVA: 0x1A9BE30 Offset: 0x1A9BF31 VA: 0x1A9BE30
	public void ClearSelection() { }

	// RVA: 0x1AA2F20 Offset: 0x1AA3021 VA: 0x1AA2F20
	public void .ctor() { }

	// RVA: 0x1AA3040 Offset: 0x1AA3141 VA: 0x1AA3040
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x142630 Offset: 0x142731 VA: 0x142630
	// RVA: 0x1AA30C0 Offset: 0x1AA31C1 VA: 0x1AA30C0
	private int <set_selectedFacesInternal>b__207_0(Face x) { }

	[CompilerGeneratedAttribute] // RVA: 0x142640 Offset: 0x142741 VA: 0x142640
	// RVA: 0x1AA3120 Offset: 0x1AA3221 VA: 0x1AA3120
	private int <SetSelectedFaces>b__221_0(Face x) { }

	[CompilerGeneratedAttribute] // RVA: 0x142650 Offset: 0x142751 VA: 0x142650
	// RVA: 0x1AA3180 Offset: 0x1AA3281 VA: 0x1AA3180
	private IEnumerable<int> <SetSelectedFaces>b__222_0(int x) { }

	[CompilerGeneratedAttribute] // RVA: 0x142660 Offset: 0x142761 VA: 0x142660
	// RVA: 0x1AA3260 Offset: 0x1AA3361 VA: 0x1AA3260
	private IEnumerable<Edge> <SetSelectedFaces>b__222_1(int x) { }
}


[ExecuteAlways] // RVA: 0x140E30 Offset: 0x140F31 VA: 0x140E30
[DefaultExecutionOrder] // RVA: 0x140E30 Offset: 0x140F31 VA: 0x140E30
[AddComponentMenu] // RVA: 0x140E30 Offset: 0x140F31 VA: 0x140E30
[HelpURLAttribute] // RVA: 0x140E30 Offset: 0x140F31 VA: 0x140E30
public class NavMeshSurface : MonoBehaviour // TypeDefIndex: 5919
{
	// Fields
	[SerializeField] // RVA: 0x140FD0 Offset: 0x1410D1 VA: 0x140FD0
	private int m_AgentTypeID; // 0x18
	[SerializeField] // RVA: 0x140FE0 Offset: 0x1410E1 VA: 0x140FE0
	private CollectObjects m_CollectObjects; // 0x1C
	[SerializeField] // RVA: 0x140FF0 Offset: 0x1410F1 VA: 0x140FF0
	private Vector3 m_Size; // 0x20
	[SerializeField] // RVA: 0x141000 Offset: 0x141101 VA: 0x141000
	private Vector3 m_Center; // 0x2C
	[SerializeField] // RVA: 0x141010 Offset: 0x141111 VA: 0x141010
	private LayerMask m_LayerMask; // 0x38
	[SerializeField] // RVA: 0x141020 Offset: 0x141121 VA: 0x141020
	private NavMeshCollectGeometry m_UseGeometry; // 0x3C
	[SerializeField] // RVA: 0x141030 Offset: 0x141131 VA: 0x141030
	private int m_DefaultArea; // 0x40
	[SerializeField] // RVA: 0x141040 Offset: 0x141141 VA: 0x141040
	private bool m_IgnoreNavMeshAgent; // 0x44
	[SerializeField] // RVA: 0x141050 Offset: 0x141151 VA: 0x141050
	private bool m_IgnoreNavMeshObstacle; // 0x45
	[SerializeField] // RVA: 0x141060 Offset: 0x141161 VA: 0x141060
	private bool m_OverrideTileSize; // 0x46
	[SerializeField] // RVA: 0x141070 Offset: 0x141171 VA: 0x141070
	private int m_TileSize; // 0x48
	[SerializeField] // RVA: 0x141080 Offset: 0x141181 VA: 0x141080
	private bool m_OverrideVoxelSize; // 0x4C
	[SerializeField] // RVA: 0x141090 Offset: 0x141191 VA: 0x141090
	private float m_VoxelSize; // 0x50
	[SerializeField] // RVA: 0x1410A0 Offset: 0x1411A1 VA: 0x1410A0
	private bool m_BuildHeightMesh; // 0x54
	[FormerlySerializedAsAttribute] // RVA: 0x1410B0 Offset: 0x1411B1 VA: 0x1410B0
	[SerializeField] // RVA: 0x1410B0 Offset: 0x1411B1 VA: 0x1410B0
	private NavMeshData m_NavMeshData; // 0x58
	private NavMeshDataInstance m_NavMeshDataInstance; // 0x60
	private Vector3 m_LastPosition; // 0x64
	private Quaternion m_LastRotation; // 0x70
	private static readonly List<NavMeshSurface> s_NavMeshSurfaces; // 0x0

	// Properties
	public int agentTypeID { get; set; }
	public CollectObjects collectObjects { get; set; }
	public Vector3 size { get; set; }
	public Vector3 center { get; set; }
	public LayerMask layerMask { get; set; }
	public NavMeshCollectGeometry useGeometry { get; set; }
	public int defaultArea { get; set; }
	public bool ignoreNavMeshAgent { get; set; }
	public bool ignoreNavMeshObstacle { get; set; }
	public bool overrideTileSize { get; set; }
	public int tileSize { get; set; }
	public bool overrideVoxelSize { get; set; }
	public float voxelSize { get; set; }
	public bool buildHeightMesh { get; set; }
	public NavMeshData navMeshData { get; set; }
	public static List<NavMeshSurface> activeSurfaces { get; }

	// Methods

	// RVA: 0x1BA7930 Offset: 0x1BA7A31 VA: 0x1BA7930
	public int get_agentTypeID() { }

	// RVA: 0x1BA7940 Offset: 0x1BA7A41 VA: 0x1BA7940
	public void set_agentTypeID(int value) { }

	// RVA: 0x1BA7950 Offset: 0x1BA7A51 VA: 0x1BA7950
	public CollectObjects get_collectObjects() { }

	// RVA: 0x1BA7960 Offset: 0x1BA7A61 VA: 0x1BA7960
	public void set_collectObjects(CollectObjects value) { }

	// RVA: 0x1BA7970 Offset: 0x1BA7A71 VA: 0x1BA7970
	public Vector3 get_size() { }

	// RVA: 0x1BA7980 Offset: 0x1BA7A81 VA: 0x1BA7980
	public void set_size(Vector3 value) { }

	// RVA: 0x1BA7990 Offset: 0x1BA7A91 VA: 0x1BA7990
	public Vector3 get_center() { }

	// RVA: 0x1BA79A0 Offset: 0x1BA7AA1 VA: 0x1BA79A0
	public void set_center(Vector3 value) { }

	// RVA: 0x1BA79B0 Offset: 0x1BA7AB1 VA: 0x1BA79B0
	public LayerMask get_layerMask() { }

	// RVA: 0x1BA79C0 Offset: 0x1BA7AC1 VA: 0x1BA79C0
	public void set_layerMask(LayerMask value) { }

	// RVA: 0x1BA79D0 Offset: 0x1BA7AD1 VA: 0x1BA79D0
	public NavMeshCollectGeometry get_useGeometry() { }

	// RVA: 0x1BA79E0 Offset: 0x1BA7AE1 VA: 0x1BA79E0
	public void set_useGeometry(NavMeshCollectGeometry value) { }

	// RVA: 0x1BA79F0 Offset: 0x1BA7AF1 VA: 0x1BA79F0
	public int get_defaultArea() { }

	// RVA: 0x1BA7A00 Offset: 0x1BA7B01 VA: 0x1BA7A00
	public void set_defaultArea(int value) { }

	// RVA: 0x1BA7A10 Offset: 0x1BA7B11 VA: 0x1BA7A10
	public bool get_ignoreNavMeshAgent() { }

	// RVA: 0x1BA7A20 Offset: 0x1BA7B21 VA: 0x1BA7A20
	public void set_ignoreNavMeshAgent(bool value) { }

	// RVA: 0x1BA7A30 Offset: 0x1BA7B31 VA: 0x1BA7A30
	public bool get_ignoreNavMeshObstacle() { }

	// RVA: 0x1BA7A40 Offset: 0x1BA7B41 VA: 0x1BA7A40
	public void set_ignoreNavMeshObstacle(bool value) { }

	// RVA: 0x1BA7A50 Offset: 0x1BA7B51 VA: 0x1BA7A50
	public bool get_overrideTileSize() { }

	// RVA: 0x1BA7A60 Offset: 0x1BA7B61 VA: 0x1BA7A60
	public void set_overrideTileSize(bool value) { }

	// RVA: 0x1BA7A70 Offset: 0x1BA7B71 VA: 0x1BA7A70
	public int get_tileSize() { }

	// RVA: 0x1BA7A80 Offset: 0x1BA7B81 VA: 0x1BA7A80
	public void set_tileSize(int value) { }

	// RVA: 0x1BA7A90 Offset: 0x1BA7B91 VA: 0x1BA7A90
	public bool get_overrideVoxelSize() { }

	// RVA: 0x1BA7AA0 Offset: 0x1BA7BA1 VA: 0x1BA7AA0
	public void set_overrideVoxelSize(bool value) { }

	// RVA: 0x1BA7AB0 Offset: 0x1BA7BB1 VA: 0x1BA7AB0
	public float get_voxelSize() { }

	// RVA: 0x1BA7AC0 Offset: 0x1BA7BC1 VA: 0x1BA7AC0
	public void set_voxelSize(float value) { }

	// RVA: 0x1BA7AD0 Offset: 0x1BA7BD1 VA: 0x1BA7AD0
	public bool get_buildHeightMesh() { }

	// RVA: 0x1BA7AE0 Offset: 0x1BA7BE1 VA: 0x1BA7AE0
	public void set_buildHeightMesh(bool value) { }

	// RVA: 0x1BA7AF0 Offset: 0x1BA7BF1 VA: 0x1BA7AF0
	public NavMeshData get_navMeshData() { }

	// RVA: 0x1BA7B00 Offset: 0x1BA7C01 VA: 0x1BA7B00
	public void set_navMeshData(NavMeshData value) { }

	// RVA: 0x1BA7B10 Offset: 0x1BA7C11 VA: 0x1BA7B10
	public static List<NavMeshSurface> get_activeSurfaces() { }

	// RVA: 0x1BA7B80 Offset: 0x1BA7C81 VA: 0x1BA7B80
	private void OnEnable() { }

	// RVA: 0x1BA7F30 Offset: 0x1BA8031 VA: 0x1BA7F30
	private void OnDisable() { }

	// RVA: 0x1BA7DB0 Offset: 0x1BA7EB1 VA: 0x1BA7DB0
	public void AddData() { }

	// RVA: 0x1BA7FC0 Offset: 0x1BA80C1 VA: 0x1BA7FC0
	public void RemoveData() { }

	// RVA: 0x1BA8130 Offset: 0x1BA8231 VA: 0x1BA8130
	public NavMeshBuildSettings GetBuildSettings() { }

	// RVA: 0x1BA82C0 Offset: 0x1BA83C1 VA: 0x1BA82C0
	public void BuildNavMesh() { }

	// RVA: 0x1BA9BB0 Offset: 0x1BA9CB1 VA: 0x1BA9BB0
	public AsyncOperation UpdateNavMesh(NavMeshData data) { }

	// RVA: 0x1BA7BF0 Offset: 0x1BA7CF1 VA: 0x1BA7BF0
	private static void Register(NavMeshSurface surface) { }

	// RVA: 0x1BA7FF0 Offset: 0x1BA80F1 VA: 0x1BA7FF0
	private static void Unregister(NavMeshSurface surface) { }

	// RVA: 0x1BA9D60 Offset: 0x1BA9E61 VA: 0x1BA9D60
	private static void UpdateActive() { }

	// RVA: 0x1BA9EC0 Offset: 0x1BA9FC1 VA: 0x1BA9EC0
	private void AppendModifierVolumes(ref List<NavMeshBuildSource> sources) { }

	// RVA: 0x1BA85A0 Offset: 0x1BA86A1 VA: 0x1BA85A0
	private List<NavMeshBuildSource> CollectSources() { }

	// RVA: 0x1BA9020 Offset: 0x1BA9121 VA: 0x1BA9020
	private static Vector3 Abs(Vector3 v) { }

	// RVA: 0x1BAA6D0 Offset: 0x1BAA7D1 VA: 0x1BAA6D0
	private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds) { }

	// RVA: 0x1BA90D0 Offset: 0x1BA91D1 VA: 0x1BA90D0
	private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources) { }

	// RVA: 0x1BAAA50 Offset: 0x1BAAB51 VA: 0x1BAAA50
	private bool HasTransformChanged() { }

	// RVA: 0x1BA9E70 Offset: 0x1BA9F71 VA: 0x1BA9E70
	private void UpdateDataIfTransformChanged() { }

	// RVA: 0x1BAABC0 Offset: 0x1BAACC1 VA: 0x1BAABC0
	public void .ctor() { }

	// RVA: 0x1BAAD00 Offset: 0x1BAAE01 VA: 0x1BAAD00
	private static void .cctor() { }
}


[ExecuteInEditMode] // RVA: 0x147970 Offset: 0x147A71 VA: 0x147970
[Serializable]
public class FracturedChunk : MonoBehaviour // TypeDefIndex: 9031
{
	// Fields
	public FracturedObject FracturedObjectSource; // 0x18
	public int SplitSubMeshIndex; // 0x20
	public bool DontDeleteAfterBroken; // 0x24
	public bool IsSupportChunk; // 0x25
	public bool IsNonSupportedChunk; // 0x26
	public bool IsDetachedChunk; // 0x27
	public float RelativeVolume; // 0x28
	public float Volume; // 0x2C
	public bool HasConcaveCollider; // 0x30
	public float PreviewDecompositionValue; // 0x34
	public Color RandomMaterialColor; // 0x38
	public bool Visited; // 0x48
	public List<FracturedChunk.AdjacencyInfo> ListAdjacentChunks; // 0x50
	[SerializeField] // RVA: 0x1758A0 Offset: 0x1759A1 VA: 0x1758A0
	private Vector3 m_v3InitialLocalPosition; // 0x58
	[SerializeField] // RVA: 0x1758B0 Offset: 0x1759B1 VA: 0x1758B0
	private Quaternion m_qInitialLocalRotation; // 0x64
	[SerializeField] // RVA: 0x1758C0 Offset: 0x1759C1 VA: 0x1758C0
	private Vector3 m_v3InitialLocalScale; // 0x74
	[SerializeField] // RVA: 0x1758D0 Offset: 0x1759D1 VA: 0x1758D0
	private bool m_bInitialLocalRotScaleInitialized; // 0x80
	private List<FracturedChunk.AdjacencyInfo> ListAdjacentChunksCopy; // 0x88
	private float m_fInvisibleTimer; // 0x90
	private bool m_bNonSupportedChunkStored; // 0x94

	// Methods

	// RVA: 0x1D59420 Offset: 0x1D59521 VA: 0x1D59420
	private void Awake() { }

	// RVA: 0x1D59530 Offset: 0x1D59631 VA: 0x1D59530
	private void Update() { }

	// RVA: 0x1D59670 Offset: 0x1D59771 VA: 0x1D59670
	private void OnCollisionEnter(Collision collision) { }

	// RVA: 0x1D5A180 Offset: 0x1D5A281 VA: 0x1D5A180
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x1D59770 Offset: 0x1D59871 VA: 0x1D59770
	private void HandleCollision(Collider other, Vector3 v3CollisionPos, float relativeSpeed) { }

	// RVA: 0x1D5A300 Offset: 0x1D5A401 VA: 0x1D5A300
	public bool IsDestructibleChunk() { }

	// RVA: 0x1D5AC00 Offset: 0x1D5AD01 VA: 0x1D5AC00
	public void ResetChunk(FracturedObject fracturedObjectSource) { }

	// RVA: 0x1D5ADB0 Offset: 0x1D5AEB1 VA: 0x1D5ADB0
	public void Impact(Vector3 v3Position, float fExplosionForce, float fRadius, bool bAlsoImpactFreeChunks) { }

	// RVA: 0x1D5B8E0 Offset: 0x1D5B9E1 VA: 0x1D5B8E0
	public void OnCreateFromFracturedObject(FracturedObject fracturedComponent, int nSplitSubMeshIndex) { }

	// RVA: 0x1D5B9F0 Offset: 0x1D5BAF1 VA: 0x1D5B9F0
	public void UpdatePreviewDecompositionPosition() { }

	// RVA: 0x1D5BB50 Offset: 0x1D5BC51 VA: 0x1D5BB50
	public void ConnectTo(FracturedChunk chunk, float fArea) { }

	// RVA: 0x1D5BF30 Offset: 0x1D5C031 VA: 0x1D5BF30
	public void DisconnectFrom(FracturedChunk chunk) { }

	// RVA: 0x1D5BCB0 Offset: 0x1D5BDB1 VA: 0x1D5BCB0
	public bool IsConnectedTo(FracturedChunk chunk) { }

	// RVA: 0x1D5A5E0 Offset: 0x1D5A6E1 VA: 0x1D5A5E0
	public void DetachFromObject(bool bCheckStructureIntegrity = True) { }

	// RVA: 0x1D5C120 Offset: 0x1D5C221 VA: 0x1D5C120
	private void RemoveConnectionInfo() { }

	// RVA: 0x1D5A510 Offset: 0x1D5A611 VA: 0x1D5A510
	public List<FracturedChunk> ComputeRandomConnectionBreaks() { }

	// RVA: 0x1D5C880 Offset: 0x1D5C981 VA: 0x1D5C880
	private static void ComputeRandomConnectionBreaksRecursive(FracturedChunk chunk, List<FracturedChunk> listBreaksOut, int nLevel) { }

	// RVA: 0x1D5CBD0 Offset: 0x1D5CCD1 VA: 0x1D5CBD0
	public static FracturedChunk ChunkRaycast(Vector3 v3Pos, Vector3 v3Forward, out RaycastHit hitInfo) { }

	// RVA: 0x1D5CD70 Offset: 0x1D5CE71 VA: 0x1D5CD70
	public void .ctor() { }
}


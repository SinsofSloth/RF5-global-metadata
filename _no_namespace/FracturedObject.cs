[ExecuteInEditMode] // RVA: 0x147980 Offset: 0x147A81 VA: 0x147980
public class FracturedObject : MonoBehaviour // TypeDefIndex: 9034
{
	// Fields
	public bool GUIExpandMain; // 0x18
	public GameObject SourceObject; // 0x20
	public bool GenerateIslands; // 0x28
	public bool GenerateChunkConnectionInfo; // 0x29
	public bool StartStatic; // 0x2A
	public float ChunkConnectionMinArea; // 0x2C
	public float ChunkConnectionStrength; // 0x30
	public float ChunkHorizontalRadiusSupportStrength; // 0x34
	public bool SupportChunksAreIndestructible; // 0x38
	public float ChunkIslandConnectionMaxDistance; // 0x3C
	public float TotalMass; // 0x40
	public PhysicMaterial ChunkPhysicMaterial; // 0x48
	public float MinColliderVolumeForBox; // 0x50
	public float CapPrecisionFix; // 0x54
	public bool InvertCapNormals; // 0x58
	public FracturedObject.ColliderType ChunkColliderType; // 0x5C
	public bool GUIExpandSplits; // 0x60
	public FracturedObject.EFracturePattern FracturePattern; // 0x64
	public bool VoronoiVolumeOptimization; // 0x68
	public bool VoronoiProximityOptimization; // 0x69
	public bool VoronoiMultithreading; // 0x6A
	public int VoronoiCellsXCount; // 0x6C
	public int VoronoiCellsYCount; // 0x70
	public int VoronoiCellsZCount; // 0x74
	public float VoronoiCellsXSizeVariation; // 0x78
	public float VoronoiCellsYSizeVariation; // 0x7C
	public float VoronoiCellsZSizeVariation; // 0x80
	public int GenerateNumChunks; // 0x84
	public bool SplitsWorldSpace; // 0x88
	public bool SplitRegularly; // 0x89
	public float SplitXProbability; // 0x8C
	public float SplitYProbability; // 0x90
	public float SplitZProbability; // 0x94
	public float SplitSizeVariation; // 0x98
	public float SplitXVariation; // 0x9C
	public float SplitYVariation; // 0xA0
	public float SplitZVariation; // 0xA4
	public Material SplitMaterial; // 0xA8
	public float SplitMappingTileU; // 0xB0
	public float SplitMappingTileV; // 0xB4
	public bool GUIExpandEvents; // 0xB8
	public float EventDetachMinMass; // 0xBC
	public float EventDetachMinVelocity; // 0xC0
	public float EventDetachExitForce; // 0xC4
	public float EventDetachUpwardsModifier; // 0xC8
	public AudioClip EventDetachSound; // 0xD0
	public FracturedObject.PrefabInfo[] EventDetachPrefabsArray; // 0xD8
	public string EventDetachCollisionCallMethod; // 0xE0
	public GameObject EventDetachCollisionCallGameObject; // 0xE8
	public float EventDetachedMinLifeTime; // 0xF0
	public float EventDetachedMaxLifeTime; // 0xF4
	public float EventDetachedOffscreenLifeTime; // 0xF8
	public float EventDetachedMinMass; // 0xFC
	public float EventDetachedMinVelocity; // 0x100
	public int EventDetachedMaxSounds; // 0x104
	public AudioClip[] EventDetachedSoundArray; // 0x108
	public int EventDetachedMaxPrefabs; // 0x110
	public FracturedObject.PrefabInfo[] EventDetachedPrefabsArray; // 0x118
	public string EventDetachedCollisionCallMethod; // 0x120
	public GameObject EventDetachedCollisionCallGameObject; // 0x128
	public AudioClip EventExplosionSound; // 0x130
	public int EventExplosionPrefabsInstanceCount; // 0x138
	public FracturedObject.PrefabInfo[] EventExplosionPrefabsArray; // 0x140
	public AudioClip EventImpactSound; // 0x148
	public FracturedObject.PrefabInfo[] EventImpactPrefabsArray; // 0x150
	public string EventDetachedAnyCallMethod; // 0x158
	public GameObject EventDetachedAnyCallGameObject; // 0x160
	public bool GUIExpandSupportPlanes; // 0x168
	public int RandomSeed; // 0x16C
	public float DecomposePreview; // 0x170
	public bool AlwaysComputeColliders; // 0x174
	public bool ShowChunkConnectionLines; // 0x175
	public bool ShowChunkColoredState; // 0x176
	public bool ShowChunkColoredRandomly; // 0x177
	public bool SaveMeshDataToAsset; // 0x178
	public string MeshAssetDataFile; // 0x180
	public bool Verbose; // 0x188
	public bool IntegrateWithConcaveCollider; // 0x189
	public FracturedObject.ECCAlgorithm ConcaveColliderAlgorithm; // 0x18C
	public int ConcaveColliderMaxHulls; // 0x190
	public int ConcaveColliderMaxHullVertices; // 0x194
	public int ConcaveColliderLegacySteps; // 0x198
	[HideInInspector] // RVA: 0x1758E0 Offset: 0x1759E1 VA: 0x1758E0
	public List<SupportPlane> ListSupportPlanes; // 0x1A0
	[HideInInspector] // RVA: 0x1758F0 Offset: 0x1759F1 VA: 0x1758F0
	public List<FracturedChunk> ListFracturedChunks; // 0x1A8
	[HideInInspector] // RVA: 0x175900 Offset: 0x175A01 VA: 0x175900
	public GameObject SingleMeshObject; // 0x1B0
	[HideInInspector] // RVA: 0x175910 Offset: 0x175A11 VA: 0x175910
	public bool IsUsingSingleMeshObjectDraw; // 0x1B8
	[HideInInspector] // RVA: 0x175920 Offset: 0x175A21 VA: 0x175920
	public float DecomposeRadius; // 0x1BC
	public static Color GizmoColorSupport; // 0x0
	public static Color GizmoColorNonSupport; // 0x10
	private bool m_bCheckDetachNonSupportedChunkds; // 0x1C0
	private bool m_bExploded; // 0x1C1
	private bool m_bDetached; // 0x1C2
	private float[] m_afFreeChunkSoundTimers; // 0x1C8
	private float[] m_afFreeChunkPrefabTimers; // 0x1D0
	private Material m_GizmosMaterial; // 0x1D8

	// Properties
	public Material GizmosMaterial { get; set; }

	// Methods

	// RVA: 0x1D5CE10 Offset: 0x1D5CF11 VA: 0x1D5CE10
	public Material get_GizmosMaterial() { }

	// RVA: 0x1D5CEE0 Offset: 0x1D5CFE1 VA: 0x1D5CEE0
	public void set_GizmosMaterial(Material value) { }

	// RVA: 0x1D5CEF0 Offset: 0x1D5CFF1 VA: 0x1D5CEF0
	private void Awake() { }

	// RVA: 0x1D5CF00 Offset: 0x1D5D001 VA: 0x1D5CF00
	private void Start() { }

	// RVA: 0x1D5D360 Offset: 0x1D5D461 VA: 0x1D5D360
	private void Update() { }

	// RVA: 0x1D5DED0 Offset: 0x1D5DFD1 VA: 0x1D5DED0
	private void OnRenderObject() { }

	// RVA: 0x1D5DEE0 Offset: 0x1D5DFE1 VA: 0x1D5DEE0
	public void OnCreateFracturedObject() { }

	// RVA: 0x1D5D140 Offset: 0x1D5D241 VA: 0x1D5D140
	public void SetSingleMeshVisibility(bool bEnabled) { }

	// RVA: 0x1D5DFE0 Offset: 0x1D5E0E1 VA: 0x1D5DFE0
	public bool ResetChunks() { }

	// RVA: 0x1D5B1E0 Offset: 0x1D5B2E1 VA: 0x1D5B1E0
	public List<FracturedChunk> GetDestructibleChunksInRadius(Vector3 v3Position, float fRadius, bool bAlsoIncludeFreeChunks) { }

	// RVA: 0x1D5E220 Offset: 0x1D5E321 VA: 0x1D5E220
	public void Explode(Vector3 v3ExplosionPosition, float fExplosionForce) { }

	// RVA: 0x1D5E790 Offset: 0x1D5E891 VA: 0x1D5E790
	public void Explode(Vector3 v3ExplosionPosition, float fExplosionForce, float fRadius, bool bPlayExplosionSound, bool bInstanceExplosionPrefabs, bool bAlsoExplodeFree, bool bCheckStructureIntegrityAfter) { }

	// RVA: 0x1D5ED90 Offset: 0x1D5EE91 VA: 0x1D5ED90
	public void DeleteChunks() { }

	// RVA: 0x1D5EFB0 Offset: 0x1D5F0B1 VA: 0x1D5EFB0
	public void CollapseChunks() { }

	// RVA: 0x1D5F200 Offset: 0x1D5F301 VA: 0x1D5F200
	public void ExplodeChunks(float fExplosionForce, Vector3 v3ExplosionPosition, float fUpwardsModifier) { }

	// RVA: 0x1D5F4E0 Offset: 0x1D5F5E1 VA: 0x1D5F4E0
	public void ComputeChunksRelativeVolume() { }

	// RVA: 0x1D5FC30 Offset: 0x1D5FD31 VA: 0x1D5FC30
	public void ComputeChunksMass(float fTotalMass) { }

	// RVA: 0x1D5FE50 Offset: 0x1D5FF51 VA: 0x1D5FE50
	public bool HasDetachedChunks() { }

	// RVA: 0x1D5C490 Offset: 0x1D5C591 VA: 0x1D5C490
	public void NotifyChunkDetach(FracturedChunk chunk) { }

	// RVA: 0x1D5A430 Offset: 0x1D5A531 VA: 0x1D5A430
	public void NotifyDetachChunkCollision(FracturedChunk.CollisionInfo collisionInfo) { }

	// RVA: 0x1D5FE60 Offset: 0x1D5FF61 VA: 0x1D5FE60
	public void NotifyDetachChunkCollision(Vector3 v3Position, bool bIsMain) { }

	// RVA: 0x1D5A840 Offset: 0x1D5A941 VA: 0x1D5A840
	public void NotifyFreeChunkCollision(FracturedChunk.CollisionInfo collisionInfo) { }

	// RVA: 0x1D5B6C0 Offset: 0x1D5B7C1 VA: 0x1D5B6C0
	public void NotifyImpact(Vector3 v3Position) { }

	// RVA: 0x1D5C730 Offset: 0x1D5C831 VA: 0x1D5C730
	public void ResetAllChunkVisitedFlags() { }

	// RVA: 0x1D5C710 Offset: 0x1D5C811 VA: 0x1D5C710
	public void CheckDetachNonSupportedChunks(bool bForceImmediate = False) { }

	// RVA: 0x1D60090 Offset: 0x1D60191 VA: 0x1D60090
	public void MarkNonSupportedChunks() { }

	// RVA: 0x1D5D4E0 Offset: 0x1D5D5E1 VA: 0x1D5D4E0
	private void CheckDetachNonSupportedChunksInternal(bool bOnlyMarkThem = False) { }

	// RVA: 0x1D601F0 Offset: 0x1D602F1 VA: 0x1D601F0
	private static bool AreSupportedChunksRecursive(FracturedChunk chunk, List<FracturedChunk> listChunksVisited, List<FracturedChunk> listChunksSupport) { }

	// RVA: 0x1D604D0 Offset: 0x1D605D1 VA: 0x1D604D0
	public void AddSupportPlane() { }

	// RVA: 0x1D605A0 Offset: 0x1D606A1 VA: 0x1D605A0
	public void ComputeSupportPlaneIntersections() { }

	// RVA: 0x1D608A0 Offset: 0x1D609A1 VA: 0x1D608A0
	public void .ctor() { }

	// RVA: 0x1D60AB0 Offset: 0x1D60BB1 VA: 0x1D60AB0
	private static void .cctor() { }
}


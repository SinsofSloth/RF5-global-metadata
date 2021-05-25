[ExecuteInEditMode] // RVA: 0x147920 Offset: 0x147A21 VA: 0x147920
[AddComponentMenu] // RVA: 0x147920 Offset: 0x147A21 VA: 0x147920
public class ConcaveCollider : MonoBehaviour // TypeDefIndex: 9015
{
	// Fields
	public ConcaveCollider.EAlgorithm Algorithm; // 0x18
	public int MaxHullVertices; // 0x1C
	public int MaxHulls; // 0x20
	public float InternalScale; // 0x24
	public float Precision; // 0x28
	public bool CreateMeshAssets; // 0x2C
	public bool CreateHullMesh; // 0x2D
	public bool DebugLog; // 0x2E
	public int LegacyDepth; // 0x30
	public bool ShowAdvancedOptions; // 0x34
	public float MinHullVolume; // 0x38
	public float BackFaceDistanceFactor; // 0x3C
	public bool NormalizeInputMesh; // 0x40
	public bool ForceNoMultithreading; // 0x41
	public PhysicMaterial PhysMaterial; // 0x48
	public bool IsTrigger; // 0x50
	public GameObject[] m_aGoHulls; // 0x58
	[SerializeField] // RVA: 0x175850 Offset: 0x175951 VA: 0x175850
	private PhysicMaterial LastMaterial; // 0x60
	[SerializeField] // RVA: 0x175860 Offset: 0x175961 VA: 0x175860
	private bool LastIsTrigger; // 0x68
	[SerializeField] // RVA: 0x175870 Offset: 0x175971 VA: 0x175870
	private int LargestHullVertices; // 0x6C
	[SerializeField] // RVA: 0x175880 Offset: 0x175981 VA: 0x175880
	private int LargestHullFaces; // 0x70

	// Methods

	// RVA: 0x1FC8710 Offset: 0x1FC8811 VA: 0x1FC8710
	private void OnDestroy() { }

	// RVA: 0x1FC8920 Offset: 0x1FC8A21 VA: 0x1FC8920
	private void Reset() { }

	// RVA: 0x1FC8930 Offset: 0x1FC8A31 VA: 0x1FC8930
	private void Update() { }

	// RVA: 0x1FC8720 Offset: 0x1FC8821 VA: 0x1FC8720
	public void DestroyHulls() { }

	// RVA: 0x1FC8C00 Offset: 0x1FC8D01 VA: 0x1FC8C00
	public void CancelComputation() { }

	// RVA: 0x1FC8CE0 Offset: 0x1FC8DE1 VA: 0x1FC8CE0
	public int GetLargestHullVertices() { }

	// RVA: 0x1FC8CF0 Offset: 0x1FC8DF1 VA: 0x1FC8CF0
	public int GetLargestHullFaces() { }

	// RVA: 0x1FC8D00 Offset: 0x1FC8E01 VA: 0x1FC8D00
	private static extern void DllInit(bool bUseMultithreading) { }

	// RVA: 0x1FC8D80 Offset: 0x1FC8E81 VA: 0x1FC8D80
	private static extern void DllClose() { }

	// RVA: 0x1FC8DF0 Offset: 0x1FC8EF1 VA: 0x1FC8DF0
	private static extern void SetLogFunctionPointer(IntPtr pfnUnity3DLog) { }

	// RVA: 0x1FC8E70 Offset: 0x1FC8F71 VA: 0x1FC8E70
	private static extern void SetProgressFunctionPointer(IntPtr pfnUnity3DProgress) { }

	// RVA: 0x1FC8C70 Offset: 0x1FC8D71 VA: 0x1FC8C70
	private static extern void CancelConvexDecomposition() { }

	// RVA: 0x1FC8EF0 Offset: 0x1FC8FF1 VA: 0x1FC8EF0
	private static extern bool DoConvexDecomposition(ref ConcaveCollider.SConvexDecompositionInfoInOut infoInOut, Vector3[] pfVertices, int[] puIndices) { }

	// RVA: 0x1FC8FA0 Offset: 0x1FC90A1 VA: 0x1FC8FA0
	private static extern bool GetHullInfo(uint uHullIndex, ref ConcaveCollider.SConvexDecompositionHullInfo infoOut) { }

	// RVA: 0x1FC9040 Offset: 0x1FC9141 VA: 0x1FC9040
	private static extern bool FillHullMeshData(uint uHullIndex, ref float pfVolumeOut, int[] pnIndicesOut, Vector3[] pfVerticesOut) { }

	// RVA: 0x1FC9100 Offset: 0x1FC9201 VA: 0x1FC9100
	public void .ctor() { }
}


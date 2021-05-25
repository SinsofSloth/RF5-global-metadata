public class Simplifier : MonoBehaviour // TypeDefIndex: 9210
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x1775A0 Offset: 0x1776A1 VA: 0x1775A0
	private static bool <Cancelled>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x1775B0 Offset: 0x1776B1 VA: 0x1775B0
	private bool <CoroutineEnded>k__BackingField; // 0x18
	private static int m_nCoroutineFrameMiliseconds; // 0x4
	private const float MAX_VERTEX_COLLAPSE_COST = 10000000;
	private List<Simplifier.Vertex> m_listVertices; // 0x20
	private List<Simplifier.Vertex> m_listHeap; // 0x28
	private Simplifier.TriangleList[] m_aListTriangles; // 0x30
	[SerializeField] // RVA: 0x1775C0 Offset: 0x1776C1 VA: 0x1775C0
	[HideInInspector] // RVA: 0x1775C0 Offset: 0x1776C1 VA: 0x1775C0
	private int m_nOriginalMeshVertexCount; // 0x38
	[SerializeField] // RVA: 0x177600 Offset: 0x177701 VA: 0x177600
	[HideInInspector] // RVA: 0x177600 Offset: 0x177701 VA: 0x177600
	private float m_fOriginalMeshSize; // 0x3C
	[SerializeField] // RVA: 0x177640 Offset: 0x177741 VA: 0x177640
	[HideInInspector] // RVA: 0x177640 Offset: 0x177741 VA: 0x177640
	private List<int> m_listVertexMap; // 0x40
	[SerializeField] // RVA: 0x177680 Offset: 0x177781 VA: 0x177680
	[HideInInspector] // RVA: 0x177680 Offset: 0x177781 VA: 0x177680
	private List<int> m_listVertexPermutationBack; // 0x48
	[SerializeField] // RVA: 0x1776C0 Offset: 0x1777C1 VA: 0x1776C0
	[HideInInspector] // RVA: 0x1776C0 Offset: 0x1777C1 VA: 0x1776C0
	private MeshUniqueVertices m_meshUniqueVertices; // 0x50
	[SerializeField] // RVA: 0x177700 Offset: 0x177801 VA: 0x177700
	[HideInInspector] // RVA: 0x177700 Offset: 0x177801 VA: 0x177700
	private Mesh m_meshOriginal; // 0x58
	[SerializeField] // RVA: 0x177740 Offset: 0x177841 VA: 0x177740
	[HideInInspector] // RVA: 0x177740 Offset: 0x177841 VA: 0x177740
	private bool m_bUseEdgeLength; // 0x60
	[SerializeField] // RVA: 0x177780 Offset: 0x177881 VA: 0x177780
	[HideInInspector] // RVA: 0x177780 Offset: 0x177881 VA: 0x177780
	private bool m_bUseCurvature; // 0x61
	[SerializeField] // RVA: 0x1777C0 Offset: 0x1778C1 VA: 0x1777C0
	[HideInInspector] // RVA: 0x1777C0 Offset: 0x1778C1 VA: 0x1777C0
	private bool m_bProtectTexture; // 0x62
	[SerializeField] // RVA: 0x177800 Offset: 0x177901 VA: 0x177800
	[HideInInspector] // RVA: 0x177800 Offset: 0x177901 VA: 0x177800
	private bool m_bLockBorder; // 0x63

	// Properties
	public static bool Cancelled { get; set; }
	public static int CoroutineFrameMiliseconds { get; set; }
	public bool CoroutineEnded { get; set; }
	public bool UseEdgeLength { get; set; }
	public bool UseCurvature { get; set; }
	public bool ProtectTexture { get; set; }
	public bool LockBorder { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A98F0 Offset: 0x1A99F1 VA: 0x1A98F0
	// RVA: 0x1F577E0 Offset: 0x1F578E1 VA: 0x1F577E0
	public static bool get_Cancelled() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9900 Offset: 0x1A9A01 VA: 0x1A9900
	// RVA: 0x1F57850 Offset: 0x1F57951 VA: 0x1F57850
	public static void set_Cancelled(bool value) { }

	// RVA: 0x1F578C0 Offset: 0x1F579C1 VA: 0x1F578C0
	public static int get_CoroutineFrameMiliseconds() { }

	// RVA: 0x1F57930 Offset: 0x1F57A31 VA: 0x1F57930
	public static void set_CoroutineFrameMiliseconds(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9910 Offset: 0x1A9A11 VA: 0x1A9910
	// RVA: 0x1F579A0 Offset: 0x1F57AA1 VA: 0x1F579A0
	public bool get_CoroutineEnded() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9920 Offset: 0x1A9A21 VA: 0x1A9920
	// RVA: 0x1F579B0 Offset: 0x1F57AB1 VA: 0x1F579B0
	public void set_CoroutineEnded(bool value) { }

	// RVA: 0x1F579C0 Offset: 0x1F57AC1 VA: 0x1F579C0
	public bool get_UseEdgeLength() { }

	// RVA: 0x1F579D0 Offset: 0x1F57AD1 VA: 0x1F579D0
	public void set_UseEdgeLength(bool value) { }

	// RVA: 0x1F579E0 Offset: 0x1F57AE1 VA: 0x1F579E0
	public bool get_UseCurvature() { }

	// RVA: 0x1F579F0 Offset: 0x1F57AF1 VA: 0x1F579F0
	public void set_UseCurvature(bool value) { }

	// RVA: 0x1F57A00 Offset: 0x1F57B01 VA: 0x1F57A00
	public bool get_ProtectTexture() { }

	// RVA: 0x1F57A10 Offset: 0x1F57B11 VA: 0x1F57A10
	public void set_ProtectTexture(bool value) { }

	// RVA: 0x1F57A20 Offset: 0x1F57B21 VA: 0x1F57A20
	public bool get_LockBorder() { }

	// RVA: 0x1F57A30 Offset: 0x1F57B31 VA: 0x1F57A30
	public void set_LockBorder(bool value) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A9930 Offset: 0x1A9A31 VA: 0x1A9930
	// RVA: 0x1F57A40 Offset: 0x1F57B41 VA: 0x1F57A40
	public IEnumerator ProgressiveMesh(GameObject gameObject, Mesh sourceMesh, RelevanceSphere[] aRelevanceSpheres, string strProgressDisplayObjectName = "", Simplifier.ProgressDelegate progress) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A99A0 Offset: 0x1A9AA1 VA: 0x1A99A0
	// RVA: 0x1F57B70 Offset: 0x1F57C71 VA: 0x1F57B70
	public IEnumerator ComputeMeshWithVertexCount(GameObject gameObject, Mesh meshOut, int nVertices, string strProgressDisplayObjectName = "", Simplifier.ProgressDelegate progress) { }

	// RVA: 0x1F57C90 Offset: 0x1F57D91 VA: 0x1F57C90
	public int GetOriginalMeshUniqueVertexCount() { }

	// RVA: 0x1F57CA0 Offset: 0x1F57DA1 VA: 0x1F57CA0
	public int GetOriginalMeshTriangleCount() { }

	// RVA: 0x1F57CF0 Offset: 0x1F57DF1 VA: 0x1F57CF0
	public static Vector3[] GetWorldVertices(GameObject gameObject) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A9A10 Offset: 0x1A9B11 VA: 0x1A9A10
	// RVA: 0x1F58680 Offset: 0x1F58781 VA: 0x1F58680
	private IEnumerator ConsolidateMesh(GameObject gameObject, Mesh meshIn, Mesh meshOut, Simplifier.TriangleList[] aListTriangles, Vector3[] av3Vertices, string strProgressDisplayObjectName = "", Simplifier.ProgressDelegate progress) { }

	// RVA: 0x1F587B0 Offset: 0x1F588B1 VA: 0x1F587B0
	private int MapVertex(int nVertex, int nMax) { }

	// RVA: 0x1F58860 Offset: 0x1F58961 VA: 0x1F58860
	private float ComputeEdgeCollapseCost(Simplifier.Vertex u, Simplifier.Vertex v, float fRelevanceBias) { }

	// RVA: 0x1F59060 Offset: 0x1F59161 VA: 0x1F59060
	private void ComputeEdgeCostAtVertex(Simplifier.Vertex v, Transform transform, RelevanceSphere[] aRelevanceSpheres) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A9A80 Offset: 0x1A9B81 VA: 0x1A9A80
	// RVA: 0x1F593D0 Offset: 0x1F594D1 VA: 0x1F593D0
	private IEnumerator ComputeAllEdgeCollapseCosts(string strProgressDisplayObjectName, Transform transform, RelevanceSphere[] aRelevanceSpheres, Simplifier.ProgressDelegate progress) { }

	// RVA: 0x1F594E0 Offset: 0x1F595E1 VA: 0x1F594E0
	private void Collapse(Simplifier.Vertex u, Simplifier.Vertex v, bool bRecompute, Transform transform, RelevanceSphere[] aRelevanceSpheres) { }

	// RVA: 0x1F5A690 Offset: 0x1F5A791 VA: 0x1F5A690
	private void AddVertices(List<Vector3> listVertices, List<Vector3> listVerticesWorld, List<MeshUniqueVertices.SerializableBoneWeight> listBoneWeights) { }

	// RVA: 0x1F5AA40 Offset: 0x1F5AB41 VA: 0x1F5AA40
	private void AddFaceListSubMesh(int nSubMesh, List<int> listTriangles, int[] anIndices, Vector2[] v2Mapping) { }

	// RVA: 0x1F5B160 Offset: 0x1F5B261 VA: 0x1F5B160
	private void ShareUV(Vector2[] aMapping, Simplifier.Triangle t) { }

	// RVA: 0x1F5B370 Offset: 0x1F5B471 VA: 0x1F5B370
	private Simplifier.Vertex MinimumCostEdge() { }

	// RVA: 0x1F5B420 Offset: 0x1F5B521 VA: 0x1F5B420
	private float HeapValue(int i) { }

	// RVA: 0x1F5A2C0 Offset: 0x1F5A3C1 VA: 0x1F5A2C0
	private void HeapSortUp(int k) { }

	// RVA: 0x1F5A490 Offset: 0x1F5A591 VA: 0x1F5A490
	private void HeapSortDown(int k) { }

	// RVA: 0x1F5B4F0 Offset: 0x1F5B5F1 VA: 0x1F5B4F0
	private void HeapAdd(Simplifier.Vertex v) { }

	// RVA: 0x1F5B380 Offset: 0x1F5B481 VA: 0x1F5B380
	private Simplifier.Vertex HeapPop() { }

	// RVA: 0x1F5B570 Offset: 0x1F5B671 VA: 0x1F5B570
	public void .ctor() { }

	// RVA: 0x1F5B590 Offset: 0x1F5B691 VA: 0x1F5B590
	private static void .cctor() { }
}


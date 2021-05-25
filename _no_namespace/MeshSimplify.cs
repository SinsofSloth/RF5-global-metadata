public class MeshSimplify : MonoBehaviour // TypeDefIndex: 9047
{
	// Fields
	[HideInInspector] // RVA: 0x175940 Offset: 0x175A41 VA: 0x175940
	public Mesh m_originalMesh; // 0x18
	[HideInInspector] // RVA: 0x175950 Offset: 0x175A51 VA: 0x175950
	public Mesh m_simplifiedMesh; // 0x20
	[HideInInspector] // RVA: 0x175960 Offset: 0x175A61 VA: 0x175960
	public bool m_bEnablePrefabUsage; // 0x28
	[HideInInspector] // RVA: 0x175970 Offset: 0x175A71 VA: 0x175970
	public float m_fVertexAmount; // 0x2C
	[HideInInspector] // RVA: 0x175980 Offset: 0x175A81 VA: 0x175980
	public string m_strAssetPath; // 0x30
	[HideInInspector] // RVA: 0x175990 Offset: 0x175A91 VA: 0x175990
	public MeshSimplify m_meshSimplifyRoot; // 0x38
	[HideInInspector] // RVA: 0x1759A0 Offset: 0x175AA1 VA: 0x1759A0
	public List<MeshSimplify> m_listDependentChildren; // 0x40
	[HideInInspector] // RVA: 0x1759B0 Offset: 0x175AB1 VA: 0x1759B0
	public bool m_bExpandRelevanceSpheres; // 0x48
	public RelevanceSphere[] m_aRelevanceSpheres; // 0x50
	[SerializeField] // RVA: 0x1759C0 Offset: 0x175AC1 VA: 0x1759C0
	[HideInInspector] // RVA: 0x1759C0 Offset: 0x175AC1 VA: 0x1759C0
	private Simplifier m_meshSimplifier; // 0x58
	[SerializeField] // RVA: 0x175A00 Offset: 0x175B01 VA: 0x175A00
	[HideInInspector] // RVA: 0x175A00 Offset: 0x175B01 VA: 0x175A00
	private bool m_bGenerateIncludeChildren; // 0x60
	[SerializeField] // RVA: 0x175A40 Offset: 0x175B41 VA: 0x175A40
	[HideInInspector] // RVA: 0x175A40 Offset: 0x175B41 VA: 0x175A40
	private bool m_bOverrideRootSettings; // 0x61
	[SerializeField] // RVA: 0x175A80 Offset: 0x175B81 VA: 0x175A80
	[HideInInspector] // RVA: 0x175A80 Offset: 0x175B81 VA: 0x175A80
	private bool m_bUseEdgeLength; // 0x62
	[SerializeField] // RVA: 0x175AC0 Offset: 0x175BC1 VA: 0x175AC0
	[HideInInspector] // RVA: 0x175AC0 Offset: 0x175BC1 VA: 0x175AC0
	private bool m_bUseCurvature; // 0x63
	[SerializeField] // RVA: 0x175B00 Offset: 0x175C01 VA: 0x175B00
	[HideInInspector] // RVA: 0x175B00 Offset: 0x175C01 VA: 0x175B00
	private bool m_bProtectTexture; // 0x64
	[SerializeField] // RVA: 0x175B40 Offset: 0x175C41 VA: 0x175B40
	[HideInInspector] // RVA: 0x175B40 Offset: 0x175C41 VA: 0x175B40
	private bool m_bLockBorder; // 0x65
	[SerializeField] // RVA: 0x175B80 Offset: 0x175C81 VA: 0x175B80
	[HideInInspector] // RVA: 0x175B80 Offset: 0x175C81 VA: 0x175B80
	private bool m_bDataDirty; // 0x66
	[SerializeField] // RVA: 0x175BC0 Offset: 0x175CC1 VA: 0x175BC0
	[HideInInspector] // RVA: 0x175BC0 Offset: 0x175CC1 VA: 0x175BC0
	private bool m_bExcludedFromTree; // 0x67

	// Properties
	public bool RecurseIntoChildren { get; }
	public Simplifier MeshSimplifier { get; set; }

	// Methods

	// RVA: 0x242C690 Offset: 0x242C791 VA: 0x242C690
	public bool get_RecurseIntoChildren() { }

	// RVA: 0x242C6A0 Offset: 0x242C7A1 VA: 0x242C6A0
	public Simplifier get_MeshSimplifier() { }

	// RVA: 0x242C6B0 Offset: 0x242C7B1 VA: 0x242C6B0
	public void set_MeshSimplifier(Simplifier value) { }

	// RVA: 0x242C6C0 Offset: 0x242C7C1 VA: 0x242C6C0
	public static bool HasValidMeshData(GameObject go) { }

	// RVA: 0x242C7B0 Offset: 0x242C8B1 VA: 0x242C7B0
	public static bool IsRootOrBelongsToTree(MeshSimplify meshSimplify, MeshSimplify root) { }

	// RVA: 0x242C950 Offset: 0x242CA51 VA: 0x242C950
	public bool IsGenerateIncludeChildrenActive() { }

	// RVA: 0x242C960 Offset: 0x242CA61 VA: 0x242C960
	public bool HasDependentChildren() { }

	// RVA: 0x242C9D0 Offset: 0x242CAD1 VA: 0x242C9D0
	public bool HasDataDirty() { }

	// RVA: 0x242C9E0 Offset: 0x242CAE1 VA: 0x242C9E0
	public bool SetDataDirty(bool bDirty) { }

	// RVA: 0x242C9F0 Offset: 0x242CAF1 VA: 0x242C9F0
	public bool HasNonMeshSimplifyGameObjectsInTree() { }

	// RVA: 0x242CA20 Offset: 0x242CB21 VA: 0x242CA20
	private bool HasNonMeshSimplifyGameObjectsInTreeRecursive(MeshSimplify root, GameObject gameObject) { }

	// RVA: 0x242CB70 Offset: 0x242CC71 VA: 0x242CB70
	public void ConfigureSimplifier() { }

	// RVA: 0x242CD20 Offset: 0x242CE21 VA: 0x242CD20
	public Simplifier GetMeshSimplifier() { }

	// RVA: 0x242CD30 Offset: 0x242CE31 VA: 0x242CD30
	public void ComputeData(bool bRecurseIntoChildren, Simplifier.ProgressDelegate progress) { }

	// RVA: 0x242CD80 Offset: 0x242CE81 VA: 0x242CD80
	private static void ComputeDataRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren, Simplifier.ProgressDelegate progress) { }

	// RVA: 0x242D750 Offset: 0x242D851 VA: 0x242D750
	public bool HasData() { }

	// RVA: 0x242D840 Offset: 0x242D941 VA: 0x242D840
	public bool HasSimplifiedMesh() { }

	// RVA: 0x242D8F0 Offset: 0x242D9F1 VA: 0x242D8F0
	public void ComputeMesh(bool bRecurseIntoChildren, Simplifier.ProgressDelegate progress) { }

	// RVA: 0x242D940 Offset: 0x242DA41 VA: 0x242D940
	private static void ComputeMeshRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren, Simplifier.ProgressDelegate progress) { }

	// RVA: 0x242DF10 Offset: 0x242E011 VA: 0x242DF10
	public void AssignSimplifiedMesh(bool bRecurseIntoChildren) { }

	// RVA: 0x242DF50 Offset: 0x242E051 VA: 0x242DF50
	private static void AssignSimplifiedMeshRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren) { }

	// RVA: 0x242E170 Offset: 0x242E271 VA: 0x242E170
	public void RestoreOriginalMesh(bool bDeleteData, bool bRecurseIntoChildren) { }

	// RVA: 0x242E1C0 Offset: 0x242E2C1 VA: 0x242E1C0
	private static void RestoreOriginalMeshRecursive(MeshSimplify root, GameObject gameObject, bool bDeleteData, bool bRecurseIntoChildren) { }

	// RVA: 0x242E430 Offset: 0x242E531 VA: 0x242E430
	public bool HasOriginalMeshActive(bool bRecurseIntoChildren) { }

	// RVA: 0x242E470 Offset: 0x242E571 VA: 0x242E470
	private static bool HasOriginalMeshActiveRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren) { }

	// RVA: 0x242E6E0 Offset: 0x242E7E1 VA: 0x242E6E0
	public bool HasVertexData(bool bRecurseIntoChildren) { }

	// RVA: 0x242E720 Offset: 0x242E821 VA: 0x242E720
	private static bool HasVertexDataRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren) { }

	// RVA: 0x242E8D0 Offset: 0x242E9D1 VA: 0x242E8D0
	public int GetOriginalVertexCount(bool bRecurseIntoChildren) { }

	// RVA: 0x242E920 Offset: 0x242EA21 VA: 0x242E920
	private static void GetOriginalVertexCountRecursive(MeshSimplify root, GameObject gameObject, ref int nVertexCount, bool bRecurseIntoChildren) { }

	// RVA: 0x242EAB0 Offset: 0x242EBB1 VA: 0x242EAB0
	public int GetOriginalTriangleCount(bool bRecurseIntoChildren) { }

	// RVA: 0x242EB00 Offset: 0x242EC01 VA: 0x242EB00
	private static void GetOriginalTriangleCountRecursive(MeshSimplify root, GameObject gameObject, ref int nTriangleCount, bool bRecurseIntoChildren) { }

	// RVA: 0x242ECB0 Offset: 0x242EDB1 VA: 0x242ECB0
	public int GetSimplifiedVertexCount(bool bRecurseIntoChildren) { }

	// RVA: 0x242ED00 Offset: 0x242EE01 VA: 0x242ED00
	private static void GetSimplifiedVertexCountRecursive(MeshSimplify root, GameObject gameObject, ref int nVertexCount, bool bRecurseIntoChildren) { }

	// RVA: 0x242EE90 Offset: 0x242EF91 VA: 0x242EE90
	public int GetSimplifiedTriangleCount(bool bRecurseIntoChildren) { }

	// RVA: 0x242EEE0 Offset: 0x242EFE1 VA: 0x242EEE0
	private static void GetSimplifiedTriangleCountRecursive(MeshSimplify root, GameObject gameObject, ref int nTriangleCount, bool bRecurseIntoChildren) { }

	// RVA: 0x242F090 Offset: 0x242F191 VA: 0x242F090
	public void RemoveFromTree() { }

	// RVA: 0x242D710 Offset: 0x242D811 VA: 0x242D710
	public void FreeData(bool bRecurseIntoChildren) { }

	// RVA: 0x242F160 Offset: 0x242F261 VA: 0x242F160
	private static void FreeDataRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren) { }

	// RVA: 0x242DE20 Offset: 0x242DF21 VA: 0x242DE20
	private static Mesh CreateNewEmptyMesh(MeshSimplify meshSimplify) { }

	// RVA: 0x242F3E0 Offset: 0x242F4E1 VA: 0x242F3E0
	public void .ctor() { }
}


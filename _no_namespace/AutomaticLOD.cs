public class AutomaticLOD : MonoBehaviour // TypeDefIndex: 9009
{
	// Fields
	[HideInInspector] // RVA: 0x1756B0 Offset: 0x1757B1 VA: 0x1756B0
	public Mesh m_originalMesh; // 0x18
	[HideInInspector] // RVA: 0x1756C0 Offset: 0x1757C1 VA: 0x1756C0
	public AutomaticLOD.EvalMode m_evalMode; // 0x20
	[HideInInspector] // RVA: 0x1756D0 Offset: 0x1757D1 VA: 0x1756D0
	public bool m_bEnablePrefabUsage; // 0x24
	[HideInInspector] // RVA: 0x1756E0 Offset: 0x1757E1 VA: 0x1756E0
	public string m_strAssetPath; // 0x28
	[HideInInspector] // RVA: 0x1756F0 Offset: 0x1757F1 VA: 0x1756F0
	public float m_fMaxCameraDistance; // 0x30
	[HideInInspector] // RVA: 0x175700 Offset: 0x175801 VA: 0x175700
	public int m_nColorEditorBarNewIndex; // 0x34
	[HideInInspector] // RVA: 0x175710 Offset: 0x175811 VA: 0x175710
	public List<AutomaticLOD.LODLevelData> m_listLODLevels; // 0x38
	[HideInInspector] // RVA: 0x175720 Offset: 0x175821 VA: 0x175720
	public AutomaticLOD m_LODObjectRoot; // 0x40
	[HideInInspector] // RVA: 0x175730 Offset: 0x175831 VA: 0x175730
	public List<AutomaticLOD> m_listDependentChildren; // 0x48
	public bool m_bExpandRelevanceSpheres; // 0x50
	public RelevanceSphere[] m_aRelevanceSpheres; // 0x58
	[SerializeField] // RVA: 0x175740 Offset: 0x175841 VA: 0x175740
	private Simplifier m_meshSimplifier; // 0x60
	[SerializeField] // RVA: 0x175750 Offset: 0x175851 VA: 0x175750
	private bool m_bGenerateIncludeChildren; // 0x68
	[SerializeField] // RVA: 0x175760 Offset: 0x175861 VA: 0x175760
	private AutomaticLOD.LevelsToGenerate m_levelsToGenerate; // 0x6C
	[SerializeField] // RVA: 0x175770 Offset: 0x175871 VA: 0x175770
	private AutomaticLOD.SwitchMode m_switchMode; // 0x70
	[SerializeField] // RVA: 0x175780 Offset: 0x175881 VA: 0x175780
	private bool m_bOverrideRootSettings; // 0x74
	[SerializeField] // RVA: 0x175790 Offset: 0x175891 VA: 0x175790
	[HideInInspector] // RVA: 0x175790 Offset: 0x175891 VA: 0x175790
	private bool m_bLODDataDirty; // 0x75
	[SerializeField] // RVA: 0x1757D0 Offset: 0x1758D1 VA: 0x1757D0
	[HideInInspector] // RVA: 0x1757D0 Offset: 0x1758D1 VA: 0x1757D0
	private AutomaticLOD m_LODObjectRootPersist; // 0x78
	[SerializeField] // RVA: 0x175810 Offset: 0x175911 VA: 0x175810
	[HideInInspector] // RVA: 0x175810 Offset: 0x175911 VA: 0x175810
	private LODGroup m_LODGroup; // 0x80
	private bool m_bUseAutomaticCameraLODSwitch; // 0x88
	private const int k_MaxLODChecksPerFrame = 4;
	private const int k_MaxFrameCheckLoop = 100;
	private static int s_currentCheckIndex; // 0x0
	private static int s_currentFrameCheckIndex; // 0x4
	private static int s_checkLoopLength; // 0x8
	private static int s_lastFrameComputedModulus; // 0xC
	private static int s_currentFrameInLoop; // 0x10
	private static Camera s_userDefinedCamera; // 0x18
	private Camera m_renderCamera; // 0x90
	private int m_nCurrentLOD; // 0x98
	private Dictionary<Camera, int> m_cachedFrameLODLevel; // 0xA0
	private Vector3 m_localCenter; // 0xA8
	private Vector3[] _corners; // 0xB8
	private int m_frameToCheck; // 0xC0
	private bool b_performCheck; // 0xC4

	// Properties
	public static Camera UserDefinedLODCamera { get; set; }
	public AutomaticLOD.SwitchMode LODSwitchMode { get; }

	// Methods

	// RVA: 0x214B2B0 Offset: 0x214B3B1 VA: 0x214B2B0
	public static Camera get_UserDefinedLODCamera() { }

	// RVA: 0x214B320 Offset: 0x214B421 VA: 0x214B320
	public static void set_UserDefinedLODCamera(Camera value) { }

	// RVA: 0x214B390 Offset: 0x214B491 VA: 0x214B390
	public AutomaticLOD.SwitchMode get_LODSwitchMode() { }

	// RVA: 0x214B460 Offset: 0x214B561 VA: 0x214B460
	private void Awake() { }

	// RVA: 0x214BC80 Offset: 0x214BD81 VA: 0x214BC80
	private void Update() { }

	// RVA: 0x214C5C0 Offset: 0x214C6C1 VA: 0x214C5C0
	private void OnWillRenderObject() { }

	// RVA: 0x214C5F0 Offset: 0x214C6F1 VA: 0x214C5F0
	public static bool HasValidMeshData(GameObject go) { }

	// RVA: 0x214C6E0 Offset: 0x214C7E1 VA: 0x214C6E0
	public static bool IsRootOrBelongsToLODTree(AutomaticLOD automaticLOD, AutomaticLOD root) { }

	// RVA: 0x214C880 Offset: 0x214C981 VA: 0x214C880
	public int GetNumberOfLevelsToGenerate() { }

	// RVA: 0x214C890 Offset: 0x214C991 VA: 0x214C890
	public bool IsGenerateIncludeChildrenActive() { }

	// RVA: 0x214C8A0 Offset: 0x214C9A1 VA: 0x214C8A0
	public bool IsRootAutomaticLOD() { }

	// RVA: 0x214C910 Offset: 0x214CA11 VA: 0x214C910
	public bool HasDependentChildren() { }

	// RVA: 0x214C980 Offset: 0x214CA81 VA: 0x214C980
	public bool HasLODDataDirty() { }

	// RVA: 0x214C990 Offset: 0x214CA91 VA: 0x214C990
	public bool SetLODDataDirty(bool bDirty) { }

	// RVA: 0x214C9A0 Offset: 0x214CAA1 VA: 0x214C9A0
	public int GetLODLevelCount() { }

	// RVA: 0x214CA00 Offset: 0x214CB01 VA: 0x214CA00
	public float ComputeScreenCoverage(Camera camera) { }

	// RVA: 0x214B770 Offset: 0x214B871 VA: 0x214B770
	public Vector3 ComputeWorldCenter() { }

	// RVA: 0x214D470 Offset: 0x214D571 VA: 0x214D470
	public float ComputeViewSpaceBounds(Vector3 v3CameraPos, Vector3 v3CameraDir, Vector3 v3CameraUp, out Vector3 v3Min, out Vector3 v3Max, out Vector3 v3Center) { }

	// RVA: 0x214DBC0 Offset: 0x214DCC1 VA: 0x214DBC0
	public void SetAutomaticCameraLODSwitch(bool bEnabled) { }

	// RVA: 0x214DC50 Offset: 0x214DD51 VA: 0x214DC50
	private static void SetAutomaticCameraLODSwitchRecursive(AutomaticLOD root, GameObject gameObject, bool bEnabled) { }

	// RVA: 0x214DDE0 Offset: 0x214DEE1 VA: 0x214DDE0
	public void SetLODLevels(List<AutomaticLOD.LODLevelData> listLODLevelData, AutomaticLOD.EvalMode evalMode, float fMaxCameraDistance, bool bRecurseIntoChildren) { }

	// RVA: 0x214DF60 Offset: 0x214E061 VA: 0x214DF60
	private static void SetLODLevelsRecursive(AutomaticLOD root, GameObject gameObject) { }

	// RVA: 0x214E900 Offset: 0x214EA01 VA: 0x214E900
	public void AddLODLevel(int nLevel, bool bBefore, bool bCreateMesh, bool bRecurseIntoChildren) { }

	// RVA: 0x214E9B0 Offset: 0x214EAB1 VA: 0x214E9B0
	public static void AddLODLevelRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, bool bBefore, bool bCreateMesh, bool bRecurseIntoChildren) { }

	// RVA: 0x214F560 Offset: 0x214F661 VA: 0x214F560
	public void RemoveLODLevel(int nLevel, bool bDeleteMesh, bool bRecurseIntoChildren) { }

	// RVA: 0x214F600 Offset: 0x214F701 VA: 0x214F600
	public static void RemoveLODLevelRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, bool bDeleteMesh, bool bRecurseIntoChildren) { }

	// RVA: 0x214FB20 Offset: 0x214FC21 VA: 0x214FB20
	public Simplifier GetMeshSimplifier() { }

	// RVA: 0x214FB30 Offset: 0x214FC31 VA: 0x214FB30
	public void ComputeLODData(bool bRecurseIntoChildren, Simplifier.ProgressDelegate progress) { }

	// RVA: 0x214FB80 Offset: 0x214FC81 VA: 0x214FB80
	private void ComputeLODDataRecursive(AutomaticLOD root, GameObject gameObject, bool bRecurseIntoChildren, Simplifier.ProgressDelegate progress) { }

	// RVA: 0x2150660 Offset: 0x2150761 VA: 0x2150660
	public bool HasLODData() { }

	// RVA: 0x214C220 Offset: 0x214C321 VA: 0x214C220
	public int GetLODLevelUsingCamera(Camera currentCamera) { }

	// RVA: 0x2150710 Offset: 0x2150811 VA: 0x2150710
	public int GetCurrentLODLevel() { }

	// RVA: 0x214C4D0 Offset: 0x214C5D1 VA: 0x214C4D0
	public void SwitchToLOD(int nLevel, bool bRecurseIntoChildren) { }

	// RVA: 0x2150720 Offset: 0x2150821 VA: 0x2150720
	private static void SwitchToLODRecursive(AutomaticLOD root, GameObject gameObject, int nLODLevel, bool bRecurseIntoChildren) { }

	// RVA: 0x2150D60 Offset: 0x2150E61 VA: 0x2150D60
	public void ComputeAllLODMeshes(bool bRecurseIntoChildren, Simplifier.ProgressDelegate progress) { }

	// RVA: 0x2151C20 Offset: 0x2151D21 VA: 0x2151C20
	public void ComputeLODMesh(int nLevel, bool bRecurseIntoChildren, Simplifier.ProgressDelegate progress) { }

	// RVA: 0x2150F00 Offset: 0x2151001 VA: 0x2150F00
	private static void ComputeLODMeshRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, bool bRecurseIntoChildren, Simplifier.ProgressDelegate progress) { }

	// RVA: 0x2151CD0 Offset: 0x2151DD1 VA: 0x2151CD0
	public void RestoreOriginalMesh(bool bDeleteLODData, bool bRecurseIntoChildren) { }

	// RVA: 0x2151DB0 Offset: 0x2151EB1 VA: 0x2151DB0
	private static void RestoreOriginalMeshRecursive(AutomaticLOD root, GameObject gameObject, bool bDeleteLODData, bool bRecurseIntoChildren) { }

	// RVA: 0x2152220 Offset: 0x2152321 VA: 0x2152220
	public bool HasOriginalMeshActive(bool bRecurseIntoChildren) { }

	// RVA: 0x21522B0 Offset: 0x21523B1 VA: 0x21522B0
	private static bool HasOriginalMeshActiveRecursive(AutomaticLOD root, GameObject gameObject, bool bRecurseIntoChildren) { }

	// RVA: 0x2152580 Offset: 0x2152681 VA: 0x2152580
	public bool HasVertexData(int nLevel, bool bRecurseIntoChildren) { }

	// RVA: 0x2152610 Offset: 0x2152711 VA: 0x2152610
	private static bool HasVertexDataRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, bool bRecurseIntoChildren) { }

	// RVA: 0x21528E0 Offset: 0x21529E1 VA: 0x21528E0
	public int GetOriginalVertexCount(bool bRecurseIntoChildren) { }

	// RVA: 0x2152980 Offset: 0x2152A81 VA: 0x2152980
	private static void GetOriginalVertexCountRecursive(AutomaticLOD root, GameObject gameObject, ref int nVertexCount, bool bRecurseIntoChildren) { }

	// RVA: 0x2152B70 Offset: 0x2152C71 VA: 0x2152B70
	public int GetOriginalTriangleCount(bool bRecurseIntoChildren) { }

	// RVA: 0x2152C10 Offset: 0x2152D11 VA: 0x2152C10
	private static void GetOriginalTriangleCountRecursive(AutomaticLOD root, GameObject gameObject, ref int nTriangleCount, bool bRecurseIntoChildren) { }

	// RVA: 0x2152E20 Offset: 0x2152F21 VA: 0x2152E20
	public int GetCurrentVertexCount(bool bRecurseIntoChildren) { }

	// RVA: 0x2152EC0 Offset: 0x2152FC1 VA: 0x2152EC0
	private static void GetCurrentVertexCountRecursive(AutomaticLOD root, GameObject gameObject, ref int nVertexCount, bool bRecurseIntoChildren) { }

	// RVA: 0x21531A0 Offset: 0x21532A1 VA: 0x21531A0
	public int GetLODVertexCount(int nLevel, bool bRecurseIntoChildren) { }

	// RVA: 0x2153250 Offset: 0x2153351 VA: 0x2153250
	private static void GetLODVertexCountRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, ref int nVertexCount, bool bRecurseIntoChildren) { }

	// RVA: 0x2153520 Offset: 0x2153621 VA: 0x2153520
	public int GetLODTriangleCount(int nLevel, bool bRecurseIntoChildren) { }

	// RVA: 0x21535D0 Offset: 0x21536D1 VA: 0x21535D0
	private static void GetLODTriangleCountRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, ref int nTriangleCount, bool bRecurseIntoChildren) { }

	// RVA: 0x21538D0 Offset: 0x21539D1 VA: 0x21538D0
	public void RemoveFromLODTree() { }

	// RVA: 0x21505D0 Offset: 0x21506D1 VA: 0x21505D0
	public void FreeLODData(bool bRecurseIntoChildren) { }

	// RVA: 0x2153980 Offset: 0x2153A81 VA: 0x2153980
	private static void FreeLODDataRecursive(AutomaticLOD root, GameObject gameObject, bool bRecurseIntoChildren) { }

	// RVA: 0x214E4F0 Offset: 0x214E5F1 VA: 0x214E4F0
	private static Mesh CreateNewEmptyMesh(AutomaticLOD automaticLOD) { }

	// RVA: 0x2153F10 Offset: 0x2154011 VA: 0x2153F10
	private static GameObject CreateBasicObjectCopy(GameObject gameObject, Mesh mesh, Transform parent) { }

	// RVA: 0x214E5E0 Offset: 0x214E6E1 VA: 0x214E5E0
	private static void CheckForAdditionalLODSetup(AutomaticLOD root, AutomaticLOD automaticLOD, AutomaticLOD.LODLevelData levelData, int level) { }

	// RVA: 0x2151890 Offset: 0x2151991 VA: 0x2151890
	public void SetupLODGroup() { }

	// RVA: 0x21543A0 Offset: 0x21544A1 VA: 0x21543A0
	private static void SetupLODGroupRecursive(AutomaticLOD root, GameObject gameObject, ref List<List<Renderer>> renderers) { }

	// RVA: 0x2154390 Offset: 0x2154491 VA: 0x2154390
	private static Component CopyComponent(Component original, GameObject destination) { }

	// RVA: 0x214D0E0 Offset: 0x214D1E1 VA: 0x214D0E0
	private void BuildCornerData(ref Vector3[] av3Corners, Bounds bounds) { }

	// RVA: 0x214BBC0 Offset: 0x214BCC1 VA: 0x214BBC0
	private bool IsDependent() { }

	// RVA: 0x2154730 Offset: 0x2154831 VA: 0x2154730
	public void .ctor() { }

	// RVA: 0x21547F0 Offset: 0x21548F1 VA: 0x21547F0
	private static void .cctor() { }
}


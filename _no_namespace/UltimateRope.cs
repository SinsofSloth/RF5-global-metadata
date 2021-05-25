[ExecuteInEditMode] // RVA: 0x147A00 Offset: 0x147B01 VA: 0x147A00
public class UltimateRope : MonoBehaviour // TypeDefIndex: 9062
{
	// Fields
	[RopePersistAttribute] // RVA: 0x175C70 Offset: 0x175D71 VA: 0x175C70
	public UltimateRope.ERopeType RopeType; // 0x18
	[RopePersistAttribute] // RVA: 0x175C80 Offset: 0x175D81 VA: 0x175C80
	public GameObject RopeStart; // 0x20
	[RopePersistAttribute] // RVA: 0x175C90 Offset: 0x175D91 VA: 0x175C90
	public List<UltimateRope.RopeNode> RopeNodes; // 0x28
	[RopePersistAttribute] // RVA: 0x175CA0 Offset: 0x175DA1 VA: 0x175CA0
	public int RopeLayer; // 0x30
	[RopePersistAttribute] // RVA: 0x175CB0 Offset: 0x175DB1 VA: 0x175CB0
	public PhysicMaterial RopePhysicsMaterial; // 0x38
	[RopePersistAttribute] // RVA: 0x175CC0 Offset: 0x175DC1 VA: 0x175CC0
	public float RopeDiameter; // 0x40
	[RopePersistAttribute] // RVA: 0x175CD0 Offset: 0x175DD1 VA: 0x175CD0
	public float RopeDiameterScaleX; // 0x44
	[RopePersistAttribute] // RVA: 0x175CE0 Offset: 0x175DE1 VA: 0x175CE0
	public float RopeDiameterScaleY; // 0x48
	[RopePersistAttribute] // RVA: 0x175CF0 Offset: 0x175DF1 VA: 0x175CF0
	public int RopeSegmentSides; // 0x4C
	[RopePersistAttribute] // RVA: 0x175D00 Offset: 0x175E01 VA: 0x175D00
	public Material RopeMaterial; // 0x50
	[RopePersistAttribute] // RVA: 0x175D10 Offset: 0x175E11 VA: 0x175D10
	public float RopeTextureTileMeters; // 0x58
	[RopePersistAttribute] // RVA: 0x175D20 Offset: 0x175E21 VA: 0x175D20
	public Material RopeSectionMaterial; // 0x60
	[RopePersistAttribute] // RVA: 0x175D30 Offset: 0x175E31 VA: 0x175D30
	public float RopeTextureSectionTileMeters; // 0x68
	[RopePersistAttribute] // RVA: 0x175D40 Offset: 0x175E41 VA: 0x175D40
	public bool IsExtensible; // 0x6C
	[RopePersistAttribute] // RVA: 0x175D50 Offset: 0x175E51 VA: 0x175D50
	public float ExtensibleLength; // 0x70
	[RopePersistAttribute] // RVA: 0x175D60 Offset: 0x175E61 VA: 0x175D60
	public bool HasACoil; // 0x74
	[RopePersistAttribute] // RVA: 0x175D70 Offset: 0x175E71 VA: 0x175D70
	public GameObject CoilObject; // 0x78
	[RopePersistAttribute] // RVA: 0x175D80 Offset: 0x175E81 VA: 0x175D80
	public UltimateRope.EAxis CoilAxisRight; // 0x80
	[RopePersistAttribute] // RVA: 0x175D90 Offset: 0x175E91 VA: 0x175D90
	public UltimateRope.EAxis CoilAxisUp; // 0x84
	[RopePersistAttribute] // RVA: 0x175DA0 Offset: 0x175EA1 VA: 0x175DA0
	public float CoilWidth; // 0x88
	[RopePersistAttribute] // RVA: 0x175DB0 Offset: 0x175EB1 VA: 0x175DB0
	public float CoilDiameter; // 0x8C
	[RopePersistAttribute] // RVA: 0x175DC0 Offset: 0x175EC1 VA: 0x175DC0
	public int CoilNumBones; // 0x90
	[RopePersistAttribute] // RVA: 0x175DD0 Offset: 0x175ED1 VA: 0x175DD0
	public GameObject LinkObject; // 0x98
	[RopePersistAttribute] // RVA: 0x175DE0 Offset: 0x175EE1 VA: 0x175DE0
	public UltimateRope.EAxis LinkAxis; // 0xA0
	[RopePersistAttribute] // RVA: 0x175DF0 Offset: 0x175EF1 VA: 0x175DF0
	public float LinkOffsetObject; // 0xA4
	[RopePersistAttribute] // RVA: 0x175E00 Offset: 0x175F01 VA: 0x175E00
	public float LinkTwistAngleStart; // 0xA8
	[RopePersistAttribute] // RVA: 0x175E10 Offset: 0x175F11 VA: 0x175E10
	public float LinkTwistAngleIncrement; // 0xAC
	[RopePersistAttribute] // RVA: 0x175E20 Offset: 0x175F21 VA: 0x175E20
	public GameObject BoneFirst; // 0xB0
	[RopePersistAttribute] // RVA: 0x175E30 Offset: 0x175F31 VA: 0x175E30
	public GameObject BoneLast; // 0xB8
	[RopePersistAttribute] // RVA: 0x175E40 Offset: 0x175F41 VA: 0x175E40
	public string BoneListNamesStatic; // 0xC0
	[RopePersistAttribute] // RVA: 0x175E50 Offset: 0x175F51 VA: 0x175E50
	public string BoneListNamesNoColliders; // 0xC8
	[RopePersistAttribute] // RVA: 0x175E60 Offset: 0x175F61 VA: 0x175E60
	public UltimateRope.EAxis BoneAxis; // 0xD0
	[RopePersistAttribute] // RVA: 0x175E70 Offset: 0x175F71 VA: 0x175E70
	public UltimateRope.EColliderType BoneColliderType; // 0xD4
	[RopePersistAttribute] // RVA: 0x175E80 Offset: 0x175F81 VA: 0x175E80
	public float BoneColliderDiameter; // 0xD8
	[RopePersistAttribute] // RVA: 0x175E90 Offset: 0x175F91 VA: 0x175E90
	public int BoneColliderSkip; // 0xDC
	[RopePersistAttribute] // RVA: 0x175EA0 Offset: 0x175FA1 VA: 0x175EA0
	public float BoneColliderLength; // 0xE0
	[RopePersistAttribute] // RVA: 0x175EB0 Offset: 0x175FB1 VA: 0x175EB0
	public float BoneColliderOffset; // 0xE4
	[RopePersistAttribute] // RVA: 0x175EC0 Offset: 0x175FC1 VA: 0x175EC0
	public float LinkMass; // 0xE8
	[RopePersistAttribute] // RVA: 0x175ED0 Offset: 0x175FD1 VA: 0x175ED0
	public int LinkSolverIterationCount; // 0xEC
	[RopePersistAttribute] // RVA: 0x175EE0 Offset: 0x175FE1 VA: 0x175EE0
	public float LinkJointAngularXLimit; // 0xF0
	[RopePersistAttribute] // RVA: 0x175EF0 Offset: 0x175FF1 VA: 0x175EF0
	public float LinkJointAngularYLimit; // 0xF4
	[RopePersistAttribute] // RVA: 0x175F00 Offset: 0x176001 VA: 0x175F00
	public float LinkJointAngularZLimit; // 0xF8
	[RopePersistAttribute] // RVA: 0x175F10 Offset: 0x176011 VA: 0x175F10
	public float LinkJointSpringValue; // 0xFC
	[RopePersistAttribute] // RVA: 0x175F20 Offset: 0x176021 VA: 0x175F20
	public float LinkJointDamperValue; // 0x100
	[RopePersistAttribute] // RVA: 0x175F30 Offset: 0x176031 VA: 0x175F30
	public float LinkJointMaxForceValue; // 0x104
	[RopePersistAttribute] // RVA: 0x175F40 Offset: 0x176041 VA: 0x175F40
	public float LinkJointBreakForce; // 0x108
	[RopePersistAttribute] // RVA: 0x175F50 Offset: 0x176051 VA: 0x175F50
	public float LinkJointBreakTorque; // 0x10C
	[RopePersistAttribute] // RVA: 0x175F60 Offset: 0x176061 VA: 0x175F60
	public bool LockStartEndInZAxis; // 0x110
	[RopePersistAttribute] // RVA: 0x175F70 Offset: 0x176071 VA: 0x175F70
	public bool SendEvents; // 0x111
	[RopePersistAttribute] // RVA: 0x175F80 Offset: 0x176081 VA: 0x175F80
	public GameObject EventsObjectReceiver; // 0x118
	[RopePersistAttribute] // RVA: 0x175F90 Offset: 0x176091 VA: 0x175F90
	public string OnBreakMethodName; // 0x120
	[RopePersistAttribute] // RVA: 0x175FA0 Offset: 0x1760A1 VA: 0x175FA0
	public bool PersistAfterPlayMode; // 0x128
	[RopePersistAttribute] // RVA: 0x175FB0 Offset: 0x1760B1 VA: 0x175FB0
	public bool EnablePrefabUsage; // 0x129
	[RopePersistAttribute] // RVA: 0x175FC0 Offset: 0x1760C1 VA: 0x175FC0
	public bool AutoRegenerate; // 0x12A
	[HideInInspector] // RVA: 0x175FD0 Offset: 0x1760D1 VA: 0x175FD0
	[RopePersistAttribute] // RVA: 0x175FD0 Offset: 0x1760D1 VA: 0x175FD0
	public bool Deleted; // 0x12B
	[HideInInspector] // RVA: 0x176010 Offset: 0x176111 VA: 0x176010
	[RopePersistAttribute] // RVA: 0x176010 Offset: 0x176111 VA: 0x176010
	public float[] LinkLengths; // 0x130
	[HideInInspector] // RVA: 0x176050 Offset: 0x176151 VA: 0x176050
	[RopePersistAttribute] // RVA: 0x176050 Offset: 0x176151 VA: 0x176050
	public int TotalLinks; // 0x138
	[HideInInspector] // RVA: 0x176090 Offset: 0x176191 VA: 0x176090
	[RopePersistAttribute] // RVA: 0x176090 Offset: 0x176191 VA: 0x176090
	public float TotalRopeLength; // 0x13C
	[HideInInspector] // RVA: 0x1760D0 Offset: 0x1761D1 VA: 0x1760D0
	[RopePersistAttribute] // RVA: 0x1760D0 Offset: 0x1761D1 VA: 0x1760D0
	public bool m_bRopeStartInitialOrientationInitialized; // 0x140
	[HideInInspector] // RVA: 0x176110 Offset: 0x176211 VA: 0x176110
	[RopePersistAttribute] // RVA: 0x176110 Offset: 0x176211 VA: 0x176110
	public Vector3 m_v3InitialRopeStartLocalPos; // 0x144
	[HideInInspector] // RVA: 0x176150 Offset: 0x176251 VA: 0x176150
	[RopePersistAttribute] // RVA: 0x176150 Offset: 0x176251 VA: 0x176150
	public Quaternion m_qInitialRopeStartLocalRot; // 0x150
	[HideInInspector] // RVA: 0x176190 Offset: 0x176291 VA: 0x176190
	[RopePersistAttribute] // RVA: 0x176190 Offset: 0x176291 VA: 0x176190
	public Vector3 m_v3InitialRopeStartLocalScale; // 0x160
	[HideInInspector] // RVA: 0x1761D0 Offset: 0x1762D1 VA: 0x1761D0
	[RopePersistAttribute] // RVA: 0x1761D0 Offset: 0x1762D1 VA: 0x1761D0
	public int m_nFirstNonCoilNode; // 0x16C
	[HideInInspector] // RVA: 0x176210 Offset: 0x176311 VA: 0x176210
	[RopePersistAttribute] // RVA: 0x176210 Offset: 0x176311 VA: 0x176210
	public float[] m_afCoilBoneRadiuses; // 0x170
	[HideInInspector] // RVA: 0x176250 Offset: 0x176351 VA: 0x176250
	[RopePersistAttribute] // RVA: 0x176250 Offset: 0x176351 VA: 0x176250
	public float[] m_afCoilBoneAngles; // 0x178
	[HideInInspector] // RVA: 0x176290 Offset: 0x176391 VA: 0x176290
	[RopePersistAttribute] // RVA: 0x176290 Offset: 0x176391 VA: 0x176290
	public float[] m_afCoilBoneX; // 0x180
	[HideInInspector] // RVA: 0x1762D0 Offset: 0x1763D1 VA: 0x1762D0
	[RopePersistAttribute] // RVA: 0x1762D0 Offset: 0x1763D1 VA: 0x1762D0
	public float m_fCurrentCoilRopeRadius; // 0x188
	[HideInInspector] // RVA: 0x176310 Offset: 0x176411 VA: 0x176310
	[RopePersistAttribute] // RVA: 0x176310 Offset: 0x176411 VA: 0x176310
	public float m_fCurrentCoilTurnsLeft; // 0x18C
	[HideInInspector] // RVA: 0x176350 Offset: 0x176451 VA: 0x176350
	[RopePersistAttribute] // RVA: 0x176350 Offset: 0x176451 VA: 0x176350
	public float m_fCurrentCoilLength; // 0x190
	[HideInInspector] // RVA: 0x176390 Offset: 0x176491 VA: 0x176390
	[RopePersistAttribute] // RVA: 0x176390 Offset: 0x176491 VA: 0x176390
	public float m_fCurrentExtension; // 0x194
	[HideInInspector] // RVA: 0x1763D0 Offset: 0x1764D1 VA: 0x1763D0
	[RopePersistAttribute] // RVA: 0x1763D0 Offset: 0x1764D1 VA: 0x1763D0
	public float m_fCurrentExtensionInput; // 0x198
	[HideInInspector] // RVA: 0x176410 Offset: 0x176511 VA: 0x176410
	[RopePersistAttribute] // RVA: 0x176410 Offset: 0x176511 VA: 0x176410
	public UltimateRope.RopeBone[] ImportedBones; // 0x1A0
	[HideInInspector] // RVA: 0x176450 Offset: 0x176551 VA: 0x176450
	[RopePersistAttribute] // RVA: 0x176450 Offset: 0x176551 VA: 0x176450
	public bool m_bBonesAreImported; // 0x1A8
	[HideInInspector] // RVA: 0x176490 Offset: 0x176591 VA: 0x176490
	[RopePersistAttribute] // RVA: 0x176490 Offset: 0x176591 VA: 0x176490
	public string m_strStatus; // 0x1B0
	[HideInInspector] // RVA: 0x1764D0 Offset: 0x1765D1 VA: 0x1764D0
	[RopePersistAttribute] // RVA: 0x1764D0 Offset: 0x1765D1 VA: 0x1764D0
	public bool m_bLastStatusIsError; // 0x1B8
	[HideInInspector] // RVA: 0x176510 Offset: 0x176611 VA: 0x176510
	[RopePersistAttribute] // RVA: 0x176510 Offset: 0x176611 VA: 0x176510
	public string m_strAssetFile; // 0x1C0

	// Properties
	[HideInInspector] // RVA: 0x1B92A0 Offset: 0x1B93A1 VA: 0x1B92A0
	public string Status { get; set; }

	// Methods

	// RVA: 0x1F5F470 Offset: 0x1F5F571 VA: 0x1F5F470
	public string get_Status() { }

	// RVA: 0x1F5F480 Offset: 0x1F5F581 VA: 0x1F5F480
	public void set_Status(string value) { }

	// RVA: 0x1F5F490 Offset: 0x1F5F591 VA: 0x1F5F490
	private void Awake() { }

	// RVA: 0x1F62730 Offset: 0x1F62831 VA: 0x1F62730
	private void Start() { }

	// RVA: 0x1F62740 Offset: 0x1F62841 VA: 0x1F62740
	private void OnGUI() { }

	// RVA: 0x1F62750 Offset: 0x1F62851 VA: 0x1F62750
	private void Update() { }

	// RVA: 0x1F62760 Offset: 0x1F62861 VA: 0x1F62760
	private void FixedUpdate() { }

	// RVA: 0x1F63C50 Offset: 0x1F63D51 VA: 0x1F63C50
	public void DeleteRope(bool bResetNodePositions = False, bool bDestroySkin = True) { }

	// RVA: 0x1F64480 Offset: 0x1F64581 VA: 0x1F64480
	public void DeleteRopeLinks() { }

	// RVA: 0x1F64B80 Offset: 0x1F64C81 VA: 0x1F64B80
	public bool Regenerate(bool bResetNodePositions = False) { }

	// RVA: 0x1F6A300 Offset: 0x1F6A401 VA: 0x1F6A300
	public bool IsLastStatusError() { }

	// RVA: 0x1F6A310 Offset: 0x1F6A411 VA: 0x1F6A310
	public bool ChangeRopeDiameter(float fNewDiameter, float fNewScaleX, float fNewScaleY) { }

	// RVA: 0x1F6B040 Offset: 0x1F6B141 VA: 0x1F6B040
	public bool ChangeRopeSegmentSides(int nNewSegmentSides) { }

	// RVA: 0x1F6C360 Offset: 0x1F6C461 VA: 0x1F6C360
	public void SetupRopeMaterials() { }

	// RVA: 0x1F61F40 Offset: 0x1F62041 VA: 0x1F61F40
	public void SetupRopeLinks() { }

	// RVA: 0x1F6CBF0 Offset: 0x1F6CCF1 VA: 0x1F6CBF0
	public void SetupRopeJoints() { }

	// RVA: 0x1F6E4D0 Offset: 0x1F6E5D1 VA: 0x1F6E4D0
	public void CheckNeedsStartExitLockZ() { }

	// RVA: 0x1F63590 Offset: 0x1F63691 VA: 0x1F63590
	public void FillLinkMeshIndicesRope(int nLinearLinkIndex, int nTotalLinks, ref int[] indices, bool bBreakable, bool bBrokenLink = False) { }

	// RVA: 0x1F63840 Offset: 0x1F63941 VA: 0x1F63840
	public void FillLinkMeshIndicesSections(int nLinearLinkIndex, int nTotalLinks, ref int[] indices, bool bBreakable, bool bBrokenLink = False) { }

	// RVA: 0x1F6ED70 Offset: 0x1F6EE71 VA: 0x1F6ED70
	public bool HasDynamicSegmentNodes() { }

	// RVA: 0x1F6EFB0 Offset: 0x1F6F0B1 VA: 0x1F6EFB0
	public void BeforeImportedBonesObjectRespawn() { }

	// RVA: 0x1F6F0B0 Offset: 0x1F6F1B1 VA: 0x1F6F0B0
	public void AfterImportedBonesObjectRespawn() { }

	// RVA: 0x1F6F1E0 Offset: 0x1F6F2E1 VA: 0x1F6F1E0
	public void ExtendRope(UltimateRope.ERopeExtensionMode eRopeExtensionMode, float fIncrement) { }

	// RVA: 0x1F62720 Offset: 0x1F62821 VA: 0x1F62720
	public void RecomputeCoil() { }

	// RVA: 0x1F6FED0 Offset: 0x1F6FFD1 VA: 0x1F6FED0
	public GameObject BuildStaticMeshObject(out string strStatusMessage) { }

	// RVA: 0x1F71860 Offset: 0x1F71961 VA: 0x1F71860
	public void MoveNodeUp(int nNode) { }

	// RVA: 0x1F71960 Offset: 0x1F71A61 VA: 0x1F71960
	public void MoveNodeDown(int nNode) { }

	// RVA: 0x1F71A70 Offset: 0x1F71B71 VA: 0x1F71A70
	public void CreateNewNode(int nNode) { }

	// RVA: 0x1F71B40 Offset: 0x1F71C41 VA: 0x1F71B40
	public void RemoveNode(int nNode) { }

	// RVA: 0x1F626A0 Offset: 0x1F627A1 VA: 0x1F626A0
	public bool FirstNodeIsCoil() { }

	// RVA: 0x1F68970 Offset: 0x1F68A71 VA: 0x1F68970
	private void CheckAddCoilNode() { }

	// RVA: 0x1F64AC0 Offset: 0x1F64BC1 VA: 0x1F64AC0
	private void CheckDelCoilNode() { }

	// RVA: 0x1F5F540 Offset: 0x1F5F641 VA: 0x1F5F540
	private void CreateRopeJoints(bool bCheckIfBroken = False) { }

	// RVA: 0x1F71BC0 Offset: 0x1F71CC1 VA: 0x1F71BC0
	private ConfigurableJoint CreateJoint(GameObject goObject, GameObject goConnectedTo, Vector3 v3Pivot) { }

	// RVA: 0x1F6E1E0 Offset: 0x1F6E2E1 VA: 0x1F6E1E0
	private void SetupJoint(ConfigurableJoint joint) { }

	// RVA: 0x1F6FD70 Offset: 0x1F6FE71 VA: 0x1F6FD70
	private Vector3 GetAxisVector(UltimateRope.EAxis eAxis, float fLength) { }

	// RVA: 0x1F6F4A0 Offset: 0x1F6F5A1 VA: 0x1F6F4A0
	private float ExtendRopeLinear(float fLinearIncrement) { }

	// RVA: 0x1F71CC0 Offset: 0x1F71DC1 VA: 0x1F71CC0
	private void SetExtensibleLinkToKinematic(GameObject link, bool bKinematic) { }

	// RVA: 0x1F68D70 Offset: 0x1F68E71 VA: 0x1F68D70
	private void SetupCoilBones(float fCoilLength) { }

	// RVA: 0x1F69EC0 Offset: 0x1F69FC1 VA: 0x1F69EC0
	private Quaternion GetLinkedObjectLocalRotation(float fTwistAngle = 0) { }

	// RVA: 0x1F69C80 Offset: 0x1F69D81 VA: 0x1F69C80
	private float GetLinkedObjectScale(float fSegmentLength, int nNumLinks) { }

	// RVA: 0x1F6C4D0 Offset: 0x1F6C5D1 VA: 0x1F6C4D0
	private float GetLinkDiameter() { }

	// RVA: 0x1F63B40 Offset: 0x1F63C41 VA: 0x1F63B40
	private Vector3 GetLinkAxisOffset(float fValue) { }

	// RVA: 0x1F6C850 Offset: 0x1F6C951 VA: 0x1F6C850
	private int GetLinkAxisIndex() { }

	// RVA: 0x1F6C8C0 Offset: 0x1F6C9C1 VA: 0x1F6C8C0
	private bool GetLinkBoxColliderCenterAndSize(float fLinkLength, float fRopeDiameter, ref Vector3 v3CenterInOut, ref Vector3 v3SizeInOut) { }

	// RVA: 0x1F68380 Offset: 0x1F68481 VA: 0x1F68380
	private bool BuildImportedBoneList(GameObject goBoneFirst, GameObject goBoneLast, List<int> ListImportBonesStatic, List<int> ListImportBonesNoCollider, out List<UltimateRope.RopeBone> outListImportedBones, out string strErrorMessage) { }

	// RVA: 0x1F71EE0 Offset: 0x1F71FE1 VA: 0x1F71EE0
	private bool BuildImportedBoneListTry(GameObject goRoot, string strPrefix, int nIndexFirst, int nIndexLast, int nDigitsFirst, int nDigitsLast, List<int> ListImportBonesStatic, List<int> ListImportBonesNoCollider, out List<UltimateRope.RopeBone> outListImportedBones, ref string strErrorMessage) { }

	// RVA: 0x1F72AC0 Offset: 0x1F72BC1 VA: 0x1F72AC0
	private bool BuildBoneHashString2GameObject(GameObject goRoot, GameObject goCurrent, ref Dictionary<string, GameObject> outHashString2GameObjects, ref string strErrorMessage) { }

	// RVA: 0x1F676C0 Offset: 0x1F677C1 VA: 0x1F676C0
	private bool ParseBoneIndices(string strBoneList, out List<int> outListBoneIndices, out string strErrorMessage) { }

	// RVA: 0x1F72C60 Offset: 0x1F72D61 VA: 0x1F72C60
	public void .ctor() { }
}


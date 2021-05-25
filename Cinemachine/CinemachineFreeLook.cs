[DocumentationSortingAttribute] // RVA: 0x12E2E0 Offset: 0x12E3E1 VA: 0x12E2E0
[DisallowMultipleComponent] // RVA: 0x12E2E0 Offset: 0x12E3E1 VA: 0x12E2E0
[ExecuteAlways] // RVA: 0x12E2E0 Offset: 0x12E3E1 VA: 0x12E2E0
[ExcludeFromPresetAttribute] // RVA: 0x12E2E0 Offset: 0x12E3E1 VA: 0x12E2E0
[AddComponentMenu] // RVA: 0x12E2E0 Offset: 0x12E3E1 VA: 0x12E2E0
[HelpURLAttribute] // RVA: 0x12E2E0 Offset: 0x12E3E1 VA: 0x12E2E0
public class CinemachineFreeLook : CinemachineVirtualCameraBase // TypeDefIndex: 4754
{
	// Fields
	[TooltipAttribute] // RVA: 0x130B20 Offset: 0x130C21 VA: 0x130B20
	[NoSaveDuringPlayAttribute] // RVA: 0x130B20 Offset: 0x130C21 VA: 0x130B20
	[VcamTargetPropertyAttribute] // RVA: 0x130B20 Offset: 0x130C21 VA: 0x130B20
	public Transform m_LookAt; // 0x68
	[TooltipAttribute] // RVA: 0x130B80 Offset: 0x130C81 VA: 0x130B80
	[NoSaveDuringPlayAttribute] // RVA: 0x130B80 Offset: 0x130C81 VA: 0x130B80
	[VcamTargetPropertyAttribute] // RVA: 0x130B80 Offset: 0x130C81 VA: 0x130B80
	public Transform m_Follow; // 0x70
	[TooltipAttribute] // RVA: 0x130BE0 Offset: 0x130CE1 VA: 0x130BE0
	[FormerlySerializedAsAttribute] // RVA: 0x130BE0 Offset: 0x130CE1 VA: 0x130BE0
	public bool m_CommonLens; // 0x78
	[FormerlySerializedAsAttribute] // RVA: 0x130C40 Offset: 0x130D41 VA: 0x130C40
	[TooltipAttribute] // RVA: 0x130C40 Offset: 0x130D41 VA: 0x130C40
	[LensSettingsPropertyAttribute] // RVA: 0x130C40 Offset: 0x130D41 VA: 0x130C40
	public LensSettings m_Lens; // 0x7C
	public CinemachineVirtualCameraBase.TransitionParams m_Transitions; // 0xA8
	[SerializeField] // RVA: 0x130CB0 Offset: 0x130DB1 VA: 0x130CB0
	[HideInInspector] // RVA: 0x130CB0 Offset: 0x130DB1 VA: 0x130CB0
	[FormerlySerializedAsAttribute] // RVA: 0x130CB0 Offset: 0x130DB1 VA: 0x130CB0
	[FormerlySerializedAsAttribute] // RVA: 0x130CB0 Offset: 0x130DB1 VA: 0x130CB0
	private CinemachineVirtualCameraBase.BlendHint m_LegacyBlendHint; // 0xB8
	[HeaderAttribute] // RVA: 0x130D30 Offset: 0x130E31 VA: 0x130D30
	[TooltipAttribute] // RVA: 0x130D30 Offset: 0x130E31 VA: 0x130D30
	[AxisStatePropertyAttribute] // RVA: 0x130D30 Offset: 0x130E31 VA: 0x130D30
	public AxisState m_YAxis; // 0xC0
	[TooltipAttribute] // RVA: 0x130DA0 Offset: 0x130EA1 VA: 0x130DA0
	public AxisState.Recentering m_YAxisRecentering; // 0x128
	[TooltipAttribute] // RVA: 0x130DE0 Offset: 0x130EE1 VA: 0x130DE0
	[AxisStatePropertyAttribute] // RVA: 0x130DE0 Offset: 0x130EE1 VA: 0x130DE0
	public AxisState m_XAxis; // 0x148
	[OrbitalTransposerHeadingPropertyAttribute] // RVA: 0x130E30 Offset: 0x130F31 VA: 0x130E30
	[TooltipAttribute] // RVA: 0x130E30 Offset: 0x130F31 VA: 0x130E30
	public CinemachineOrbitalTransposer.Heading m_Heading; // 0x1B0
	[TooltipAttribute] // RVA: 0x130E80 Offset: 0x130F81 VA: 0x130E80
	public AxisState.Recentering m_RecenterToTargetHeading; // 0x1BC
	[HeaderAttribute] // RVA: 0x130EC0 Offset: 0x130FC1 VA: 0x130EC0
	[TooltipAttribute] // RVA: 0x130EC0 Offset: 0x130FC1 VA: 0x130EC0
	public CinemachineTransposer.BindingMode m_BindingMode; // 0x1D8
	[TooltipAttribute] // RVA: 0x130F20 Offset: 0x131021 VA: 0x130F20
	[RangeAttribute] // RVA: 0x130F20 Offset: 0x131021 VA: 0x130F20
	[FormerlySerializedAsAttribute] // RVA: 0x130F20 Offset: 0x131021 VA: 0x130F20
	public float m_SplineCurvature; // 0x1DC
	[TooltipAttribute] // RVA: 0x130FA0 Offset: 0x1310A1 VA: 0x130FA0
	public CinemachineFreeLook.Orbit[] m_Orbits; // 0x1E0
	[SerializeField] // RVA: 0x130FE0 Offset: 0x1310E1 VA: 0x130FE0
	[HideInInspector] // RVA: 0x130FE0 Offset: 0x1310E1 VA: 0x130FE0
	[FormerlySerializedAsAttribute] // RVA: 0x130FE0 Offset: 0x1310E1 VA: 0x130FE0
	private float m_LegacyHeadingBias; // 0x1E8
	private bool mUseLegacyRigDefinitions; // 0x1EC
	private bool mIsDestroyed; // 0x1ED
	private CameraState m_State; // 0x1F0
	[SerializeField] // RVA: 0x131040 Offset: 0x131141 VA: 0x131040
	[HideInInspector] // RVA: 0x131040 Offset: 0x131141 VA: 0x131040
	[NoSaveDuringPlayAttribute] // RVA: 0x131040 Offset: 0x131141 VA: 0x131040
	private CinemachineVirtualCamera[] m_Rigs; // 0x2D0
	private CinemachineOrbitalTransposer[] mOrbitals; // 0x2D8
	private CinemachineBlend mBlendA; // 0x2E0
	private CinemachineBlend mBlendB; // 0x2E8
	public static CinemachineFreeLook.CreateRigDelegate CreateRigOverride; // 0x0
	public static CinemachineFreeLook.DestroyRigDelegate DestroyRigOverride; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x131090 Offset: 0x131191 VA: 0x131090
	private float <CachedXAxisHeading>k__BackingField; // 0x2F0
	private CinemachineFreeLook.Orbit[] m_CachedOrbits; // 0x2F8
	private float m_CachedTension; // 0x300
	private Vector4[] m_CachedKnots; // 0x308
	private Vector4[] m_CachedCtrl1; // 0x310
	private Vector4[] m_CachedCtrl2; // 0x318

	// Properties
	public static string[] RigNames { get; }
	public override bool PreviousStateIsValid { get; set; }
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	private float CachedXAxisHeading { get; set; }

	// Methods

	// RVA: 0x1724D30 Offset: 0x1724E31 VA: 0x1724D30 Slot: 38
	protected override void OnValidate() { }

	// RVA: 0x1724E30 Offset: 0x1724F31 VA: 0x1724E30
	public CinemachineVirtualCamera GetRig(int i) { }

	// RVA: 0x17250A0 Offset: 0x17251A1 VA: 0x17250A0
	public static string[] get_RigNames() { }

	// RVA: 0x1725200 Offset: 0x1725301 VA: 0x1725200 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x17252C0 Offset: 0x17253C1 VA: 0x17252C0
	public void UpdateInputAxisProvider() { }

	// RVA: 0x1725360 Offset: 0x1725461 VA: 0x1725360 Slot: 35
	protected override void OnDestroy() { }

	// RVA: 0x17254C0 Offset: 0x17255C1 VA: 0x17254C0
	private void OnTransformChildrenChanged() { }

	// RVA: 0x17254E0 Offset: 0x17255E1 VA: 0x17254E0
	private void Reset() { }

	// RVA: 0x1725A70 Offset: 0x1725B71 VA: 0x1725A70 Slot: 31
	public override bool get_PreviousStateIsValid() { }

	// RVA: 0x1725A80 Offset: 0x1725B81 VA: 0x1725A80 Slot: 32
	public override void set_PreviousStateIsValid(bool value) { }

	// RVA: 0x1725B90 Offset: 0x1725C91 VA: 0x1725B90 Slot: 25
	public override CameraState get_State() { }

	// RVA: 0x1725BA0 Offset: 0x1725CA1 VA: 0x1725BA0 Slot: 27
	public override Transform get_LookAt() { }

	// RVA: 0x1725BB0 Offset: 0x1725CB1 VA: 0x1725BB0 Slot: 28
	public override void set_LookAt(Transform value) { }

	// RVA: 0x1725BC0 Offset: 0x1725CC1 VA: 0x1725BC0 Slot: 29
	public override Transform get_Follow() { }

	// RVA: 0x1725BD0 Offset: 0x1725CD1 VA: 0x1725BD0 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x1725BE0 Offset: 0x1725CE1 VA: 0x1725BE0 Slot: 26
	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0x1725D20 Offset: 0x1725E21 VA: 0x1725D20 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1725E00 Offset: 0x1725F01 VA: 0x1725E00 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1726DC0 Offset: 0x1726EC1 VA: 0x1726DC0 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1727340 Offset: 0x1727441 VA: 0x1727340 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x17260A0 Offset: 0x17261A1 VA: 0x17260A0
	private float GetYAxisClosestValue(Vector3 cameraPos, Vector3 up) { }

	// RVA: 0x1724E10 Offset: 0x1724F11 VA: 0x1724E10
	private void InvalidateRigCache() { }

	// RVA: 0x17254F0 Offset: 0x17255F1 VA: 0x17254F0
	private void DestroyRigs() { }

	// RVA: 0x1727E10 Offset: 0x1727F11 VA: 0x1727E10
	private CinemachineVirtualCamera[] CreateRigs(CinemachineVirtualCamera[] copyFrom) { }

	// RVA: 0x1724EA0 Offset: 0x1724FA1 VA: 0x1724EA0
	private void UpdateRigCache() { }

	// RVA: 0x17286B0 Offset: 0x17287B1 VA: 0x17286B0
	private int LocateExistingRigs(string[] rigNames, bool forceOrbital) { }

	[CompilerGeneratedAttribute] // RVA: 0x136B70 Offset: 0x136C71 VA: 0x136B70
	// RVA: 0x1729100 Offset: 0x1729201 VA: 0x1729100
	private float get_CachedXAxisHeading() { }

	[CompilerGeneratedAttribute] // RVA: 0x136B80 Offset: 0x136C81 VA: 0x136B80
	// RVA: 0x1729110 Offset: 0x1729211 VA: 0x1729110
	private void set_CachedXAxisHeading(float value) { }

	// RVA: 0x1729120 Offset: 0x1729221 VA: 0x1729120
	private float UpdateXAxisHeading(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up) { }

	// RVA: 0x17268A0 Offset: 0x17269A1 VA: 0x17268A0
	private void PushSettingsToRigs() { }

	// RVA: 0x1725CF0 Offset: 0x1725DF1 VA: 0x1725CF0
	private float GetYAxisValue() { }

	// RVA: 0x1727190 Offset: 0x1727291 VA: 0x1727190
	private CameraState CalculateNewState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1727820 Offset: 0x1727921 VA: 0x1727820
	public Vector3 GetLocalPositionForCameraFromInput(float t) { }

	// RVA: 0x1729410 Offset: 0x1729511 VA: 0x1729410
	private void UpdateCachedSpline() { }

	// RVA: 0x17298A0 Offset: 0x17299A1 VA: 0x17298A0
	public void .ctor() { }
}


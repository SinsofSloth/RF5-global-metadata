[DocumentationSortingAttribute] // RVA: 0x12E9E0 Offset: 0x12EAE1 VA: 0x12E9E0
[AddComponentMenu] // RVA: 0x12E9E0 Offset: 0x12EAE1 VA: 0x12E9E0
[SaveDuringPlayAttribute] // RVA: 0x12E9E0 Offset: 0x12EAE1 VA: 0x12E9E0
public class CinemachineFramingTransposer : CinemachineComponentBase // TypeDefIndex: 4786
{
	// Fields
	[TooltipAttribute] // RVA: 0x132680 Offset: 0x132781 VA: 0x132680
	public Vector3 m_TrackedObjectOffset; // 0x50
	[TooltipAttribute] // RVA: 0x1326C0 Offset: 0x1327C1 VA: 0x1326C0
	[RangeAttribute] // RVA: 0x1326C0 Offset: 0x1327C1 VA: 0x1326C0
	[SpaceAttribute] // RVA: 0x1326C0 Offset: 0x1327C1 VA: 0x1326C0
	public float m_LookaheadTime; // 0x5C
	[TooltipAttribute] // RVA: 0x132730 Offset: 0x132831 VA: 0x132730
	[RangeAttribute] // RVA: 0x132730 Offset: 0x132831 VA: 0x132730
	public float m_LookaheadSmoothing; // 0x60
	[TooltipAttribute] // RVA: 0x132790 Offset: 0x132891 VA: 0x132790
	public bool m_LookaheadIgnoreY; // 0x64
	[SpaceAttribute] // RVA: 0x1327D0 Offset: 0x1328D1 VA: 0x1327D0
	[RangeAttribute] // RVA: 0x1327D0 Offset: 0x1328D1 VA: 0x1327D0
	[TooltipAttribute] // RVA: 0x1327D0 Offset: 0x1328D1 VA: 0x1327D0
	public float m_XDamping; // 0x68
	[RangeAttribute] // RVA: 0x132840 Offset: 0x132941 VA: 0x132840
	[TooltipAttribute] // RVA: 0x132840 Offset: 0x132941 VA: 0x132840
	public float m_YDamping; // 0x6C
	[RangeAttribute] // RVA: 0x1328A0 Offset: 0x1329A1 VA: 0x1328A0
	[TooltipAttribute] // RVA: 0x1328A0 Offset: 0x1329A1 VA: 0x1328A0
	public float m_ZDamping; // 0x70
	[TooltipAttribute] // RVA: 0x132900 Offset: 0x132A01 VA: 0x132900
	public bool m_TargetMovementOnly; // 0x74
	[SpaceAttribute] // RVA: 0x132940 Offset: 0x132A41 VA: 0x132940
	[RangeAttribute] // RVA: 0x132940 Offset: 0x132A41 VA: 0x132940
	[TooltipAttribute] // RVA: 0x132940 Offset: 0x132A41 VA: 0x132940
	public float m_ScreenX; // 0x78
	[RangeAttribute] // RVA: 0x1329B0 Offset: 0x132AB1 VA: 0x1329B0
	[TooltipAttribute] // RVA: 0x1329B0 Offset: 0x132AB1 VA: 0x1329B0
	public float m_ScreenY; // 0x7C
	[TooltipAttribute] // RVA: 0x132A10 Offset: 0x132B11 VA: 0x132A10
	public float m_CameraDistance; // 0x80
	[SpaceAttribute] // RVA: 0x132A50 Offset: 0x132B51 VA: 0x132A50
	[RangeAttribute] // RVA: 0x132A50 Offset: 0x132B51 VA: 0x132A50
	[TooltipAttribute] // RVA: 0x132A50 Offset: 0x132B51 VA: 0x132A50
	public float m_DeadZoneWidth; // 0x84
	[RangeAttribute] // RVA: 0x132AC0 Offset: 0x132BC1 VA: 0x132AC0
	[TooltipAttribute] // RVA: 0x132AC0 Offset: 0x132BC1 VA: 0x132AC0
	public float m_DeadZoneHeight; // 0x88
	[TooltipAttribute] // RVA: 0x132B20 Offset: 0x132C21 VA: 0x132B20
	[FormerlySerializedAsAttribute] // RVA: 0x132B20 Offset: 0x132C21 VA: 0x132B20
	public float m_DeadZoneDepth; // 0x8C
	[SpaceAttribute] // RVA: 0x132B80 Offset: 0x132C81 VA: 0x132B80
	[TooltipAttribute] // RVA: 0x132B80 Offset: 0x132C81 VA: 0x132B80
	public bool m_UnlimitedSoftZone; // 0x90
	[RangeAttribute] // RVA: 0x132BD0 Offset: 0x132CD1 VA: 0x132BD0
	[TooltipAttribute] // RVA: 0x132BD0 Offset: 0x132CD1 VA: 0x132BD0
	public float m_SoftZoneWidth; // 0x94
	[RangeAttribute] // RVA: 0x132C30 Offset: 0x132D31 VA: 0x132C30
	[TooltipAttribute] // RVA: 0x132C30 Offset: 0x132D31 VA: 0x132C30
	public float m_SoftZoneHeight; // 0x98
	[RangeAttribute] // RVA: 0x132C90 Offset: 0x132D91 VA: 0x132C90
	[TooltipAttribute] // RVA: 0x132C90 Offset: 0x132D91 VA: 0x132C90
	public float m_BiasX; // 0x9C
	[RangeAttribute] // RVA: 0x132CF0 Offset: 0x132DF1 VA: 0x132CF0
	[TooltipAttribute] // RVA: 0x132CF0 Offset: 0x132DF1 VA: 0x132CF0
	public float m_BiasY; // 0xA0
	[TooltipAttribute] // RVA: 0x132D50 Offset: 0x132E51 VA: 0x132D50
	public bool m_CenterOnActivate; // 0xA4
	[SpaceAttribute] // RVA: 0x132D90 Offset: 0x132E91 VA: 0x132D90
	[TooltipAttribute] // RVA: 0x132D90 Offset: 0x132E91 VA: 0x132D90
	[FormerlySerializedAsAttribute] // RVA: 0x132D90 Offset: 0x132E91 VA: 0x132D90
	public CinemachineFramingTransposer.FramingMode m_GroupFramingMode; // 0xA8
	[TooltipAttribute] // RVA: 0x132E00 Offset: 0x132F01 VA: 0x132E00
	public CinemachineFramingTransposer.AdjustmentMode m_AdjustmentMode; // 0xAC
	[TooltipAttribute] // RVA: 0x132E40 Offset: 0x132F41 VA: 0x132E40
	public float m_GroupFramingSize; // 0xB0
	[TooltipAttribute] // RVA: 0x132E80 Offset: 0x132F81 VA: 0x132E80
	public float m_MaxDollyIn; // 0xB4
	[TooltipAttribute] // RVA: 0x132EC0 Offset: 0x132FC1 VA: 0x132EC0
	public float m_MaxDollyOut; // 0xB8
	[TooltipAttribute] // RVA: 0x132F00 Offset: 0x133001 VA: 0x132F00
	public float m_MinimumDistance; // 0xBC
	[TooltipAttribute] // RVA: 0x132F40 Offset: 0x133041 VA: 0x132F40
	public float m_MaximumDistance; // 0xC0
	[RangeAttribute] // RVA: 0x132F80 Offset: 0x133081 VA: 0x132F80
	[TooltipAttribute] // RVA: 0x132F80 Offset: 0x133081 VA: 0x132F80
	public float m_MinimumFOV; // 0xC4
	[RangeAttribute] // RVA: 0x132FE0 Offset: 0x1330E1 VA: 0x132FE0
	[TooltipAttribute] // RVA: 0x132FE0 Offset: 0x1330E1 VA: 0x132FE0
	public float m_MaximumFOV; // 0xC8
	[TooltipAttribute] // RVA: 0x133040 Offset: 0x133141 VA: 0x133040
	public float m_MinimumOrthoSize; // 0xCC
	[TooltipAttribute] // RVA: 0x133080 Offset: 0x133181 VA: 0x133080
	public float m_MaximumOrthoSize; // 0xD0
	private const float kMinimumCameraDistance = 0.01;
	private const float kMinimumGroupSize = 0.01;
	private Vector3 m_PreviousCameraPosition; // 0xD4
	private PositionPredictor m_Predictor; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x1330C0 Offset: 0x1331C1 VA: 0x1330C0
	private Vector3 <TrackedPoint>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x1330D0 Offset: 0x1331D1 VA: 0x1330D0
	private bool <InheritingPosition>k__BackingField; // 0xF4
	private float m_prevFOV; // 0xF8
	private Quaternion m_prevRotation; // 0xFC
	[CompilerGeneratedAttribute] // RVA: 0x1330E0 Offset: 0x1331E1 VA: 0x1330E0
	private Bounds <LastBounds>k__BackingField; // 0x10C
	[CompilerGeneratedAttribute] // RVA: 0x1330F0 Offset: 0x1331F1 VA: 0x1330F0
	private Matrix4x4 <LastBoundsMatrix>k__BackingField; // 0x124

	// Properties
	internal Rect SoftGuideRect { get; set; }
	internal Rect HardGuideRect { get; set; }
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }
	public override bool BodyAppliesAfterAim { get; }
	public Vector3 TrackedPoint { get; set; }
	private bool InheritingPosition { get; set; }
	public Bounds LastBounds { get; set; }
	public Matrix4x4 LastBoundsMatrix { get; set; }

	// Methods

	// RVA: 0x1721F20 Offset: 0x1722021 VA: 0x1721F20
	internal Rect get_SoftGuideRect() { }

	// RVA: 0x1721F70 Offset: 0x1722071 VA: 0x1721F70
	internal void set_SoftGuideRect(Rect value) { }

	// RVA: 0x17220D0 Offset: 0x17221D1 VA: 0x17220D0
	internal Rect get_HardGuideRect() { }

	// RVA: 0x17221E0 Offset: 0x17222E1 VA: 0x17221E0
	internal void set_HardGuideRect(Rect value) { }

	// RVA: 0x1722400 Offset: 0x1722501 VA: 0x1722400
	private void OnValidate() { }

	// RVA: 0x1722560 Offset: 0x1722661 VA: 0x1722560 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x1722600 Offset: 0x1722701 VA: 0x1722600 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x1722610 Offset: 0x1722711 VA: 0x1722610 Slot: 7
	public override bool get_BodyAppliesAfterAim() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CA0 Offset: 0x136DA1 VA: 0x136CA0
	// RVA: 0x1722620 Offset: 0x1722721 VA: 0x1722620
	public Vector3 get_TrackedPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CB0 Offset: 0x136DB1 VA: 0x136CB0
	// RVA: 0x1722630 Offset: 0x1722731 VA: 0x1722630
	private void set_TrackedPoint(Vector3 value) { }

	// RVA: 0x1722640 Offset: 0x1722741 VA: 0x1722640 Slot: 10
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x17227A0 Offset: 0x17228A1 VA: 0x17227A0 Slot: 11
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x17227F0 Offset: 0x17228F1 VA: 0x17227F0 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1722890 Offset: 0x1722991 VA: 0x1722890 Slot: 9
	public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) { }

	[CompilerGeneratedAttribute] // RVA: 0x136CC0 Offset: 0x136DC1 VA: 0x136CC0
	// RVA: 0x17229B0 Offset: 0x1722AB1 VA: 0x17229B0
	private bool get_InheritingPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CD0 Offset: 0x136DD1 VA: 0x136CD0
	// RVA: 0x17229C0 Offset: 0x1722AC1 VA: 0x17229C0
	private void set_InheritingPosition(bool value) { }

	// RVA: 0x17229D0 Offset: 0x1722AD1 VA: 0x17229D0
	private Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect) { }

	// RVA: 0x1722AB0 Offset: 0x1722BB1 VA: 0x1722AB0
	private Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect) { }

	[CompilerGeneratedAttribute] // RVA: 0x136CE0 Offset: 0x136DE1 VA: 0x136CE0
	// RVA: 0x1722C00 Offset: 0x1722D01 VA: 0x1722C00
	public Bounds get_LastBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CF0 Offset: 0x136DF1 VA: 0x136CF0
	// RVA: 0x1722C30 Offset: 0x1722D31 VA: 0x1722C30
	private void set_LastBounds(Bounds value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136D00 Offset: 0x136E01 VA: 0x136D00
	// RVA: 0x1722C60 Offset: 0x1722D61 VA: 0x1722C60
	public Matrix4x4 get_LastBoundsMatrix() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D10 Offset: 0x136E11 VA: 0x136D10
	// RVA: 0x1722CC0 Offset: 0x1722DC1 VA: 0x1722CC0
	private void set_LastBoundsMatrix(Matrix4x4 value) { }

	// RVA: 0x1722CE0 Offset: 0x1722DE1 VA: 0x1722CE0 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1724430 Offset: 0x1724531 VA: 0x1724430
	private float GetTargetHeight(Vector2 boundsSize) { }

	// RVA: 0x1723E60 Offset: 0x1723F61 VA: 0x1723E60
	private Vector3 ComputeGroupBounds(ICinemachineTargetGroup group, ref CameraState curState) { }

	// RVA: 0x1724580 Offset: 0x1724681 VA: 0x1724580
	private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, ref Vector3 pos, Quaternion orientation) { }

	// RVA: 0x1724BF0 Offset: 0x1724CF1 VA: 0x1724BF0
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E9E0 Offset: 0x12EAE1 VA: 0x12E9E0
[AddComponentMenu] // RVA: 0x12E9E0 Offset: 0x12EAE1 VA: 0x12E9E0
[SaveDuringPlayAttribute] // RVA: 0x12E9E0 Offset: 0x12EAE1 VA: 0x12E9E0
public class CinemachineFramingTransposer : CinemachineComponentBase // TypeDefIndex: 4786
{
	// Fields
	[TooltipAttribute] // RVA: 0x132680 Offset: 0x132781 VA: 0x132680
	public Vector3 m_TrackedObjectOffset; // 0x50
	[TooltipAttribute] // RVA: 0x1326C0 Offset: 0x1327C1 VA: 0x1326C0
	[RangeAttribute] // RVA: 0x1326C0 Offset: 0x1327C1 VA: 0x1326C0
	[SpaceAttribute] // RVA: 0x1326C0 Offset: 0x1327C1 VA: 0x1326C0
	public float m_LookaheadTime; // 0x5C
	[TooltipAttribute] // RVA: 0x132730 Offset: 0x132831 VA: 0x132730
	[RangeAttribute] // RVA: 0x132730 Offset: 0x132831 VA: 0x132730
	public float m_LookaheadSmoothing; // 0x60
	[TooltipAttribute] // RVA: 0x132790 Offset: 0x132891 VA: 0x132790
	public bool m_LookaheadIgnoreY; // 0x64
	[SpaceAttribute] // RVA: 0x1327D0 Offset: 0x1328D1 VA: 0x1327D0
	[RangeAttribute] // RVA: 0x1327D0 Offset: 0x1328D1 VA: 0x1327D0
	[TooltipAttribute] // RVA: 0x1327D0 Offset: 0x1328D1 VA: 0x1327D0
	public float m_XDamping; // 0x68
	[RangeAttribute] // RVA: 0x132840 Offset: 0x132941 VA: 0x132840
	[TooltipAttribute] // RVA: 0x132840 Offset: 0x132941 VA: 0x132840
	public float m_YDamping; // 0x6C
	[RangeAttribute] // RVA: 0x1328A0 Offset: 0x1329A1 VA: 0x1328A0
	[TooltipAttribute] // RVA: 0x1328A0 Offset: 0x1329A1 VA: 0x1328A0
	public float m_ZDamping; // 0x70
	[TooltipAttribute] // RVA: 0x132900 Offset: 0x132A01 VA: 0x132900
	public bool m_TargetMovementOnly; // 0x74
	[SpaceAttribute] // RVA: 0x132940 Offset: 0x132A41 VA: 0x132940
	[RangeAttribute] // RVA: 0x132940 Offset: 0x132A41 VA: 0x132940
	[TooltipAttribute] // RVA: 0x132940 Offset: 0x132A41 VA: 0x132940
	public float m_ScreenX; // 0x78
	[RangeAttribute] // RVA: 0x1329B0 Offset: 0x132AB1 VA: 0x1329B0
	[TooltipAttribute] // RVA: 0x1329B0 Offset: 0x132AB1 VA: 0x1329B0
	public float m_ScreenY; // 0x7C
	[TooltipAttribute] // RVA: 0x132A10 Offset: 0x132B11 VA: 0x132A10
	public float m_CameraDistance; // 0x80
	[SpaceAttribute] // RVA: 0x132A50 Offset: 0x132B51 VA: 0x132A50
	[RangeAttribute] // RVA: 0x132A50 Offset: 0x132B51 VA: 0x132A50
	[TooltipAttribute] // RVA: 0x132A50 Offset: 0x132B51 VA: 0x132A50
	public float m_DeadZoneWidth; // 0x84
	[RangeAttribute] // RVA: 0x132AC0 Offset: 0x132BC1 VA: 0x132AC0
	[TooltipAttribute] // RVA: 0x132AC0 Offset: 0x132BC1 VA: 0x132AC0
	public float m_DeadZoneHeight; // 0x88
	[TooltipAttribute] // RVA: 0x132B20 Offset: 0x132C21 VA: 0x132B20
	[FormerlySerializedAsAttribute] // RVA: 0x132B20 Offset: 0x132C21 VA: 0x132B20
	public float m_DeadZoneDepth; // 0x8C
	[SpaceAttribute] // RVA: 0x132B80 Offset: 0x132C81 VA: 0x132B80
	[TooltipAttribute] // RVA: 0x132B80 Offset: 0x132C81 VA: 0x132B80
	public bool m_UnlimitedSoftZone; // 0x90
	[RangeAttribute] // RVA: 0x132BD0 Offset: 0x132CD1 VA: 0x132BD0
	[TooltipAttribute] // RVA: 0x132BD0 Offset: 0x132CD1 VA: 0x132BD0
	public float m_SoftZoneWidth; // 0x94
	[RangeAttribute] // RVA: 0x132C30 Offset: 0x132D31 VA: 0x132C30
	[TooltipAttribute] // RVA: 0x132C30 Offset: 0x132D31 VA: 0x132C30
	public float m_SoftZoneHeight; // 0x98
	[RangeAttribute] // RVA: 0x132C90 Offset: 0x132D91 VA: 0x132C90
	[TooltipAttribute] // RVA: 0x132C90 Offset: 0x132D91 VA: 0x132C90
	public float m_BiasX; // 0x9C
	[RangeAttribute] // RVA: 0x132CF0 Offset: 0x132DF1 VA: 0x132CF0
	[TooltipAttribute] // RVA: 0x132CF0 Offset: 0x132DF1 VA: 0x132CF0
	public float m_BiasY; // 0xA0
	[TooltipAttribute] // RVA: 0x132D50 Offset: 0x132E51 VA: 0x132D50
	public bool m_CenterOnActivate; // 0xA4
	[SpaceAttribute] // RVA: 0x132D90 Offset: 0x132E91 VA: 0x132D90
	[TooltipAttribute] // RVA: 0x132D90 Offset: 0x132E91 VA: 0x132D90
	[FormerlySerializedAsAttribute] // RVA: 0x132D90 Offset: 0x132E91 VA: 0x132D90
	public CinemachineFramingTransposer.FramingMode m_GroupFramingMode; // 0xA8
	[TooltipAttribute] // RVA: 0x132E00 Offset: 0x132F01 VA: 0x132E00
	public CinemachineFramingTransposer.AdjustmentMode m_AdjustmentMode; // 0xAC
	[TooltipAttribute] // RVA: 0x132E40 Offset: 0x132F41 VA: 0x132E40
	public float m_GroupFramingSize; // 0xB0
	[TooltipAttribute] // RVA: 0x132E80 Offset: 0x132F81 VA: 0x132E80
	public float m_MaxDollyIn; // 0xB4
	[TooltipAttribute] // RVA: 0x132EC0 Offset: 0x132FC1 VA: 0x132EC0
	public float m_MaxDollyOut; // 0xB8
	[TooltipAttribute] // RVA: 0x132F00 Offset: 0x133001 VA: 0x132F00
	public float m_MinimumDistance; // 0xBC
	[TooltipAttribute] // RVA: 0x132F40 Offset: 0x133041 VA: 0x132F40
	public float m_MaximumDistance; // 0xC0
	[RangeAttribute] // RVA: 0x132F80 Offset: 0x133081 VA: 0x132F80
	[TooltipAttribute] // RVA: 0x132F80 Offset: 0x133081 VA: 0x132F80
	public float m_MinimumFOV; // 0xC4
	[RangeAttribute] // RVA: 0x132FE0 Offset: 0x1330E1 VA: 0x132FE0
	[TooltipAttribute] // RVA: 0x132FE0 Offset: 0x1330E1 VA: 0x132FE0
	public float m_MaximumFOV; // 0xC8
	[TooltipAttribute] // RVA: 0x133040 Offset: 0x133141 VA: 0x133040
	public float m_MinimumOrthoSize; // 0xCC
	[TooltipAttribute] // RVA: 0x133080 Offset: 0x133181 VA: 0x133080
	public float m_MaximumOrthoSize; // 0xD0
	private const float kMinimumCameraDistance = 0.01;
	private const float kMinimumGroupSize = 0.01;
	private Vector3 m_PreviousCameraPosition; // 0xD4
	private PositionPredictor m_Predictor; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x1330C0 Offset: 0x1331C1 VA: 0x1330C0
	private Vector3 <TrackedPoint>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x1330D0 Offset: 0x1331D1 VA: 0x1330D0
	private bool <InheritingPosition>k__BackingField; // 0xF4
	private float m_prevFOV; // 0xF8
	private Quaternion m_prevRotation; // 0xFC
	[CompilerGeneratedAttribute] // RVA: 0x1330E0 Offset: 0x1331E1 VA: 0x1330E0
	private Bounds <LastBounds>k__BackingField; // 0x10C
	[CompilerGeneratedAttribute] // RVA: 0x1330F0 Offset: 0x1331F1 VA: 0x1330F0
	private Matrix4x4 <LastBoundsMatrix>k__BackingField; // 0x124

	// Properties
	internal Rect SoftGuideRect { get; set; }
	internal Rect HardGuideRect { get; set; }
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }
	public override bool BodyAppliesAfterAim { get; }
	public Vector3 TrackedPoint { get; set; }
	private bool InheritingPosition { get; set; }
	public Bounds LastBounds { get; set; }
	public Matrix4x4 LastBoundsMatrix { get; set; }

	// Methods

	// RVA: 0x1721F20 Offset: 0x1722021 VA: 0x1721F20
	internal Rect get_SoftGuideRect() { }

	// RVA: 0x1721F70 Offset: 0x1722071 VA: 0x1721F70
	internal void set_SoftGuideRect(Rect value) { }

	// RVA: 0x17220D0 Offset: 0x17221D1 VA: 0x17220D0
	internal Rect get_HardGuideRect() { }

	// RVA: 0x17221E0 Offset: 0x17222E1 VA: 0x17221E0
	internal void set_HardGuideRect(Rect value) { }

	// RVA: 0x1722400 Offset: 0x1722501 VA: 0x1722400
	private void OnValidate() { }

	// RVA: 0x1722560 Offset: 0x1722661 VA: 0x1722560 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x1722600 Offset: 0x1722701 VA: 0x1722600 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x1722610 Offset: 0x1722711 VA: 0x1722610 Slot: 7
	public override bool get_BodyAppliesAfterAim() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CA0 Offset: 0x136DA1 VA: 0x136CA0
	// RVA: 0x1722620 Offset: 0x1722721 VA: 0x1722620
	public Vector3 get_TrackedPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CB0 Offset: 0x136DB1 VA: 0x136CB0
	// RVA: 0x1722630 Offset: 0x1722731 VA: 0x1722630
	private void set_TrackedPoint(Vector3 value) { }

	// RVA: 0x1722640 Offset: 0x1722741 VA: 0x1722640 Slot: 10
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x17227A0 Offset: 0x17228A1 VA: 0x17227A0 Slot: 11
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x17227F0 Offset: 0x17228F1 VA: 0x17227F0 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1722890 Offset: 0x1722991 VA: 0x1722890 Slot: 9
	public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) { }

	[CompilerGeneratedAttribute] // RVA: 0x136CC0 Offset: 0x136DC1 VA: 0x136CC0
	// RVA: 0x17229B0 Offset: 0x1722AB1 VA: 0x17229B0
	private bool get_InheritingPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CD0 Offset: 0x136DD1 VA: 0x136CD0
	// RVA: 0x17229C0 Offset: 0x1722AC1 VA: 0x17229C0
	private void set_InheritingPosition(bool value) { }

	// RVA: 0x17229D0 Offset: 0x1722AD1 VA: 0x17229D0
	private Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect) { }

	// RVA: 0x1722AB0 Offset: 0x1722BB1 VA: 0x1722AB0
	private Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect) { }

	[CompilerGeneratedAttribute] // RVA: 0x136CE0 Offset: 0x136DE1 VA: 0x136CE0
	// RVA: 0x1722C00 Offset: 0x1722D01 VA: 0x1722C00
	public Bounds get_LastBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CF0 Offset: 0x136DF1 VA: 0x136CF0
	// RVA: 0x1722C30 Offset: 0x1722D31 VA: 0x1722C30
	private void set_LastBounds(Bounds value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136D00 Offset: 0x136E01 VA: 0x136D00
	// RVA: 0x1722C60 Offset: 0x1722D61 VA: 0x1722C60
	public Matrix4x4 get_LastBoundsMatrix() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D10 Offset: 0x136E11 VA: 0x136D10
	// RVA: 0x1722CC0 Offset: 0x1722DC1 VA: 0x1722CC0
	private void set_LastBoundsMatrix(Matrix4x4 value) { }

	// RVA: 0x1722CE0 Offset: 0x1722DE1 VA: 0x1722CE0 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1724430 Offset: 0x1724531 VA: 0x1724430
	private float GetTargetHeight(Vector2 boundsSize) { }

	// RVA: 0x1723E60 Offset: 0x1723F61 VA: 0x1723E60
	private Vector3 ComputeGroupBounds(ICinemachineTargetGroup group, ref CameraState curState) { }

	// RVA: 0x1724580 Offset: 0x1724681 VA: 0x1724580
	private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, ref Vector3 pos, Quaternion orientation) { }

	// RVA: 0x1724BF0 Offset: 0x1724CF1 VA: 0x1724BF0
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E9E0 Offset: 0x12EAE1 VA: 0x12E9E0
[AddComponentMenu] // RVA: 0x12E9E0 Offset: 0x12EAE1 VA: 0x12E9E0
[SaveDuringPlayAttribute] // RVA: 0x12E9E0 Offset: 0x12EAE1 VA: 0x12E9E0
public class CinemachineFramingTransposer : CinemachineComponentBase // TypeDefIndex: 4786
{
	// Fields
	[TooltipAttribute] // RVA: 0x132680 Offset: 0x132781 VA: 0x132680
	public Vector3 m_TrackedObjectOffset; // 0x50
	[TooltipAttribute] // RVA: 0x1326C0 Offset: 0x1327C1 VA: 0x1326C0
	[RangeAttribute] // RVA: 0x1326C0 Offset: 0x1327C1 VA: 0x1326C0
	[SpaceAttribute] // RVA: 0x1326C0 Offset: 0x1327C1 VA: 0x1326C0
	public float m_LookaheadTime; // 0x5C
	[TooltipAttribute] // RVA: 0x132730 Offset: 0x132831 VA: 0x132730
	[RangeAttribute] // RVA: 0x132730 Offset: 0x132831 VA: 0x132730
	public float m_LookaheadSmoothing; // 0x60
	[TooltipAttribute] // RVA: 0x132790 Offset: 0x132891 VA: 0x132790
	public bool m_LookaheadIgnoreY; // 0x64
	[SpaceAttribute] // RVA: 0x1327D0 Offset: 0x1328D1 VA: 0x1327D0
	[RangeAttribute] // RVA: 0x1327D0 Offset: 0x1328D1 VA: 0x1327D0
	[TooltipAttribute] // RVA: 0x1327D0 Offset: 0x1328D1 VA: 0x1327D0
	public float m_XDamping; // 0x68
	[RangeAttribute] // RVA: 0x132840 Offset: 0x132941 VA: 0x132840
	[TooltipAttribute] // RVA: 0x132840 Offset: 0x132941 VA: 0x132840
	public float m_YDamping; // 0x6C
	[RangeAttribute] // RVA: 0x1328A0 Offset: 0x1329A1 VA: 0x1328A0
	[TooltipAttribute] // RVA: 0x1328A0 Offset: 0x1329A1 VA: 0x1328A0
	public float m_ZDamping; // 0x70
	[TooltipAttribute] // RVA: 0x132900 Offset: 0x132A01 VA: 0x132900
	public bool m_TargetMovementOnly; // 0x74
	[SpaceAttribute] // RVA: 0x132940 Offset: 0x132A41 VA: 0x132940
	[RangeAttribute] // RVA: 0x132940 Offset: 0x132A41 VA: 0x132940
	[TooltipAttribute] // RVA: 0x132940 Offset: 0x132A41 VA: 0x132940
	public float m_ScreenX; // 0x78
	[RangeAttribute] // RVA: 0x1329B0 Offset: 0x132AB1 VA: 0x1329B0
	[TooltipAttribute] // RVA: 0x1329B0 Offset: 0x132AB1 VA: 0x1329B0
	public float m_ScreenY; // 0x7C
	[TooltipAttribute] // RVA: 0x132A10 Offset: 0x132B11 VA: 0x132A10
	public float m_CameraDistance; // 0x80
	[SpaceAttribute] // RVA: 0x132A50 Offset: 0x132B51 VA: 0x132A50
	[RangeAttribute] // RVA: 0x132A50 Offset: 0x132B51 VA: 0x132A50
	[TooltipAttribute] // RVA: 0x132A50 Offset: 0x132B51 VA: 0x132A50
	public float m_DeadZoneWidth; // 0x84
	[RangeAttribute] // RVA: 0x132AC0 Offset: 0x132BC1 VA: 0x132AC0
	[TooltipAttribute] // RVA: 0x132AC0 Offset: 0x132BC1 VA: 0x132AC0
	public float m_DeadZoneHeight; // 0x88
	[TooltipAttribute] // RVA: 0x132B20 Offset: 0x132C21 VA: 0x132B20
	[FormerlySerializedAsAttribute] // RVA: 0x132B20 Offset: 0x132C21 VA: 0x132B20
	public float m_DeadZoneDepth; // 0x8C
	[SpaceAttribute] // RVA: 0x132B80 Offset: 0x132C81 VA: 0x132B80
	[TooltipAttribute] // RVA: 0x132B80 Offset: 0x132C81 VA: 0x132B80
	public bool m_UnlimitedSoftZone; // 0x90
	[RangeAttribute] // RVA: 0x132BD0 Offset: 0x132CD1 VA: 0x132BD0
	[TooltipAttribute] // RVA: 0x132BD0 Offset: 0x132CD1 VA: 0x132BD0
	public float m_SoftZoneWidth; // 0x94
	[RangeAttribute] // RVA: 0x132C30 Offset: 0x132D31 VA: 0x132C30
	[TooltipAttribute] // RVA: 0x132C30 Offset: 0x132D31 VA: 0x132C30
	public float m_SoftZoneHeight; // 0x98
	[RangeAttribute] // RVA: 0x132C90 Offset: 0x132D91 VA: 0x132C90
	[TooltipAttribute] // RVA: 0x132C90 Offset: 0x132D91 VA: 0x132C90
	public float m_BiasX; // 0x9C
	[RangeAttribute] // RVA: 0x132CF0 Offset: 0x132DF1 VA: 0x132CF0
	[TooltipAttribute] // RVA: 0x132CF0 Offset: 0x132DF1 VA: 0x132CF0
	public float m_BiasY; // 0xA0
	[TooltipAttribute] // RVA: 0x132D50 Offset: 0x132E51 VA: 0x132D50
	public bool m_CenterOnActivate; // 0xA4
	[SpaceAttribute] // RVA: 0x132D90 Offset: 0x132E91 VA: 0x132D90
	[TooltipAttribute] // RVA: 0x132D90 Offset: 0x132E91 VA: 0x132D90
	[FormerlySerializedAsAttribute] // RVA: 0x132D90 Offset: 0x132E91 VA: 0x132D90
	public CinemachineFramingTransposer.FramingMode m_GroupFramingMode; // 0xA8
	[TooltipAttribute] // RVA: 0x132E00 Offset: 0x132F01 VA: 0x132E00
	public CinemachineFramingTransposer.AdjustmentMode m_AdjustmentMode; // 0xAC
	[TooltipAttribute] // RVA: 0x132E40 Offset: 0x132F41 VA: 0x132E40
	public float m_GroupFramingSize; // 0xB0
	[TooltipAttribute] // RVA: 0x132E80 Offset: 0x132F81 VA: 0x132E80
	public float m_MaxDollyIn; // 0xB4
	[TooltipAttribute] // RVA: 0x132EC0 Offset: 0x132FC1 VA: 0x132EC0
	public float m_MaxDollyOut; // 0xB8
	[TooltipAttribute] // RVA: 0x132F00 Offset: 0x133001 VA: 0x132F00
	public float m_MinimumDistance; // 0xBC
	[TooltipAttribute] // RVA: 0x132F40 Offset: 0x133041 VA: 0x132F40
	public float m_MaximumDistance; // 0xC0
	[RangeAttribute] // RVA: 0x132F80 Offset: 0x133081 VA: 0x132F80
	[TooltipAttribute] // RVA: 0x132F80 Offset: 0x133081 VA: 0x132F80
	public float m_MinimumFOV; // 0xC4
	[RangeAttribute] // RVA: 0x132FE0 Offset: 0x1330E1 VA: 0x132FE0
	[TooltipAttribute] // RVA: 0x132FE0 Offset: 0x1330E1 VA: 0x132FE0
	public float m_MaximumFOV; // 0xC8
	[TooltipAttribute] // RVA: 0x133040 Offset: 0x133141 VA: 0x133040
	public float m_MinimumOrthoSize; // 0xCC
	[TooltipAttribute] // RVA: 0x133080 Offset: 0x133181 VA: 0x133080
	public float m_MaximumOrthoSize; // 0xD0
	private const float kMinimumCameraDistance = 0.01;
	private const float kMinimumGroupSize = 0.01;
	private Vector3 m_PreviousCameraPosition; // 0xD4
	private PositionPredictor m_Predictor; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x1330C0 Offset: 0x1331C1 VA: 0x1330C0
	private Vector3 <TrackedPoint>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x1330D0 Offset: 0x1331D1 VA: 0x1330D0
	private bool <InheritingPosition>k__BackingField; // 0xF4
	private float m_prevFOV; // 0xF8
	private Quaternion m_prevRotation; // 0xFC
	[CompilerGeneratedAttribute] // RVA: 0x1330E0 Offset: 0x1331E1 VA: 0x1330E0
	private Bounds <LastBounds>k__BackingField; // 0x10C
	[CompilerGeneratedAttribute] // RVA: 0x1330F0 Offset: 0x1331F1 VA: 0x1330F0
	private Matrix4x4 <LastBoundsMatrix>k__BackingField; // 0x124

	// Properties
	internal Rect SoftGuideRect { get; set; }
	internal Rect HardGuideRect { get; set; }
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }
	public override bool BodyAppliesAfterAim { get; }
	public Vector3 TrackedPoint { get; set; }
	private bool InheritingPosition { get; set; }
	public Bounds LastBounds { get; set; }
	public Matrix4x4 LastBoundsMatrix { get; set; }

	// Methods

	// RVA: 0x1721F20 Offset: 0x1722021 VA: 0x1721F20
	internal Rect get_SoftGuideRect() { }

	// RVA: 0x1721F70 Offset: 0x1722071 VA: 0x1721F70
	internal void set_SoftGuideRect(Rect value) { }

	// RVA: 0x17220D0 Offset: 0x17221D1 VA: 0x17220D0
	internal Rect get_HardGuideRect() { }

	// RVA: 0x17221E0 Offset: 0x17222E1 VA: 0x17221E0
	internal void set_HardGuideRect(Rect value) { }

	// RVA: 0x1722400 Offset: 0x1722501 VA: 0x1722400
	private void OnValidate() { }

	// RVA: 0x1722560 Offset: 0x1722661 VA: 0x1722560 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x1722600 Offset: 0x1722701 VA: 0x1722600 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x1722610 Offset: 0x1722711 VA: 0x1722610 Slot: 7
	public override bool get_BodyAppliesAfterAim() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CA0 Offset: 0x136DA1 VA: 0x136CA0
	// RVA: 0x1722620 Offset: 0x1722721 VA: 0x1722620
	public Vector3 get_TrackedPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CB0 Offset: 0x136DB1 VA: 0x136CB0
	// RVA: 0x1722630 Offset: 0x1722731 VA: 0x1722630
	private void set_TrackedPoint(Vector3 value) { }

	// RVA: 0x1722640 Offset: 0x1722741 VA: 0x1722640 Slot: 10
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x17227A0 Offset: 0x17228A1 VA: 0x17227A0 Slot: 11
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x17227F0 Offset: 0x17228F1 VA: 0x17227F0 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1722890 Offset: 0x1722991 VA: 0x1722890 Slot: 9
	public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) { }

	[CompilerGeneratedAttribute] // RVA: 0x136CC0 Offset: 0x136DC1 VA: 0x136CC0
	// RVA: 0x17229B0 Offset: 0x1722AB1 VA: 0x17229B0
	private bool get_InheritingPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CD0 Offset: 0x136DD1 VA: 0x136CD0
	// RVA: 0x17229C0 Offset: 0x1722AC1 VA: 0x17229C0
	private void set_InheritingPosition(bool value) { }

	// RVA: 0x17229D0 Offset: 0x1722AD1 VA: 0x17229D0
	private Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect) { }

	// RVA: 0x1722AB0 Offset: 0x1722BB1 VA: 0x1722AB0
	private Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect) { }

	[CompilerGeneratedAttribute] // RVA: 0x136CE0 Offset: 0x136DE1 VA: 0x136CE0
	// RVA: 0x1722C00 Offset: 0x1722D01 VA: 0x1722C00
	public Bounds get_LastBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CF0 Offset: 0x136DF1 VA: 0x136CF0
	// RVA: 0x1722C30 Offset: 0x1722D31 VA: 0x1722C30
	private void set_LastBounds(Bounds value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136D00 Offset: 0x136E01 VA: 0x136D00
	// RVA: 0x1722C60 Offset: 0x1722D61 VA: 0x1722C60
	public Matrix4x4 get_LastBoundsMatrix() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D10 Offset: 0x136E11 VA: 0x136D10
	// RVA: 0x1722CC0 Offset: 0x1722DC1 VA: 0x1722CC0
	private void set_LastBoundsMatrix(Matrix4x4 value) { }

	// RVA: 0x1722CE0 Offset: 0x1722DE1 VA: 0x1722CE0 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1724430 Offset: 0x1724531 VA: 0x1724430
	private float GetTargetHeight(Vector2 boundsSize) { }

	// RVA: 0x1723E60 Offset: 0x1723F61 VA: 0x1723E60
	private Vector3 ComputeGroupBounds(ICinemachineTargetGroup group, ref CameraState curState) { }

	// RVA: 0x1724580 Offset: 0x1724681 VA: 0x1724580
	private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, ref Vector3 pos, Quaternion orientation) { }

	// RVA: 0x1724BF0 Offset: 0x1724CF1 VA: 0x1724BF0
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E9E0 Offset: 0x12EAE1 VA: 0x12E9E0
[AddComponentMenu] // RVA: 0x12E9E0 Offset: 0x12EAE1 VA: 0x12E9E0
[SaveDuringPlayAttribute] // RVA: 0x12E9E0 Offset: 0x12EAE1 VA: 0x12E9E0
public class CinemachineFramingTransposer : CinemachineComponentBase // TypeDefIndex: 4786
{
	// Fields
	[TooltipAttribute] // RVA: 0x132680 Offset: 0x132781 VA: 0x132680
	public Vector3 m_TrackedObjectOffset; // 0x50
	[TooltipAttribute] // RVA: 0x1326C0 Offset: 0x1327C1 VA: 0x1326C0
	[RangeAttribute] // RVA: 0x1326C0 Offset: 0x1327C1 VA: 0x1326C0
	[SpaceAttribute] // RVA: 0x1326C0 Offset: 0x1327C1 VA: 0x1326C0
	public float m_LookaheadTime; // 0x5C
	[TooltipAttribute] // RVA: 0x132730 Offset: 0x132831 VA: 0x132730
	[RangeAttribute] // RVA: 0x132730 Offset: 0x132831 VA: 0x132730
	public float m_LookaheadSmoothing; // 0x60
	[TooltipAttribute] // RVA: 0x132790 Offset: 0x132891 VA: 0x132790
	public bool m_LookaheadIgnoreY; // 0x64
	[SpaceAttribute] // RVA: 0x1327D0 Offset: 0x1328D1 VA: 0x1327D0
	[RangeAttribute] // RVA: 0x1327D0 Offset: 0x1328D1 VA: 0x1327D0
	[TooltipAttribute] // RVA: 0x1327D0 Offset: 0x1328D1 VA: 0x1327D0
	public float m_XDamping; // 0x68
	[RangeAttribute] // RVA: 0x132840 Offset: 0x132941 VA: 0x132840
	[TooltipAttribute] // RVA: 0x132840 Offset: 0x132941 VA: 0x132840
	public float m_YDamping; // 0x6C
	[RangeAttribute] // RVA: 0x1328A0 Offset: 0x1329A1 VA: 0x1328A0
	[TooltipAttribute] // RVA: 0x1328A0 Offset: 0x1329A1 VA: 0x1328A0
	public float m_ZDamping; // 0x70
	[TooltipAttribute] // RVA: 0x132900 Offset: 0x132A01 VA: 0x132900
	public bool m_TargetMovementOnly; // 0x74
	[SpaceAttribute] // RVA: 0x132940 Offset: 0x132A41 VA: 0x132940
	[RangeAttribute] // RVA: 0x132940 Offset: 0x132A41 VA: 0x132940
	[TooltipAttribute] // RVA: 0x132940 Offset: 0x132A41 VA: 0x132940
	public float m_ScreenX; // 0x78
	[RangeAttribute] // RVA: 0x1329B0 Offset: 0x132AB1 VA: 0x1329B0
	[TooltipAttribute] // RVA: 0x1329B0 Offset: 0x132AB1 VA: 0x1329B0
	public float m_ScreenY; // 0x7C
	[TooltipAttribute] // RVA: 0x132A10 Offset: 0x132B11 VA: 0x132A10
	public float m_CameraDistance; // 0x80
	[SpaceAttribute] // RVA: 0x132A50 Offset: 0x132B51 VA: 0x132A50
	[RangeAttribute] // RVA: 0x132A50 Offset: 0x132B51 VA: 0x132A50
	[TooltipAttribute] // RVA: 0x132A50 Offset: 0x132B51 VA: 0x132A50
	public float m_DeadZoneWidth; // 0x84
	[RangeAttribute] // RVA: 0x132AC0 Offset: 0x132BC1 VA: 0x132AC0
	[TooltipAttribute] // RVA: 0x132AC0 Offset: 0x132BC1 VA: 0x132AC0
	public float m_DeadZoneHeight; // 0x88
	[TooltipAttribute] // RVA: 0x132B20 Offset: 0x132C21 VA: 0x132B20
	[FormerlySerializedAsAttribute] // RVA: 0x132B20 Offset: 0x132C21 VA: 0x132B20
	public float m_DeadZoneDepth; // 0x8C
	[SpaceAttribute] // RVA: 0x132B80 Offset: 0x132C81 VA: 0x132B80
	[TooltipAttribute] // RVA: 0x132B80 Offset: 0x132C81 VA: 0x132B80
	public bool m_UnlimitedSoftZone; // 0x90
	[RangeAttribute] // RVA: 0x132BD0 Offset: 0x132CD1 VA: 0x132BD0
	[TooltipAttribute] // RVA: 0x132BD0 Offset: 0x132CD1 VA: 0x132BD0
	public float m_SoftZoneWidth; // 0x94
	[RangeAttribute] // RVA: 0x132C30 Offset: 0x132D31 VA: 0x132C30
	[TooltipAttribute] // RVA: 0x132C30 Offset: 0x132D31 VA: 0x132C30
	public float m_SoftZoneHeight; // 0x98
	[RangeAttribute] // RVA: 0x132C90 Offset: 0x132D91 VA: 0x132C90
	[TooltipAttribute] // RVA: 0x132C90 Offset: 0x132D91 VA: 0x132C90
	public float m_BiasX; // 0x9C
	[RangeAttribute] // RVA: 0x132CF0 Offset: 0x132DF1 VA: 0x132CF0
	[TooltipAttribute] // RVA: 0x132CF0 Offset: 0x132DF1 VA: 0x132CF0
	public float m_BiasY; // 0xA0
	[TooltipAttribute] // RVA: 0x132D50 Offset: 0x132E51 VA: 0x132D50
	public bool m_CenterOnActivate; // 0xA4
	[SpaceAttribute] // RVA: 0x132D90 Offset: 0x132E91 VA: 0x132D90
	[TooltipAttribute] // RVA: 0x132D90 Offset: 0x132E91 VA: 0x132D90
	[FormerlySerializedAsAttribute] // RVA: 0x132D90 Offset: 0x132E91 VA: 0x132D90
	public CinemachineFramingTransposer.FramingMode m_GroupFramingMode; // 0xA8
	[TooltipAttribute] // RVA: 0x132E00 Offset: 0x132F01 VA: 0x132E00
	public CinemachineFramingTransposer.AdjustmentMode m_AdjustmentMode; // 0xAC
	[TooltipAttribute] // RVA: 0x132E40 Offset: 0x132F41 VA: 0x132E40
	public float m_GroupFramingSize; // 0xB0
	[TooltipAttribute] // RVA: 0x132E80 Offset: 0x132F81 VA: 0x132E80
	public float m_MaxDollyIn; // 0xB4
	[TooltipAttribute] // RVA: 0x132EC0 Offset: 0x132FC1 VA: 0x132EC0
	public float m_MaxDollyOut; // 0xB8
	[TooltipAttribute] // RVA: 0x132F00 Offset: 0x133001 VA: 0x132F00
	public float m_MinimumDistance; // 0xBC
	[TooltipAttribute] // RVA: 0x132F40 Offset: 0x133041 VA: 0x132F40
	public float m_MaximumDistance; // 0xC0
	[RangeAttribute] // RVA: 0x132F80 Offset: 0x133081 VA: 0x132F80
	[TooltipAttribute] // RVA: 0x132F80 Offset: 0x133081 VA: 0x132F80
	public float m_MinimumFOV; // 0xC4
	[RangeAttribute] // RVA: 0x132FE0 Offset: 0x1330E1 VA: 0x132FE0
	[TooltipAttribute] // RVA: 0x132FE0 Offset: 0x1330E1 VA: 0x132FE0
	public float m_MaximumFOV; // 0xC8
	[TooltipAttribute] // RVA: 0x133040 Offset: 0x133141 VA: 0x133040
	public float m_MinimumOrthoSize; // 0xCC
	[TooltipAttribute] // RVA: 0x133080 Offset: 0x133181 VA: 0x133080
	public float m_MaximumOrthoSize; // 0xD0
	private const float kMinimumCameraDistance = 0.01;
	private const float kMinimumGroupSize = 0.01;
	private Vector3 m_PreviousCameraPosition; // 0xD4
	private PositionPredictor m_Predictor; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x1330C0 Offset: 0x1331C1 VA: 0x1330C0
	private Vector3 <TrackedPoint>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x1330D0 Offset: 0x1331D1 VA: 0x1330D0
	private bool <InheritingPosition>k__BackingField; // 0xF4
	private float m_prevFOV; // 0xF8
	private Quaternion m_prevRotation; // 0xFC
	[CompilerGeneratedAttribute] // RVA: 0x1330E0 Offset: 0x1331E1 VA: 0x1330E0
	private Bounds <LastBounds>k__BackingField; // 0x10C
	[CompilerGeneratedAttribute] // RVA: 0x1330F0 Offset: 0x1331F1 VA: 0x1330F0
	private Matrix4x4 <LastBoundsMatrix>k__BackingField; // 0x124

	// Properties
	internal Rect SoftGuideRect { get; set; }
	internal Rect HardGuideRect { get; set; }
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }
	public override bool BodyAppliesAfterAim { get; }
	public Vector3 TrackedPoint { get; set; }
	private bool InheritingPosition { get; set; }
	public Bounds LastBounds { get; set; }
	public Matrix4x4 LastBoundsMatrix { get; set; }

	// Methods

	// RVA: 0x1721F20 Offset: 0x1722021 VA: 0x1721F20
	internal Rect get_SoftGuideRect() { }

	// RVA: 0x1721F70 Offset: 0x1722071 VA: 0x1721F70
	internal void set_SoftGuideRect(Rect value) { }

	// RVA: 0x17220D0 Offset: 0x17221D1 VA: 0x17220D0
	internal Rect get_HardGuideRect() { }

	// RVA: 0x17221E0 Offset: 0x17222E1 VA: 0x17221E0
	internal void set_HardGuideRect(Rect value) { }

	// RVA: 0x1722400 Offset: 0x1722501 VA: 0x1722400
	private void OnValidate() { }

	// RVA: 0x1722560 Offset: 0x1722661 VA: 0x1722560 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x1722600 Offset: 0x1722701 VA: 0x1722600 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x1722610 Offset: 0x1722711 VA: 0x1722610 Slot: 7
	public override bool get_BodyAppliesAfterAim() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CA0 Offset: 0x136DA1 VA: 0x136CA0
	// RVA: 0x1722620 Offset: 0x1722721 VA: 0x1722620
	public Vector3 get_TrackedPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CB0 Offset: 0x136DB1 VA: 0x136CB0
	// RVA: 0x1722630 Offset: 0x1722731 VA: 0x1722630
	private void set_TrackedPoint(Vector3 value) { }

	// RVA: 0x1722640 Offset: 0x1722741 VA: 0x1722640 Slot: 10
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x17227A0 Offset: 0x17228A1 VA: 0x17227A0 Slot: 11
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x17227F0 Offset: 0x17228F1 VA: 0x17227F0 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1722890 Offset: 0x1722991 VA: 0x1722890 Slot: 9
	public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) { }

	[CompilerGeneratedAttribute] // RVA: 0x136CC0 Offset: 0x136DC1 VA: 0x136CC0
	// RVA: 0x17229B0 Offset: 0x1722AB1 VA: 0x17229B0
	private bool get_InheritingPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CD0 Offset: 0x136DD1 VA: 0x136CD0
	// RVA: 0x17229C0 Offset: 0x1722AC1 VA: 0x17229C0
	private void set_InheritingPosition(bool value) { }

	// RVA: 0x17229D0 Offset: 0x1722AD1 VA: 0x17229D0
	private Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect) { }

	// RVA: 0x1722AB0 Offset: 0x1722BB1 VA: 0x1722AB0
	private Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect) { }

	[CompilerGeneratedAttribute] // RVA: 0x136CE0 Offset: 0x136DE1 VA: 0x136CE0
	// RVA: 0x1722C00 Offset: 0x1722D01 VA: 0x1722C00
	public Bounds get_LastBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CF0 Offset: 0x136DF1 VA: 0x136CF0
	// RVA: 0x1722C30 Offset: 0x1722D31 VA: 0x1722C30
	private void set_LastBounds(Bounds value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136D00 Offset: 0x136E01 VA: 0x136D00
	// RVA: 0x1722C60 Offset: 0x1722D61 VA: 0x1722C60
	public Matrix4x4 get_LastBoundsMatrix() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D10 Offset: 0x136E11 VA: 0x136D10
	// RVA: 0x1722CC0 Offset: 0x1722DC1 VA: 0x1722CC0
	private void set_LastBoundsMatrix(Matrix4x4 value) { }

	// RVA: 0x1722CE0 Offset: 0x1722DE1 VA: 0x1722CE0 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1724430 Offset: 0x1724531 VA: 0x1724430
	private float GetTargetHeight(Vector2 boundsSize) { }

	// RVA: 0x1723E60 Offset: 0x1723F61 VA: 0x1723E60
	private Vector3 ComputeGroupBounds(ICinemachineTargetGroup group, ref CameraState curState) { }

	// RVA: 0x1724580 Offset: 0x1724681 VA: 0x1724580
	private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, ref Vector3 pos, Quaternion orientation) { }

	// RVA: 0x1724BF0 Offset: 0x1724CF1 VA: 0x1724BF0
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E9E0 Offset: 0x12EAE1 VA: 0x12E9E0
[AddComponentMenu] // RVA: 0x12E9E0 Offset: 0x12EAE1 VA: 0x12E9E0
[SaveDuringPlayAttribute] // RVA: 0x12E9E0 Offset: 0x12EAE1 VA: 0x12E9E0
public class CinemachineFramingTransposer : CinemachineComponentBase // TypeDefIndex: 4786
{
	// Fields
	[TooltipAttribute] // RVA: 0x132680 Offset: 0x132781 VA: 0x132680
	public Vector3 m_TrackedObjectOffset; // 0x50
	[TooltipAttribute] // RVA: 0x1326C0 Offset: 0x1327C1 VA: 0x1326C0
	[RangeAttribute] // RVA: 0x1326C0 Offset: 0x1327C1 VA: 0x1326C0
	[SpaceAttribute] // RVA: 0x1326C0 Offset: 0x1327C1 VA: 0x1326C0
	public float m_LookaheadTime; // 0x5C
	[TooltipAttribute] // RVA: 0x132730 Offset: 0x132831 VA: 0x132730
	[RangeAttribute] // RVA: 0x132730 Offset: 0x132831 VA: 0x132730
	public float m_LookaheadSmoothing; // 0x60
	[TooltipAttribute] // RVA: 0x132790 Offset: 0x132891 VA: 0x132790
	public bool m_LookaheadIgnoreY; // 0x64
	[SpaceAttribute] // RVA: 0x1327D0 Offset: 0x1328D1 VA: 0x1327D0
	[RangeAttribute] // RVA: 0x1327D0 Offset: 0x1328D1 VA: 0x1327D0
	[TooltipAttribute] // RVA: 0x1327D0 Offset: 0x1328D1 VA: 0x1327D0
	public float m_XDamping; // 0x68
	[RangeAttribute] // RVA: 0x132840 Offset: 0x132941 VA: 0x132840
	[TooltipAttribute] // RVA: 0x132840 Offset: 0x132941 VA: 0x132840
	public float m_YDamping; // 0x6C
	[RangeAttribute] // RVA: 0x1328A0 Offset: 0x1329A1 VA: 0x1328A0
	[TooltipAttribute] // RVA: 0x1328A0 Offset: 0x1329A1 VA: 0x1328A0
	public float m_ZDamping; // 0x70
	[TooltipAttribute] // RVA: 0x132900 Offset: 0x132A01 VA: 0x132900
	public bool m_TargetMovementOnly; // 0x74
	[SpaceAttribute] // RVA: 0x132940 Offset: 0x132A41 VA: 0x132940
	[RangeAttribute] // RVA: 0x132940 Offset: 0x132A41 VA: 0x132940
	[TooltipAttribute] // RVA: 0x132940 Offset: 0x132A41 VA: 0x132940
	public float m_ScreenX; // 0x78
	[RangeAttribute] // RVA: 0x1329B0 Offset: 0x132AB1 VA: 0x1329B0
	[TooltipAttribute] // RVA: 0x1329B0 Offset: 0x132AB1 VA: 0x1329B0
	public float m_ScreenY; // 0x7C
	[TooltipAttribute] // RVA: 0x132A10 Offset: 0x132B11 VA: 0x132A10
	public float m_CameraDistance; // 0x80
	[SpaceAttribute] // RVA: 0x132A50 Offset: 0x132B51 VA: 0x132A50
	[RangeAttribute] // RVA: 0x132A50 Offset: 0x132B51 VA: 0x132A50
	[TooltipAttribute] // RVA: 0x132A50 Offset: 0x132B51 VA: 0x132A50
	public float m_DeadZoneWidth; // 0x84
	[RangeAttribute] // RVA: 0x132AC0 Offset: 0x132BC1 VA: 0x132AC0
	[TooltipAttribute] // RVA: 0x132AC0 Offset: 0x132BC1 VA: 0x132AC0
	public float m_DeadZoneHeight; // 0x88
	[TooltipAttribute] // RVA: 0x132B20 Offset: 0x132C21 VA: 0x132B20
	[FormerlySerializedAsAttribute] // RVA: 0x132B20 Offset: 0x132C21 VA: 0x132B20
	public float m_DeadZoneDepth; // 0x8C
	[SpaceAttribute] // RVA: 0x132B80 Offset: 0x132C81 VA: 0x132B80
	[TooltipAttribute] // RVA: 0x132B80 Offset: 0x132C81 VA: 0x132B80
	public bool m_UnlimitedSoftZone; // 0x90
	[RangeAttribute] // RVA: 0x132BD0 Offset: 0x132CD1 VA: 0x132BD0
	[TooltipAttribute] // RVA: 0x132BD0 Offset: 0x132CD1 VA: 0x132BD0
	public float m_SoftZoneWidth; // 0x94
	[RangeAttribute] // RVA: 0x132C30 Offset: 0x132D31 VA: 0x132C30
	[TooltipAttribute] // RVA: 0x132C30 Offset: 0x132D31 VA: 0x132C30
	public float m_SoftZoneHeight; // 0x98
	[RangeAttribute] // RVA: 0x132C90 Offset: 0x132D91 VA: 0x132C90
	[TooltipAttribute] // RVA: 0x132C90 Offset: 0x132D91 VA: 0x132C90
	public float m_BiasX; // 0x9C
	[RangeAttribute] // RVA: 0x132CF0 Offset: 0x132DF1 VA: 0x132CF0
	[TooltipAttribute] // RVA: 0x132CF0 Offset: 0x132DF1 VA: 0x132CF0
	public float m_BiasY; // 0xA0
	[TooltipAttribute] // RVA: 0x132D50 Offset: 0x132E51 VA: 0x132D50
	public bool m_CenterOnActivate; // 0xA4
	[SpaceAttribute] // RVA: 0x132D90 Offset: 0x132E91 VA: 0x132D90
	[TooltipAttribute] // RVA: 0x132D90 Offset: 0x132E91 VA: 0x132D90
	[FormerlySerializedAsAttribute] // RVA: 0x132D90 Offset: 0x132E91 VA: 0x132D90
	public CinemachineFramingTransposer.FramingMode m_GroupFramingMode; // 0xA8
	[TooltipAttribute] // RVA: 0x132E00 Offset: 0x132F01 VA: 0x132E00
	public CinemachineFramingTransposer.AdjustmentMode m_AdjustmentMode; // 0xAC
	[TooltipAttribute] // RVA: 0x132E40 Offset: 0x132F41 VA: 0x132E40
	public float m_GroupFramingSize; // 0xB0
	[TooltipAttribute] // RVA: 0x132E80 Offset: 0x132F81 VA: 0x132E80
	public float m_MaxDollyIn; // 0xB4
	[TooltipAttribute] // RVA: 0x132EC0 Offset: 0x132FC1 VA: 0x132EC0
	public float m_MaxDollyOut; // 0xB8
	[TooltipAttribute] // RVA: 0x132F00 Offset: 0x133001 VA: 0x132F00
	public float m_MinimumDistance; // 0xBC
	[TooltipAttribute] // RVA: 0x132F40 Offset: 0x133041 VA: 0x132F40
	public float m_MaximumDistance; // 0xC0
	[RangeAttribute] // RVA: 0x132F80 Offset: 0x133081 VA: 0x132F80
	[TooltipAttribute] // RVA: 0x132F80 Offset: 0x133081 VA: 0x132F80
	public float m_MinimumFOV; // 0xC4
	[RangeAttribute] // RVA: 0x132FE0 Offset: 0x1330E1 VA: 0x132FE0
	[TooltipAttribute] // RVA: 0x132FE0 Offset: 0x1330E1 VA: 0x132FE0
	public float m_MaximumFOV; // 0xC8
	[TooltipAttribute] // RVA: 0x133040 Offset: 0x133141 VA: 0x133040
	public float m_MinimumOrthoSize; // 0xCC
	[TooltipAttribute] // RVA: 0x133080 Offset: 0x133181 VA: 0x133080
	public float m_MaximumOrthoSize; // 0xD0
	private const float kMinimumCameraDistance = 0.01;
	private const float kMinimumGroupSize = 0.01;
	private Vector3 m_PreviousCameraPosition; // 0xD4
	private PositionPredictor m_Predictor; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x1330C0 Offset: 0x1331C1 VA: 0x1330C0
	private Vector3 <TrackedPoint>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x1330D0 Offset: 0x1331D1 VA: 0x1330D0
	private bool <InheritingPosition>k__BackingField; // 0xF4
	private float m_prevFOV; // 0xF8
	private Quaternion m_prevRotation; // 0xFC
	[CompilerGeneratedAttribute] // RVA: 0x1330E0 Offset: 0x1331E1 VA: 0x1330E0
	private Bounds <LastBounds>k__BackingField; // 0x10C
	[CompilerGeneratedAttribute] // RVA: 0x1330F0 Offset: 0x1331F1 VA: 0x1330F0
	private Matrix4x4 <LastBoundsMatrix>k__BackingField; // 0x124

	// Properties
	internal Rect SoftGuideRect { get; set; }
	internal Rect HardGuideRect { get; set; }
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }
	public override bool BodyAppliesAfterAim { get; }
	public Vector3 TrackedPoint { get; set; }
	private bool InheritingPosition { get; set; }
	public Bounds LastBounds { get; set; }
	public Matrix4x4 LastBoundsMatrix { get; set; }

	// Methods

	// RVA: 0x1721F20 Offset: 0x1722021 VA: 0x1721F20
	internal Rect get_SoftGuideRect() { }

	// RVA: 0x1721F70 Offset: 0x1722071 VA: 0x1721F70
	internal void set_SoftGuideRect(Rect value) { }

	// RVA: 0x17220D0 Offset: 0x17221D1 VA: 0x17220D0
	internal Rect get_HardGuideRect() { }

	// RVA: 0x17221E0 Offset: 0x17222E1 VA: 0x17221E0
	internal void set_HardGuideRect(Rect value) { }

	// RVA: 0x1722400 Offset: 0x1722501 VA: 0x1722400
	private void OnValidate() { }

	// RVA: 0x1722560 Offset: 0x1722661 VA: 0x1722560 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x1722600 Offset: 0x1722701 VA: 0x1722600 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x1722610 Offset: 0x1722711 VA: 0x1722610 Slot: 7
	public override bool get_BodyAppliesAfterAim() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CA0 Offset: 0x136DA1 VA: 0x136CA0
	// RVA: 0x1722620 Offset: 0x1722721 VA: 0x1722620
	public Vector3 get_TrackedPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CB0 Offset: 0x136DB1 VA: 0x136CB0
	// RVA: 0x1722630 Offset: 0x1722731 VA: 0x1722630
	private void set_TrackedPoint(Vector3 value) { }

	// RVA: 0x1722640 Offset: 0x1722741 VA: 0x1722640 Slot: 10
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x17227A0 Offset: 0x17228A1 VA: 0x17227A0 Slot: 11
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x17227F0 Offset: 0x17228F1 VA: 0x17227F0 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1722890 Offset: 0x1722991 VA: 0x1722890 Slot: 9
	public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) { }

	[CompilerGeneratedAttribute] // RVA: 0x136CC0 Offset: 0x136DC1 VA: 0x136CC0
	// RVA: 0x17229B0 Offset: 0x1722AB1 VA: 0x17229B0
	private bool get_InheritingPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CD0 Offset: 0x136DD1 VA: 0x136CD0
	// RVA: 0x17229C0 Offset: 0x1722AC1 VA: 0x17229C0
	private void set_InheritingPosition(bool value) { }

	// RVA: 0x17229D0 Offset: 0x1722AD1 VA: 0x17229D0
	private Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect) { }

	// RVA: 0x1722AB0 Offset: 0x1722BB1 VA: 0x1722AB0
	private Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect) { }

	[CompilerGeneratedAttribute] // RVA: 0x136CE0 Offset: 0x136DE1 VA: 0x136CE0
	// RVA: 0x1722C00 Offset: 0x1722D01 VA: 0x1722C00
	public Bounds get_LastBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CF0 Offset: 0x136DF1 VA: 0x136CF0
	// RVA: 0x1722C30 Offset: 0x1722D31 VA: 0x1722C30
	private void set_LastBounds(Bounds value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136D00 Offset: 0x136E01 VA: 0x136D00
	// RVA: 0x1722C60 Offset: 0x1722D61 VA: 0x1722C60
	public Matrix4x4 get_LastBoundsMatrix() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D10 Offset: 0x136E11 VA: 0x136D10
	// RVA: 0x1722CC0 Offset: 0x1722DC1 VA: 0x1722CC0
	private void set_LastBoundsMatrix(Matrix4x4 value) { }

	// RVA: 0x1722CE0 Offset: 0x1722DE1 VA: 0x1722CE0 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1724430 Offset: 0x1724531 VA: 0x1724430
	private float GetTargetHeight(Vector2 boundsSize) { }

	// RVA: 0x1723E60 Offset: 0x1723F61 VA: 0x1723E60
	private Vector3 ComputeGroupBounds(ICinemachineTargetGroup group, ref CameraState curState) { }

	// RVA: 0x1724580 Offset: 0x1724681 VA: 0x1724580
	private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, ref Vector3 pos, Quaternion orientation) { }

	// RVA: 0x1724BF0 Offset: 0x1724CF1 VA: 0x1724BF0
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E9E0 Offset: 0x12EAE1 VA: 0x12E9E0
[AddComponentMenu] // RVA: 0x12E9E0 Offset: 0x12EAE1 VA: 0x12E9E0
[SaveDuringPlayAttribute] // RVA: 0x12E9E0 Offset: 0x12EAE1 VA: 0x12E9E0
public class CinemachineFramingTransposer : CinemachineComponentBase // TypeDefIndex: 4786
{
	// Fields
	[TooltipAttribute] // RVA: 0x132680 Offset: 0x132781 VA: 0x132680
	public Vector3 m_TrackedObjectOffset; // 0x50
	[TooltipAttribute] // RVA: 0x1326C0 Offset: 0x1327C1 VA: 0x1326C0
	[RangeAttribute] // RVA: 0x1326C0 Offset: 0x1327C1 VA: 0x1326C0
	[SpaceAttribute] // RVA: 0x1326C0 Offset: 0x1327C1 VA: 0x1326C0
	public float m_LookaheadTime; // 0x5C
	[TooltipAttribute] // RVA: 0x132730 Offset: 0x132831 VA: 0x132730
	[RangeAttribute] // RVA: 0x132730 Offset: 0x132831 VA: 0x132730
	public float m_LookaheadSmoothing; // 0x60
	[TooltipAttribute] // RVA: 0x132790 Offset: 0x132891 VA: 0x132790
	public bool m_LookaheadIgnoreY; // 0x64
	[SpaceAttribute] // RVA: 0x1327D0 Offset: 0x1328D1 VA: 0x1327D0
	[RangeAttribute] // RVA: 0x1327D0 Offset: 0x1328D1 VA: 0x1327D0
	[TooltipAttribute] // RVA: 0x1327D0 Offset: 0x1328D1 VA: 0x1327D0
	public float m_XDamping; // 0x68
	[RangeAttribute] // RVA: 0x132840 Offset: 0x132941 VA: 0x132840
	[TooltipAttribute] // RVA: 0x132840 Offset: 0x132941 VA: 0x132840
	public float m_YDamping; // 0x6C
	[RangeAttribute] // RVA: 0x1328A0 Offset: 0x1329A1 VA: 0x1328A0
	[TooltipAttribute] // RVA: 0x1328A0 Offset: 0x1329A1 VA: 0x1328A0
	public float m_ZDamping; // 0x70
	[TooltipAttribute] // RVA: 0x132900 Offset: 0x132A01 VA: 0x132900
	public bool m_TargetMovementOnly; // 0x74
	[SpaceAttribute] // RVA: 0x132940 Offset: 0x132A41 VA: 0x132940
	[RangeAttribute] // RVA: 0x132940 Offset: 0x132A41 VA: 0x132940
	[TooltipAttribute] // RVA: 0x132940 Offset: 0x132A41 VA: 0x132940
	public float m_ScreenX; // 0x78
	[RangeAttribute] // RVA: 0x1329B0 Offset: 0x132AB1 VA: 0x1329B0
	[TooltipAttribute] // RVA: 0x1329B0 Offset: 0x132AB1 VA: 0x1329B0
	public float m_ScreenY; // 0x7C
	[TooltipAttribute] // RVA: 0x132A10 Offset: 0x132B11 VA: 0x132A10
	public float m_CameraDistance; // 0x80
	[SpaceAttribute] // RVA: 0x132A50 Offset: 0x132B51 VA: 0x132A50
	[RangeAttribute] // RVA: 0x132A50 Offset: 0x132B51 VA: 0x132A50
	[TooltipAttribute] // RVA: 0x132A50 Offset: 0x132B51 VA: 0x132A50
	public float m_DeadZoneWidth; // 0x84
	[RangeAttribute] // RVA: 0x132AC0 Offset: 0x132BC1 VA: 0x132AC0
	[TooltipAttribute] // RVA: 0x132AC0 Offset: 0x132BC1 VA: 0x132AC0
	public float m_DeadZoneHeight; // 0x88
	[TooltipAttribute] // RVA: 0x132B20 Offset: 0x132C21 VA: 0x132B20
	[FormerlySerializedAsAttribute] // RVA: 0x132B20 Offset: 0x132C21 VA: 0x132B20
	public float m_DeadZoneDepth; // 0x8C
	[SpaceAttribute] // RVA: 0x132B80 Offset: 0x132C81 VA: 0x132B80
	[TooltipAttribute] // RVA: 0x132B80 Offset: 0x132C81 VA: 0x132B80
	public bool m_UnlimitedSoftZone; // 0x90
	[RangeAttribute] // RVA: 0x132BD0 Offset: 0x132CD1 VA: 0x132BD0
	[TooltipAttribute] // RVA: 0x132BD0 Offset: 0x132CD1 VA: 0x132BD0
	public float m_SoftZoneWidth; // 0x94
	[RangeAttribute] // RVA: 0x132C30 Offset: 0x132D31 VA: 0x132C30
	[TooltipAttribute] // RVA: 0x132C30 Offset: 0x132D31 VA: 0x132C30
	public float m_SoftZoneHeight; // 0x98
	[RangeAttribute] // RVA: 0x132C90 Offset: 0x132D91 VA: 0x132C90
	[TooltipAttribute] // RVA: 0x132C90 Offset: 0x132D91 VA: 0x132C90
	public float m_BiasX; // 0x9C
	[RangeAttribute] // RVA: 0x132CF0 Offset: 0x132DF1 VA: 0x132CF0
	[TooltipAttribute] // RVA: 0x132CF0 Offset: 0x132DF1 VA: 0x132CF0
	public float m_BiasY; // 0xA0
	[TooltipAttribute] // RVA: 0x132D50 Offset: 0x132E51 VA: 0x132D50
	public bool m_CenterOnActivate; // 0xA4
	[SpaceAttribute] // RVA: 0x132D90 Offset: 0x132E91 VA: 0x132D90
	[TooltipAttribute] // RVA: 0x132D90 Offset: 0x132E91 VA: 0x132D90
	[FormerlySerializedAsAttribute] // RVA: 0x132D90 Offset: 0x132E91 VA: 0x132D90
	public CinemachineFramingTransposer.FramingMode m_GroupFramingMode; // 0xA8
	[TooltipAttribute] // RVA: 0x132E00 Offset: 0x132F01 VA: 0x132E00
	public CinemachineFramingTransposer.AdjustmentMode m_AdjustmentMode; // 0xAC
	[TooltipAttribute] // RVA: 0x132E40 Offset: 0x132F41 VA: 0x132E40
	public float m_GroupFramingSize; // 0xB0
	[TooltipAttribute] // RVA: 0x132E80 Offset: 0x132F81 VA: 0x132E80
	public float m_MaxDollyIn; // 0xB4
	[TooltipAttribute] // RVA: 0x132EC0 Offset: 0x132FC1 VA: 0x132EC0
	public float m_MaxDollyOut; // 0xB8
	[TooltipAttribute] // RVA: 0x132F00 Offset: 0x133001 VA: 0x132F00
	public float m_MinimumDistance; // 0xBC
	[TooltipAttribute] // RVA: 0x132F40 Offset: 0x133041 VA: 0x132F40
	public float m_MaximumDistance; // 0xC0
	[RangeAttribute] // RVA: 0x132F80 Offset: 0x133081 VA: 0x132F80
	[TooltipAttribute] // RVA: 0x132F80 Offset: 0x133081 VA: 0x132F80
	public float m_MinimumFOV; // 0xC4
	[RangeAttribute] // RVA: 0x132FE0 Offset: 0x1330E1 VA: 0x132FE0
	[TooltipAttribute] // RVA: 0x132FE0 Offset: 0x1330E1 VA: 0x132FE0
	public float m_MaximumFOV; // 0xC8
	[TooltipAttribute] // RVA: 0x133040 Offset: 0x133141 VA: 0x133040
	public float m_MinimumOrthoSize; // 0xCC
	[TooltipAttribute] // RVA: 0x133080 Offset: 0x133181 VA: 0x133080
	public float m_MaximumOrthoSize; // 0xD0
	private const float kMinimumCameraDistance = 0.01;
	private const float kMinimumGroupSize = 0.01;
	private Vector3 m_PreviousCameraPosition; // 0xD4
	private PositionPredictor m_Predictor; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x1330C0 Offset: 0x1331C1 VA: 0x1330C0
	private Vector3 <TrackedPoint>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x1330D0 Offset: 0x1331D1 VA: 0x1330D0
	private bool <InheritingPosition>k__BackingField; // 0xF4
	private float m_prevFOV; // 0xF8
	private Quaternion m_prevRotation; // 0xFC
	[CompilerGeneratedAttribute] // RVA: 0x1330E0 Offset: 0x1331E1 VA: 0x1330E0
	private Bounds <LastBounds>k__BackingField; // 0x10C
	[CompilerGeneratedAttribute] // RVA: 0x1330F0 Offset: 0x1331F1 VA: 0x1330F0
	private Matrix4x4 <LastBoundsMatrix>k__BackingField; // 0x124

	// Properties
	internal Rect SoftGuideRect { get; set; }
	internal Rect HardGuideRect { get; set; }
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }
	public override bool BodyAppliesAfterAim { get; }
	public Vector3 TrackedPoint { get; set; }
	private bool InheritingPosition { get; set; }
	public Bounds LastBounds { get; set; }
	public Matrix4x4 LastBoundsMatrix { get; set; }

	// Methods

	// RVA: 0x1721F20 Offset: 0x1722021 VA: 0x1721F20
	internal Rect get_SoftGuideRect() { }

	// RVA: 0x1721F70 Offset: 0x1722071 VA: 0x1721F70
	internal void set_SoftGuideRect(Rect value) { }

	// RVA: 0x17220D0 Offset: 0x17221D1 VA: 0x17220D0
	internal Rect get_HardGuideRect() { }

	// RVA: 0x17221E0 Offset: 0x17222E1 VA: 0x17221E0
	internal void set_HardGuideRect(Rect value) { }

	// RVA: 0x1722400 Offset: 0x1722501 VA: 0x1722400
	private void OnValidate() { }

	// RVA: 0x1722560 Offset: 0x1722661 VA: 0x1722560 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x1722600 Offset: 0x1722701 VA: 0x1722600 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x1722610 Offset: 0x1722711 VA: 0x1722610 Slot: 7
	public override bool get_BodyAppliesAfterAim() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CA0 Offset: 0x136DA1 VA: 0x136CA0
	// RVA: 0x1722620 Offset: 0x1722721 VA: 0x1722620
	public Vector3 get_TrackedPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CB0 Offset: 0x136DB1 VA: 0x136CB0
	// RVA: 0x1722630 Offset: 0x1722731 VA: 0x1722630
	private void set_TrackedPoint(Vector3 value) { }

	// RVA: 0x1722640 Offset: 0x1722741 VA: 0x1722640 Slot: 10
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x17227A0 Offset: 0x17228A1 VA: 0x17227A0 Slot: 11
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x17227F0 Offset: 0x17228F1 VA: 0x17227F0 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1722890 Offset: 0x1722991 VA: 0x1722890 Slot: 9
	public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) { }

	[CompilerGeneratedAttribute] // RVA: 0x136CC0 Offset: 0x136DC1 VA: 0x136CC0
	// RVA: 0x17229B0 Offset: 0x1722AB1 VA: 0x17229B0
	private bool get_InheritingPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CD0 Offset: 0x136DD1 VA: 0x136CD0
	// RVA: 0x17229C0 Offset: 0x1722AC1 VA: 0x17229C0
	private void set_InheritingPosition(bool value) { }

	// RVA: 0x17229D0 Offset: 0x1722AD1 VA: 0x17229D0
	private Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect) { }

	// RVA: 0x1722AB0 Offset: 0x1722BB1 VA: 0x1722AB0
	private Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect) { }

	[CompilerGeneratedAttribute] // RVA: 0x136CE0 Offset: 0x136DE1 VA: 0x136CE0
	// RVA: 0x1722C00 Offset: 0x1722D01 VA: 0x1722C00
	public Bounds get_LastBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x136CF0 Offset: 0x136DF1 VA: 0x136CF0
	// RVA: 0x1722C30 Offset: 0x1722D31 VA: 0x1722C30
	private void set_LastBounds(Bounds value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136D00 Offset: 0x136E01 VA: 0x136D00
	// RVA: 0x1722C60 Offset: 0x1722D61 VA: 0x1722C60
	public Matrix4x4 get_LastBoundsMatrix() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D10 Offset: 0x136E11 VA: 0x136D10
	// RVA: 0x1722CC0 Offset: 0x1722DC1 VA: 0x1722CC0
	private void set_LastBoundsMatrix(Matrix4x4 value) { }

	// RVA: 0x1722CE0 Offset: 0x1722DE1 VA: 0x1722CE0 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1724430 Offset: 0x1724531 VA: 0x1724430
	private float GetTargetHeight(Vector2 boundsSize) { }

	// RVA: 0x1723E60 Offset: 0x1723F61 VA: 0x1723E60
	private Vector3 ComputeGroupBounds(ICinemachineTargetGroup group, ref CameraState curState) { }

	// RVA: 0x1724580 Offset: 0x1724681 VA: 0x1724580
	private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, ref Vector3 pos, Quaternion orientation) { }

	// RVA: 0x1724BF0 Offset: 0x1724CF1 VA: 0x1724BF0
	public void .ctor() { }
}


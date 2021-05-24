[DocumentationSortingAttribute] // RVA: 0x12E980 Offset: 0x12EA81 VA: 0x12E980
[AddComponentMenu] // RVA: 0x12E980 Offset: 0x12EA81 VA: 0x12E980
[SaveDuringPlayAttribute] // RVA: 0x12E980 Offset: 0x12EA81 VA: 0x12E980
public class CinemachineComposer : CinemachineComponentBase // TypeDefIndex: 4784
{
	// Fields
	[TooltipAttribute] // RVA: 0x132100 Offset: 0x132201 VA: 0x132100
	public Vector3 m_TrackedObjectOffset; // 0x50
	[SpaceAttribute] // RVA: 0x132140 Offset: 0x132241 VA: 0x132140
	[TooltipAttribute] // RVA: 0x132140 Offset: 0x132241 VA: 0x132140
	[RangeAttribute] // RVA: 0x132140 Offset: 0x132241 VA: 0x132140
	public float m_LookaheadTime; // 0x5C
	[TooltipAttribute] // RVA: 0x1321B0 Offset: 0x1322B1 VA: 0x1321B0
	[RangeAttribute] // RVA: 0x1321B0 Offset: 0x1322B1 VA: 0x1321B0
	public float m_LookaheadSmoothing; // 0x60
	[TooltipAttribute] // RVA: 0x132210 Offset: 0x132311 VA: 0x132210
	public bool m_LookaheadIgnoreY; // 0x64
	[SpaceAttribute] // RVA: 0x132250 Offset: 0x132351 VA: 0x132250
	[RangeAttribute] // RVA: 0x132250 Offset: 0x132351 VA: 0x132250
	[TooltipAttribute] // RVA: 0x132250 Offset: 0x132351 VA: 0x132250
	public float m_HorizontalDamping; // 0x68
	[RangeAttribute] // RVA: 0x1322C0 Offset: 0x1323C1 VA: 0x1322C0
	[TooltipAttribute] // RVA: 0x1322C0 Offset: 0x1323C1 VA: 0x1322C0
	public float m_VerticalDamping; // 0x6C
	[SpaceAttribute] // RVA: 0x132320 Offset: 0x132421 VA: 0x132320
	[RangeAttribute] // RVA: 0x132320 Offset: 0x132421 VA: 0x132320
	[TooltipAttribute] // RVA: 0x132320 Offset: 0x132421 VA: 0x132320
	public float m_ScreenX; // 0x70
	[RangeAttribute] // RVA: 0x132390 Offset: 0x132491 VA: 0x132390
	[TooltipAttribute] // RVA: 0x132390 Offset: 0x132491 VA: 0x132390
	public float m_ScreenY; // 0x74
	[RangeAttribute] // RVA: 0x1323F0 Offset: 0x1324F1 VA: 0x1323F0
	[TooltipAttribute] // RVA: 0x1323F0 Offset: 0x1324F1 VA: 0x1323F0
	public float m_DeadZoneWidth; // 0x78
	[RangeAttribute] // RVA: 0x132450 Offset: 0x132551 VA: 0x132450
	[TooltipAttribute] // RVA: 0x132450 Offset: 0x132551 VA: 0x132450
	public float m_DeadZoneHeight; // 0x7C
	[RangeAttribute] // RVA: 0x1324B0 Offset: 0x1325B1 VA: 0x1324B0
	[TooltipAttribute] // RVA: 0x1324B0 Offset: 0x1325B1 VA: 0x1324B0
	public float m_SoftZoneWidth; // 0x80
	[RangeAttribute] // RVA: 0x132510 Offset: 0x132611 VA: 0x132510
	[TooltipAttribute] // RVA: 0x132510 Offset: 0x132611 VA: 0x132510
	public float m_SoftZoneHeight; // 0x84
	[RangeAttribute] // RVA: 0x132570 Offset: 0x132671 VA: 0x132570
	[TooltipAttribute] // RVA: 0x132570 Offset: 0x132671 VA: 0x132570
	public float m_BiasX; // 0x88
	[RangeAttribute] // RVA: 0x1325D0 Offset: 0x1326D1 VA: 0x1325D0
	[TooltipAttribute] // RVA: 0x1325D0 Offset: 0x1326D1 VA: 0x1325D0
	public float m_BiasY; // 0x8C
	[TooltipAttribute] // RVA: 0x132630 Offset: 0x132731 VA: 0x132630
	public bool m_CenterOnActivate; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x132670 Offset: 0x132771 VA: 0x132670
	private Vector3 <TrackedPoint>k__BackingField; // 0x94
	private Vector3 m_CameraPosPrevFrame; // 0xA0
	private Vector3 m_LookAtPrevFrame; // 0xAC
	private Vector2 m_ScreenOffsetPrevFrame; // 0xB8
	private Quaternion m_CameraOrientationPrevFrame; // 0xC0
	internal PositionPredictor m_Predictor; // 0xD0
	private CinemachineComposer.FovCache mCache; // 0xD8

	// Properties
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }
	public Vector3 TrackedPoint { get; set; }
	internal Rect SoftGuideRect { get; set; }
	internal Rect HardGuideRect { get; set; }

	// Methods

	// RVA: 0x1897A30 Offset: 0x1897B31 VA: 0x1897A30 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x1897AD0 Offset: 0x1897BD1 VA: 0x1897AD0 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	[CompilerGeneratedAttribute] // RVA: 0x136C80 Offset: 0x136D81 VA: 0x136C80
	// RVA: 0x1897AE0 Offset: 0x1897BE1 VA: 0x1897AE0
	public Vector3 get_TrackedPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x136C90 Offset: 0x136D91 VA: 0x136C90
	// RVA: 0x1897AF0 Offset: 0x1897BF1 VA: 0x1897AF0
	private void set_TrackedPoint(Vector3 value) { }

	// RVA: 0x1897B00 Offset: 0x1897C01 VA: 0x1897B00 Slot: 13
	protected virtual Vector3 GetLookAtPointAndSetTrackedPoint(Vector3 lookAt, Vector3 up, float deltaTime) { }

	// RVA: 0x1897DC0 Offset: 0x1897EC1 VA: 0x1897DC0 Slot: 10
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1897F20 Offset: 0x1898021 VA: 0x1897F20 Slot: 11
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1897F40 Offset: 0x1898041 VA: 0x1897F40 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1897FC0 Offset: 0x18980C1 VA: 0x1897FC0 Slot: 5
	public override void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x18980B0 Offset: 0x18981B1 VA: 0x18980B0 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1898AF0 Offset: 0x1898BF1 VA: 0x1898AF0
	internal Rect get_SoftGuideRect() { }

	// RVA: 0x1899280 Offset: 0x1899381 VA: 0x1899280
	internal void set_SoftGuideRect(Rect value) { }

	// RVA: 0x1898B40 Offset: 0x1898C41 VA: 0x1898B40
	internal Rect get_HardGuideRect() { }

	// RVA: 0x18993E0 Offset: 0x18994E1 VA: 0x18993E0
	internal void set_HardGuideRect(Rect value) { }

	// RVA: 0x1898F80 Offset: 0x1899081 VA: 0x1898F80
	private void RotateToScreenBounds(ref CameraState state, Rect screenRect, Vector3 trackedPoint, ref Quaternion rigOrientation, float fov, float fovH, float deltaTime) { }

	// RVA: 0x1899600 Offset: 0x1899701 VA: 0x1899600
	private bool ClampVerticalBounds(ref Rect r, Vector3 dir, Vector3 up, float fov) { }

	// RVA: 0x18997F0 Offset: 0x18998F1 VA: 0x18997F0
	public void .ctor() { }
}


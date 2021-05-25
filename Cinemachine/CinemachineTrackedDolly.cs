[DocumentationSortingAttribute] // RVA: 0x12EC80 Offset: 0x12ED81 VA: 0x12EC80
[AddComponentMenu] // RVA: 0x12EC80 Offset: 0x12ED81 VA: 0x12EC80
[SaveDuringPlayAttribute] // RVA: 0x12EC80 Offset: 0x12ED81 VA: 0x12EC80
public class CinemachineTrackedDolly : CinemachineComponentBase // TypeDefIndex: 4802
{
	// Fields
	[TooltipAttribute] // RVA: 0x133910 Offset: 0x133A11 VA: 0x133910
	public CinemachinePathBase m_Path; // 0x50
	[TooltipAttribute] // RVA: 0x133950 Offset: 0x133A51 VA: 0x133950
	public float m_PathPosition; // 0x58
	[TooltipAttribute] // RVA: 0x133990 Offset: 0x133A91 VA: 0x133990
	public CinemachinePathBase.PositionUnits m_PositionUnits; // 0x5C
	[TooltipAttribute] // RVA: 0x1339D0 Offset: 0x133AD1 VA: 0x1339D0
	public Vector3 m_PathOffset; // 0x60
	[RangeAttribute] // RVA: 0x133A10 Offset: 0x133B11 VA: 0x133A10
	[TooltipAttribute] // RVA: 0x133A10 Offset: 0x133B11 VA: 0x133A10
	public float m_XDamping; // 0x6C
	[RangeAttribute] // RVA: 0x133A70 Offset: 0x133B71 VA: 0x133A70
	[TooltipAttribute] // RVA: 0x133A70 Offset: 0x133B71 VA: 0x133A70
	public float m_YDamping; // 0x70
	[RangeAttribute] // RVA: 0x133AD0 Offset: 0x133BD1 VA: 0x133AD0
	[TooltipAttribute] // RVA: 0x133AD0 Offset: 0x133BD1 VA: 0x133AD0
	public float m_ZDamping; // 0x74
	[TooltipAttribute] // RVA: 0x133B30 Offset: 0x133C31 VA: 0x133B30
	public CinemachineTrackedDolly.CameraUpMode m_CameraUp; // 0x78
	[RangeAttribute] // RVA: 0x133B70 Offset: 0x133C71 VA: 0x133B70
	[TooltipAttribute] // RVA: 0x133B70 Offset: 0x133C71 VA: 0x133B70
	public float m_PitchDamping; // 0x7C
	[RangeAttribute] // RVA: 0x133BD0 Offset: 0x133CD1 VA: 0x133BD0
	[TooltipAttribute] // RVA: 0x133BD0 Offset: 0x133CD1 VA: 0x133BD0
	public float m_YawDamping; // 0x80
	[RangeAttribute] // RVA: 0x133C30 Offset: 0x133D31 VA: 0x133C30
	[TooltipAttribute] // RVA: 0x133C30 Offset: 0x133D31 VA: 0x133C30
	public float m_RollDamping; // 0x84
	[TooltipAttribute] // RVA: 0x133C90 Offset: 0x133D91 VA: 0x133C90
	public CinemachineTrackedDolly.AutoDolly m_AutoDolly; // 0x88
	private float m_PreviousPathPosition; // 0x98
	private Quaternion m_PreviousOrientation; // 0x9C
	private Vector3 m_PreviousCameraPosition; // 0xAC

	// Properties
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }
	private Vector3 AngularDamping { get; }

	// Methods

	// RVA: 0x1A12F60 Offset: 0x1A13061 VA: 0x1A12F60 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x1A12FF0 Offset: 0x1A130F1 VA: 0x1A12FF0 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x1A13000 Offset: 0x1A13101 VA: 0x1A13000 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1A131C0 Offset: 0x1A132C1 VA: 0x1A131C0 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1A13FC0 Offset: 0x1A140C1 VA: 0x1A13FC0
	private Quaternion GetCameraOrientationAtPathPoint(Quaternion pathOrientation, Vector3 up) { }

	// RVA: 0x1A130F0 Offset: 0x1A131F1 VA: 0x1A130F0
	private Vector3 get_AngularDamping() { }

	// RVA: 0x1A146A0 Offset: 0x1A147A1 VA: 0x1A146A0
	public void .ctor() { }
}


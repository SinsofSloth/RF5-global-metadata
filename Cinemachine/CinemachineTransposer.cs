[DocumentationSortingAttribute] // RVA: 0x12ECE0 Offset: 0x12EDE1 VA: 0x12ECE0
[AddComponentMenu] // RVA: 0x12ECE0 Offset: 0x12EDE1 VA: 0x12ECE0
[SaveDuringPlayAttribute] // RVA: 0x12ECE0 Offset: 0x12EDE1 VA: 0x12ECE0
public class CinemachineTransposer : CinemachineComponentBase // TypeDefIndex: 4805
{
	// Fields
	[TooltipAttribute] // RVA: 0x133CD0 Offset: 0x133DD1 VA: 0x133CD0
	public CinemachineTransposer.BindingMode m_BindingMode; // 0x50
	[TooltipAttribute] // RVA: 0x133D10 Offset: 0x133E11 VA: 0x133D10
	public Vector3 m_FollowOffset; // 0x54
	[RangeAttribute] // RVA: 0x133D50 Offset: 0x133E51 VA: 0x133D50
	[TooltipAttribute] // RVA: 0x133D50 Offset: 0x133E51 VA: 0x133D50
	public float m_XDamping; // 0x60
	[RangeAttribute] // RVA: 0x133DB0 Offset: 0x133EB1 VA: 0x133DB0
	[TooltipAttribute] // RVA: 0x133DB0 Offset: 0x133EB1 VA: 0x133DB0
	public float m_YDamping; // 0x64
	[RangeAttribute] // RVA: 0x133E10 Offset: 0x133F11 VA: 0x133E10
	[TooltipAttribute] // RVA: 0x133E10 Offset: 0x133F11 VA: 0x133E10
	public float m_ZDamping; // 0x68
	public CinemachineTransposer.AngularDampingMode m_AngularDampingMode; // 0x6C
	[RangeAttribute] // RVA: 0x133E70 Offset: 0x133F71 VA: 0x133E70
	[TooltipAttribute] // RVA: 0x133E70 Offset: 0x133F71 VA: 0x133E70
	public float m_PitchDamping; // 0x70
	[RangeAttribute] // RVA: 0x133ED0 Offset: 0x133FD1 VA: 0x133ED0
	[TooltipAttribute] // RVA: 0x133ED0 Offset: 0x133FD1 VA: 0x133ED0
	public float m_YawDamping; // 0x74
	[RangeAttribute] // RVA: 0x133F30 Offset: 0x134031 VA: 0x133F30
	[TooltipAttribute] // RVA: 0x133F30 Offset: 0x134031 VA: 0x133F30
	public float m_RollDamping; // 0x78
	[RangeAttribute] // RVA: 0x133F90 Offset: 0x134091 VA: 0x133F90
	[TooltipAttribute] // RVA: 0x133F90 Offset: 0x134091 VA: 0x133F90
	public float m_AngularDamping; // 0x7C
	[CompilerGeneratedAttribute] // RVA: 0x133FF0 Offset: 0x1340F1 VA: 0x133FF0
	private bool <HideOffsetInInspector>k__BackingField; // 0x80
	private Vector3 m_PreviousTargetPosition; // 0x84
	private Quaternion m_PreviousReferenceOrientation; // 0x90
	private Quaternion m_targetOrientationOnAssign; // 0xA0
	private Vector3 m_PreviousOffset; // 0xB0
	private Transform m_previousTarget; // 0xC0

	// Properties
	public bool HideOffsetInInspector { get; set; }
	public Vector3 EffectiveOffset { get; }
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }
	protected Vector3 Damping { get; }
	protected Vector3 AngularDamping { get; }

	// Methods

	// RVA: 0x1A147A0 Offset: 0x1A148A1 VA: 0x1A147A0 Slot: 13
	protected virtual void OnValidate() { }

	[CompilerGeneratedAttribute] // RVA: 0x136DA0 Offset: 0x136EA1 VA: 0x136DA0
	// RVA: 0x1A148E0 Offset: 0x1A149E1 VA: 0x1A148E0
	public bool get_HideOffsetInInspector() { }

	[CompilerGeneratedAttribute] // RVA: 0x136DB0 Offset: 0x136EB1 VA: 0x136DB0
	// RVA: 0x1A148F0 Offset: 0x1A149F1 VA: 0x1A148F0
	public void set_HideOffsetInInspector(bool value) { }

	// RVA: 0x1A14840 Offset: 0x1A14941 VA: 0x1A14840
	public Vector3 get_EffectiveOffset() { }

	// RVA: 0x1A14900 Offset: 0x1A14A01 VA: 0x1A14900 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x1A149A0 Offset: 0x1A14AA1 VA: 0x1A149A0 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x1A149B0 Offset: 0x1A14AB1 VA: 0x1A149B0 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1A14C50 Offset: 0x1A14D51 VA: 0x1A14C50 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1A15D10 Offset: 0x1A15E11 VA: 0x1A15D10 Slot: 10
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1A15E30 Offset: 0x1A15F31 VA: 0x1A15E30 Slot: 11
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1A14F20 Offset: 0x1A15021 VA: 0x1A14F20
	protected void InitPrevFrameStateInfo(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1A150D0 Offset: 0x1A151D1 VA: 0x1A150D0
	protected void TrackTarget(float deltaTime, Vector3 up, Vector3 desiredCameraOffset, out Vector3 outTargetPosition, out Quaternion outTargetOrient) { }

	// RVA: 0x1A15900 Offset: 0x1A15A01 VA: 0x1A15900
	protected Vector3 GetOffsetForMinimumTargetDistance(Vector3 dampedTargetPos, Vector3 cameraOffset, Vector3 cameraFwd, Vector3 up, Vector3 actualTargetPos) { }

	// RVA: 0x1A14AF0 Offset: 0x1A14BF1 VA: 0x1A14AF0
	protected Vector3 get_Damping() { }

	// RVA: 0x1A14B50 Offset: 0x1A14C51 VA: 0x1A14B50
	protected Vector3 get_AngularDamping() { }

	// RVA: 0x1A16950 Offset: 0x1A16A51 VA: 0x1A16950 Slot: 14
	public virtual Vector3 GetTargetCameraPosition(Vector3 worldUp) { }

	// RVA: 0x1A16040 Offset: 0x1A16141 VA: 0x1A16040
	public Quaternion GetReferenceOrientation(Vector3 worldUp) { }

	// RVA: 0x1A16B50 Offset: 0x1A16C51 VA: 0x1A16B50
	public void .ctor() { }
}


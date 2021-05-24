[AddComponentMenu] // RVA: 0x12E8D0 Offset: 0x12E9D1 VA: 0x12E8D0
[SaveDuringPlayAttribute] // RVA: 0x12E8D0 Offset: 0x12E9D1 VA: 0x12E8D0
public class Cinemachine3rdPersonFollow : CinemachineComponentBase // TypeDefIndex: 4782
{
	// Fields
	[TooltipAttribute] // RVA: 0x131D20 Offset: 0x131E21 VA: 0x131D20
	public Vector3 Damping; // 0x50
	[HeaderAttribute] // RVA: 0x131D60 Offset: 0x131E61 VA: 0x131D60
	[TooltipAttribute] // RVA: 0x131D60 Offset: 0x131E61 VA: 0x131D60
	public Vector3 ShoulderOffset; // 0x5C
	[TooltipAttribute] // RVA: 0x131DC0 Offset: 0x131EC1 VA: 0x131DC0
	public float VerticalArmLength; // 0x68
	[TooltipAttribute] // RVA: 0x131E00 Offset: 0x131F01 VA: 0x131E00
	[RangeAttribute] // RVA: 0x131E00 Offset: 0x131F01 VA: 0x131E00
	public float CameraSide; // 0x6C
	[TooltipAttribute] // RVA: 0x131E60 Offset: 0x131F61 VA: 0x131E60
	public float CameraDistance; // 0x70
	[HeaderAttribute] // RVA: 0x131EA0 Offset: 0x131FA1 VA: 0x131EA0
	[TooltipAttribute] // RVA: 0x131EA0 Offset: 0x131FA1 VA: 0x131EA0
	public LayerMask CameraCollisionFilter; // 0x74
	[TagFieldAttribute] // RVA: 0x131F00 Offset: 0x132001 VA: 0x131F00
	[TooltipAttribute] // RVA: 0x131F00 Offset: 0x132001 VA: 0x131F00
	public string IgnoreTag; // 0x78
	[TooltipAttribute] // RVA: 0x131F50 Offset: 0x132051 VA: 0x131F50
	public float CameraRadius; // 0x80
	private Vector3 PreviousFollowTargetPosition; // 0x84
	private float PreviousHeadingAngle; // 0x90

	// Properties
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }

	// Methods

	// RVA: 0x1887180 Offset: 0x1887281 VA: 0x1887180
	private void OnValidate() { }

	// RVA: 0x1887260 Offset: 0x1887361 VA: 0x1887260
	private void Reset() { }

	// RVA: 0x1887330 Offset: 0x1887431 VA: 0x1887330 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x1887480 Offset: 0x1887581 VA: 0x1887480 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x1887490 Offset: 0x1887591 VA: 0x1887490 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1887530 Offset: 0x1887631 VA: 0x1887530 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1887720 Offset: 0x1887821 VA: 0x1887720
	private void PositionCamera(ref CameraState curState, float deltaTime) { }

	// RVA: 0x18880B0 Offset: 0x18881B1 VA: 0x18880B0
	public void GetRigPositions(out Vector3 root, out Vector3 shoulder, out Vector3 hand) { }

	// RVA: 0x18882C0 Offset: 0x18883C1 VA: 0x18882C0
	private Vector3 PullTowardsStartOnCollision(in Vector3 rayStart, in Vector3 rayEnd, in LayerMask filter, float radius) { }

	// RVA: 0x18884B0 Offset: 0x18885B1 VA: 0x18884B0
	public void .ctor() { }
}


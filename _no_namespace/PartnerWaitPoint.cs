public class PartnerWaitPoint // TypeDefIndex: 8192
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16B770 Offset: 0x16B871 VA: 0x16B770
	private readonly PartnerMovementOrderType <Type>k__BackingField; // 0x10
	private Vector3 LocalPosition; // 0x14
	private float CenterSqrMagnitude; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x16B780 Offset: 0x16B881 VA: 0x16B780
	private Vector3 <Position>k__BackingField; // 0x24
	public float CameraValue; // 0x30

	// Properties
	public PartnerMovementOrderType Type { get; }
	public Vector3 Position { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A6550 Offset: 0x1A6651 VA: 0x1A6550
	// RVA: 0x1FDEFF0 Offset: 0x1FDF0F1 VA: 0x1FDEFF0
	public PartnerMovementOrderType get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6560 Offset: 0x1A6661 VA: 0x1A6560
	// RVA: 0x1FDF000 Offset: 0x1FDF101 VA: 0x1FDF000
	public Vector3 get_Position() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6570 Offset: 0x1A6671 VA: 0x1A6570
	// RVA: 0x1FDF010 Offset: 0x1FDF111 VA: 0x1FDF010
	private void set_Position(Vector3 value) { }

	// RVA: 0x1FDF020 Offset: 0x1FDF121 VA: 0x1FDF020
	public void .ctor(PartnerMovementOrderType type, Vector3 localPosition) { }

	// RVA: 0x1FDF090 Offset: 0x1FDF191 VA: 0x1FDF090
	public void UpdatePosition(Transform transform) { }

	// RVA: 0x1FDF170 Offset: 0x1FDF271 VA: 0x1FDF170
	public void UpdateCameraForwardValue(GameObject cameraObj) { }

	// RVA: 0x1FDF300 Offset: 0x1FDF401 VA: 0x1FDF300
	public void OnDrawGizmos() { }
}


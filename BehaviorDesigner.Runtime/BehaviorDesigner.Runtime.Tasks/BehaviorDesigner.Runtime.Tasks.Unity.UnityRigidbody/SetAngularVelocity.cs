[TaskCategoryAttribute] // RVA: 0x1504C0 Offset: 0x1505C1 VA: 0x1504C0
[TaskDescriptionAttribute] // RVA: 0x1504C0 Offset: 0x1505C1 VA: 0x1504C0
public class SetAngularVelocity : Action // TypeDefIndex: 11143
{
	// Fields
	[TooltipAttribute] // RVA: 0x18A800 Offset: 0x18A901 VA: 0x18A800
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18A840 Offset: 0x18A941 VA: 0x18A840
	public SharedVector3 angularVelocity; // 0x58
	private Rigidbody rigidbody; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2884800 Offset: 0x2884901 VA: 0x2884800 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2884900 Offset: 0x2884A01 VA: 0x2884900 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x28849F0 Offset: 0x2884AF1 VA: 0x28849F0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2884A80 Offset: 0x2884B81 VA: 0x2884A80
	public void .ctor() { }
}


[TaskCategoryAttribute] // RVA: 0x1507C0 Offset: 0x1508C1 VA: 0x1507C0
[TaskDescriptionAttribute] // RVA: 0x1507C0 Offset: 0x1508C1 VA: 0x1507C0
public class SetRotation : Action // TypeDefIndex: 11151
{
	// Fields
	[TooltipAttribute] // RVA: 0x18AC00 Offset: 0x18AD01 VA: 0x18AC00
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18AC40 Offset: 0x18AD41 VA: 0x18AC40
	public SharedQuaternion rotation; // 0x58
	private Rigidbody rigidbody; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2885B30 Offset: 0x2885C31 VA: 0x2885B30 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2885C30 Offset: 0x2885D31 VA: 0x2885C30 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2885D20 Offset: 0x2885E21 VA: 0x2885D20 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2885DB0 Offset: 0x2885EB1 VA: 0x2885DB0
	public void .ctor() { }
}


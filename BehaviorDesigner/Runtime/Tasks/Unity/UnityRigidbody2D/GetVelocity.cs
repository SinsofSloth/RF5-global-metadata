[TaskCategoryAttribute] // RVA: 0x14F6F0 Offset: 0x14F7F1 VA: 0x14F6F0
[TaskDescriptionAttribute] // RVA: 0x14F6F0 Offset: 0x14F7F1 VA: 0x14F6F0
public class GetVelocity : Action // TypeDefIndex: 11107
{
	// Fields
	[TooltipAttribute] // RVA: 0x189440 Offset: 0x189541 VA: 0x189440
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x189480 Offset: 0x189581 VA: 0x189480
	[RequiredFieldAttribute] // RVA: 0x189480 Offset: 0x189581 VA: 0x189480
	public SharedVector2 storeValue; // 0x58
	private Rigidbody2D rigidbody2D; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2888340 Offset: 0x2888441 VA: 0x2888340 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2888440 Offset: 0x2888541 VA: 0x2888440 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2888530 Offset: 0x2888631 VA: 0x2888530 Slot: 16
	public override void OnReset() { }

	// RVA: 0x28885C0 Offset: 0x28886C1 VA: 0x28885C0
	public void .ctor() { }
}


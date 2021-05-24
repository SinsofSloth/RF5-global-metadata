[TaskCategoryAttribute] // RVA: 0x14DB30 Offset: 0x14DC31 VA: 0x14DB30
[TaskDescriptionAttribute] // RVA: 0x14DB30 Offset: 0x14DC31 VA: 0x14DB30
public class SetRotation : Action // TypeDefIndex: 11033
{
	// Fields
	[TooltipAttribute] // RVA: 0x186CE0 Offset: 0x186DE1 VA: 0x186CE0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x186D20 Offset: 0x186E21 VA: 0x186D20
	public SharedQuaternion rotation; // 0x58
	private Transform targetTransform; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2890910 Offset: 0x2890A11 VA: 0x2890910 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2890A10 Offset: 0x2890B11 VA: 0x2890A10 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2890B00 Offset: 0x2890C01 VA: 0x2890B00 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2890B90 Offset: 0x2890C91 VA: 0x2890B90
	public void .ctor() { }
}


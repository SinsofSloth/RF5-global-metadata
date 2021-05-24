[TaskCategoryAttribute] // RVA: 0x150280 Offset: 0x150381 VA: 0x150280
[TaskDescriptionAttribute] // RVA: 0x150280 Offset: 0x150381 VA: 0x150280
public class GetVelocity : Action // TypeDefIndex: 11137
{
	// Fields
	[TooltipAttribute] // RVA: 0x18A570 Offset: 0x18A671 VA: 0x18A570
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18A5B0 Offset: 0x18A6B1 VA: 0x18A5B0
	[RequiredFieldAttribute] // RVA: 0x18A5B0 Offset: 0x18A6B1 VA: 0x18A5B0
	public SharedVector3 storeValue; // 0x58
	private Rigidbody rigidbody; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2883A00 Offset: 0x2883B01 VA: 0x2883A00 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2883B00 Offset: 0x2883C01 VA: 0x2883B00 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2883BF0 Offset: 0x2883CF1 VA: 0x2883BF0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2883C80 Offset: 0x2883D81 VA: 0x2883C80
	public void .ctor() { }
}


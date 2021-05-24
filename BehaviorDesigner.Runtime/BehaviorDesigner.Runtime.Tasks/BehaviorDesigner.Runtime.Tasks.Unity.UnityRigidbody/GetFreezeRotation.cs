[TaskCategoryAttribute] // RVA: 0x150040 Offset: 0x150141 VA: 0x150040
[TaskDescriptionAttribute] // RVA: 0x150040 Offset: 0x150141 VA: 0x150040
public class GetFreezeRotation : Action // TypeDefIndex: 11131
{
	// Fields
	[TooltipAttribute] // RVA: 0x18A210 Offset: 0x18A311 VA: 0x18A210
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18A250 Offset: 0x18A351 VA: 0x18A250
	[RequiredFieldAttribute] // RVA: 0x18A250 Offset: 0x18A351 VA: 0x18A250
	public SharedBool storeValue; // 0x58
	private Rigidbody rigidbody; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2882B70 Offset: 0x2882C71 VA: 0x2882B70 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2882C70 Offset: 0x2882D71 VA: 0x2882C70 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2882D70 Offset: 0x2882E71 VA: 0x2882D70 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2882DC0 Offset: 0x2882EC1 VA: 0x2882DC0
	public void .ctor() { }
}


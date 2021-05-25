[TaskCategoryAttribute] // RVA: 0x150220 Offset: 0x150321 VA: 0x150220
[TaskDescriptionAttribute] // RVA: 0x150220 Offset: 0x150321 VA: 0x150220
public class GetUseGravity : Action // TypeDefIndex: 11136
{
	// Fields
	[TooltipAttribute] // RVA: 0x18A4E0 Offset: 0x18A5E1 VA: 0x18A4E0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18A520 Offset: 0x18A621 VA: 0x18A520
	[RequiredFieldAttribute] // RVA: 0x18A520 Offset: 0x18A621 VA: 0x18A520
	public SharedBool storeValue; // 0x58
	private Rigidbody rigidbody; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x28837A0 Offset: 0x28838A1 VA: 0x28837A0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x28838A0 Offset: 0x28839A1 VA: 0x28838A0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x28839A0 Offset: 0x2883AA1 VA: 0x28839A0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x28839F0 Offset: 0x2883AF1 VA: 0x28839F0
	public void .ctor() { }
}


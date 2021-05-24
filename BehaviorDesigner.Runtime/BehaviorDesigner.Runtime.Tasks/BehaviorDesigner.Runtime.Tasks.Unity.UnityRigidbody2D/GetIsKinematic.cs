[TaskCategoryAttribute] // RVA: 0x14F570 Offset: 0x14F671 VA: 0x14F570
[TaskDescriptionAttribute] // RVA: 0x14F570 Offset: 0x14F671 VA: 0x14F570
public class GetIsKinematic : Action // TypeDefIndex: 11103
{
	// Fields
	[TooltipAttribute] // RVA: 0x189200 Offset: 0x189301 VA: 0x189200
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x189240 Offset: 0x189341 VA: 0x189240
	[RequiredFieldAttribute] // RVA: 0x189240 Offset: 0x189341 VA: 0x189240
	public SharedBool storeValue; // 0x58
	private Rigidbody2D rigidbody2D; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x28879B0 Offset: 0x2887AB1 VA: 0x28879B0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2887AB0 Offset: 0x2887BB1 VA: 0x2887AB0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2887BB0 Offset: 0x2887CB1 VA: 0x2887BB0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2887C00 Offset: 0x2887D01 VA: 0x2887C00
	public void .ctor() { }
}


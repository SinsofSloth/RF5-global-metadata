[TaskCategoryAttribute] // RVA: 0x14FFE0 Offset: 0x1500E1 VA: 0x14FFE0
[TaskDescriptionAttribute] // RVA: 0x14FFE0 Offset: 0x1500E1 VA: 0x14FFE0
public class GetDrag : Action // TypeDefIndex: 11130
{
	// Fields
	[TooltipAttribute] // RVA: 0x18A180 Offset: 0x18A281 VA: 0x18A180
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18A1C0 Offset: 0x18A2C1 VA: 0x18A1C0
	[RequiredFieldAttribute] // RVA: 0x18A1C0 Offset: 0x18A2C1 VA: 0x18A1C0
	public SharedFloat storeValue; // 0x58
	private Rigidbody rigidbody; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2882920 Offset: 0x2882A21 VA: 0x2882920 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2882A20 Offset: 0x2882B21 VA: 0x2882A20 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2882B10 Offset: 0x2882C11 VA: 0x2882B10 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2882B60 Offset: 0x2882C61 VA: 0x2882B60
	public void .ctor() { }
}


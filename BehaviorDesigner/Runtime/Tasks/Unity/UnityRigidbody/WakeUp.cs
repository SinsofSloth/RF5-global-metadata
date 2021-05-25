[TaskCategoryAttribute] // RVA: 0x1509A0 Offset: 0x150AA1 VA: 0x1509A0
[TaskDescriptionAttribute] // RVA: 0x1509A0 Offset: 0x150AA1 VA: 0x1509A0
public class WakeUp : Conditional // TypeDefIndex: 11156
{
	// Fields
	[TooltipAttribute] // RVA: 0x18AE00 Offset: 0x18AF01 VA: 0x18AE00
	public SharedGameObject targetGameObject; // 0x50
	private Rigidbody rigidbody; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x28866B0 Offset: 0x28867B1 VA: 0x28866B0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x28867B0 Offset: 0x28868B1 VA: 0x28867B0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2886890 Offset: 0x2886991 VA: 0x2886890 Slot: 16
	public override void OnReset() { }

	// RVA: 0x28868A0 Offset: 0x28869A1 VA: 0x28868A0
	public void .ctor() { }
}


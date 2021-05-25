[TaskCategoryAttribute] // RVA: 0x150700 Offset: 0x150801 VA: 0x150700
[TaskDescriptionAttribute] // RVA: 0x150700 Offset: 0x150801 VA: 0x150700
public class SetMass : Action // TypeDefIndex: 11149
{
	// Fields
	[TooltipAttribute] // RVA: 0x18AB00 Offset: 0x18AC01 VA: 0x18AB00
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18AB40 Offset: 0x18AC41 VA: 0x18AB40
	public SharedFloat mass; // 0x58
	private Rigidbody rigidbody; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2885650 Offset: 0x2885751 VA: 0x2885650 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2885750 Offset: 0x2885851 VA: 0x2885750 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2885840 Offset: 0x2885941 VA: 0x2885840 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2885890 Offset: 0x2885991 VA: 0x2885890
	public void .ctor() { }
}


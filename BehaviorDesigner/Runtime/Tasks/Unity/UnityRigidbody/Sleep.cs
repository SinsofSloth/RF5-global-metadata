[TaskCategoryAttribute] // RVA: 0x1508E0 Offset: 0x1509E1 VA: 0x1508E0
[TaskDescriptionAttribute] // RVA: 0x1508E0 Offset: 0x1509E1 VA: 0x1508E0
public class Sleep : Conditional // TypeDefIndex: 11154
{
	// Fields
	[TooltipAttribute] // RVA: 0x18AD80 Offset: 0x18AE81 VA: 0x18AD80
	public SharedGameObject targetGameObject; // 0x50
	private Rigidbody rigidbody; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x28862B0 Offset: 0x28863B1 VA: 0x28862B0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x28863B0 Offset: 0x28864B1 VA: 0x28863B0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2886490 Offset: 0x2886591 VA: 0x2886490 Slot: 16
	public override void OnReset() { }

	// RVA: 0x28864A0 Offset: 0x28865A1 VA: 0x28864A0
	public void .ctor() { }
}


[TaskCategoryAttribute] // RVA: 0x150940 Offset: 0x150A41 VA: 0x150940
[TaskDescriptionAttribute] // RVA: 0x150940 Offset: 0x150A41 VA: 0x150940
public class UseGravity : Conditional // TypeDefIndex: 11155
{
	// Fields
	[TooltipAttribute] // RVA: 0x18ADC0 Offset: 0x18AEC1 VA: 0x18ADC0
	public SharedGameObject targetGameObject; // 0x50
	private Rigidbody rigidbody; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x28864B0 Offset: 0x28865B1 VA: 0x28864B0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x28865B0 Offset: 0x28866B1 VA: 0x28865B0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2886690 Offset: 0x2886791 VA: 0x2886690 Slot: 16
	public override void OnReset() { }

	// RVA: 0x28866A0 Offset: 0x28867A1 VA: 0x28866A0
	public void .ctor() { }
}


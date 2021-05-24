[TaskCategoryAttribute] // RVA: 0x151F00 Offset: 0x152001 VA: 0x151F00
[TaskDescriptionAttribute] // RVA: 0x151F00 Offset: 0x152001 VA: 0x151F00
public class Simulate : Action // TypeDefIndex: 11213
{
	// Fields
	[TooltipAttribute] // RVA: 0x18D560 Offset: 0x18D661 VA: 0x18D560
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18D5A0 Offset: 0x18D6A1 VA: 0x18D5A0
	public SharedFloat time; // 0x58
	private ParticleSystem particleSystem; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x287D470 Offset: 0x287D571 VA: 0x287D470 Slot: 5
	public override void OnStart() { }

	// RVA: 0x287D570 Offset: 0x287D671 VA: 0x287D570 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287D660 Offset: 0x287D761 VA: 0x287D660 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287D6B0 Offset: 0x287D7B1 VA: 0x287D6B0
	public void .ctor() { }
}


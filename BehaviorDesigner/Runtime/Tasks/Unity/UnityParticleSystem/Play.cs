[TaskCategoryAttribute] // RVA: 0x151A20 Offset: 0x151B21 VA: 0x151A20
[TaskDescriptionAttribute] // RVA: 0x151A20 Offset: 0x151B21 VA: 0x151A20
public class Play : Action // TypeDefIndex: 11200
{
	// Fields
	[TooltipAttribute] // RVA: 0x18CF20 Offset: 0x18D021 VA: 0x18CF20
	public SharedGameObject targetGameObject; // 0x50
	private ParticleSystem particleSystem; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x287B470 Offset: 0x287B571 VA: 0x287B470 Slot: 5
	public override void OnStart() { }

	// RVA: 0x287B570 Offset: 0x287B671 VA: 0x287B570 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287B650 Offset: 0x287B751 VA: 0x287B650 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287B660 Offset: 0x287B761 VA: 0x287B660
	public void .ctor() { }
}


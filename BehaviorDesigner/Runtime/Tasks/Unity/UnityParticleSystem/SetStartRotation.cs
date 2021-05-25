[TaskCategoryAttribute] // RVA: 0x151D80 Offset: 0x151E81 VA: 0x151D80
[TaskDescriptionAttribute] // RVA: 0x151D80 Offset: 0x151E81 VA: 0x151D80
public class SetStartRotation : Action // TypeDefIndex: 11209
{
	// Fields
	[TooltipAttribute] // RVA: 0x18D360 Offset: 0x18D461 VA: 0x18D360
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18D3A0 Offset: 0x18D4A1 VA: 0x18D3A0
	public SharedFloat startRotation; // 0x58
	private ParticleSystem particleSystem; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x287CA70 Offset: 0x287CB71 VA: 0x287CA70 Slot: 5
	public override void OnStart() { }

	// RVA: 0x287CB70 Offset: 0x287CC71 VA: 0x287CB70 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287CCA0 Offset: 0x287CDA1 VA: 0x287CCA0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287CCF0 Offset: 0x287CDF1 VA: 0x287CCF0
	public void .ctor() { }
}


[TaskCategoryAttribute] // RVA: 0x151F60 Offset: 0x152061 VA: 0x151F60
[TaskDescriptionAttribute] // RVA: 0x151F60 Offset: 0x152061 VA: 0x151F60
public class Stop : Action // TypeDefIndex: 11214
{
	// Fields
	[TooltipAttribute] // RVA: 0x18D5E0 Offset: 0x18D6E1 VA: 0x18D5E0
	public SharedGameObject targetGameObject; // 0x50
	private ParticleSystem particleSystem; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x287D6C0 Offset: 0x287D7C1 VA: 0x287D6C0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x287D7C0 Offset: 0x287D8C1 VA: 0x287D7C0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287D8A0 Offset: 0x287D9A1 VA: 0x287D8A0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287D8B0 Offset: 0x287D9B1 VA: 0x287D8B0
	public void .ctor() { }
}


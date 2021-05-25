[TaskCategoryAttribute] // RVA: 0x151BA0 Offset: 0x151CA1 VA: 0x151BA0
[TaskDescriptionAttribute] // RVA: 0x151BA0 Offset: 0x151CA1 VA: 0x151BA0
public class SetMaxParticles : Action // TypeDefIndex: 11204
{
	// Fields
	[TooltipAttribute] // RVA: 0x18D0E0 Offset: 0x18D1E1 VA: 0x18D0E0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18D120 Offset: 0x18D221 VA: 0x18D120
	public SharedInt maxParticles; // 0x58
	private ParticleSystem particleSystem; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x287BDA0 Offset: 0x287BEA1 VA: 0x287BDA0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x287BEA0 Offset: 0x287BFA1 VA: 0x287BEA0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287BFB0 Offset: 0x287C0B1 VA: 0x287BFB0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287C000 Offset: 0x287C101 VA: 0x287C000
	public void .ctor() { }
}


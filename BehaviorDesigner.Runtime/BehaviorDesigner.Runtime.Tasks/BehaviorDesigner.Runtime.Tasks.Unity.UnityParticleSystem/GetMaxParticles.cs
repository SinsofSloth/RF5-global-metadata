[TaskCategoryAttribute] // RVA: 0x1516C0 Offset: 0x1517C1 VA: 0x1516C0
[TaskDescriptionAttribute] // RVA: 0x1516C0 Offset: 0x1517C1 VA: 0x1516C0
public class GetMaxParticles : Action // TypeDefIndex: 11191
{
	// Fields
	[TooltipAttribute] // RVA: 0x18CBA0 Offset: 0x18CCA1 VA: 0x18CBA0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18CBE0 Offset: 0x18CCE1 VA: 0x18CBE0
	[RequiredFieldAttribute] // RVA: 0x18CBE0 Offset: 0x18CCE1 VA: 0x18CBE0
	public SharedFloat storeResult; // 0x58
	private ParticleSystem particleSystem; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x287A0D0 Offset: 0x287A1D1 VA: 0x287A0D0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x287A1D0 Offset: 0x287A2D1 VA: 0x287A1D0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287A2F0 Offset: 0x287A3F1 VA: 0x287A2F0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287A340 Offset: 0x287A441 VA: 0x287A340
	public void .ctor() { }
}


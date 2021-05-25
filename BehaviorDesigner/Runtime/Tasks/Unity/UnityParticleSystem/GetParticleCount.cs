[TaskCategoryAttribute] // RVA: 0x151720 Offset: 0x151821 VA: 0x151720
[TaskDescriptionAttribute] // RVA: 0x151720 Offset: 0x151821 VA: 0x151720
public class GetParticleCount : Action // TypeDefIndex: 11192
{
	// Fields
	[TooltipAttribute] // RVA: 0x18CC30 Offset: 0x18CD31 VA: 0x18CC30
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18CC70 Offset: 0x18CD71 VA: 0x18CC70
	[RequiredFieldAttribute] // RVA: 0x18CC70 Offset: 0x18CD71 VA: 0x18CC70
	public SharedFloat storeResult; // 0x58
	private ParticleSystem particleSystem; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x287A350 Offset: 0x287A451 VA: 0x287A350 Slot: 5
	public override void OnStart() { }

	// RVA: 0x287A450 Offset: 0x287A551 VA: 0x287A450 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287A550 Offset: 0x287A651 VA: 0x287A550 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287A5A0 Offset: 0x287A6A1 VA: 0x287A5A0
	public void .ctor() { }
}


[TaskCategoryAttribute] // RVA: 0x151660 Offset: 0x151761 VA: 0x151660
[TaskDescriptionAttribute] // RVA: 0x151660 Offset: 0x151761 VA: 0x151660
public class GetLoop : Action // TypeDefIndex: 11190
{
	// Fields
	[TooltipAttribute] // RVA: 0x18CB10 Offset: 0x18CC11 VA: 0x18CB10
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18CB50 Offset: 0x18CC51 VA: 0x18CB50
	[RequiredFieldAttribute] // RVA: 0x18CB50 Offset: 0x18CC51 VA: 0x18CB50
	public SharedBool storeResult; // 0x58
	private ParticleSystem particleSystem; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2879E50 Offset: 0x2879F51 VA: 0x2879E50 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2879F50 Offset: 0x287A051 VA: 0x2879F50 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287A070 Offset: 0x287A171 VA: 0x287A070 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287A0C0 Offset: 0x287A1C1 VA: 0x287A0C0
	public void .ctor() { }
}


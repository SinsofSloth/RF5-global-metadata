[TaskCategoryAttribute] // RVA: 0x151600 Offset: 0x151701 VA: 0x151600
[TaskDescriptionAttribute] // RVA: 0x151600 Offset: 0x151701 VA: 0x151600
public class GetEnableEmission : Action // TypeDefIndex: 11189
{
	// Fields
	[TooltipAttribute] // RVA: 0x18CA80 Offset: 0x18CB81 VA: 0x18CA80
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18CAC0 Offset: 0x18CBC1 VA: 0x18CAC0
	[RequiredFieldAttribute] // RVA: 0x18CAC0 Offset: 0x18CBC1 VA: 0x18CAC0
	public SharedBool storeResult; // 0x58
	private ParticleSystem particleSystem; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2879BD0 Offset: 0x2879CD1 VA: 0x2879BD0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2879CD0 Offset: 0x2879DD1 VA: 0x2879CD0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2879DF0 Offset: 0x2879EF1 VA: 0x2879DF0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2879E40 Offset: 0x2879F41 VA: 0x2879E40
	public void .ctor() { }
}


[TaskCategoryAttribute] // RVA: 0x151D20 Offset: 0x151E21 VA: 0x151D20
[TaskDescriptionAttribute] // RVA: 0x151D20 Offset: 0x151E21 VA: 0x151D20
public class SetStartLifetime : Action // TypeDefIndex: 11208
{
	// Fields
	[TooltipAttribute] // RVA: 0x18D2E0 Offset: 0x18D3E1 VA: 0x18D2E0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18D320 Offset: 0x18D421 VA: 0x18D320
	public SharedFloat startLifetime; // 0x58
	private ParticleSystem particleSystem; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x287C7E0 Offset: 0x287C8E1 VA: 0x287C7E0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x287C8E0 Offset: 0x287C9E1 VA: 0x287C8E0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287CA10 Offset: 0x287CB11 VA: 0x287CA10 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287CA60 Offset: 0x287CB61 VA: 0x287CA60
	public void .ctor() { }
}


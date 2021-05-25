[TaskCategoryAttribute] // RVA: 0x152380 Offset: 0x152481 VA: 0x152380
[TaskDescriptionAttribute] // RVA: 0x152380 Offset: 0x152481 VA: 0x152380
public class SetAcceleration : Action // TypeDefIndex: 11225
{
	// Fields
	[TooltipAttribute] // RVA: 0x18DAC0 Offset: 0x18DBC1 VA: 0x18DAC0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18DB00 Offset: 0x18DC01 VA: 0x18DB00
	public SharedFloat acceleration; // 0x58
	private NavMeshAgent navMeshAgent; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x28784D0 Offset: 0x28785D1 VA: 0x28784D0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x28785D0 Offset: 0x28786D1 VA: 0x28785D0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x28786C0 Offset: 0x28787C1 VA: 0x28786C0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2878710 Offset: 0x2878811 VA: 0x2878710
	public void .ctor() { }
}


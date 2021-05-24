[TaskCategoryAttribute] // RVA: 0x152440 Offset: 0x152541 VA: 0x152440
[TaskDescriptionAttribute] // RVA: 0x152440 Offset: 0x152541 VA: 0x152440
public class SetDestination : Action // TypeDefIndex: 11227
{
	// Fields
	[TooltipAttribute] // RVA: 0x18DBC0 Offset: 0x18DCC1 VA: 0x18DBC0
	public SharedGameObject targetGameObject; // 0x50
	[SharedRequiredAttribute] // RVA: 0x18DC00 Offset: 0x18DD01 VA: 0x18DC00
	[TooltipAttribute] // RVA: 0x18DC00 Offset: 0x18DD01 VA: 0x18DC00
	public SharedVector3 destination; // 0x58
	private NavMeshAgent navMeshAgent; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2878970 Offset: 0x2878A71 VA: 0x2878970 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2878A70 Offset: 0x2878B71 VA: 0x2878A70 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2878B70 Offset: 0x2878C71 VA: 0x2878B70 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2878C00 Offset: 0x2878D01 VA: 0x2878C00
	public void .ctor() { }
}


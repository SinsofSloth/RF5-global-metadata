[TaskCategoryAttribute] // RVA: 0x152320 Offset: 0x152421 VA: 0x152320
[TaskDescriptionAttribute] // RVA: 0x152320 Offset: 0x152421 VA: 0x152320
public class Resume : Action // TypeDefIndex: 11224
{
	// Fields
	[TooltipAttribute] // RVA: 0x18DA80 Offset: 0x18DB81 VA: 0x18DA80
	public SharedGameObject targetGameObject; // 0x50
	private NavMeshAgent navMeshAgent; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x28782D0 Offset: 0x28783D1 VA: 0x28782D0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x28783D0 Offset: 0x28784D1 VA: 0x28783D0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x28784B0 Offset: 0x28785B1 VA: 0x28784B0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x28784C0 Offset: 0x28785C1 VA: 0x28784C0
	public void .ctor() { }
}


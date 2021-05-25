[TaskCategoryAttribute] // RVA: 0x152560 Offset: 0x152661 VA: 0x152560
[TaskDescriptionAttribute] // RVA: 0x152560 Offset: 0x152661 VA: 0x152560
public class Stop : Action // TypeDefIndex: 11230
{
	// Fields
	[TooltipAttribute] // RVA: 0x18DD50 Offset: 0x18DE51 VA: 0x18DD50
	public SharedGameObject targetGameObject; // 0x50
	private NavMeshAgent navMeshAgent; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x2879080 Offset: 0x2879181 VA: 0x2879080 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2879180 Offset: 0x2879281 VA: 0x2879180 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2879260 Offset: 0x2879361 VA: 0x2879260 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2879270 Offset: 0x2879371 VA: 0x2879270
	public void .ctor() { }
}


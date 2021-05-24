[TaskCategoryAttribute] // RVA: 0x1525C0 Offset: 0x1526C1 VA: 0x1525C0
[TaskDescriptionAttribute] // RVA: 0x1525C0 Offset: 0x1526C1 VA: 0x1525C0
public class Warp : Action // TypeDefIndex: 11231
{
	// Fields
	[TooltipAttribute] // RVA: 0x18DD90 Offset: 0x18DE91 VA: 0x18DD90
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18DDD0 Offset: 0x18DED1 VA: 0x18DDD0
	public SharedVector3 newPosition; // 0x58
	private NavMeshAgent navMeshAgent; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2879280 Offset: 0x2879381 VA: 0x2879280 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2879380 Offset: 0x2879481 VA: 0x2879380 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2879470 Offset: 0x2879571 VA: 0x2879470 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2879500 Offset: 0x2879601 VA: 0x2879500
	public void .ctor() { }
}


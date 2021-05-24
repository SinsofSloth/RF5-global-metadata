[TaskCategoryAttribute] // RVA: 0x152200 Offset: 0x152301 VA: 0x152200
[TaskDescriptionAttribute] // RVA: 0x152200 Offset: 0x152301 VA: 0x152200
public class IsStopped : Conditional // TypeDefIndex: 11221
{
	// Fields
	[TooltipAttribute] // RVA: 0x18D980 Offset: 0x18DA81 VA: 0x18D980
	public SharedGameObject targetGameObject; // 0x50
	private NavMeshAgent navMeshAgent; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x2877C40 Offset: 0x2877D41 VA: 0x2877C40 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2877D40 Offset: 0x2877E41 VA: 0x2877D40 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2877E20 Offset: 0x2877F21 VA: 0x2877E20 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2877E30 Offset: 0x2877F31 VA: 0x2877E30
	public void .ctor() { }
}


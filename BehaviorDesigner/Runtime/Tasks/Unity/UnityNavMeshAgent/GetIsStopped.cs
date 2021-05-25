[TaskCategoryAttribute] // RVA: 0x1520E0 Offset: 0x1521E1 VA: 0x1520E0
[TaskDescriptionAttribute] // RVA: 0x1520E0 Offset: 0x1521E1 VA: 0x1520E0
public class GetIsStopped : Action // TypeDefIndex: 11218
{
	// Fields
	[TooltipAttribute] // RVA: 0x18D7D0 Offset: 0x18D8D1 VA: 0x18D7D0
	public SharedGameObject targetGameObject; // 0x50
	[SharedRequiredAttribute] // RVA: 0x18D810 Offset: 0x18D911 VA: 0x18D810
	[TooltipAttribute] // RVA: 0x18D810 Offset: 0x18D911 VA: 0x18D810
	public SharedBool storeValue; // 0x58
	private NavMeshAgent navMeshAgent; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27A5D50 Offset: 0x27A5E51 VA: 0x27A5D50 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27A5E50 Offset: 0x27A5F51 VA: 0x27A5E50 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A5F50 Offset: 0x27A6051 VA: 0x27A5F50 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A5F90 Offset: 0x27A6091 VA: 0x27A5F90
	public void .ctor() { }
}


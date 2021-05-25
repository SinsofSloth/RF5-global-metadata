[TaskCategoryAttribute] // RVA: 0x152080 Offset: 0x152181 VA: 0x152080
[TaskDescriptionAttribute] // RVA: 0x152080 Offset: 0x152181 VA: 0x152080
public class GetDestination : Action // TypeDefIndex: 11217
{
	// Fields
	[TooltipAttribute] // RVA: 0x18D740 Offset: 0x18D841 VA: 0x18D740
	public SharedGameObject targetGameObject; // 0x50
	[SharedRequiredAttribute] // RVA: 0x18D780 Offset: 0x18D881 VA: 0x18D780
	[TooltipAttribute] // RVA: 0x18D780 Offset: 0x18D881 VA: 0x18D780
	public SharedVector3 storeValue; // 0x58
	private NavMeshAgent navMeshAgent; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27A5AC0 Offset: 0x27A5BC1 VA: 0x27A5AC0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27A5BC0 Offset: 0x27A5CC1 VA: 0x27A5BC0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A5CB0 Offset: 0x27A5DB1 VA: 0x27A5CB0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A5D40 Offset: 0x27A5E41 VA: 0x27A5D40
	public void .ctor() { }
}


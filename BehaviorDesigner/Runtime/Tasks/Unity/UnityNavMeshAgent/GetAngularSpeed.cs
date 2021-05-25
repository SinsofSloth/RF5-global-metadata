[TaskCategoryAttribute] // RVA: 0x152020 Offset: 0x152121 VA: 0x152020
[TaskDescriptionAttribute] // RVA: 0x152020 Offset: 0x152121 VA: 0x152020
public class GetAngularSpeed : Action // TypeDefIndex: 11216
{
	// Fields
	[TooltipAttribute] // RVA: 0x18D6B0 Offset: 0x18D7B1 VA: 0x18D6B0
	public SharedGameObject targetGameObject; // 0x50
	[SharedRequiredAttribute] // RVA: 0x18D6F0 Offset: 0x18D7F1 VA: 0x18D6F0
	[TooltipAttribute] // RVA: 0x18D6F0 Offset: 0x18D7F1 VA: 0x18D6F0
	public SharedFloat storeValue; // 0x58
	private NavMeshAgent navMeshAgent; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27A5870 Offset: 0x27A5971 VA: 0x27A5870 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27A5970 Offset: 0x27A5A71 VA: 0x27A5970 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A5A60 Offset: 0x27A5B61 VA: 0x27A5A60 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A5AB0 Offset: 0x27A5BB1 VA: 0x27A5AB0
	public void .ctor() { }
}


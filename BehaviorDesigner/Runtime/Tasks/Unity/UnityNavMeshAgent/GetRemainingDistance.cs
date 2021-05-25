[TaskCategoryAttribute] // RVA: 0x152140 Offset: 0x152241 VA: 0x152140
[TaskDescriptionAttribute] // RVA: 0x152140 Offset: 0x152241 VA: 0x152140
public class GetRemainingDistance : Action // TypeDefIndex: 11219
{
	// Fields
	[TooltipAttribute] // RVA: 0x18D860 Offset: 0x18D961 VA: 0x18D860
	public SharedGameObject targetGameObject; // 0x50
	[SharedRequiredAttribute] // RVA: 0x18D8A0 Offset: 0x18D9A1 VA: 0x18D8A0
	[TooltipAttribute] // RVA: 0x18D8A0 Offset: 0x18D9A1 VA: 0x18D8A0
	public SharedFloat storeValue; // 0x58
	private NavMeshAgent navMeshAgent; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27A5FA0 Offset: 0x27A60A1 VA: 0x27A5FA0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27A60A0 Offset: 0x27A61A1 VA: 0x27A60A0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A6190 Offset: 0x27A6291 VA: 0x27A6190 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A61E0 Offset: 0x27A62E1 VA: 0x27A61E0
	public void .ctor() { }
}


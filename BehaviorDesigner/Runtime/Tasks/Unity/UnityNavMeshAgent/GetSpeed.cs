[TaskCategoryAttribute] // RVA: 0x1521A0 Offset: 0x1522A1 VA: 0x1521A0
[TaskDescriptionAttribute] // RVA: 0x1521A0 Offset: 0x1522A1 VA: 0x1521A0
public class GetSpeed : Action // TypeDefIndex: 11220
{
	// Fields
	[TooltipAttribute] // RVA: 0x18D8F0 Offset: 0x18D9F1 VA: 0x18D8F0
	public SharedGameObject targetGameObject; // 0x50
	[SharedRequiredAttribute] // RVA: 0x18D930 Offset: 0x18DA31 VA: 0x18D930
	[TooltipAttribute] // RVA: 0x18D930 Offset: 0x18DA31 VA: 0x18D930
	public SharedFloat storeValue; // 0x58
	private NavMeshAgent navMeshAgent; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27A61F0 Offset: 0x27A62F1 VA: 0x27A61F0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27A62F0 Offset: 0x27A63F1 VA: 0x27A62F0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A63E0 Offset: 0x27A64E1 VA: 0x27A63E0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A6430 Offset: 0x27A6531 VA: 0x27A6430
	public void .ctor() { }
}


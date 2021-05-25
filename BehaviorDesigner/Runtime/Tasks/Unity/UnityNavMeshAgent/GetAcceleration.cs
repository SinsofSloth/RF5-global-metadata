[TaskCategoryAttribute] // RVA: 0x151FC0 Offset: 0x1520C1 VA: 0x151FC0
[TaskDescriptionAttribute] // RVA: 0x151FC0 Offset: 0x1520C1 VA: 0x151FC0
public class GetAcceleration : Action // TypeDefIndex: 11215
{
	// Fields
	[TooltipAttribute] // RVA: 0x18D620 Offset: 0x18D721 VA: 0x18D620
	public SharedGameObject targetGameObject; // 0x50
	[SharedRequiredAttribute] // RVA: 0x18D660 Offset: 0x18D761 VA: 0x18D660
	[TooltipAttribute] // RVA: 0x18D660 Offset: 0x18D761 VA: 0x18D660
	public SharedFloat storeValue; // 0x58
	private NavMeshAgent navMeshAgent; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27A5620 Offset: 0x27A5721 VA: 0x27A5620 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27A5720 Offset: 0x27A5821 VA: 0x27A5720 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A5810 Offset: 0x27A5911 VA: 0x27A5810 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A5860 Offset: 0x27A5961 VA: 0x27A5860
	public void .ctor() { }
}


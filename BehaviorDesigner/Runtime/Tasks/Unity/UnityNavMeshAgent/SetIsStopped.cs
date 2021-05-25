[TaskCategoryAttribute] // RVA: 0x1524A0 Offset: 0x1525A1 VA: 0x1524A0
[TaskDescriptionAttribute] // RVA: 0x1524A0 Offset: 0x1525A1 VA: 0x1524A0
public class SetIsStopped : Action // TypeDefIndex: 11228
{
	// Fields
	[TooltipAttribute] // RVA: 0x18DC50 Offset: 0x18DD51 VA: 0x18DC50
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18DC90 Offset: 0x18DD91 VA: 0x18DC90
	public SharedBool isStopped; // 0x58
	private NavMeshAgent navMeshAgent; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2878C10 Offset: 0x2878D11 VA: 0x2878C10 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2878D10 Offset: 0x2878E11 VA: 0x2878D10 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2878E10 Offset: 0x2878F11 VA: 0x2878E10 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2878E20 Offset: 0x2878F21 VA: 0x2878E20
	public void .ctor() { }
}


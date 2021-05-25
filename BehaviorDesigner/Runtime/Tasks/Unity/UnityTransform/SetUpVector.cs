[TaskCategoryAttribute] // RVA: 0x14DB90 Offset: 0x14DC91 VA: 0x14DB90
[TaskDescriptionAttribute] // RVA: 0x14DB90 Offset: 0x14DC91 VA: 0x14DB90
public class SetUpVector : Action // TypeDefIndex: 11034
{
	// Fields
	[TooltipAttribute] // RVA: 0x186D60 Offset: 0x186E61 VA: 0x186D60
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x186DA0 Offset: 0x186EA1 VA: 0x186DA0
	public SharedVector3 position; // 0x58
	private Transform targetTransform; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2890BA0 Offset: 0x2890CA1 VA: 0x2890BA0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2890CA0 Offset: 0x2890DA1 VA: 0x2890CA0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2890D90 Offset: 0x2890E91 VA: 0x2890D90 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2890E20 Offset: 0x2890F21 VA: 0x2890E20
	public void .ctor() { }
}


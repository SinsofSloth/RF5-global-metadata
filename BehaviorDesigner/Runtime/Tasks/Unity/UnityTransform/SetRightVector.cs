[TaskCategoryAttribute] // RVA: 0x14DAD0 Offset: 0x14DBD1 VA: 0x14DAD0
[TaskDescriptionAttribute] // RVA: 0x14DAD0 Offset: 0x14DBD1 VA: 0x14DAD0
public class SetRightVector : Action // TypeDefIndex: 11032
{
	// Fields
	[TooltipAttribute] // RVA: 0x186C60 Offset: 0x186D61 VA: 0x186C60
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x186CA0 Offset: 0x186DA1 VA: 0x186CA0
	public SharedVector3 position; // 0x58
	private Transform targetTransform; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2890680 Offset: 0x2890781 VA: 0x2890680 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2890780 Offset: 0x2890881 VA: 0x2890780 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2890870 Offset: 0x2890971 VA: 0x2890870 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2890900 Offset: 0x2890A01 VA: 0x2890900
	public void .ctor() { }
}


[TaskCategoryAttribute] // RVA: 0x14D710 Offset: 0x14D811 VA: 0x14D710
[TaskDescriptionAttribute] // RVA: 0x14D710 Offset: 0x14D811 VA: 0x14D710
public class Rotate : Action // TypeDefIndex: 11022
{
	// Fields
	[TooltipAttribute] // RVA: 0x1866A0 Offset: 0x1867A1 VA: 0x1866A0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1866E0 Offset: 0x1867E1 VA: 0x1866E0
	public SharedVector3 eulerAngles; // 0x58
	[TooltipAttribute] // RVA: 0x186720 Offset: 0x186821 VA: 0x186720
	public Space relativeTo; // 0x60
	private Transform targetTransform; // 0x68
	private GameObject prevGameObject; // 0x70

	// Methods

	// RVA: 0x288EC40 Offset: 0x288ED41 VA: 0x288EC40 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288ED40 Offset: 0x288EE41 VA: 0x288ED40 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288EE40 Offset: 0x288EF41 VA: 0x288EE40 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288EEE0 Offset: 0x288EFE1 VA: 0x288EEE0
	public void .ctor() { }
}


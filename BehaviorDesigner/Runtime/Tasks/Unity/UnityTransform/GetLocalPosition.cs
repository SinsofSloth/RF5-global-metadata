[TaskCategoryAttribute] // RVA: 0x14D350 Offset: 0x14D451 VA: 0x14D350
[TaskDescriptionAttribute] // RVA: 0x14D350 Offset: 0x14D451 VA: 0x14D350
public class GetLocalPosition : Action // TypeDefIndex: 11012
{
	// Fields
	[TooltipAttribute] // RVA: 0x1860A0 Offset: 0x1861A1 VA: 0x1860A0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1860E0 Offset: 0x1861E1 VA: 0x1860E0
	[RequiredFieldAttribute] // RVA: 0x1860E0 Offset: 0x1861E1 VA: 0x1860E0
	public SharedVector3 storeValue; // 0x58
	private Transform targetTransform; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x288D270 Offset: 0x288D371 VA: 0x288D270 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288D370 Offset: 0x288D471 VA: 0x288D370 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288D460 Offset: 0x288D561 VA: 0x288D460 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288D4F0 Offset: 0x288D5F1 VA: 0x288D4F0
	public void .ctor() { }
}


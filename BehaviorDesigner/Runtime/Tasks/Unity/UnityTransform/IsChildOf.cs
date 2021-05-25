[TaskCategoryAttribute] // RVA: 0x14D650 Offset: 0x14D751 VA: 0x14D650
[TaskDescriptionAttribute] // RVA: 0x14D650 Offset: 0x14D751 VA: 0x14D650
public class IsChildOf : Conditional // TypeDefIndex: 11020
{
	// Fields
	[TooltipAttribute] // RVA: 0x186520 Offset: 0x186621 VA: 0x186520
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x186560 Offset: 0x186661 VA: 0x186560
	public SharedTransform transformName; // 0x58
	private Transform targetTransform; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x288E6B0 Offset: 0x288E7B1 VA: 0x288E6B0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288E7B0 Offset: 0x288E8B1 VA: 0x288E7B0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288E8B0 Offset: 0x288E9B1 VA: 0x288E8B0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288E8F0 Offset: 0x288E9F1 VA: 0x288E8F0
	public void .ctor() { }
}


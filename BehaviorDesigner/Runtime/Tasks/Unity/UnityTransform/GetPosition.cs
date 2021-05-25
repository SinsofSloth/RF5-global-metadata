[TaskCategoryAttribute] // RVA: 0x14D4D0 Offset: 0x14D5D1 VA: 0x14D4D0
[TaskDescriptionAttribute] // RVA: 0x14D4D0 Offset: 0x14D5D1 VA: 0x14D4D0
public class GetPosition : Action // TypeDefIndex: 11016
{
	// Fields
	[TooltipAttribute] // RVA: 0x1862E0 Offset: 0x1863E1 VA: 0x1862E0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x186320 Offset: 0x186421 VA: 0x186320
	[RequiredFieldAttribute] // RVA: 0x186320 Offset: 0x186421 VA: 0x186320
	public SharedVector3 storeValue; // 0x58
	private Transform targetTransform; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x288DC70 Offset: 0x288DD71 VA: 0x288DC70 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288DD70 Offset: 0x288DE71 VA: 0x288DD70 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288DE60 Offset: 0x288DF61 VA: 0x288DE60 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288DEF0 Offset: 0x288DFF1 VA: 0x288DEF0
	public void .ctor() { }
}


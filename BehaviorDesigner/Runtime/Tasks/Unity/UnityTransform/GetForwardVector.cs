[TaskCategoryAttribute] // RVA: 0x14D290 Offset: 0x14D391 VA: 0x14D290
[TaskDescriptionAttribute] // RVA: 0x14D290 Offset: 0x14D391 VA: 0x14D290
public class GetForwardVector : Action // TypeDefIndex: 11010
{
	// Fields
	[TooltipAttribute] // RVA: 0x185F80 Offset: 0x186081 VA: 0x185F80
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x185FC0 Offset: 0x1860C1 VA: 0x185FC0
	[RequiredFieldAttribute] // RVA: 0x185FC0 Offset: 0x1860C1 VA: 0x185FC0
	public SharedVector3 storeValue; // 0x58
	private Transform targetTransform; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x288CD50 Offset: 0x288CE51 VA: 0x288CD50 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288CE50 Offset: 0x288CF51 VA: 0x288CE50 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288CF40 Offset: 0x288D041 VA: 0x288CF40 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288CFD0 Offset: 0x288D0D1 VA: 0x288CFD0
	public void .ctor() { }
}


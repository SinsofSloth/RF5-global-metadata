[TaskCategoryAttribute] // RVA: 0x14D1D0 Offset: 0x14D2D1 VA: 0x14D1D0
[TaskDescriptionAttribute] // RVA: 0x14D1D0 Offset: 0x14D2D1 VA: 0x14D1D0
public class GetChildCount : Action // TypeDefIndex: 11008
{
	// Fields
	[TooltipAttribute] // RVA: 0x185E60 Offset: 0x185F61 VA: 0x185E60
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x185EA0 Offset: 0x185FA1 VA: 0x185EA0
	[RequiredFieldAttribute] // RVA: 0x185EA0 Offset: 0x185FA1 VA: 0x185EA0
	public SharedInt storeValue; // 0x58
	private Transform targetTransform; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x288C860 Offset: 0x288C961 VA: 0x288C860 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288C960 Offset: 0x288CA61 VA: 0x288C960 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288CA60 Offset: 0x288CB61 VA: 0x288CA60 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288CAB0 Offset: 0x288CBB1 VA: 0x288CAB0
	public void .ctor() { }
}


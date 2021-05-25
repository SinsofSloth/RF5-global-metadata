[TaskCategoryAttribute] // RVA: 0x14D7D0 Offset: 0x14D8D1 VA: 0x14D7D0
[TaskDescriptionAttribute] // RVA: 0x14D7D0 Offset: 0x14D8D1 VA: 0x14D7D0
public class SetEulerAngles : Action // TypeDefIndex: 11024
{
	// Fields
	[TooltipAttribute] // RVA: 0x186860 Offset: 0x186961 VA: 0x186860
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1868A0 Offset: 0x1869A1 VA: 0x1868A0
	public SharedVector3 eulerAngles; // 0x58
	private Transform targetTransform; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x288F240 Offset: 0x288F341 VA: 0x288F240 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288F340 Offset: 0x288F441 VA: 0x288F340 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288F430 Offset: 0x288F531 VA: 0x288F430 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288F4C0 Offset: 0x288F5C1 VA: 0x288F4C0
	public void .ctor() { }
}


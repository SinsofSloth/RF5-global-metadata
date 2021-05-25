[TaskCategoryAttribute] // RVA: 0x14D950 Offset: 0x14DA51 VA: 0x14D950
[TaskDescriptionAttribute] // RVA: 0x14D950 Offset: 0x14DA51 VA: 0x14D950
public class SetLocalRotation : Action // TypeDefIndex: 11028
{
	// Fields
	[TooltipAttribute] // RVA: 0x186A60 Offset: 0x186B61 VA: 0x186A60
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x186AA0 Offset: 0x186BA1 VA: 0x186AA0
	public SharedQuaternion localRotation; // 0x58
	private Transform targetTransform; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x288FC80 Offset: 0x288FD81 VA: 0x288FC80 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288FD80 Offset: 0x288FE81 VA: 0x288FD80 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288FE70 Offset: 0x288FF71 VA: 0x288FE70 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288FF00 Offset: 0x2890001 VA: 0x288FF00
	public void .ctor() { }
}


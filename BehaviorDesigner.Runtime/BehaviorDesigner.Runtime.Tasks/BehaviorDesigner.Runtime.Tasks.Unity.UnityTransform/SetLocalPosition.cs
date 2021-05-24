[TaskCategoryAttribute] // RVA: 0x14D8F0 Offset: 0x14D9F1 VA: 0x14D8F0
[TaskDescriptionAttribute] // RVA: 0x14D8F0 Offset: 0x14D9F1 VA: 0x14D8F0
public class SetLocalPosition : Action // TypeDefIndex: 11027
{
	// Fields
	[TooltipAttribute] // RVA: 0x1869E0 Offset: 0x186AE1 VA: 0x1869E0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x186A20 Offset: 0x186B21 VA: 0x186A20
	public SharedVector3 localPosition; // 0x58
	private Transform targetTransform; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x288F9F0 Offset: 0x288FAF1 VA: 0x288F9F0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288FAF0 Offset: 0x288FBF1 VA: 0x288FAF0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288FBE0 Offset: 0x288FCE1 VA: 0x288FBE0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288FC70 Offset: 0x288FD71 VA: 0x288FC70
	public void .ctor() { }
}


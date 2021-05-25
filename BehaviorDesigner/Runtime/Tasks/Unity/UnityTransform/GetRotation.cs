[TaskCategoryAttribute] // RVA: 0x14D590 Offset: 0x14D691 VA: 0x14D590
[TaskDescriptionAttribute] // RVA: 0x14D590 Offset: 0x14D691 VA: 0x14D590
public class GetRotation : Action // TypeDefIndex: 11018
{
	// Fields
	[TooltipAttribute] // RVA: 0x186400 Offset: 0x186501 VA: 0x186400
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x186440 Offset: 0x186541 VA: 0x186440
	[RequiredFieldAttribute] // RVA: 0x186440 Offset: 0x186541 VA: 0x186440
	public SharedQuaternion storeValue; // 0x58
	private Transform targetTransform; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x288E190 Offset: 0x288E291 VA: 0x288E190 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288E290 Offset: 0x288E391 VA: 0x288E290 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288E380 Offset: 0x288E481 VA: 0x288E380 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288E410 Offset: 0x288E511 VA: 0x288E410
	public void .ctor() { }
}


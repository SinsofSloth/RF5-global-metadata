[TaskCategoryAttribute] // RVA: 0x14D410 Offset: 0x14D511 VA: 0x14D410
[TaskDescriptionAttribute] // RVA: 0x14D410 Offset: 0x14D511 VA: 0x14D410
public class GetLocalScale : Action // TypeDefIndex: 11014
{
	// Fields
	[TooltipAttribute] // RVA: 0x1861C0 Offset: 0x1862C1 VA: 0x1861C0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x186200 Offset: 0x186301 VA: 0x186200
	[RequiredFieldAttribute] // RVA: 0x186200 Offset: 0x186301 VA: 0x186200
	public SharedVector3 storeValue; // 0x58
	private Transform targetTransform; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x288D790 Offset: 0x288D891 VA: 0x288D790 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288D890 Offset: 0x288D991 VA: 0x288D890 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288D980 Offset: 0x288DA81 VA: 0x288D980 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288DA10 Offset: 0x288DB11 VA: 0x288DA10
	public void .ctor() { }
}


[TaskCategoryAttribute] // RVA: 0x14D470 Offset: 0x14D571 VA: 0x14D470
[TaskDescriptionAttribute] // RVA: 0x14D470 Offset: 0x14D571 VA: 0x14D470
public class GetParent : Action // TypeDefIndex: 11015
{
	// Fields
	[TooltipAttribute] // RVA: 0x186250 Offset: 0x186351 VA: 0x186250
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x186290 Offset: 0x186391 VA: 0x186290
	[RequiredFieldAttribute] // RVA: 0x186290 Offset: 0x186391 VA: 0x186290
	public SharedTransform storeValue; // 0x58
	private Transform targetTransform; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x288DA20 Offset: 0x288DB21 VA: 0x288DA20 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288DB20 Offset: 0x288DC21 VA: 0x288DB20 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288DC20 Offset: 0x288DD21 VA: 0x288DC20 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288DC60 Offset: 0x288DD61 VA: 0x288DC60
	public void .ctor() { }
}


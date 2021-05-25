[TaskCategoryAttribute] // RVA: 0x14D170 Offset: 0x14D271 VA: 0x14D170
[TaskDescriptionAttribute] // RVA: 0x14D170 Offset: 0x14D271 VA: 0x14D170
public class GetChild : Action // TypeDefIndex: 11007
{
	// Fields
	[TooltipAttribute] // RVA: 0x185D90 Offset: 0x185E91 VA: 0x185D90
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x185DD0 Offset: 0x185ED1 VA: 0x185DD0
	public SharedInt index; // 0x58
	[TooltipAttribute] // RVA: 0x185E10 Offset: 0x185F11 VA: 0x185E10
	[RequiredFieldAttribute] // RVA: 0x185E10 Offset: 0x185F11 VA: 0x185E10
	public SharedTransform storeValue; // 0x60
	private Transform targetTransform; // 0x68
	private GameObject prevGameObject; // 0x70

	// Methods

	// RVA: 0x288C5F0 Offset: 0x288C6F1 VA: 0x288C5F0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288C6F0 Offset: 0x288C7F1 VA: 0x288C6F0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288C800 Offset: 0x288C901 VA: 0x288C800 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288C850 Offset: 0x288C951 VA: 0x288C850
	public void .ctor() { }
}


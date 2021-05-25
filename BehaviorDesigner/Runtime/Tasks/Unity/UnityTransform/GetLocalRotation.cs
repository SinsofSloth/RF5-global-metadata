[TaskCategoryAttribute] // RVA: 0x14D3B0 Offset: 0x14D4B1 VA: 0x14D3B0
[TaskDescriptionAttribute] // RVA: 0x14D3B0 Offset: 0x14D4B1 VA: 0x14D3B0
public class GetLocalRotation : Action // TypeDefIndex: 11013
{
	// Fields
	[TooltipAttribute] // RVA: 0x186130 Offset: 0x186231 VA: 0x186130
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x186170 Offset: 0x186271 VA: 0x186170
	[RequiredFieldAttribute] // RVA: 0x186170 Offset: 0x186271 VA: 0x186170
	public SharedQuaternion storeValue; // 0x58
	private Transform targetTransform; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x288D500 Offset: 0x288D601 VA: 0x288D500 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288D600 Offset: 0x288D701 VA: 0x288D600 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288D6F0 Offset: 0x288D7F1 VA: 0x288D6F0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288D780 Offset: 0x288D881 VA: 0x288D780
	public void .ctor() { }
}


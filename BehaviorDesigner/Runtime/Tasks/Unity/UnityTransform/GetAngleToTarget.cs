[TaskCategoryAttribute] // RVA: 0x14D110 Offset: 0x14D211 VA: 0x14D110
[TaskDescriptionAttribute] // RVA: 0x14D110 Offset: 0x14D211 VA: 0x14D110
public class GetAngleToTarget : Action // TypeDefIndex: 11006
{
	// Fields
	[TooltipAttribute] // RVA: 0x185C40 Offset: 0x185D41 VA: 0x185C40
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x185C80 Offset: 0x185D81 VA: 0x185C80
	public SharedGameObject targetObject; // 0x58
	[TooltipAttribute] // RVA: 0x185CC0 Offset: 0x185DC1 VA: 0x185CC0
	public SharedVector3 targetPosition; // 0x60
	[TooltipAttribute] // RVA: 0x185D00 Offset: 0x185E01 VA: 0x185D00
	public SharedBool ignoreHeight; // 0x68
	[TooltipAttribute] // RVA: 0x185D40 Offset: 0x185E41 VA: 0x185D40
	[RequiredFieldAttribute] // RVA: 0x185D40 Offset: 0x185E41 VA: 0x185D40
	public SharedFloat storeValue; // 0x70
	private Transform targetTransform; // 0x78
	private GameObject prevGameObject; // 0x80

	// Methods

	// RVA: 0x288C150 Offset: 0x288C251 VA: 0x288C150 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288C250 Offset: 0x288C351 VA: 0x288C250 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288C4D0 Offset: 0x288C5D1 VA: 0x288C4D0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288C5B0 Offset: 0x288C6B1 VA: 0x288C5B0
	public void .ctor() { }
}


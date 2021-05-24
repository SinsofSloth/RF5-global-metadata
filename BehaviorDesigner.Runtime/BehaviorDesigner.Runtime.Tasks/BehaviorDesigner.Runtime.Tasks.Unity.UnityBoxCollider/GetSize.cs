[TaskCategoryAttribute] // RVA: 0x154D80 Offset: 0x154E81 VA: 0x154D80
[TaskDescriptionAttribute] // RVA: 0x154D80 Offset: 0x154E81 VA: 0x154D80
public class GetSize : Action // TypeDefIndex: 11342
{
	// Fields
	[TooltipAttribute] // RVA: 0x1917C0 Offset: 0x1918C1 VA: 0x1917C0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x191800 Offset: 0x191901 VA: 0x191800
	[RequiredFieldAttribute] // RVA: 0x191800 Offset: 0x191901 VA: 0x191800
	public SharedVector3 storeValue; // 0x58
	private BoxCollider boxCollider; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279B3B0 Offset: 0x279B4B1 VA: 0x279B3B0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279B4B0 Offset: 0x279B5B1 VA: 0x279B4B0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279B5A0 Offset: 0x279B6A1 VA: 0x279B5A0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279B630 Offset: 0x279B731 VA: 0x279B630
	public void .ctor() { }
}


[TaskDescriptionAttribute] // RVA: 0x14BDD0 Offset: 0x14BED1 VA: 0x14BDD0
[TaskCategoryAttribute] // RVA: 0x14BDD0 Offset: 0x14BED1 VA: 0x14BDD0
public class HasExitedTrigger : Conditional // TypeDefIndex: 10953
{
	// Fields
	[TooltipAttribute] // RVA: 0x183BD0 Offset: 0x183CD1 VA: 0x183BD0
	public SharedString tag; // 0x50
	[TooltipAttribute] // RVA: 0x183C10 Offset: 0x183D11 VA: 0x183C10
	public SharedGameObject otherGameObject; // 0x58
	private bool exitedTrigger; // 0x60

	// Methods

	// RVA: 0x20E0290 Offset: 0x20E0391 VA: 0x20E0290 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20E02B0 Offset: 0x20E03B1 VA: 0x20E02B0 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x20E02C0 Offset: 0x20E03C1 VA: 0x20E02C0 Slot: 21
	public override void OnTriggerExit(Collider other) { }

	// RVA: 0x20E03B0 Offset: 0x20E04B1 VA: 0x20E03B0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20E04B0 Offset: 0x20E05B1 VA: 0x20E04B0
	public void .ctor() { }
}


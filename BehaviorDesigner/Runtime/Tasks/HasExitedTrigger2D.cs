[TaskDescriptionAttribute] // RVA: 0x14BE30 Offset: 0x14BF31 VA: 0x14BE30
[TaskCategoryAttribute] // RVA: 0x14BE30 Offset: 0x14BF31 VA: 0x14BE30
public class HasExitedTrigger2D : Conditional // TypeDefIndex: 10954
{
	// Fields
	[TooltipAttribute] // RVA: 0x183C50 Offset: 0x183D51 VA: 0x183C50
	public SharedString tag; // 0x50
	[TooltipAttribute] // RVA: 0x183C90 Offset: 0x183D91 VA: 0x183C90
	public SharedGameObject otherGameObject; // 0x58
	private bool exitedTrigger; // 0x60

	// Methods

	// RVA: 0x20E05B0 Offset: 0x20E06B1 VA: 0x20E05B0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20E05D0 Offset: 0x20E06D1 VA: 0x20E05D0 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x20E05E0 Offset: 0x20E06E1 VA: 0x20E05E0 Slot: 25
	public override void OnTriggerExit2D(Collider2D other) { }

	// RVA: 0x20E06D0 Offset: 0x20E07D1 VA: 0x20E06D0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20E07D0 Offset: 0x20E08D1 VA: 0x20E07D0
	public void .ctor() { }
}


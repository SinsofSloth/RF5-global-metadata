[TaskCategoryAttribute] // RVA: 0x14ED30 Offset: 0x14EE31 VA: 0x14ED30
[TaskDescriptionAttribute] // RVA: 0x14ED30 Offset: 0x14EE31 VA: 0x14ED30
public class SetSharedInt : Action // TypeDefIndex: 11081
{
	// Fields
	[TooltipAttribute] // RVA: 0x188590 Offset: 0x188691 VA: 0x188590
	public SharedInt targetValue; // 0x50
	[RequiredFieldAttribute] // RVA: 0x1885D0 Offset: 0x1886D1 VA: 0x1885D0
	[TooltipAttribute] // RVA: 0x1885D0 Offset: 0x1886D1 VA: 0x1885D0
	public SharedInt targetVariable; // 0x58

	// Methods

	// RVA: 0x278C480 Offset: 0x278C581 VA: 0x278C480 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278C500 Offset: 0x278C601 VA: 0x278C500 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278C550 Offset: 0x278C651 VA: 0x278C550
	public void .ctor() { }
}


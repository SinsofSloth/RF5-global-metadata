[TaskCategoryAttribute] // RVA: 0x14ED90 Offset: 0x14EE91 VA: 0x14ED90
[TaskDescriptionAttribute] // RVA: 0x14ED90 Offset: 0x14EE91 VA: 0x14ED90
public class SetSharedObject : Action // TypeDefIndex: 11082
{
	// Fields
	[TooltipAttribute] // RVA: 0x188620 Offset: 0x188721 VA: 0x188620
	public SharedObject targetValue; // 0x50
	[RequiredFieldAttribute] // RVA: 0x188660 Offset: 0x188761 VA: 0x188660
	[TooltipAttribute] // RVA: 0x188660 Offset: 0x188761 VA: 0x188660
	public SharedObject targetVariable; // 0x58

	// Methods

	// RVA: 0x278C560 Offset: 0x278C661 VA: 0x278C560 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278C5E0 Offset: 0x278C6E1 VA: 0x278C5E0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278C620 Offset: 0x278C721 VA: 0x278C620
	public void .ctor() { }
}


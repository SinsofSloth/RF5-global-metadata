[TaskCategoryAttribute] // RVA: 0x1541E0 Offset: 0x1542E1 VA: 0x1541E0
[TaskDescriptionAttribute] // RVA: 0x1541E0 Offset: 0x1542E1 VA: 0x1541E0
public class SetEnabled : Action // TypeDefIndex: 11311
{
	// Fields
	[TooltipAttribute] // RVA: 0x190760 Offset: 0x190861 VA: 0x190760
	public SharedCollider specifiedCollider; // 0x50
	[TooltipAttribute] // RVA: 0x1907A0 Offset: 0x1908A1 VA: 0x1907A0
	public SharedBool enabled; // 0x58

	// Methods

	// RVA: 0x20E9B90 Offset: 0x20E9C91 VA: 0x20E9B90 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20E9C70 Offset: 0x20E9D71 VA: 0x20E9C70 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20E9D60 Offset: 0x20E9E61 VA: 0x20E9D60
	public void .ctor() { }
}


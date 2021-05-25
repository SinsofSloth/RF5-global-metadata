[TaskCategoryAttribute] // RVA: 0x14CED0 Offset: 0x14CFD1 VA: 0x14CED0
[TaskDescriptionAttribute] // RVA: 0x14CED0 Offset: 0x14CFD1 VA: 0x14CED0
public class Multiply : Action // TypeDefIndex: 10999
{
	// Fields
	[TooltipAttribute] // RVA: 0x1857D0 Offset: 0x1858D1 VA: 0x1857D0
	public SharedVector2 vector2Variable; // 0x50
	[TooltipAttribute] // RVA: 0x185810 Offset: 0x185911 VA: 0x185810
	public SharedFloat multiplyBy; // 0x58
	[TooltipAttribute] // RVA: 0x185850 Offset: 0x185951 VA: 0x185850
	[RequiredFieldAttribute] // RVA: 0x185850 Offset: 0x185951 VA: 0x185850
	public SharedVector2 storeResult; // 0x60

	// Methods

	// RVA: 0x2892220 Offset: 0x2892321 VA: 0x2892220 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2892310 Offset: 0x2892411 VA: 0x2892310 Slot: 16
	public override void OnReset() { }

	// RVA: 0x28923C0 Offset: 0x28924C1 VA: 0x28923C0
	public void .ctor() { }
}


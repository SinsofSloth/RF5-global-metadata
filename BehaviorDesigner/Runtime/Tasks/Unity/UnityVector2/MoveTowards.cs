[TaskCategoryAttribute] // RVA: 0x14CE70 Offset: 0x14CF71 VA: 0x14CE70
[TaskDescriptionAttribute] // RVA: 0x14CE70 Offset: 0x14CF71 VA: 0x14CE70
public class MoveTowards : Action // TypeDefIndex: 10998
{
	// Fields
	[TooltipAttribute] // RVA: 0x1856C0 Offset: 0x1857C1 VA: 0x1856C0
	public SharedVector2 currentPosition; // 0x50
	[TooltipAttribute] // RVA: 0x185700 Offset: 0x185801 VA: 0x185700
	public SharedVector2 targetPosition; // 0x58
	[TooltipAttribute] // RVA: 0x185740 Offset: 0x185841 VA: 0x185740
	public SharedFloat speed; // 0x60
	[TooltipAttribute] // RVA: 0x185780 Offset: 0x185881 VA: 0x185780
	[RequiredFieldAttribute] // RVA: 0x185780 Offset: 0x185881 VA: 0x185780
	public SharedVector2 storeResult; // 0x68

	// Methods

	// RVA: 0x2892010 Offset: 0x2892111 VA: 0x2892010 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2892130 Offset: 0x2892231 VA: 0x2892130 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2892210 Offset: 0x2892311 VA: 0x2892210
	public void .ctor() { }
}


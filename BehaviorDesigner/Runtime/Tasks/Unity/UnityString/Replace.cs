[TaskCategoryAttribute] // RVA: 0x14E310 Offset: 0x14E411 VA: 0x14E310
[TaskDescriptionAttribute] // RVA: 0x14E310 Offset: 0x14E411 VA: 0x14E310
public class Replace : Action // TypeDefIndex: 11054
{
	// Fields
	[TooltipAttribute] // RVA: 0x1876C0 Offset: 0x1877C1 VA: 0x1876C0
	public SharedString targetString; // 0x50
	[TooltipAttribute] // RVA: 0x187700 Offset: 0x187801 VA: 0x187700
	public SharedString oldString; // 0x58
	[TooltipAttribute] // RVA: 0x187740 Offset: 0x187841 VA: 0x187740
	public SharedString newString; // 0x60
	[TooltipAttribute] // RVA: 0x187780 Offset: 0x187881 VA: 0x187780
	[RequiredFieldAttribute] // RVA: 0x187780 Offset: 0x187881 VA: 0x187780
	public SharedString storeResult; // 0x68

	// Methods

	// RVA: 0x288B7F0 Offset: 0x288B8F1 VA: 0x288B7F0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288B8C0 Offset: 0x288B9C1 VA: 0x288B8C0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288B980 Offset: 0x288BA81 VA: 0x288B980
	public void .ctor() { }
}


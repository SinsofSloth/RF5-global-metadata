[TaskCategoryAttribute] // RVA: 0x14E250 Offset: 0x14E351 VA: 0x14E250
[TaskDescriptionAttribute] // RVA: 0x14E250 Offset: 0x14E351 VA: 0x14E250
public class GetSubstring : Action // TypeDefIndex: 11052
{
	// Fields
	[TooltipAttribute] // RVA: 0x187570 Offset: 0x187671 VA: 0x187570
	public SharedString targetString; // 0x50
	[TooltipAttribute] // RVA: 0x1875B0 Offset: 0x1876B1 VA: 0x1875B0
	public SharedInt startIndex; // 0x58
	[TooltipAttribute] // RVA: 0x1875F0 Offset: 0x1876F1 VA: 0x1875F0
	public SharedInt length; // 0x60
	[TooltipAttribute] // RVA: 0x187630 Offset: 0x187731 VA: 0x187630
	[RequiredFieldAttribute] // RVA: 0x187630 Offset: 0x187731 VA: 0x187630
	public SharedString storeResult; // 0x68

	// Methods

	// RVA: 0x288B4E0 Offset: 0x288B5E1 VA: 0x288B4E0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288B5F0 Offset: 0x288B6F1 VA: 0x288B5F0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288B6B0 Offset: 0x288B7B1 VA: 0x288B6B0
	public void .ctor() { }
}


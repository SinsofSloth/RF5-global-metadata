[TaskCategoryAttribute] // RVA: 0x14C750 Offset: 0x14C851 VA: 0x14C750
[TaskDescriptionAttribute] // RVA: 0x14C750 Offset: 0x14C851 VA: 0x14C750
public class GetXYZ : Action // TypeDefIndex: 10978
{
	// Fields
	[TooltipAttribute] // RVA: 0x184790 Offset: 0x184891 VA: 0x184790
	public SharedVector3 vector3Variable; // 0x50
	[TooltipAttribute] // RVA: 0x1847D0 Offset: 0x1848D1 VA: 0x1847D0
	[RequiredFieldAttribute] // RVA: 0x1847D0 Offset: 0x1848D1 VA: 0x1847D0
	public SharedFloat storeX; // 0x58
	[TooltipAttribute] // RVA: 0x184820 Offset: 0x184921 VA: 0x184820
	[RequiredFieldAttribute] // RVA: 0x184820 Offset: 0x184921 VA: 0x184820
	public SharedFloat storeY; // 0x60
	[TooltipAttribute] // RVA: 0x184870 Offset: 0x184971 VA: 0x184870
	[RequiredFieldAttribute] // RVA: 0x184870 Offset: 0x184971 VA: 0x184870
	public SharedFloat storeZ; // 0x68

	// Methods

	// RVA: 0x22D9230 Offset: 0x22D9331 VA: 0x22D9230 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x22D9310 Offset: 0x22D9411 VA: 0x22D9310 Slot: 16
	public override void OnReset() { }

	// RVA: 0x22D93F0 Offset: 0x22D94F1 VA: 0x22D93F0
	public void .ctor() { }
}


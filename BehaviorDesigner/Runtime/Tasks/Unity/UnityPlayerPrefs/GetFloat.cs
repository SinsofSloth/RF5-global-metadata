[TaskCategoryAttribute] // RVA: 0x150FA0 Offset: 0x1510A1 VA: 0x150FA0
[TaskDescriptionAttribute] // RVA: 0x150FA0 Offset: 0x1510A1 VA: 0x150FA0
public class GetFloat : Action // TypeDefIndex: 11172
{
	// Fields
	[TooltipAttribute] // RVA: 0x18B7F0 Offset: 0x18B8F1 VA: 0x18B7F0
	public SharedString key; // 0x50
	[TooltipAttribute] // RVA: 0x18B830 Offset: 0x18B931 VA: 0x18B830
	public SharedFloat defaultValue; // 0x58
	[TooltipAttribute] // RVA: 0x18B870 Offset: 0x18B971 VA: 0x18B870
	[RequiredFieldAttribute] // RVA: 0x18B870 Offset: 0x18B971 VA: 0x18B870
	public SharedFloat storeResult; // 0x60

	// Methods

	// RVA: 0x287F050 Offset: 0x287F151 VA: 0x287F050 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287F100 Offset: 0x287F201 VA: 0x287F100 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287F1B0 Offset: 0x287F2B1 VA: 0x287F1B0
	public void .ctor() { }
}


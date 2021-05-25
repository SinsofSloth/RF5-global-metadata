[TaskCategoryAttribute] // RVA: 0x14EF10 Offset: 0x14F011 VA: 0x14EF10
[TaskDescriptionAttribute] // RVA: 0x14EF10 Offset: 0x14F011 VA: 0x14EF10
public class SetSharedString : Action // TypeDefIndex: 11086
{
	// Fields
	[TooltipAttribute] // RVA: 0x188860 Offset: 0x188961 VA: 0x188860
	public SharedString targetValue; // 0x50
	[RequiredFieldAttribute] // RVA: 0x1888A0 Offset: 0x1889A1 VA: 0x1888A0
	[TooltipAttribute] // RVA: 0x1888A0 Offset: 0x1889A1 VA: 0x1888A0
	public SharedString targetVariable; // 0x58

	// Methods

	// RVA: 0x278C940 Offset: 0x278CA41 VA: 0x278C940 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278C9C0 Offset: 0x278CAC1 VA: 0x278C9C0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278CA40 Offset: 0x278CB41 VA: 0x278CA40
	public void .ctor() { }
}


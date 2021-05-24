[TaskCategoryAttribute] // RVA: 0x14EF70 Offset: 0x14F071 VA: 0x14EF70
[TaskDescriptionAttribute] // RVA: 0x14EF70 Offset: 0x14F071 VA: 0x14EF70
public class SetSharedTransform : Action // TypeDefIndex: 11087
{
	// Fields
	[TooltipAttribute] // RVA: 0x1888F0 Offset: 0x1889F1 VA: 0x1888F0
	public SharedTransform targetValue; // 0x50
	[RequiredFieldAttribute] // RVA: 0x188930 Offset: 0x188A31 VA: 0x188930
	[TooltipAttribute] // RVA: 0x188930 Offset: 0x188A31 VA: 0x188930
	public SharedTransform targetVariable; // 0x58

	// Methods

	// RVA: 0x278CA50 Offset: 0x278CB51 VA: 0x278CA50 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278CB30 Offset: 0x278CC31 VA: 0x278CB30 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278CB70 Offset: 0x278CC71 VA: 0x278CB70
	public void .ctor() { }
}


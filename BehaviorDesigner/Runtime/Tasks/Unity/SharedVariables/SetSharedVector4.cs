[TaskCategoryAttribute] // RVA: 0x14F0F0 Offset: 0x14F1F1 VA: 0x14F0F0
[TaskDescriptionAttribute] // RVA: 0x14F0F0 Offset: 0x14F1F1 VA: 0x14F0F0
public class SetSharedVector4 : Action // TypeDefIndex: 11091
{
	// Fields
	[TooltipAttribute] // RVA: 0x188B30 Offset: 0x188C31 VA: 0x188B30
	public SharedVector4 targetValue; // 0x50
	[RequiredFieldAttribute] // RVA: 0x188B70 Offset: 0x188C71 VA: 0x188B70
	[TooltipAttribute] // RVA: 0x188B70 Offset: 0x188C71 VA: 0x188B70
	public SharedVector4 targetVariable; // 0x58

	// Methods

	// RVA: 0x278CEB0 Offset: 0x278CFB1 VA: 0x278CEB0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278CF30 Offset: 0x278D031 VA: 0x278CF30 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278CFD0 Offset: 0x278D0D1 VA: 0x278CFD0
	public void .ctor() { }
}


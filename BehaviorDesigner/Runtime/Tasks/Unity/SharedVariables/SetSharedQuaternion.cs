[TaskCategoryAttribute] // RVA: 0x14EE50 Offset: 0x14EF51 VA: 0x14EE50
[TaskDescriptionAttribute] // RVA: 0x14EE50 Offset: 0x14EF51 VA: 0x14EE50
public class SetSharedQuaternion : Action // TypeDefIndex: 11084
{
	// Fields
	[TooltipAttribute] // RVA: 0x188740 Offset: 0x188841 VA: 0x188740
	public SharedQuaternion targetValue; // 0x50
	[RequiredFieldAttribute] // RVA: 0x188780 Offset: 0x188881 VA: 0x188780
	[TooltipAttribute] // RVA: 0x188780 Offset: 0x188881 VA: 0x188780
	public SharedQuaternion targetVariable; // 0x58

	// Methods

	// RVA: 0x278C700 Offset: 0x278C801 VA: 0x278C700 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278C780 Offset: 0x278C881 VA: 0x278C780 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278C820 Offset: 0x278C921 VA: 0x278C820
	public void .ctor() { }
}


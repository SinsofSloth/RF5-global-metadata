[TaskCategoryAttribute] // RVA: 0x14F090 Offset: 0x14F191 VA: 0x14F090
[TaskDescriptionAttribute] // RVA: 0x14F090 Offset: 0x14F191 VA: 0x14F090
public class SetSharedVector3 : Action // TypeDefIndex: 11090
{
	// Fields
	[TooltipAttribute] // RVA: 0x188AA0 Offset: 0x188BA1 VA: 0x188AA0
	public SharedVector3 targetValue; // 0x50
	[RequiredFieldAttribute] // RVA: 0x188AE0 Offset: 0x188BE1 VA: 0x188AE0
	[TooltipAttribute] // RVA: 0x188AE0 Offset: 0x188BE1 VA: 0x188AE0
	public SharedVector3 targetVariable; // 0x58

	// Methods

	// RVA: 0x278CD80 Offset: 0x278CE81 VA: 0x278CD80 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278CE00 Offset: 0x278CF01 VA: 0x278CE00 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278CEA0 Offset: 0x278CFA1 VA: 0x278CEA0
	public void .ctor() { }
}


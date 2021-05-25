[TaskCategoryAttribute] // RVA: 0x153760 Offset: 0x153861 VA: 0x153760
[TaskDescriptionAttribute] // RVA: 0x153760 Offset: 0x153861 VA: 0x153760
public class GetMouseButton : Action // TypeDefIndex: 11283
{
	// Fields
	[TooltipAttribute] // RVA: 0x18F950 Offset: 0x18FA51 VA: 0x18F950
	public SharedInt buttonIndex; // 0x50
	[RequiredFieldAttribute] // RVA: 0x18F990 Offset: 0x18FA91 VA: 0x18F990
	[TooltipAttribute] // RVA: 0x18F990 Offset: 0x18FA91 VA: 0x18F990
	public SharedBool storeResult; // 0x58

	// Methods

	// RVA: 0x27A24C0 Offset: 0x27A25C1 VA: 0x27A24C0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A2550 Offset: 0x27A2651 VA: 0x27A2550 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A25A0 Offset: 0x27A26A1 VA: 0x27A25A0
	public void .ctor() { }
}


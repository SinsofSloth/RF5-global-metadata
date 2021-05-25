[TaskCategoryAttribute] // RVA: 0x153640 Offset: 0x153741 VA: 0x153640
[TaskDescriptionAttribute] // RVA: 0x153640 Offset: 0x153741 VA: 0x153640
public class GetAxisRaw : Action // TypeDefIndex: 11280
{
	// Fields
	[TooltipAttribute] // RVA: 0x18F760 Offset: 0x18F861 VA: 0x18F760
	public SharedString axisName; // 0x50
	[TooltipAttribute] // RVA: 0x18F7A0 Offset: 0x18F8A1 VA: 0x18F7A0
	public SharedFloat multiplier; // 0x58
	[RequiredFieldAttribute] // RVA: 0x18F7E0 Offset: 0x18F8E1 VA: 0x18F7E0
	[TooltipAttribute] // RVA: 0x18F7E0 Offset: 0x18F8E1 VA: 0x18F7E0
	public SharedFloat storeResult; // 0x60

	// Methods

	// RVA: 0x27A2160 Offset: 0x27A2261 VA: 0x27A2160 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A2220 Offset: 0x27A2321 VA: 0x27A2220 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A22C0 Offset: 0x27A23C1 VA: 0x27A22C0
	public void .ctor() { }
}


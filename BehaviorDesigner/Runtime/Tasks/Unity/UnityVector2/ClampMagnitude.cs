[TaskCategoryAttribute] // RVA: 0x14CAB0 Offset: 0x14CBB1 VA: 0x14CAB0
[TaskDescriptionAttribute] // RVA: 0x14CAB0 Offset: 0x14CBB1 VA: 0x14CAB0
public class ClampMagnitude : Action // TypeDefIndex: 10988
{
	// Fields
	[TooltipAttribute] // RVA: 0x185010 Offset: 0x185111 VA: 0x185010
	public SharedVector2 vector2Variable; // 0x50
	[TooltipAttribute] // RVA: 0x185050 Offset: 0x185151 VA: 0x185050
	public SharedFloat maxLength; // 0x58
	[TooltipAttribute] // RVA: 0x185090 Offset: 0x185191 VA: 0x185090
	[RequiredFieldAttribute] // RVA: 0x185090 Offset: 0x185191 VA: 0x185090
	public SharedVector2 storeResult; // 0x60

	// Methods

	// RVA: 0x28910E0 Offset: 0x28911E1 VA: 0x28910E0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x28911D0 Offset: 0x28912D1 VA: 0x28911D0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2891290 Offset: 0x2891391 VA: 0x2891290
	public void .ctor() { }
}


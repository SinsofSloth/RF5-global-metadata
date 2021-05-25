[TaskDescriptionAttribute] // RVA: 0x1540C0 Offset: 0x1541C1 VA: 0x1540C0
[TaskIconAttribute] // RVA: 0x1540C0 Offset: 0x1541C1 VA: 0x1540C0
public class LogFormat : Action // TypeDefIndex: 11308
{
	// Fields
	[TooltipAttribute] // RVA: 0x190610 Offset: 0x190711 VA: 0x190610
	public SharedString textFormat; // 0x50
	[TooltipAttribute] // RVA: 0x190650 Offset: 0x190751 VA: 0x190650
	public SharedBool logError; // 0x58
	public SharedVariable arg0; // 0x60
	public SharedVariable arg1; // 0x68
	public SharedVariable arg2; // 0x70
	public SharedVariable arg3; // 0x78

	// Methods

	// RVA: 0x27A0660 Offset: 0x27A0761 VA: 0x27A0660 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A0750 Offset: 0x27A0851 VA: 0x27A0750
	private object[] buildParamsArray() { }

	// RVA: 0x27A0A10 Offset: 0x27A0B11 VA: 0x27A0A10
	private bool isValid(SharedVariable sv) { }

	// RVA: 0x27A0A40 Offset: 0x27A0B41 VA: 0x27A0A40 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A0B10 Offset: 0x27A0C11 VA: 0x27A0B10
	public void .ctor() { }
}


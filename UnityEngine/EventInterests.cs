[VisibleToOtherModulesAttribute] // RVA: 0xF4820 Offset: 0xF4921 VA: 0xF4820
internal struct EventInterests // TypeDefIndex: 3587
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0xF5510 Offset: 0xF5611 VA: 0xF5510
	[CompilerGeneratedAttribute] // RVA: 0xF5510 Offset: 0xF5611 VA: 0xF5510
	private bool <wantsMouseMove>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0xF5550 Offset: 0xF5651 VA: 0xF5550
	[DebuggerBrowsableAttribute] // RVA: 0xF5550 Offset: 0xF5651 VA: 0xF5550
	private bool <wantsMouseEnterLeaveWindow>k__BackingField; // 0x1

	// Properties
	public bool wantsMouseMove { get; }
	public bool wantsMouseEnterLeaveWindow { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xF62C0 Offset: 0xF63C1 VA: 0xF62C0
	// RVA: 0x38BC40 Offset: 0x38BD41 VA: 0x38BC40
	public bool get_wantsMouseMove() { }

	[CompilerGeneratedAttribute] // RVA: 0xF62D0 Offset: 0xF63D1 VA: 0xF62D0
	// RVA: 0x38BC50 Offset: 0x38BD51 VA: 0x38BC50
	public bool get_wantsMouseEnterLeaveWindow() { }

	// RVA: 0x38BC60 Offset: 0x38BD61 VA: 0x38BC60
	public bool WantsEvent(EventType type) { }
}


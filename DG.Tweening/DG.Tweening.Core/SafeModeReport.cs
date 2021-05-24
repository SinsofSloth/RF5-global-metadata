internal struct SafeModeReport // TypeDefIndex: 5078
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x137C30 Offset: 0x137D31 VA: 0x137C30
	private int <totMissingTargetOrFieldErrors>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x137C40 Offset: 0x137D41 VA: 0x137C40
	private int <totCallbackErrors>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x137C50 Offset: 0x137D51 VA: 0x137C50
	private int <totStartupErrors>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x137C60 Offset: 0x137D61 VA: 0x137C60
	private int <totUnsetErrors>k__BackingField; // 0xC

	// Properties
	public int totMissingTargetOrFieldErrors { get; set; }
	public int totCallbackErrors { get; set; }
	public int totStartupErrors { get; set; }
	public int totUnsetErrors { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x138A30 Offset: 0x138B31 VA: 0x138A30
	// RVA: 0x132B0 Offset: 0x133B1 VA: 0x132B0
	public int get_totMissingTargetOrFieldErrors() { }

	[CompilerGeneratedAttribute] // RVA: 0x138A40 Offset: 0x138B41 VA: 0x138A40
	// RVA: 0x132C0 Offset: 0x133C1 VA: 0x132C0
	private void set_totMissingTargetOrFieldErrors(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x138A50 Offset: 0x138B51 VA: 0x138A50
	// RVA: 0x132D0 Offset: 0x133D1 VA: 0x132D0
	public int get_totCallbackErrors() { }

	[CompilerGeneratedAttribute] // RVA: 0x138A60 Offset: 0x138B61 VA: 0x138A60
	// RVA: 0x132E0 Offset: 0x133E1 VA: 0x132E0
	private void set_totCallbackErrors(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x138A70 Offset: 0x138B71 VA: 0x138A70
	// RVA: 0x132F0 Offset: 0x133F1 VA: 0x132F0
	public int get_totStartupErrors() { }

	[CompilerGeneratedAttribute] // RVA: 0x138A80 Offset: 0x138B81 VA: 0x138A80
	// RVA: 0x13300 Offset: 0x13401 VA: 0x13300
	private void set_totStartupErrors(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x138A90 Offset: 0x138B91 VA: 0x138A90
	// RVA: 0x13310 Offset: 0x13411 VA: 0x13310
	public int get_totUnsetErrors() { }

	[CompilerGeneratedAttribute] // RVA: 0x138AA0 Offset: 0x138BA1 VA: 0x138AA0
	// RVA: 0x13320 Offset: 0x13421 VA: 0x13320
	private void set_totUnsetErrors(int value) { }

	// RVA: 0x13330 Offset: 0x13431 VA: 0x13330
	public void Add(SafeModeReport.SafeModeReportType type) { }

	// RVA: 0x13370 Offset: 0x13471 VA: 0x13370
	public int GetTotErrors() { }
}


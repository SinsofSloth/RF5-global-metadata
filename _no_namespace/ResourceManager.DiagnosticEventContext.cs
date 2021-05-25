public struct ResourceManager.DiagnosticEventContext // TypeDefIndex: 4453
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x129BC0 Offset: 0x129CC1 VA: 0x129BC0
	private readonly AsyncOperationHandle <OperationHandle>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x129BD0 Offset: 0x129CD1 VA: 0x129BD0
	private readonly ResourceManager.DiagnosticEventType <Type>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x129BE0 Offset: 0x129CE1 VA: 0x129BE0
	private readonly int <EventValue>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x129BF0 Offset: 0x129CF1 VA: 0x129BF0
	private readonly IResourceLocation <Location>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x129C00 Offset: 0x129D01 VA: 0x129C00
	private readonly object <Context>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x129C10 Offset: 0x129D11 VA: 0x129C10
	private readonly string <Error>k__BackingField; // 0x30

	// Properties
	public AsyncOperationHandle OperationHandle { get; }
	public ResourceManager.DiagnosticEventType Type { get; }
	public int EventValue { get; }
	public IResourceLocation Location { get; }
	public object Context { get; }
	public string Error { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x12A1B0 Offset: 0x12A2B1 VA: 0x12A1B0
	// RVA: 0x160D0 Offset: 0x161D1 VA: 0x160D0
	public AsyncOperationHandle get_OperationHandle() { }

	[CompilerGeneratedAttribute] // RVA: 0x12A1C0 Offset: 0x12A2C1 VA: 0x12A1C0
	// RVA: 0x160F0 Offset: 0x161F1 VA: 0x160F0
	public ResourceManager.DiagnosticEventType get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x12A1D0 Offset: 0x12A2D1 VA: 0x12A1D0
	// RVA: 0x16100 Offset: 0x16201 VA: 0x16100
	public int get_EventValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x12A1E0 Offset: 0x12A2E1 VA: 0x12A1E0
	// RVA: 0x16110 Offset: 0x16211 VA: 0x16110
	public IResourceLocation get_Location() { }

	[CompilerGeneratedAttribute] // RVA: 0x12A1F0 Offset: 0x12A2F1 VA: 0x12A1F0
	// RVA: 0x16120 Offset: 0x16221 VA: 0x16120
	public object get_Context() { }

	[CompilerGeneratedAttribute] // RVA: 0x12A200 Offset: 0x12A301 VA: 0x12A200
	// RVA: 0x16130 Offset: 0x16231 VA: 0x16130
	public string get_Error() { }

	// RVA: 0x16140 Offset: 0x16241 VA: 0x16140
	public void .ctor(AsyncOperationHandle op, ResourceManager.DiagnosticEventType type, int eventValue = 0, string error, object context) { }
}


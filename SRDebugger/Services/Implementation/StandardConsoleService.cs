[ServiceAttribute] // RVA: 0x13BAE0 Offset: 0x13BBE1 VA: 0x13BAE0
public class StandardConsoleService : IConsoleService // TypeDefIndex: 5638
{
	// Fields
	private readonly bool _collapseEnabled; // 0x10
	private bool _hasCleared; // 0x11
	private readonly CircularBuffer<ConsoleEntry> _allConsoleEntries; // 0x18
	private CircularBuffer<ConsoleEntry> _consoleEntries; // 0x20
	private readonly object _threadLock; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x13CAF0 Offset: 0x13CBF1 VA: 0x13CAF0
	private int <ErrorCount>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x13CB00 Offset: 0x13CC01 VA: 0x13CB00
	private int <WarningCount>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x13CB10 Offset: 0x13CC11 VA: 0x13CB10
	private int <InfoCount>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x13CB20 Offset: 0x13CC21 VA: 0x13CB20
	private ConsoleUpdatedEventHandler Updated; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x13CB30 Offset: 0x13CC31 VA: 0x13CB30
	private ConsoleUpdatedEventHandler Error; // 0x48

	// Properties
	public int ErrorCount { get; set; }
	public int WarningCount { get; set; }
	public int InfoCount { get; set; }
	public IReadOnlyList<ConsoleEntry> Entries { get; }
	public IReadOnlyList<ConsoleEntry> AllEntries { get; }

	// Methods

	// RVA: 0x153E920 Offset: 0x153EA21 VA: 0x153E920
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x13D370 Offset: 0x13D471 VA: 0x13D370
	// RVA: 0x153EA60 Offset: 0x153EB61 VA: 0x153EA60 Slot: 4
	public int get_ErrorCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x13D380 Offset: 0x13D481 VA: 0x13D380
	// RVA: 0x153EA70 Offset: 0x153EB71 VA: 0x153EA70
	private void set_ErrorCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D390 Offset: 0x13D491 VA: 0x13D390
	// RVA: 0x153EA80 Offset: 0x153EB81 VA: 0x153EA80 Slot: 5
	public int get_WarningCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x13D3A0 Offset: 0x13D4A1 VA: 0x13D3A0
	// RVA: 0x153EA90 Offset: 0x153EB91 VA: 0x153EA90
	private void set_WarningCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D3B0 Offset: 0x13D4B1 VA: 0x13D3B0
	// RVA: 0x153EAA0 Offset: 0x153EBA1 VA: 0x153EAA0 Slot: 6
	public int get_InfoCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x13D3C0 Offset: 0x13D4C1 VA: 0x13D3C0
	// RVA: 0x153EAB0 Offset: 0x153EBB1 VA: 0x153EAB0
	private void set_InfoCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D3D0 Offset: 0x13D4D1 VA: 0x13D3D0
	// RVA: 0x153EAC0 Offset: 0x153EBC1 VA: 0x153EAC0 Slot: 9
	public void add_Updated(ConsoleUpdatedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D3E0 Offset: 0x13D4E1 VA: 0x13D3E0
	// RVA: 0x153EB70 Offset: 0x153EC71 VA: 0x153EB70 Slot: 10
	public void remove_Updated(ConsoleUpdatedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D3F0 Offset: 0x13D4F1 VA: 0x13D3F0
	// RVA: 0x153EC20 Offset: 0x153ED21 VA: 0x153EC20 Slot: 11
	public void add_Error(ConsoleUpdatedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D400 Offset: 0x13D501 VA: 0x13D400
	// RVA: 0x153ECD0 Offset: 0x153EDD1 VA: 0x153ECD0 Slot: 12
	public void remove_Error(ConsoleUpdatedEventHandler value) { }

	// RVA: 0x153ED80 Offset: 0x153EE81 VA: 0x153ED80 Slot: 7
	public IReadOnlyList<ConsoleEntry> get_Entries() { }

	// RVA: 0x153EDA0 Offset: 0x153EEA1 VA: 0x153EDA0 Slot: 8
	public IReadOnlyList<ConsoleEntry> get_AllEntries() { }

	// RVA: 0x153EDB0 Offset: 0x153EEB1 VA: 0x153EDB0 Slot: 13
	public void Clear() { }

	// RVA: 0x153EFE0 Offset: 0x153F0E1 VA: 0x153EFE0
	protected void OnEntryAdded(ConsoleEntry entry) { }

	// RVA: 0x153F270 Offset: 0x153F371 VA: 0x153F270
	protected void OnEntryDuplicated(ConsoleEntry entry) { }

	// RVA: 0x153EF10 Offset: 0x153F011 VA: 0x153EF10
	private void OnUpdated() { }

	// RVA: 0x153F370 Offset: 0x153F471 VA: 0x153F370
	private void UnityLogCallback(string condition, string stackTrace, LogType type) { }

	// RVA: 0x153F200 Offset: 0x153F301 VA: 0x153F200
	private void AdjustCounter(LogType type, int amount) { }
}


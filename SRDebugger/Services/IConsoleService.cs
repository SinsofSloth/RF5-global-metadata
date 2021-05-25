public interface IConsoleService // TypeDefIndex: 5610
{
	// Properties
	public abstract int ErrorCount { get; }
	public abstract int WarningCount { get; }
	public abstract int InfoCount { get; }
	public abstract IReadOnlyList<ConsoleEntry> Entries { get; }
	public abstract IReadOnlyList<ConsoleEntry> AllEntries { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_ErrorCount() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_WarningCount() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_InfoCount() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IReadOnlyList<ConsoleEntry> get_Entries() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IReadOnlyList<ConsoleEntry> get_AllEntries() { }

	[CompilerGeneratedAttribute] // RVA: 0x13CFE0 Offset: 0x13D0E1 VA: 0x13CFE0
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void add_Updated(ConsoleUpdatedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13CFF0 Offset: 0x13D0F1 VA: 0x13CFF0
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void remove_Updated(ConsoleUpdatedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D000 Offset: 0x13D101 VA: 0x13D000
	// RVA: -1 Offset: -1 Slot: 7
	public abstract void add_Error(ConsoleUpdatedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D010 Offset: 0x13D111 VA: 0x13D010
	// RVA: -1 Offset: -1 Slot: 8
	public abstract void remove_Error(ConsoleUpdatedEventHandler value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Clear() { }
}


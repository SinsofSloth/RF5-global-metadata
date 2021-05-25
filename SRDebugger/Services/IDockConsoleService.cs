public interface IDockConsoleService // TypeDefIndex: 5616
{
	// Properties
	public abstract bool IsVisible { get; set; }
	public abstract bool IsExpanded { get; set; }
	public abstract ConsoleAlignment Alignment { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsVisible() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_IsVisible(bool value) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsExpanded() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_IsExpanded(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ConsoleAlignment get_Alignment() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_Alignment(ConsoleAlignment value) { }
}


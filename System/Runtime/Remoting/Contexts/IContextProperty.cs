[ComVisibleAttribute] // RVA: 0xB0D20 Offset: 0xB0E21 VA: 0xB0D20
public interface IContextProperty // TypeDefIndex: 1152
{
	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Freeze(Context newContext) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsNewContextOK(Context newCtx) { }
}


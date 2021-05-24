public interface IPinEntryService // TypeDefIndex: 5619
{
	// Properties
	public abstract bool IsShowingKeypad { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsShowingKeypad() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool allowCancel = True) { }

	[ObsoleteAttribute] // RVA: 0x13D100 Offset: 0x13D201 VA: 0x13D100
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool blockInput, bool allowCancel) { }
}


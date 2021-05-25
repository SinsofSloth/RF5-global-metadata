public interface IFocusRing // TypeDefIndex: 4111
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }
}


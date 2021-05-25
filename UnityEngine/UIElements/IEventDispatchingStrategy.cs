internal interface IEventDispatchingStrategy // TypeDefIndex: 4180
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CanDispatchEvent(EventBase evt) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void DispatchEvent(EventBase evt, IPanel panel) { }
}


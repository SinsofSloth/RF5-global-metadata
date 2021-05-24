public class NotifyCollectionChangedEventArgs : EventArgs // TypeDefIndex: 2064
{
	// Fields
	private NotifyCollectionChangedAction _action; // 0x10
	private IList _newItems; // 0x18
	private IList _oldItems; // 0x20
	private int _newStartingIndex; // 0x28
	private int _oldStartingIndex; // 0x2C

	// Methods

	// RVA: 0x28E5D80 Offset: 0x28E5E81 VA: 0x28E5D80
	public void .ctor(NotifyCollectionChangedAction action) { }

	// RVA: 0x28E5FB0 Offset: 0x28E60B1 VA: 0x28E5FB0
	public void .ctor(NotifyCollectionChangedAction action, object changedItem, int index) { }

	// RVA: 0x28E62D0 Offset: 0x28E63D1 VA: 0x28E62D0
	public void .ctor(NotifyCollectionChangedAction action, object newItem, object oldItem, int index) { }

	// RVA: 0x28E6190 Offset: 0x28E6291 VA: 0x28E6190
	private void InitializeAddOrRemove(NotifyCollectionChangedAction action, IList changedItems, int startingIndex) { }

	// RVA: 0x28E5F00 Offset: 0x28E6001 VA: 0x28E5F00
	private void InitializeAdd(NotifyCollectionChangedAction action, IList newItems, int newStartingIndex) { }

	// RVA: 0x28E6620 Offset: 0x28E6721 VA: 0x28E6620
	private void InitializeRemove(NotifyCollectionChangedAction action, IList oldItems, int oldStartingIndex) { }

	// RVA: 0x28E64E0 Offset: 0x28E65E1 VA: 0x28E64E0
	private void InitializeMoveOrReplace(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex, int oldStartingIndex) { }
}


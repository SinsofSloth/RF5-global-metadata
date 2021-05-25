public class ListChangedEventArgs<T> : EventArgs // TypeDefIndex: 9736
{
	// Fields
	public ListChangeType type; // 0x0
	public List<T> newItems; // 0x0
	public List<T> removedItems; // 0x0
	public int insertIndex; // 0x0
	public int removeIndex; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAFE70 Offset: 0x2CAFF71 VA: 0x2CAFE70
	|-ListChangedEventArgs<SplineNode>..ctor
	|-ListChangedEventArgs<object>..ctor
	*/
}


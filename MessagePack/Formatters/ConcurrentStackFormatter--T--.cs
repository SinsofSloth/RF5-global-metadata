public sealed class ConcurrentStackFormatter<T> : CollectionFormatterBase<T, T[], ConcurrentStack<T>> // TypeDefIndex: 5387
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	protected override Nullable<int> GetCount(ConcurrentStack<T> sequence) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D391E0 Offset: 0x2D392E1 VA: 0x2D391E0
	|-ConcurrentStackFormatter<object>.GetCount
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override void Add(T[] collection, int index, T value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D39270 Offset: 0x2D39371 VA: 0x2D39270
	|-ConcurrentStackFormatter<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected override T[] Create(int count, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D392B0 Offset: 0x2D393B1 VA: 0x2D392B0
	|-ConcurrentStackFormatter<object>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override ConcurrentStack<T> Complete(T[] intermediateCollection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D39300 Offset: 0x2D39401 VA: 0x2D39300
	|-ConcurrentStackFormatter<object>.Complete
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D39370 Offset: 0x2D39471 VA: 0x2D39370
	|-ConcurrentStackFormatter<object>..ctor
	*/
}


public sealed class ReadOnlyCollectionFormatter<T> : CollectionFormatterBase<T, T[], ReadOnlyCollection<T>> // TypeDefIndex: 5364
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	protected override void Add(T[] collection, int index, T value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE0F20 Offset: 0x2CE1021 VA: 0x2CE0F20
	|-ReadOnlyCollectionFormatter<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override ReadOnlyCollection<T> Complete(T[] intermediateCollection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE0F60 Offset: 0x2CE1061 VA: 0x2CE0F60
	|-ReadOnlyCollectionFormatter<object>.Complete
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected override T[] Create(int count, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE0FD0 Offset: 0x2CE10D1 VA: 0x2CE0FD0
	|-ReadOnlyCollectionFormatter<object>.Create
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE1020 Offset: 0x2CE1121 VA: 0x2CE1020
	|-ReadOnlyCollectionFormatter<object>..ctor
	*/
}


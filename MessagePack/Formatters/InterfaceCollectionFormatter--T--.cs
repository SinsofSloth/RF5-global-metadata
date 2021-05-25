[ObsoleteAttribute] // RVA: 0x1393C0 Offset: 0x1394C1 VA: 0x1393C0
public sealed class InterfaceCollectionFormatter<T> : CollectionFormatterBase<T, T[], ICollection<T>> // TypeDefIndex: 5366
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	protected override void Add(T[] collection, int index, T value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCBB30 Offset: 0x2CCBC31 VA: 0x2CCBB30
	|-InterfaceCollectionFormatter<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected override T[] Create(int count, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCBB70 Offset: 0x2CCBC71 VA: 0x2CCBB70
	|-InterfaceCollectionFormatter<object>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override ICollection<T> Complete(T[] intermediateCollection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCBBD0 Offset: 0x2CCBCD1 VA: 0x2CCBBD0
	|-InterfaceCollectionFormatter<object>.Complete
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCBBE0 Offset: 0x2CCBCE1 VA: 0x2CCBBE0
	|-InterfaceCollectionFormatter<object>..ctor
	*/
}


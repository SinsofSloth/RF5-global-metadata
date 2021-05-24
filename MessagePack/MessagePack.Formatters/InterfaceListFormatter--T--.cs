[ObsoleteAttribute] // RVA: 0x139380 Offset: 0x139481 VA: 0x139380
public sealed class InterfaceListFormatter<T> : CollectionFormatterBase<T, T[], IList<T>> // TypeDefIndex: 5365
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	protected override void Add(T[] collection, int index, T value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCC540 Offset: 0x2CCC641 VA: 0x2CCC540
	|-InterfaceListFormatter<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected override T[] Create(int count, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCC580 Offset: 0x2CCC681 VA: 0x2CCC580
	|-InterfaceListFormatter<object>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override IList<T> Complete(T[] intermediateCollection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCC5E0 Offset: 0x2CCC6E1 VA: 0x2CCC5E0
	|-InterfaceListFormatter<object>.Complete
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCC5F0 Offset: 0x2CCC6F1 VA: 0x2CCC5F0
	|-InterfaceListFormatter<object>..ctor
	*/
}


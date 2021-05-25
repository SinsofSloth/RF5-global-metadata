public sealed class InterfaceLookupFormatter<TKey, TElement> : CollectionFormatterBase<IGrouping<TKey, TElement>, Dictionary<TKey, IGrouping<TKey, TElement>>, ILookup<TKey, TElement>> // TypeDefIndex: 5371
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	protected override void Add(Dictionary<TKey, IGrouping<TKey, TElement>> collection, int index, IGrouping<TKey, TElement> value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCC620 Offset: 0x2CCC721 VA: 0x2CCC620
	|-InterfaceLookupFormatter<object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override ILookup<TKey, TElement> Complete(Dictionary<TKey, IGrouping<TKey, TElement>> intermediateCollection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCC700 Offset: 0x2CCC801 VA: 0x2CCC700
	|-InterfaceLookupFormatter<object, object>.Complete
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected override Dictionary<TKey, IGrouping<TKey, TElement>> Create(int count, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCC770 Offset: 0x2CCC871 VA: 0x2CCC770
	|-InterfaceLookupFormatter<object, object>.Create
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCC7E0 Offset: 0x2CCC8E1 VA: 0x2CCC7E0
	|-InterfaceLookupFormatter<object, object>..ctor
	*/
}


public abstract class CollectionFormatterBase<TElement, TIntermediate, TEnumerator, TCollection> : IMessagePackFormatter<TCollection>, IMessagePackFormatter // TypeDefIndex: 5356
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, TCollection value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D334E0 Offset: 0x2D335E1 VA: 0x2D334E0
	|-CollectionFormatterBase<object, object, HashSet.Enumerator<object>, object>.Serialize
	|
	|-RVA: 0x2D345A0 Offset: 0x2D346A1 VA: 0x2D345A0
	|-CollectionFormatterBase<object, object, LinkedList.Enumerator<object>, object>.Serialize
	|
	|-RVA: 0x2D356E0 Offset: 0x2D357E1 VA: 0x2D356E0
	|-CollectionFormatterBase<object, object, Queue.Enumerator<object>, object>.Serialize
	|
	|-RVA: 0x2D367A0 Offset: 0x2D368A1 VA: 0x2D367A0
	|-CollectionFormatterBase<object, object, Stack.Enumerator<object>, object>.Serialize
	|
	|-RVA: 0x2D37860 Offset: 0x2D37961 VA: 0x2D37860
	|-CollectionFormatterBase<object, object, object, object>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public TCollection Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D34110 Offset: 0x2D34211 VA: 0x2D34110
	|-CollectionFormatterBase<object, object, HashSet.Enumerator<object>, object>.Deserialize
	|
	|-RVA: 0x2D35250 Offset: 0x2D35351 VA: 0x2D35250
	|-CollectionFormatterBase<object, object, LinkedList.Enumerator<object>, object>.Deserialize
	|
	|-RVA: 0x2D36310 Offset: 0x2D36411 VA: 0x2D36310
	|-CollectionFormatterBase<object, object, Queue.Enumerator<object>, object>.Deserialize
	|
	|-RVA: 0x2D373D0 Offset: 0x2D374D1 VA: 0x2D373D0
	|-CollectionFormatterBase<object, object, Stack.Enumerator<object>, object>.Deserialize
	|
	|-RVA: 0x2D38240 Offset: 0x2D38341 VA: 0x2D38240
	|-CollectionFormatterBase<object, object, object, object>.Deserialize
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected virtual Nullable<int> GetCount(TCollection sequence) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D343E0 Offset: 0x2D344E1 VA: 0x2D343E0
	|-CollectionFormatterBase<object, object, HashSet.Enumerator<object>, object>.GetCount
	|
	|-RVA: 0x2D35520 Offset: 0x2D35621 VA: 0x2D35520
	|-CollectionFormatterBase<object, object, LinkedList.Enumerator<object>, object>.GetCount
	|
	|-RVA: 0x2D365E0 Offset: 0x2D366E1 VA: 0x2D365E0
	|-CollectionFormatterBase<object, object, Queue.Enumerator<object>, object>.GetCount
	|
	|-RVA: 0x2D376A0 Offset: 0x2D377A1 VA: 0x2D376A0
	|-CollectionFormatterBase<object, object, Stack.Enumerator<object>, object>.GetCount
	|
	|-RVA: 0x2D38510 Offset: 0x2D38611 VA: 0x2D38510
	|-CollectionFormatterBase<object, object, object, object>.GetCount
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract TEnumerator GetSourceEnumerator(TCollection source) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-CollectionFormatterBase<object, object, object, object>.GetSourceEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract TIntermediate Create(int count, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-CollectionFormatterBase<object, object, object, object>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void Add(TIntermediate collection, int index, TElement value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-CollectionFormatterBase<object, object, object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract TCollection Complete(TIntermediate intermediateCollection) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-CollectionFormatterBase<object, object, object, object>.Complete
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D34580 Offset: 0x2D34681 VA: 0x2D34580
	|-CollectionFormatterBase<object, object, HashSet.Enumerator<object>, object>..ctor
	|
	|-RVA: 0x2D356C0 Offset: 0x2D357C1 VA: 0x2D356C0
	|-CollectionFormatterBase<object, object, LinkedList.Enumerator<object>, object>..ctor
	|
	|-RVA: 0x2D36780 Offset: 0x2D36881 VA: 0x2D36780
	|-CollectionFormatterBase<object, object, Queue.Enumerator<object>, object>..ctor
	|
	|-RVA: 0x2D37840 Offset: 0x2D37941 VA: 0x2D37840
	|-CollectionFormatterBase<object, object, Stack.Enumerator<object>, object>..ctor
	|
	|-RVA: 0x2D386B0 Offset: 0x2D387B1 VA: 0x2D386B0
	|-CollectionFormatterBase<object, object, object, object>..ctor
	*/
}

public abstract class CollectionFormatterBase<TElement, TIntermediate, TCollection> : CollectionFormatterBase<TElement, TIntermediate, IEnumerator<TElement>, TCollection> // TypeDefIndex: 5357
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	protected override IEnumerator<TElement> GetSourceEnumerator(TCollection source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D33410 Offset: 0x2D33511 VA: 0x2D33410
	|-CollectionFormatterBase<object, object, object>.GetSourceEnumerator
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D334B0 Offset: 0x2D335B1 VA: 0x2D334B0
	|-CollectionFormatterBase<object, object, object>..ctor
	*/
}

public abstract class CollectionFormatterBase<TElement, TCollection> : CollectionFormatterBase<TElement, TCollection, TCollection> // TypeDefIndex: 5358
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 10
	protected sealed override TCollection Complete(TCollection intermediateCollection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D333D0 Offset: 0x2D334D1 VA: 0x2D333D0
	|-CollectionFormatterBase<object, object>.Complete
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D333E0 Offset: 0x2D334E1 VA: 0x2D333E0
	|-CollectionFormatterBase<object, object>..ctor
	*/
}


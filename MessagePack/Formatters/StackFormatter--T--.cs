public sealed class StackFormatter<T> : CollectionFormatterBase<T, T[], Stack.Enumerator<T>, Stack<T>> // TypeDefIndex: 5362
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	protected override Nullable<int> GetCount(Stack<T> sequence) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x285E960 Offset: 0x285EA61 VA: 0x285E960
	|-StackFormatter<object>.GetCount
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override void Add(T[] collection, int index, T value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x285E9F0 Offset: 0x285EAF1 VA: 0x285E9F0
	|-StackFormatter<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected override T[] Create(int count, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x285EA30 Offset: 0x285EB31 VA: 0x285EA30
	|-StackFormatter<object>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected override Stack.Enumerator<T> GetSourceEnumerator(Stack<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x285EA80 Offset: 0x285EB81 VA: 0x285EA80
	|-StackFormatter<object>.GetSourceEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override Stack<T> Complete(T[] intermediateCollection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x285EAE0 Offset: 0x285EBE1 VA: 0x285EAE0
	|-StackFormatter<object>.Complete
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x285EB50 Offset: 0x285EC51 VA: 0x285EB50
	|-StackFormatter<object>..ctor
	*/
}


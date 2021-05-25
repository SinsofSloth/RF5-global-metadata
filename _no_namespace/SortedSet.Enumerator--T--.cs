[Serializable]
public struct SortedSet.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback // TypeDefIndex: 2095
{
	// Fields
	private static readonly SortedSet.Node<T> s_dummyNode; // 0x0
	private SortedSet<T> _tree; // 0x0
	private int _version; // 0x0
	private Stack<SortedSet.Node<T>> _stack; // 0x0
	private SortedSet.Node<T> _current; // 0x0
	private bool _reverse; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	internal bool NotStartedOrEnded { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384F80 Offset: 0x385081 VA: 0x384F80
	|-SortedSet.Enumerator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x385130 Offset: 0x385231 VA: 0x385130
	|-SortedSet.Enumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(SortedSet<T> set, bool reverse) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384FD0 Offset: 0x3850D1 VA: 0x384FD0
	|-SortedSet.Enumerator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x385180 Offset: 0x385281 VA: 0x385180
	|-SortedSet.Enumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384FE0 Offset: 0x3850E1 VA: 0x384FE0
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x385190 Offset: 0x385291 VA: 0x385190
	|-SortedSet.Enumerator<object>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384FF0 Offset: 0x3850F1 VA: 0x384FF0
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x3851A0 Offset: 0x3852A1 VA: 0x3851A0
	|-SortedSet.Enumerator<object>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	private void Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x385000 Offset: 0x385101 VA: 0x385000
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.Initialize
	|
	|-RVA: 0x3851B0 Offset: 0x3852B1 VA: 0x3851B0
	|-SortedSet.Enumerator<object>.Initialize
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x385010 Offset: 0x385111 VA: 0x385010
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x3851C0 Offset: 0x3852C1 VA: 0x3851C0
	|-SortedSet.Enumerator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x385020 Offset: 0x385121 VA: 0x385020
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x3851D0 Offset: 0x3852D1 VA: 0x3851D0
	|-SortedSet.Enumerator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x385030 Offset: 0x385131 VA: 0x385030
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.get_Current
	|
	|-RVA: 0x3851E0 Offset: 0x3852E1 VA: 0x3851E0
	|-SortedSet.Enumerator<object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3850C0 Offset: 0x3851C1 VA: 0x3850C0
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x385280 Offset: 0x385381 VA: 0x385280
	|-SortedSet.Enumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1
	internal bool get_NotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3850D0 Offset: 0x3851D1 VA: 0x3850D0
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.get_NotStartedOrEnded
	|
	|-RVA: 0x385290 Offset: 0x385391 VA: 0x385290
	|-SortedSet.Enumerator<object>.get_NotStartedOrEnded
	*/

	// RVA: -1 Offset: -1
	internal void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3850E0 Offset: 0x3851E1 VA: 0x3850E0
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.Reset
	|
	|-RVA: 0x3852A0 Offset: 0x3853A1 VA: 0x3852A0
	|-SortedSet.Enumerator<object>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3850F0 Offset: 0x3851F1 VA: 0x3850F0
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3852B0 Offset: 0x3853B1 VA: 0x3852B0
	|-SortedSet.Enumerator<object>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB6160 Offset: 0x2BB6261 VA: 0x2BB6160
	|-SortedSet.Enumerator<KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x2BB6F50 Offset: 0x2BB7051 VA: 0x2BB6F50
	|-SortedSet.Enumerator<object>..cctor
	*/
}


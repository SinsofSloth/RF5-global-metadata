[DebuggerDisplayAttribute] // RVA: 0xBC990 Offset: 0xBCA91 VA: 0xBC990
[DebuggerTypeProxyAttribute] // RVA: 0xBC990 Offset: 0xBCA91 VA: 0xBC990
[Serializable]
public class SortedSet<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 2093
{
	// Fields
	private SortedSet.Node<T> root; // 0x0
	private IComparer<T> comparer; // 0x0
	private int count; // 0x0
	private int version; // 0x0
	private SerializationInfo siInfo; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB87B0 Offset: 0x2BB88B1 VA: 0x2BB87B0
	|-SortedSet<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2EDE330 Offset: 0x2EDE431 VA: 0x2EDE330
	|-SortedSet<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB8800 Offset: 0x2BB8901 VA: 0x2BB8800
	|-SortedSet<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2EDE380 Offset: 0x2EDE481 VA: 0x2EDE380
	|-SortedSet<object>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB8870 Offset: 0x2BB8971 VA: 0x2BB8870
	|-SortedSet<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2EDE3F0 Offset: 0x2EDE4F1 VA: 0x2EDE3F0
	|-SortedSet<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal virtual bool InOrderTreeWalk(TreeWalkPredicate<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB88B0 Offset: 0x2BB89B1 VA: 0x2BB88B0
	|-SortedSet<KeyValuePair<object, object>>.InOrderTreeWalk
	|
	|-RVA: 0x2EDE430 Offset: 0x2EDE531 VA: 0x2EDE430
	|-SortedSet<object>.InOrderTreeWalk
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB8AC0 Offset: 0x2BB8BC1 VA: 0x2BB8AC0
	|-SortedSet<KeyValuePair<object, object>>.get_Count
	|
	|-RVA: 0x2EDE640 Offset: 0x2EDE741 VA: 0x2EDE640
	|-SortedSet<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB8B00 Offset: 0x2BB8C01 VA: 0x2BB8B00
	|-SortedSet<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2EDE680 Offset: 0x2EDE781 VA: 0x2EDE680
	|-SortedSet<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal virtual void VersionCheck() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB8B10 Offset: 0x2BB8C11 VA: 0x2BB8B10
	|-SortedSet<KeyValuePair<object, object>>.VersionCheck
	|
	|-RVA: 0x2EDE690 Offset: 0x2EDE791 VA: 0x2EDE690
	|-SortedSet<object>.VersionCheck
	*/

	// RVA: -1 Offset: -1 Slot: 20
	internal virtual bool IsWithinRange(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB8B20 Offset: 0x2BB8C21 VA: 0x2BB8B20
	|-SortedSet<KeyValuePair<object, object>>.IsWithinRange
	|
	|-RVA: 0x2EDE6A0 Offset: 0x2EDE7A1 VA: 0x2EDE6A0
	|-SortedSet<object>.IsWithinRange
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public bool Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB8B30 Offset: 0x2BB8C31 VA: 0x2BB8B30
	|-SortedSet<KeyValuePair<object, object>>.Add
	|
	|-RVA: 0x2EDE6B0 Offset: 0x2EDE7B1 VA: 0x2EDE6B0
	|-SortedSet<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB8B50 Offset: 0x2BB8C51 VA: 0x2BB8B50
	|-SortedSet<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2EDE6D0 Offset: 0x2EDE7D1 VA: 0x2EDE6D0
	|-SortedSet<object>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	internal virtual bool AddIfNotPresent(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB8B80 Offset: 0x2BB8C81 VA: 0x2BB8B80
	|-SortedSet<KeyValuePair<object, object>>.AddIfNotPresent
	|
	|-RVA: 0x2EDE700 Offset: 0x2EDE801 VA: 0x2EDE700
	|-SortedSet<object>.AddIfNotPresent
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB8EF0 Offset: 0x2BB8FF1 VA: 0x2BB8EF0
	|-SortedSet<KeyValuePair<object, object>>.Remove
	|
	|-RVA: 0x2EDEA50 Offset: 0x2EDEB51 VA: 0x2EDEA50
	|-SortedSet<object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 23
	internal virtual bool DoRemove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB8F10 Offset: 0x2BB9011 VA: 0x2BB8F10
	|-SortedSet<KeyValuePair<object, object>>.DoRemove
	|
	|-RVA: 0x2EDEA70 Offset: 0x2EDEB71 VA: 0x2EDEA70
	|-SortedSet<object>.DoRemove
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public virtual void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB9370 Offset: 0x2BB9471 VA: 0x2BB9370
	|-SortedSet<KeyValuePair<object, object>>.Clear
	|
	|-RVA: 0x2EDEEA0 Offset: 0x2EDEFA1 VA: 0x2EDEEA0
	|-SortedSet<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 25
	public virtual bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB93B0 Offset: 0x2BB94B1 VA: 0x2BB93B0
	|-SortedSet<KeyValuePair<object, object>>.Contains
	|
	|-RVA: 0x2EDEEE0 Offset: 0x2EDEFE1 VA: 0x2EDEEE0
	|-SortedSet<object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB93E0 Offset: 0x2BB94E1 VA: 0x2BB93E0
	|-SortedSet<KeyValuePair<object, object>>.CopyTo
	|
	|-RVA: 0x2EDEF10 Offset: 0x2EDF011 VA: 0x2EDEF10
	|-SortedSet<object>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB9450 Offset: 0x2BB9551 VA: 0x2BB9450
	|-SortedSet<KeyValuePair<object, object>>.CopyTo
	|
	|-RVA: 0x2EDEF80 Offset: 0x2EDF081 VA: 0x2EDEF80
	|-SortedSet<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB96B0 Offset: 0x2BB97B1 VA: 0x2BB96B0
	|-SortedSet<KeyValuePair<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EDF1E0 Offset: 0x2EDF2E1 VA: 0x2EDF1E0
	|-SortedSet<object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB9AD0 Offset: 0x2BB9BD1 VA: 0x2BB9AD0
	|-SortedSet<KeyValuePair<object, object>>.GetEnumerator
	|
	|-RVA: 0x2EDF600 Offset: 0x2EDF701 VA: 0x2EDF600
	|-SortedSet<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB9B60 Offset: 0x2BB9C61 VA: 0x2BB9B60
	|-SortedSet<KeyValuePair<object, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2EDF660 Offset: 0x2EDF761 VA: 0x2EDF660
	|-SortedSet<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB9BF0 Offset: 0x2BB9CF1 VA: 0x2BB9BF0
	|-SortedSet<KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EDF6F0 Offset: 0x2EDF7F1 VA: 0x2EDF6F0
	|-SortedSet<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private void InsertionBalance(SortedSet.Node<T> current, ref SortedSet.Node<T> parent, SortedSet.Node<T> grandParent, SortedSet.Node<T> greatGrandParent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB9C80 Offset: 0x2BB9D81 VA: 0x2BB9C80
	|-SortedSet<KeyValuePair<object, object>>.InsertionBalance
	|
	|-RVA: 0x2EDF780 Offset: 0x2EDF881 VA: 0x2EDF780
	|-SortedSet<object>.InsertionBalance
	*/

	// RVA: -1 Offset: -1
	private void ReplaceChildOrRoot(SortedSet.Node<T> parent, SortedSet.Node<T> child, SortedSet.Node<T> newChild) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB9DE0 Offset: 0x2BB9EE1 VA: 0x2BB9DE0
	|-SortedSet<KeyValuePair<object, object>>.ReplaceChildOrRoot
	|
	|-RVA: 0x2EDF8E0 Offset: 0x2EDF9E1 VA: 0x2EDF8E0
	|-SortedSet<object>.ReplaceChildOrRoot
	*/

	// RVA: -1 Offset: -1
	private void ReplaceNode(SortedSet.Node<T> match, SortedSet.Node<T> parentOfMatch, SortedSet.Node<T> successor, SortedSet.Node<T> parentOfSuccessor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB9E20 Offset: 0x2BB9F21 VA: 0x2BB9E20
	|-SortedSet<KeyValuePair<object, object>>.ReplaceNode
	|
	|-RVA: 0x2EDF920 Offset: 0x2EDFA21 VA: 0x2EDF920
	|-SortedSet<object>.ReplaceNode
	*/

	// RVA: -1 Offset: -1 Slot: 26
	internal virtual SortedSet.Node<T> FindNode(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB9FE0 Offset: 0x2BBA0E1 VA: 0x2BB9FE0
	|-SortedSet<KeyValuePair<object, object>>.FindNode
	|
	|-RVA: 0x2EDFAE0 Offset: 0x2EDFBE1 VA: 0x2EDFAE0
	|-SortedSet<object>.FindNode
	*/

	// RVA: -1 Offset: -1
	internal void UpdateVersion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BBA120 Offset: 0x2BBA221 VA: 0x2BBA120
	|-SortedSet<KeyValuePair<object, object>>.UpdateVersion
	|
	|-RVA: 0x2EDFC10 Offset: 0x2EDFD11 VA: 0x2EDFC10
	|-SortedSet<object>.UpdateVersion
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BBA130 Offset: 0x2BBA231 VA: 0x2BBA130
	|-SortedSet<KeyValuePair<object, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x2EDFC20 Offset: 0x2EDFD21 VA: 0x2EDFC20
	|-SortedSet<object>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 27
	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BBA150 Offset: 0x2BBA251 VA: 0x2BBA150
	|-SortedSet<KeyValuePair<object, object>>.GetObjectData
	|
	|-RVA: 0x2EDFC40 Offset: 0x2EDFD41 VA: 0x2EDFC40
	|-SortedSet<object>.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BBA350 Offset: 0x2BBA451 VA: 0x2BBA350
	|-SortedSet<KeyValuePair<object, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x2EDFE40 Offset: 0x2EDFF41 VA: 0x2EDFE40
	|-SortedSet<object>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected virtual void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BBA370 Offset: 0x2BBA471 VA: 0x2BBA370
	|-SortedSet<KeyValuePair<object, object>>.OnDeserialization
	|
	|-RVA: 0x2EDFE60 Offset: 0x2EDFF61 VA: 0x2EDFE60
	|-SortedSet<object>.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	private static int Log2(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BBA670 Offset: 0x2BBA771 VA: 0x2BBA670
	|-SortedSet<KeyValuePair<object, object>>.Log2
	|
	|-RVA: 0x2EE0160 Offset: 0x2EE0261 VA: 0x2EE0160
	|-SortedSet<object>.Log2
	*/
}


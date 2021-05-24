[DebuggerDisplayAttribute] // RVA: 0xB31F0 Offset: 0xB32F1 VA: 0xB31F0
[ComVisibleAttribute] // RVA: 0xB31F0 Offset: 0xB32F1 VA: 0xB31F0
[DefaultMemberAttribute] // RVA: 0xB31F0 Offset: 0xB32F1 VA: 0xB31F0
[DebuggerTypeProxyAttribute] // RVA: 0xB31F0 Offset: 0xB32F1 VA: 0xB31F0
[Serializable]
public class Collection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 1392
{
	// Fields
	private IList<T> items; // 0x0

	// Properties
	public int Count { get; }
	public T Item { get; set; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.IList.IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE5AD0 Offset: 0x2EE5BD1 VA: 0x2EE5AD0
	|-Collection<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE5B50 Offset: 0x2EE5C51 VA: 0x2EE5B50
	|-Collection<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE5BF0 Offset: 0x2EE5CF1 VA: 0x2EE5BF0
	|-Collection<object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE5CA0 Offset: 0x2EE5DA1 VA: 0x2EE5CA0
	|-Collection<object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE5E40 Offset: 0x2EE5F41 VA: 0x2EE5E40
	|-Collection<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE5FD0 Offset: 0x2EE60D1 VA: 0x2EE5FD0
	|-Collection<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE60C0 Offset: 0x2EE61C1 VA: 0x2EE60C0
	|-Collection<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE6180 Offset: 0x2EE6281 VA: 0x2EE6180
	|-Collection<object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE6230 Offset: 0x2EE6331 VA: 0x2EE6230
	|-Collection<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE62D0 Offset: 0x2EE63D1 VA: 0x2EE62D0
	|-Collection<object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE6380 Offset: 0x2EE6481 VA: 0x2EE6380
	|-Collection<object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE6520 Offset: 0x2EE6621 VA: 0x2EE6520
	|-Collection<object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE66C0 Offset: 0x2EE67C1 VA: 0x2EE66C0
	|-Collection<object>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected virtual void ClearItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE6850 Offset: 0x2EE6951 VA: 0x2EE6850
	|-Collection<object>.ClearItems
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected virtual void InsertItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE68F0 Offset: 0x2EE69F1 VA: 0x2EE68F0
	|-Collection<object>.InsertItem
	*/

	// RVA: -1 Offset: -1 Slot: 34
	protected virtual void RemoveItem(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE69B0 Offset: 0x2EE6AB1 VA: 0x2EE69B0
	|-Collection<object>.RemoveItem
	*/

	// RVA: -1 Offset: -1 Slot: 35
	protected virtual void SetItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE6A60 Offset: 0x2EE6B61 VA: 0x2EE6A60
	|-Collection<object>.SetItem
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE6B20 Offset: 0x2EE6C21 VA: 0x2EE6B20
	|-Collection<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE6BC0 Offset: 0x2EE6CC1 VA: 0x2EE6BC0
	|-Collection<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE6C70 Offset: 0x2EE6D71 VA: 0x2EE6C70
	|-Collection<object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE7200 Offset: 0x2EE7301 VA: 0x2EE7200
	|-Collection<object>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE72B0 Offset: 0x2EE73B1 VA: 0x2EE72B0
	|-Collection<object>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE7460 Offset: 0x2EE7561 VA: 0x2EE7460
	|-Collection<object>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE7500 Offset: 0x2EE7601 VA: 0x2EE7500
	|-Collection<object>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE7760 Offset: 0x2EE7861 VA: 0x2EE7760
	|-Collection<object>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE7840 Offset: 0x2EE7941 VA: 0x2EE7840
	|-Collection<object>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE7920 Offset: 0x2EE7A21 VA: 0x2EE7920
	|-Collection<object>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE7B80 Offset: 0x2EE7C81 VA: 0x2EE7B80
	|-Collection<object>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE7D00 Offset: 0x2EE7E01 VA: 0x2EE7D00
	|-Collection<object>.IsCompatibleObject
	*/
}


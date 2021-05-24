[DefaultMemberAttribute] // RVA: 0xBF020 Offset: 0xBF121 VA: 0xBF020
[Serializable]
public sealed class ReadOnlyCollectionBuilder<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection // TypeDefIndex: 2718
{
	// Fields
	private T[] _items; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0

	// Properties
	public int Capacity { set; }
	public int Count { get; }
	public T Item { get; set; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267C440 Offset: 0x267C541 VA: 0x267C440
	|-ReadOnlyCollectionBuilder<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267C490 Offset: 0x267C591 VA: 0x267C490
	|-ReadOnlyCollectionBuilder<object>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 29
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267C5F0 Offset: 0x267C6F1 VA: 0x267C5F0
	|-ReadOnlyCollectionBuilder<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267C600 Offset: 0x267C701 VA: 0x267C600
	|-ReadOnlyCollectionBuilder<object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267C630 Offset: 0x267C731 VA: 0x267C630
	|-ReadOnlyCollectionBuilder<object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267C780 Offset: 0x267C881 VA: 0x267C780
	|-ReadOnlyCollectionBuilder<object>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267C890 Offset: 0x267C991 VA: 0x267C890
	|-ReadOnlyCollectionBuilder<object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267C950 Offset: 0x267CA51 VA: 0x267C950
	|-ReadOnlyCollectionBuilder<object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267CA30 Offset: 0x267CB31 VA: 0x267CA30
	|-ReadOnlyCollectionBuilder<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267CAE0 Offset: 0x267CBE1 VA: 0x267CAE0
	|-ReadOnlyCollectionBuilder<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267CB30 Offset: 0x267CC31 VA: 0x267CB30
	|-ReadOnlyCollectionBuilder<object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267CC60 Offset: 0x267CD61 VA: 0x267CC60
	|-ReadOnlyCollectionBuilder<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267CC80 Offset: 0x267CD81 VA: 0x267CC80
	|-ReadOnlyCollectionBuilder<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267CC90 Offset: 0x267CD91 VA: 0x267CC90
	|-ReadOnlyCollectionBuilder<object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267CD00 Offset: 0x267CE01 VA: 0x267CD00
	|-ReadOnlyCollectionBuilder<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267CD70 Offset: 0x267CE71 VA: 0x267CD70
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267CDA0 Offset: 0x267CEA1 VA: 0x267CDA0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267CDB0 Offset: 0x267CEB1 VA: 0x267CDB0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267CF80 Offset: 0x267D081 VA: 0x267CF80
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267D060 Offset: 0x267D161 VA: 0x267D060
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267D140 Offset: 0x267D241 VA: 0x267D140
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267D300 Offset: 0x267D401 VA: 0x267D300
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267D3D0 Offset: 0x267D4D1 VA: 0x267D3D0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267D400 Offset: 0x267D501 VA: 0x267D400
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267D5C0 Offset: 0x267D6C1 VA: 0x267D5C0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267D6B0 Offset: 0x267D7B1 VA: 0x267D6B0
	|-ReadOnlyCollectionBuilder<object>.ToArray
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> ToReadOnlyCollection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267D730 Offset: 0x267D831 VA: 0x267D730
	|-ReadOnlyCollectionBuilder<object>.ToReadOnlyCollection
	*/

	// RVA: -1 Offset: -1
	private void EnsureCapacity(int min) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267D810 Offset: 0x267D911 VA: 0x267D810
	|-ReadOnlyCollectionBuilder<object>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267D860 Offset: 0x267D961 VA: 0x267D860
	|-ReadOnlyCollectionBuilder<object>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1
	private static void ValidateNullValue(object value, string argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267D8F0 Offset: 0x267D9F1 VA: 0x267D8F0
	|-ReadOnlyCollectionBuilder<object>.ValidateNullValue
	*/
}


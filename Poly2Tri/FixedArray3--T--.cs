[DefaultMemberAttribute] // RVA: 0x147CB0 Offset: 0x147DB1 VA: 0x147CB0
public struct FixedArray3<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 9288
{
	// Fields
	public T _0; // 0x0
	public T _1; // 0x0
	public T _2; // 0x0

	// Properties
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38B990 Offset: 0x38BA91 VA: 0x38B990
	|-FixedArray3<DelaunayTriangle>.get_Item
	|-FixedArray3<TriangulationPoint>.get_Item
	|-FixedArray3<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38BA40 Offset: 0x38BB41 VA: 0x38BA40
	|-FixedArray3<DelaunayTriangle>.set_Item
	|-FixedArray3<TriangulationPoint>.set_Item
	|-FixedArray3<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38BA50 Offset: 0x38BB51 VA: 0x38BA50
	|-FixedArray3<TriangulationPoint>.Contains
	|-FixedArray3<object>.Contains
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38BA60 Offset: 0x38BB61 VA: 0x38BA60
	|-FixedArray3<TriangulationPoint>.IndexOf
	|-FixedArray3<object>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38BA70 Offset: 0x38BB71 VA: 0x38BA70
	|-FixedArray3<DelaunayTriangle>.Clear
	|-FixedArray3<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Clear(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38BAC0 Offset: 0x38BBC1 VA: 0x38BAC0
	|-FixedArray3<object>.Clear
	*/

	[IteratorStateMachineAttribute] // RVA: 0x1A9DD0 Offset: 0x1A9ED1 VA: 0x1A9DD0
	// RVA: -1 Offset: -1
	private IEnumerable<T> Enumerate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38BAD0 Offset: 0x38BBD1 VA: 0x38BAD0
	|-FixedArray3<object>.Enumerate
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38BAE0 Offset: 0x38BBE1 VA: 0x38BAE0
	|-FixedArray3<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38BAF0 Offset: 0x38BBF1 VA: 0x38BAF0
	|-FixedArray3<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}


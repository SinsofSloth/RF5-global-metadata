[DefaultMemberAttribute] // RVA: 0x129910 Offset: 0x129A11 VA: 0x129910
internal class ListWithEvents<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 4447
{
	// Fields
	private List<T> m_List; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x129B70 Offset: 0x129C71 VA: 0x129B70
	private Action<T> OnElementAdded; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x129B80 Offset: 0x129C81 VA: 0x129B80
	private Action<T> OnElementRemoved; // 0x0

	// Properties
	public T Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x12A0B0 Offset: 0x12A1B1 VA: 0x12A0B0
	// RVA: -1 Offset: -1
	public void add_OnElementAdded(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D23D10 Offset: 0x2D23E11 VA: 0x2D23D10
	|-ListWithEvents<object>.add_OnElementAdded
	|-ListWithEvents<IUpdateReceiver>.add_OnElementAdded
	|-ListWithEvents<IResourceProvider>.add_OnElementAdded
	*/

	[CompilerGeneratedAttribute] // RVA: 0x12A0C0 Offset: 0x12A1C1 VA: 0x12A0C0
	// RVA: -1 Offset: -1
	public void remove_OnElementAdded(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D23DC0 Offset: 0x2D23EC1 VA: 0x2D23DC0
	|-ListWithEvents<object>.remove_OnElementAdded
	*/

	[CompilerGeneratedAttribute] // RVA: 0x12A0D0 Offset: 0x12A1D1 VA: 0x12A0D0
	// RVA: -1 Offset: -1
	public void add_OnElementRemoved(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D23E70 Offset: 0x2D23F71 VA: 0x2D23E70
	|-ListWithEvents<object>.add_OnElementRemoved
	|-ListWithEvents<IResourceProvider>.add_OnElementRemoved
	*/

	[CompilerGeneratedAttribute] // RVA: 0x12A0E0 Offset: 0x12A1E1 VA: 0x12A0E0
	// RVA: -1 Offset: -1
	public void remove_OnElementRemoved(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D23F20 Offset: 0x2D24021 VA: 0x2D23F20
	|-ListWithEvents<object>.remove_OnElementRemoved
	*/

	// RVA: -1 Offset: -1
	private void InvokeAdded(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D23FD0 Offset: 0x2D240D1 VA: 0x2D23FD0
	|-ListWithEvents<object>.InvokeAdded
	*/

	// RVA: -1 Offset: -1
	private void InvokeRemoved(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D23FF0 Offset: 0x2D240F1 VA: 0x2D23FF0
	|-ListWithEvents<object>.InvokeRemoved
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24010 Offset: 0x2D24111 VA: 0x2D24010
	|-ListWithEvents<object>.get_Item
	|-ListWithEvents<IUpdateReceiver>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24040 Offset: 0x2D24141 VA: 0x2D24040
	|-ListWithEvents<object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24100 Offset: 0x2D24201 VA: 0x2D24100
	|-ListWithEvents<object>.get_Count
	|-ListWithEvents<IUpdateReceiver>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24130 Offset: 0x2D24231 VA: 0x2D24130
	|-ListWithEvents<object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D241D0 Offset: 0x2D242D1 VA: 0x2D241D0
	|-ListWithEvents<object>.Add
	|-ListWithEvents<IUpdateReceiver>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24240 Offset: 0x2D24341 VA: 0x2D24240
	|-ListWithEvents<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24420 Offset: 0x2D24521 VA: 0x2D24420
	|-ListWithEvents<object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24450 Offset: 0x2D24551 VA: 0x2D24450
	|-ListWithEvents<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24480 Offset: 0x2D24581 VA: 0x2D24480
	|-ListWithEvents<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24500 Offset: 0x2D24601 VA: 0x2D24500
	|-ListWithEvents<object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24530 Offset: 0x2D24631 VA: 0x2D24530
	|-ListWithEvents<object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D245A0 Offset: 0x2D246A1 VA: 0x2D245A0
	|-ListWithEvents<object>.Remove
	|-ListWithEvents<IUpdateReceiver>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24630 Offset: 0x2D24731 VA: 0x2D24630
	|-ListWithEvents<object>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D246C0 Offset: 0x2D247C1 VA: 0x2D246C0
	|-ListWithEvents<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24770 Offset: 0x2D24871 VA: 0x2D24770
	|-ListWithEvents<object>..ctor
	|-ListWithEvents<IUpdateReceiver>..ctor
	|-ListWithEvents<IResourceProvider>..ctor
	*/
}


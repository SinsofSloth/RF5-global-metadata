[DefaultMemberAttribute] // RVA: 0x15ABD0 Offset: 0x15ACD1 VA: 0x15ABD0
public struct TouchScreenState2.TouchStateArray2 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 11595
{
	// Fields
	private const int _Length = 2;
	private TouchState _value0; // 0x0
	private TouchState _value1; // 0x28

	// Properties
	public int Length { get; }
	public TouchState Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x387930 Offset: 0x387A31 VA: 0x387930
	public int get_Length() { }

	// RVA: 0x387940 Offset: 0x387A41 VA: 0x387940 Slot: 4
	public TouchState get_Item(int index) { }

	// RVA: 0x387A10 Offset: 0x387B11 VA: 0x387A10 Slot: 5
	public void set_Item(int index, TouchState value) { }

	// RVA: 0x387AF0 Offset: 0x387BF1 VA: 0x387AF0 Slot: 9
	public int get_Count() { }

	// RVA: 0x387B00 Offset: 0x387C01 VA: 0x387B00 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x387B10 Offset: 0x387C11 VA: 0x387B10 Slot: 13
	public bool Contains(TouchState item) { }

	// RVA: 0x387B50 Offset: 0x387C51 VA: 0x387B50 Slot: 6
	public int IndexOf(TouchState item) { }

	// RVA: 0x387B90 Offset: 0x387C91 VA: 0x387B90 Slot: 14
	public void CopyTo(TouchState[] array, int arrayIndex) { }

	// RVA: 0x387BA0 Offset: 0x387CA1 VA: 0x387BA0 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B7500 Offset: 0x1B7601 VA: 0x1B7500
	// RVA: 0x387C70 Offset: 0x387D71 VA: 0x387C70 Slot: 16
	public IEnumerator<TouchState> GetEnumerator() { }

	// RVA: 0x387D40 Offset: 0x387E41 VA: 0x387D40 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x387E10 Offset: 0x387F11 VA: 0x387E10 Slot: 11
	public void Add(TouchState item) { }

	// RVA: 0x387E20 Offset: 0x387F21 VA: 0x387E20 Slot: 12
	public void Clear() { }

	// RVA: 0x387E30 Offset: 0x387F31 VA: 0x387E30 Slot: 7
	public void Insert(int index, TouchState item) { }

	// RVA: 0x387E40 Offset: 0x387F41 VA: 0x387E40 Slot: 15
	public bool Remove(TouchState item) { }

	// RVA: 0x387E50 Offset: 0x387F51 VA: 0x387E50 Slot: 8
	public void RemoveAt(int index) { }
}


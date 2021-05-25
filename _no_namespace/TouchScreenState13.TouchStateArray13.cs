[DefaultMemberAttribute] // RVA: 0x15AE90 Offset: 0x15AF91 VA: 0x15AE90
public struct TouchScreenState13.TouchStateArray13 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 11628
{
	// Fields
	private const int _Length = 13;
	private TouchState _value0; // 0x0
	private TouchState _value1; // 0x28
	private TouchState _value2; // 0x50
	private TouchState _value3; // 0x78
	private TouchState _value4; // 0xA0
	private TouchState _value5; // 0xC8
	private TouchState _value6; // 0xF0
	private TouchState _value7; // 0x118
	private TouchState _value8; // 0x140
	private TouchState _value9; // 0x168
	private TouchState _value10; // 0x190
	private TouchState _value11; // 0x1B8
	private TouchState _value12; // 0x1E0

	// Properties
	public int Length { get; }
	public TouchState Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x3868E0 Offset: 0x3869E1 VA: 0x3868E0
	public int get_Length() { }

	// RVA: 0x3868F0 Offset: 0x3869F1 VA: 0x3868F0 Slot: 4
	public TouchState get_Item(int index) { }

	// RVA: 0x386900 Offset: 0x386A01 VA: 0x386900 Slot: 5
	public void set_Item(int index, TouchState value) { }

	// RVA: 0x386940 Offset: 0x386A41 VA: 0x386940 Slot: 9
	public int get_Count() { }

	// RVA: 0x386950 Offset: 0x386A51 VA: 0x386950 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x386960 Offset: 0x386A61 VA: 0x386960 Slot: 13
	public bool Contains(TouchState item) { }

	// RVA: 0x386A50 Offset: 0x386B51 VA: 0x386A50 Slot: 6
	public int IndexOf(TouchState item) { }

	// RVA: 0x386B30 Offset: 0x386C31 VA: 0x386B30 Slot: 14
	public void CopyTo(TouchState[] array, int arrayIndex) { }

	// RVA: 0x386B40 Offset: 0x386C41 VA: 0x386B40 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B79D0 Offset: 0x1B7AD1 VA: 0x1B79D0
	// RVA: 0x386B50 Offset: 0x386C51 VA: 0x386B50 Slot: 16
	public IEnumerator<TouchState> GetEnumerator() { }

	// RVA: 0x386BF0 Offset: 0x386CF1 VA: 0x386BF0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x386C90 Offset: 0x386D91 VA: 0x386C90 Slot: 11
	public void Add(TouchState item) { }

	// RVA: 0x386CA0 Offset: 0x386DA1 VA: 0x386CA0 Slot: 12
	public void Clear() { }

	// RVA: 0x386CB0 Offset: 0x386DB1 VA: 0x386CB0 Slot: 7
	public void Insert(int index, TouchState item) { }

	// RVA: 0x386CC0 Offset: 0x386DC1 VA: 0x386CC0 Slot: 15
	public bool Remove(TouchState item) { }

	// RVA: 0x386CD0 Offset: 0x386DD1 VA: 0x386CD0 Slot: 8
	public void RemoveAt(int index) { }
}


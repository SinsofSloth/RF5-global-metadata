[DefaultMemberAttribute] // RVA: 0x15AED0 Offset: 0x15AFD1 VA: 0x15AED0
public struct TouchScreenState14.TouchStateArray14 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 11631
{
	// Fields
	private const int _Length = 14;
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
	private TouchState _value13; // 0x208

	// Properties
	public int Length { get; }
	public TouchState Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x386CF0 Offset: 0x386DF1 VA: 0x386CF0
	public int get_Length() { }

	// RVA: 0x386D00 Offset: 0x386E01 VA: 0x386D00 Slot: 4
	public TouchState get_Item(int index) { }

	// RVA: 0x386D10 Offset: 0x386E11 VA: 0x386D10 Slot: 5
	public void set_Item(int index, TouchState value) { }

	// RVA: 0x386D50 Offset: 0x386E51 VA: 0x386D50 Slot: 9
	public int get_Count() { }

	// RVA: 0x386D60 Offset: 0x386E61 VA: 0x386D60 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x386D70 Offset: 0x386E71 VA: 0x386D70 Slot: 13
	public bool Contains(TouchState item) { }

	// RVA: 0x386E60 Offset: 0x386F61 VA: 0x386E60 Slot: 6
	public int IndexOf(TouchState item) { }

	// RVA: 0x386F40 Offset: 0x387041 VA: 0x386F40 Slot: 14
	public void CopyTo(TouchState[] array, int arrayIndex) { }

	// RVA: 0x386F50 Offset: 0x387051 VA: 0x386F50 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B7A40 Offset: 0x1B7B41 VA: 0x1B7A40
	// RVA: 0x386F60 Offset: 0x387061 VA: 0x386F60 Slot: 16
	public IEnumerator<TouchState> GetEnumerator() { }

	// RVA: 0x387000 Offset: 0x387101 VA: 0x387000 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x3870A0 Offset: 0x3871A1 VA: 0x3870A0 Slot: 11
	public void Add(TouchState item) { }

	// RVA: 0x3870B0 Offset: 0x3871B1 VA: 0x3870B0 Slot: 12
	public void Clear() { }

	// RVA: 0x3870C0 Offset: 0x3871C1 VA: 0x3870C0 Slot: 7
	public void Insert(int index, TouchState item) { }

	// RVA: 0x3870D0 Offset: 0x3871D1 VA: 0x3870D0 Slot: 15
	public bool Remove(TouchState item) { }

	// RVA: 0x3870E0 Offset: 0x3871E1 VA: 0x3870E0 Slot: 8
	public void RemoveAt(int index) { }
}


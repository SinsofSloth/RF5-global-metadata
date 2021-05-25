[DefaultMemberAttribute] // RVA: 0x15ADD0 Offset: 0x15AED1 VA: 0x15ADD0
public struct TouchScreenState10.TouchStateArray10 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 11619
{
	// Fields
	private const int _Length = 10;
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

	// Properties
	public int Length { get; }
	public TouchState Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x385CB0 Offset: 0x385DB1 VA: 0x385CB0
	public int get_Length() { }

	// RVA: 0x385CC0 Offset: 0x385DC1 VA: 0x385CC0 Slot: 4
	public TouchState get_Item(int index) { }

	// RVA: 0x385CD0 Offset: 0x385DD1 VA: 0x385CD0 Slot: 5
	public void set_Item(int index, TouchState value) { }

	// RVA: 0x385D10 Offset: 0x385E11 VA: 0x385D10 Slot: 9
	public int get_Count() { }

	// RVA: 0x385D20 Offset: 0x385E21 VA: 0x385D20 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x385D30 Offset: 0x385E31 VA: 0x385D30 Slot: 13
	public bool Contains(TouchState item) { }

	// RVA: 0x385E20 Offset: 0x385F21 VA: 0x385E20 Slot: 6
	public int IndexOf(TouchState item) { }

	// RVA: 0x385F00 Offset: 0x386001 VA: 0x385F00 Slot: 14
	public void CopyTo(TouchState[] array, int arrayIndex) { }

	// RVA: 0x385F10 Offset: 0x386011 VA: 0x385F10 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B7880 Offset: 0x1B7981 VA: 0x1B7880
	// RVA: 0x385F20 Offset: 0x386021 VA: 0x385F20 Slot: 16
	public IEnumerator<TouchState> GetEnumerator() { }

	// RVA: 0x385FC0 Offset: 0x3860C1 VA: 0x385FC0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x386060 Offset: 0x386161 VA: 0x386060 Slot: 11
	public void Add(TouchState item) { }

	// RVA: 0x386070 Offset: 0x386171 VA: 0x386070 Slot: 12
	public void Clear() { }

	// RVA: 0x386080 Offset: 0x386181 VA: 0x386080 Slot: 7
	public void Insert(int index, TouchState item) { }

	// RVA: 0x386090 Offset: 0x386191 VA: 0x386090 Slot: 15
	public bool Remove(TouchState item) { }

	// RVA: 0x3860A0 Offset: 0x3861A1 VA: 0x3860A0 Slot: 8
	public void RemoveAt(int index) { }
}


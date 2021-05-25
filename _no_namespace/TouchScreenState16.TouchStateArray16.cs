[DefaultMemberAttribute] // RVA: 0x15AF50 Offset: 0x15B051 VA: 0x15AF50
public struct TouchScreenState16.TouchStateArray16 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 11637
{
	// Fields
	private const int _Length = 16;
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
	private TouchState _value14; // 0x230
	private TouchState _value15; // 0x258

	// Properties
	public int Length { get; }
	public TouchState Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x387510 Offset: 0x387611 VA: 0x387510
	public int get_Length() { }

	// RVA: 0x387520 Offset: 0x387621 VA: 0x387520 Slot: 4
	public TouchState get_Item(int index) { }

	// RVA: 0x387530 Offset: 0x387631 VA: 0x387530 Slot: 5
	public void set_Item(int index, TouchState value) { }

	// RVA: 0x387570 Offset: 0x387671 VA: 0x387570 Slot: 9
	public int get_Count() { }

	// RVA: 0x387580 Offset: 0x387681 VA: 0x387580 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x387590 Offset: 0x387691 VA: 0x387590 Slot: 13
	public bool Contains(TouchState item) { }

	// RVA: 0x387680 Offset: 0x387781 VA: 0x387680 Slot: 6
	public int IndexOf(TouchState item) { }

	// RVA: 0x387760 Offset: 0x387861 VA: 0x387760 Slot: 14
	public void CopyTo(TouchState[] array, int arrayIndex) { }

	// RVA: 0x387770 Offset: 0x387871 VA: 0x387770 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B7B20 Offset: 0x1B7C21 VA: 0x1B7B20
	// RVA: 0x387780 Offset: 0x387881 VA: 0x387780 Slot: 16
	public IEnumerator<TouchState> GetEnumerator() { }

	// RVA: 0x387820 Offset: 0x387921 VA: 0x387820 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x3878C0 Offset: 0x3879C1 VA: 0x3878C0 Slot: 11
	public void Add(TouchState item) { }

	// RVA: 0x3878D0 Offset: 0x3879D1 VA: 0x3878D0 Slot: 12
	public void Clear() { }

	// RVA: 0x3878E0 Offset: 0x3879E1 VA: 0x3878E0 Slot: 7
	public void Insert(int index, TouchState item) { }

	// RVA: 0x3878F0 Offset: 0x3879F1 VA: 0x3878F0 Slot: 15
	public bool Remove(TouchState item) { }

	// RVA: 0x387900 Offset: 0x387A01 VA: 0x387900 Slot: 8
	public void RemoveAt(int index) { }
}


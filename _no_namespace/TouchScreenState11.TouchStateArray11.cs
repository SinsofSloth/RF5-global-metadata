[DefaultMemberAttribute] // RVA: 0x15AE10 Offset: 0x15AF11 VA: 0x15AE10
public struct TouchScreenState11.TouchStateArray11 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 11622
{
	// Fields
	private const int _Length = 11;
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

	// Properties
	public int Length { get; }
	public TouchState Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x3860C0 Offset: 0x3861C1 VA: 0x3860C0
	public int get_Length() { }

	// RVA: 0x3860D0 Offset: 0x3861D1 VA: 0x3860D0 Slot: 4
	public TouchState get_Item(int index) { }

	// RVA: 0x3860E0 Offset: 0x3861E1 VA: 0x3860E0 Slot: 5
	public void set_Item(int index, TouchState value) { }

	// RVA: 0x386120 Offset: 0x386221 VA: 0x386120 Slot: 9
	public int get_Count() { }

	// RVA: 0x386130 Offset: 0x386231 VA: 0x386130 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x386140 Offset: 0x386241 VA: 0x386140 Slot: 13
	public bool Contains(TouchState item) { }

	// RVA: 0x386230 Offset: 0x386331 VA: 0x386230 Slot: 6
	public int IndexOf(TouchState item) { }

	// RVA: 0x386310 Offset: 0x386411 VA: 0x386310 Slot: 14
	public void CopyTo(TouchState[] array, int arrayIndex) { }

	// RVA: 0x386320 Offset: 0x386421 VA: 0x386320 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B78F0 Offset: 0x1B79F1 VA: 0x1B78F0
	// RVA: 0x386330 Offset: 0x386431 VA: 0x386330 Slot: 16
	public IEnumerator<TouchState> GetEnumerator() { }

	// RVA: 0x3863D0 Offset: 0x3864D1 VA: 0x3863D0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x386470 Offset: 0x386571 VA: 0x386470 Slot: 11
	public void Add(TouchState item) { }

	// RVA: 0x386480 Offset: 0x386581 VA: 0x386480 Slot: 12
	public void Clear() { }

	// RVA: 0x386490 Offset: 0x386591 VA: 0x386490 Slot: 7
	public void Insert(int index, TouchState item) { }

	// RVA: 0x3864A0 Offset: 0x3865A1 VA: 0x3864A0 Slot: 15
	public bool Remove(TouchState item) { }

	// RVA: 0x3864B0 Offset: 0x3865B1 VA: 0x3864B0 Slot: 8
	public void RemoveAt(int index) { }
}


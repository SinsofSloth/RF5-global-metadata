[DefaultMemberAttribute] // RVA: 0x15AE50 Offset: 0x15AF51 VA: 0x15AE50
public struct TouchScreenState12.TouchStateArray12 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 11625
{
	// Fields
	private const int _Length = 12;
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

	// Properties
	public int Length { get; }
	public TouchState Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x3864D0 Offset: 0x3865D1 VA: 0x3864D0
	public int get_Length() { }

	// RVA: 0x3864E0 Offset: 0x3865E1 VA: 0x3864E0 Slot: 4
	public TouchState get_Item(int index) { }

	// RVA: 0x3864F0 Offset: 0x3865F1 VA: 0x3864F0 Slot: 5
	public void set_Item(int index, TouchState value) { }

	// RVA: 0x386530 Offset: 0x386631 VA: 0x386530 Slot: 9
	public int get_Count() { }

	// RVA: 0x386540 Offset: 0x386641 VA: 0x386540 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x386550 Offset: 0x386651 VA: 0x386550 Slot: 13
	public bool Contains(TouchState item) { }

	// RVA: 0x386640 Offset: 0x386741 VA: 0x386640 Slot: 6
	public int IndexOf(TouchState item) { }

	// RVA: 0x386720 Offset: 0x386821 VA: 0x386720 Slot: 14
	public void CopyTo(TouchState[] array, int arrayIndex) { }

	// RVA: 0x386730 Offset: 0x386831 VA: 0x386730 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B7960 Offset: 0x1B7A61 VA: 0x1B7960
	// RVA: 0x386740 Offset: 0x386841 VA: 0x386740 Slot: 16
	public IEnumerator<TouchState> GetEnumerator() { }

	// RVA: 0x3867E0 Offset: 0x3868E1 VA: 0x3867E0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x386880 Offset: 0x386981 VA: 0x386880 Slot: 11
	public void Add(TouchState item) { }

	// RVA: 0x386890 Offset: 0x386991 VA: 0x386890 Slot: 12
	public void Clear() { }

	// RVA: 0x3868A0 Offset: 0x3869A1 VA: 0x3868A0 Slot: 7
	public void Insert(int index, TouchState item) { }

	// RVA: 0x3868B0 Offset: 0x3869B1 VA: 0x3868B0 Slot: 15
	public bool Remove(TouchState item) { }

	// RVA: 0x3868C0 Offset: 0x3869C1 VA: 0x3868C0 Slot: 8
	public void RemoveAt(int index) { }
}


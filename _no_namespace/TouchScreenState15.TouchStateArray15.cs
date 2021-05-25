[DefaultMemberAttribute] // RVA: 0x15AF10 Offset: 0x15B011 VA: 0x15AF10
public struct TouchScreenState15.TouchStateArray15 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 11634
{
	// Fields
	private const int _Length = 15;
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

	// Properties
	public int Length { get; }
	public TouchState Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x387100 Offset: 0x387201 VA: 0x387100
	public int get_Length() { }

	// RVA: 0x387110 Offset: 0x387211 VA: 0x387110 Slot: 4
	public TouchState get_Item(int index) { }

	// RVA: 0x387120 Offset: 0x387221 VA: 0x387120 Slot: 5
	public void set_Item(int index, TouchState value) { }

	// RVA: 0x387160 Offset: 0x387261 VA: 0x387160 Slot: 9
	public int get_Count() { }

	// RVA: 0x387170 Offset: 0x387271 VA: 0x387170 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x387180 Offset: 0x387281 VA: 0x387180 Slot: 13
	public bool Contains(TouchState item) { }

	// RVA: 0x387270 Offset: 0x387371 VA: 0x387270 Slot: 6
	public int IndexOf(TouchState item) { }

	// RVA: 0x387350 Offset: 0x387451 VA: 0x387350 Slot: 14
	public void CopyTo(TouchState[] array, int arrayIndex) { }

	// RVA: 0x387360 Offset: 0x387461 VA: 0x387360 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B7AB0 Offset: 0x1B7BB1 VA: 0x1B7AB0
	// RVA: 0x387370 Offset: 0x387471 VA: 0x387370 Slot: 16
	public IEnumerator<TouchState> GetEnumerator() { }

	// RVA: 0x387410 Offset: 0x387511 VA: 0x387410 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x3874B0 Offset: 0x3875B1 VA: 0x3874B0 Slot: 11
	public void Add(TouchState item) { }

	// RVA: 0x3874C0 Offset: 0x3875C1 VA: 0x3874C0 Slot: 12
	public void Clear() { }

	// RVA: 0x3874D0 Offset: 0x3875D1 VA: 0x3874D0 Slot: 7
	public void Insert(int index, TouchState item) { }

	// RVA: 0x3874E0 Offset: 0x3875E1 VA: 0x3874E0 Slot: 15
	public bool Remove(TouchState item) { }

	// RVA: 0x3874F0 Offset: 0x3875F1 VA: 0x3874F0 Slot: 8
	public void RemoveAt(int index) { }
}


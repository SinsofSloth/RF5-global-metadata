[DefaultMemberAttribute] // RVA: 0x15AD90 Offset: 0x15AE91 VA: 0x15AD90
public struct TouchScreenState9.TouchStateArray9 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 11616
{
	// Fields
	private const int _Length = 9;
	private TouchState _value0; // 0x0
	private TouchState _value1; // 0x28
	private TouchState _value2; // 0x50
	private TouchState _value3; // 0x78
	private TouchState _value4; // 0xA0
	private TouchState _value5; // 0xC8
	private TouchState _value6; // 0xF0
	private TouchState _value7; // 0x118
	private TouchState _value8; // 0x140

	// Properties
	public int Length { get; }
	public TouchState Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x389EA0 Offset: 0x389FA1 VA: 0x389EA0
	public int get_Length() { }

	// RVA: 0x389EB0 Offset: 0x389FB1 VA: 0x389EB0 Slot: 4
	public TouchState get_Item(int index) { }

	// RVA: 0x38A030 Offset: 0x38A131 VA: 0x38A030 Slot: 5
	public void set_Item(int index, TouchState value) { }

	// RVA: 0x38A1F0 Offset: 0x38A2F1 VA: 0x38A1F0 Slot: 9
	public int get_Count() { }

	// RVA: 0x38A200 Offset: 0x38A301 VA: 0x38A200 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x38A210 Offset: 0x38A311 VA: 0x38A210 Slot: 13
	public bool Contains(TouchState item) { }

	// RVA: 0x38A250 Offset: 0x38A351 VA: 0x38A250 Slot: 6
	public int IndexOf(TouchState item) { }

	// RVA: 0x38A290 Offset: 0x38A391 VA: 0x38A290 Slot: 14
	public void CopyTo(TouchState[] array, int arrayIndex) { }

	// RVA: 0x38A2A0 Offset: 0x38A3A1 VA: 0x38A2A0 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B7810 Offset: 0x1B7911 VA: 0x1B7810
	// RVA: 0x38A2B0 Offset: 0x38A3B1 VA: 0x38A2B0 Slot: 16
	public IEnumerator<TouchState> GetEnumerator() { }

	// RVA: 0x38A350 Offset: 0x38A451 VA: 0x38A350 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x38A3F0 Offset: 0x38A4F1 VA: 0x38A3F0 Slot: 11
	public void Add(TouchState item) { }

	// RVA: 0x38A400 Offset: 0x38A501 VA: 0x38A400 Slot: 12
	public void Clear() { }

	// RVA: 0x38A410 Offset: 0x38A511 VA: 0x38A410 Slot: 7
	public void Insert(int index, TouchState item) { }

	// RVA: 0x38A420 Offset: 0x38A521 VA: 0x38A420 Slot: 15
	public bool Remove(TouchState item) { }

	// RVA: 0x38A430 Offset: 0x38A531 VA: 0x38A430 Slot: 8
	public void RemoveAt(int index) { }
}


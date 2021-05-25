[DefaultMemberAttribute] // RVA: 0x15ACD0 Offset: 0x15ADD1 VA: 0x15ACD0
public struct TouchScreenState6.TouchStateArray6 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 11607
{
	// Fields
	private const int _Length = 6;
	private TouchState _value0; // 0x0
	private TouchState _value1; // 0x28
	private TouchState _value2; // 0x50
	private TouchState _value3; // 0x78
	private TouchState _value4; // 0xA0
	private TouchState _value5; // 0xC8

	// Properties
	public int Length { get; }
	public TouchState Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x388EC0 Offset: 0x388FC1 VA: 0x388EC0
	public int get_Length() { }

	// RVA: 0x388ED0 Offset: 0x388FD1 VA: 0x388ED0 Slot: 4
	public TouchState get_Item(int index) { }

	// RVA: 0x389010 Offset: 0x389111 VA: 0x389010 Slot: 5
	public void set_Item(int index, TouchState value) { }

	// RVA: 0x389180 Offset: 0x389281 VA: 0x389180 Slot: 9
	public int get_Count() { }

	// RVA: 0x389190 Offset: 0x389291 VA: 0x389190 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x3891A0 Offset: 0x3892A1 VA: 0x3891A0 Slot: 13
	public bool Contains(TouchState item) { }

	// RVA: 0x3891E0 Offset: 0x3892E1 VA: 0x3891E0 Slot: 6
	public int IndexOf(TouchState item) { }

	// RVA: 0x389220 Offset: 0x389321 VA: 0x389220 Slot: 14
	public void CopyTo(TouchState[] array, int arrayIndex) { }

	// RVA: 0x389230 Offset: 0x389331 VA: 0x389230 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B76C0 Offset: 0x1B77C1 VA: 0x1B76C0
	// RVA: 0x389240 Offset: 0x389341 VA: 0x389240 Slot: 16
	public IEnumerator<TouchState> GetEnumerator() { }

	// RVA: 0x3892E0 Offset: 0x3893E1 VA: 0x3892E0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x389380 Offset: 0x389481 VA: 0x389380 Slot: 11
	public void Add(TouchState item) { }

	// RVA: 0x389390 Offset: 0x389491 VA: 0x389390 Slot: 12
	public void Clear() { }

	// RVA: 0x3893A0 Offset: 0x3894A1 VA: 0x3893A0 Slot: 7
	public void Insert(int index, TouchState item) { }

	// RVA: 0x3893B0 Offset: 0x3894B1 VA: 0x3893B0 Slot: 15
	public bool Remove(TouchState item) { }

	// RVA: 0x3893C0 Offset: 0x3894C1 VA: 0x3893C0 Slot: 8
	public void RemoveAt(int index) { }
}


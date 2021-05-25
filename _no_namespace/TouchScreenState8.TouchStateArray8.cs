[DefaultMemberAttribute] // RVA: 0x15AD50 Offset: 0x15AE51 VA: 0x15AD50
public struct TouchScreenState8.TouchStateArray8 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 11613
{
	// Fields
	private const int _Length = 8;
	private TouchState _value0; // 0x0
	private TouchState _value1; // 0x28
	private TouchState _value2; // 0x50
	private TouchState _value3; // 0x78
	private TouchState _value4; // 0xA0
	private TouchState _value5; // 0xC8
	private TouchState _value6; // 0xF0
	private TouchState _value7; // 0x118

	// Properties
	public int Length { get; }
	public TouchState Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x389930 Offset: 0x389A31 VA: 0x389930
	public int get_Length() { }

	// RVA: 0x389940 Offset: 0x389A41 VA: 0x389940 Slot: 4
	public TouchState get_Item(int index) { }

	// RVA: 0x389AA0 Offset: 0x389BA1 VA: 0x389AA0 Slot: 5
	public void set_Item(int index, TouchState value) { }

	// RVA: 0x389C40 Offset: 0x389D41 VA: 0x389C40 Slot: 9
	public int get_Count() { }

	// RVA: 0x389C50 Offset: 0x389D51 VA: 0x389C50 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x389C60 Offset: 0x389D61 VA: 0x389C60 Slot: 13
	public bool Contains(TouchState item) { }

	// RVA: 0x389CA0 Offset: 0x389DA1 VA: 0x389CA0 Slot: 6
	public int IndexOf(TouchState item) { }

	// RVA: 0x389CE0 Offset: 0x389DE1 VA: 0x389CE0 Slot: 14
	public void CopyTo(TouchState[] array, int arrayIndex) { }

	// RVA: 0x389CF0 Offset: 0x389DF1 VA: 0x389CF0 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B77A0 Offset: 0x1B78A1 VA: 0x1B77A0
	// RVA: 0x389D00 Offset: 0x389E01 VA: 0x389D00 Slot: 16
	public IEnumerator<TouchState> GetEnumerator() { }

	// RVA: 0x389DA0 Offset: 0x389EA1 VA: 0x389DA0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x389E40 Offset: 0x389F41 VA: 0x389E40 Slot: 11
	public void Add(TouchState item) { }

	// RVA: 0x389E50 Offset: 0x389F51 VA: 0x389E50 Slot: 12
	public void Clear() { }

	// RVA: 0x389E60 Offset: 0x389F61 VA: 0x389E60 Slot: 7
	public void Insert(int index, TouchState item) { }

	// RVA: 0x389E70 Offset: 0x389F71 VA: 0x389E70 Slot: 15
	public bool Remove(TouchState item) { }

	// RVA: 0x389E80 Offset: 0x389F81 VA: 0x389E80 Slot: 8
	public void RemoveAt(int index) { }
}


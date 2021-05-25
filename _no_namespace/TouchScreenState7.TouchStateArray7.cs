[DefaultMemberAttribute] // RVA: 0x15AD10 Offset: 0x15AE11 VA: 0x15AD10
public struct TouchScreenState7.TouchStateArray7 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 11610
{
	// Fields
	private const int _Length = 7;
	private TouchState _value0; // 0x0
	private TouchState _value1; // 0x28
	private TouchState _value2; // 0x50
	private TouchState _value3; // 0x78
	private TouchState _value4; // 0xA0
	private TouchState _value5; // 0xC8
	private TouchState _value6; // 0xF0

	// Properties
	public int Length { get; }
	public TouchState Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x3893E0 Offset: 0x3894E1 VA: 0x3893E0
	public int get_Length() { }

	// RVA: 0x3893F0 Offset: 0x3894F1 VA: 0x3893F0 Slot: 4
	public TouchState get_Item(int index) { }

	// RVA: 0x389540 Offset: 0x389641 VA: 0x389540 Slot: 5
	public void set_Item(int index, TouchState value) { }

	// RVA: 0x3896D0 Offset: 0x3897D1 VA: 0x3896D0 Slot: 9
	public int get_Count() { }

	// RVA: 0x3896E0 Offset: 0x3897E1 VA: 0x3896E0 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x3896F0 Offset: 0x3897F1 VA: 0x3896F0 Slot: 13
	public bool Contains(TouchState item) { }

	// RVA: 0x389730 Offset: 0x389831 VA: 0x389730 Slot: 6
	public int IndexOf(TouchState item) { }

	// RVA: 0x389770 Offset: 0x389871 VA: 0x389770 Slot: 14
	public void CopyTo(TouchState[] array, int arrayIndex) { }

	// RVA: 0x389780 Offset: 0x389881 VA: 0x389780 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B7730 Offset: 0x1B7831 VA: 0x1B7730
	// RVA: 0x389790 Offset: 0x389891 VA: 0x389790 Slot: 16
	public IEnumerator<TouchState> GetEnumerator() { }

	// RVA: 0x389830 Offset: 0x389931 VA: 0x389830 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x3898D0 Offset: 0x3899D1 VA: 0x3898D0 Slot: 11
	public void Add(TouchState item) { }

	// RVA: 0x3898E0 Offset: 0x3899E1 VA: 0x3898E0 Slot: 12
	public void Clear() { }

	// RVA: 0x3898F0 Offset: 0x3899F1 VA: 0x3898F0 Slot: 7
	public void Insert(int index, TouchState item) { }

	// RVA: 0x389900 Offset: 0x389A01 VA: 0x389900 Slot: 15
	public bool Remove(TouchState item) { }

	// RVA: 0x389910 Offset: 0x389A11 VA: 0x389910 Slot: 8
	public void RemoveAt(int index) { }
}

